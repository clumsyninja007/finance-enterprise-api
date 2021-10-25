using FinanceEnterpriseApi.Data.Interfaces.Finance.dbo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinanceEnterpriseApi.Controllers.Finance
{
    [AllowAnonymous]
    [Route("finance/[controller]")]
    [ApiController]
    public class HrController : ControllerBase
    {
        private readonly IHrEmpmstrService _hrEmpmstrService;
        private readonly IHrHrcodeService _hrHrcodeService;

        public HrController(IHrEmpmstrService hrEmpmstrService,
            IHrHrcodeService hrHrcodeService)
        {
            _hrEmpmstrService = hrEmpmstrService;
            _hrHrcodeService = hrHrcodeService;
        }

        /// <summary>
        /// Updates the gender of an employee profile, specified by empid
        /// </summary>
        /// <param name="id"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        [HttpPut("hrempmstr/{id}/gender/{gender}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
            nameof(DefaultApiConventions.Put))]
        public async Task<IActionResult> PutHrEmpmstrGenderAsync(string id, string gender)
        {
            if (!await _hrHrcodeService.CodeExistsAsync("GENDER_CODE", gender))
            {
                return BadRequest($"Gender code {gender} does not exist");
            }

            if (!await _hrEmpmstrService.EmpExistsAsync(id))
            {
                return BadRequest($"Employee {id} does not exist");
            }

            await _hrEmpmstrService.UpdateGenderAsync(id, gender);

            return NoContent();
        }
    }
}
