using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Villa_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {

        [HttpGet]
        public string GetVillas()
        {
            return "This is Villa API";
        }

        [HttpGet("{id:int}")]

        public string GetvillaById(int id)
        {
            return "nmll"+id;
        }

    }
}
