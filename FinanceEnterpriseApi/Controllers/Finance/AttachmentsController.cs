using Dapper;
using FinanceEnterpriseApi.Classes;
using FinanceEnterpriseApi.Dtos.Finance;
using FinanceEnterpriseApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinanceEnterpriseApi.Controllers.Finance
{
    [Authorize]
    [Route("finance/[controller]")]
    [ApiController]
    public class AttachmentsController : ControllerBase
    {
        private readonly SqlConnectionHelpers _helperFunctions;
        private readonly ILogger<AttachmentsController> _logger;

        public AttachmentsController(SqlConnectionHelpers helperFunctions, ILogger<AttachmentsController> logger)
        {
            _helperFunctions = helperFunctions;
            _logger = logger;
        }

        /// <summary>
        /// Gets information about what record the document is attached to
        /// </summary>
        /// <param name="env"></param>
        /// <param name="docId"></param>
        /// <returns>A list of attachment values</returns>
        /// <response code="200">Returns attachment info</response>
        /// <response code="400">If a bad environment name is supplied</response>
        /// <response code="404">If the document is not in the database</response>
        [HttpGet("{env}/{docId}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<List<AttachmentDto>>> GetAttachmentInfo(string env, int docId)
        {
            const string sql = @"SELECT d.doc_id
	                    ,im.attach_id
	                    ,im.table_name
	                    ,dtl.column_name
	                    ,d.field_value
                    FROM im_index_data AS d
                    INNER JOIN im_index_mstr AS im
	                    ON im.index_id = d.index_id
                    INNER JOIN im_index_dtl AS dtl
	                    ON dtl.index_id = d.index_id
	                    AND dtl.field_id = d.field_id
                    WHERE d.doc_id = @docId
                    ORDER BY table_name
	                    ,column_name";

            await using var conn = _helperFunctions.GetSqlConnection(env);

            if (conn == null)
            {
                return BadRequest("Invalid Environment Name");
            }

            await conn.OpenAsync();

            var attachmentInfo = (await conn.QueryAsync<AttachmentDto>(sql, new { docId })).ToList();

            if (!attachmentInfo.Any())
            {
                return NotFound($"Document {docId} not found");
            }

            await conn.CloseAsync();

            return attachmentInfo;
        }

        /// <summary>
        /// Deletes the specified document and any attachment data
        /// </summary>
        /// <param name="env"></param>
        /// <param name="docId"></param>
        /// <returns></returns>
        /// <response code="200">If the document is successfully deleted</response>
        /// <response code="400">If a bad environment name is supplied</response>
        /// <response code="404">If the document specified is not found in the database</response>
        [HttpDelete("{env}/{docId}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Delete))]
        public async Task<IActionResult> DeleteDocument(string env, int docId)
        {
            var attachInfo = JsonSerializer.Serialize((await GetAttachmentInfo(env, docId)).Value);

            await using var conn = _helperFunctions.GetSqlConnection(env);

            if (conn == null)
            {
                return BadRequest("Invalid Environment Name");
            }

            await conn.OpenAsync();

            var sql = @"DELETE FROM im_page WHERE doc_id = @docId";
            var imPage = await conn.ExecuteAsync(sql, new { docId });

            sql = @"DELETE FROM im_index_data WHERE doc_id = @docId";
            var imIndexData = await conn.ExecuteAsync(sql, new { docId });

            sql = @"DELETE FROM im_info WHERE doc_id = @docId";
            var imInfo = await conn.ExecuteAsync(sql, new { docId });

            await conn.CloseAsync();

            if (imPage == 0 && imIndexData == 0 && imInfo == 0)
            {
                return NotFound();
            }

            _logger.LogInformation(LoggingEvents.DeleteItem, $"{env}\t{docId}\t{GetCurrentUser()}\timPage: {imPage}\timIndexData: {imIndexData}\timInfo: {imInfo}\tattachInfo: {attachInfo}");

            return Ok();
        }

        private string GetCurrentUser()
        {
            return User.Identity?.Name;
        }
    }
}
