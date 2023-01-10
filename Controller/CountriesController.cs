using Microsoft.AspNetCore.Mvc;
using ModelBinder.Models;

namespace ModelBinder.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpPost("{id}/{name}")]
        public IActionResult Index([FromRoute]int id, [FromHeader]CountryModel obj)
        {
            return Ok($"ID:{id}\nName:{obj.Name}");
        }


        [HttpPost("{search}")]
        public IActionResult Details([ModelBinder(typeof(CustomBinder))]string[] countries) 
        {
            return Ok(countries);
        }
             
    }
}
