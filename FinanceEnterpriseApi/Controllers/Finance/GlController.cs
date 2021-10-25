using FinanceEnterpriseApi.Data.Dtos.Finance.dbo;
using FinanceEnterpriseApi.Data.Dtos.Finance.humco;
using FinanceEnterpriseApi.Data.Interfaces.Finance.dbo;
using FinanceEnterpriseApi.Data.Interfaces.Finance.humco;
using FinanceEnterpriseApi.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using FinanceEnterprise.Entities.Finance.Models.humco;
using Microsoft.AspNetCore.Authorization;

namespace FinanceEnterpriseApi.Controllers.Finance
{
    [AllowAnonymous]
    [Route("finance/[controller]")]
    [ApiController]
    public class GlController : ControllerBase
    {
        private readonly IGlTrnsDetailsService _glTrnsDetailsService;
        private readonly IGlTransactionGrantNotesService _glTransactionGrantNotesService;

        public GlController(IGlTrnsDetailsService glTrnsDetailsService,
            IGlTransactionGrantNotesService glTransactionGrantNotesService)
        {
            _glTrnsDetailsService = glTrnsDetailsService;
            _glTransactionGrantNotesService = glTransactionGrantNotesService;
        }

        /// <summary>
        /// Pulls GL Transaction Details
        /// </summary>
        /// <param name="paramsDto"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A list of transactions</returns>
        [HttpGet("trns")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<PagedModel<GlTrnsDetailsDto>>> GetGlTrnsDetailsListAsync([FromQuery] GetGlTrnsDetailsListParamsDto paramsDto,
            CancellationToken cancellationToken)
        {
            return await _glTrnsDetailsService.GetByPageAsync(
                paramsDto,
                cancellationToken);
        }

        /// <summary>
        /// Pulls Grant Notes for the given GL Transaction
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Notes object for given ID</returns>
        [HttpGet("trns/{id}/notes", Name = "GetGlTransactionGrantNotesById")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<GlTransactionGrantNote>> GetGlTransactionGrantNotesById(int id)
        {
            return await _glTransactionGrantNotesService.GetByIdAsync(id);
        }

        /// <summary>
        /// Inserts or updates notes for given GL Transaction
        /// </summary>
        /// <param name="id"></param>
        /// <param name="notes"></param>
        /// <returns></returns>
        [HttpPut("trns/{id}/notes")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Put))]
        public async Task<IActionResult> PutGlTransactionGrantNotes(int id, [FromBody] PutGlTransactionGrantNotesParamsDto notes)
        {
            if (id != notes.GlTrnsId)
            {
                return BadRequest("Id does not match input object.");
            }

            if (await _glTransactionGrantNotesService.GetByIdAsync(id) == null)
            {
                await _glTransactionGrantNotesService.AddAsync(notes);
                return CreatedAtRoute("GetGlTransactionGrantNotesById", new { id }, notes);
            }

            await _glTransactionGrantNotesService.UpdateAsync(notes);
            return NoContent();
        }
    }
}
