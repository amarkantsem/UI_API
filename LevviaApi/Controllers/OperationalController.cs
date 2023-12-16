using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LevviaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationalController : ControllerBase
    {

        [HttpPost("AddOperation")]
        public async Task<ActionResult> AddOperation([FromBody] OperationalDTO  operationalDTO)
        {
            try
            {
                var remainingMentees = "";// await _engagementSevice.AddEngagement(engagementDTO);
                return Ok(remainingMentees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while fetching remaining mentees.");
            }
        }
    }
}
