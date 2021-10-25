using FinanceEnterpriseApi.Data.Interfaces.Finance.dbo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FinanceEnterpriseApi.Controllers.Finance
{
    [AllowAnonymous]
    [Route("finance/[controller]")]
    [ApiController]
    public class NuController : ControllerBase
    {
        private readonly INuJobMstrService _nuJobMstrService;

        public NuController(INuJobMstrService nuJobMstrService)
        {
            _nuJobMstrService = nuJobMstrService;
        }

        /// <summary>
        /// Returns the status of a given job
        /// </summary>
        /// <param name="jobNo"></param>
        /// <returns></returns>
        [HttpGet("job/{jobNo}/status")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
            nameof(DefaultApiConventions.Get))]
        public async Task<ActionResult<string>> GetJobStatus(int jobNo)
        {
            try
            {
                return await _nuJobMstrService.GetJobStatusAsync(jobNo);
            }
            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
