using FinanceEnterpriseApi.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace FinanceEnterpriseApi.Controllers
{
    [AllowAnonymous]
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly string _basePath;

        public HomeController(IConfiguration configuration)
        {
            _basePath = configuration.GetSection("Basepath").Value;
        }

        [HttpPut("data/{filename}")]
        public async Task<ActionResult> CreateJobFile(string filename, [FromBody] JobFileText fileText)
        {
            var file = Path.Combine(_basePath, filename);

            await System.IO.File.WriteAllTextAsync(file, fileText.Value);

            return NoContent();
        }

        [HttpDelete("data/{filename}")]
        public ActionResult DeleteJobFile(string filename)
        {
            var file = Path.Combine(_basePath, filename);

            if (!System.IO.File.Exists(file))
            {
                return BadRequest();
            }

            System.IO.File.Delete(file);

            return NoContent();
        }
    }
}
