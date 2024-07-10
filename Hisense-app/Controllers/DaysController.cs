using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_Test.Controllers
{
    [ApiController]
    public class DaysController : ControllerBase
    {
        [HttpGet]
        [Route("api/dayinweek/{day}")]
        public IActionResult GetDayOfWeek(int day)
        {
            if (day < 1 || day > 7)
            {
                return BadRequest("Days must be between 1 and 7!!!");
            }

            string[] DaniUNedelji = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            return Ok(DaniUNedelji[day - 1]);
        }
    }
}
