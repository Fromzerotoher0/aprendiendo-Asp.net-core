using Microsoft.AspNetCore.Mvc;
using webApiAutores.entities;

namespace webApiAutores.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class authorsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Author>> get()
        {
            return new List<Author>() {
                new Author(){ id = 1 , name ="Claudio ranieri"},
                new Author(){ id = 2   , name="helena Villalba"}
            };
        }
    }
}