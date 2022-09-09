using Microsoft.AspNetCore.Mvc;

namespace HeroesWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeroesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Olá, Herói";
        }
    }
}