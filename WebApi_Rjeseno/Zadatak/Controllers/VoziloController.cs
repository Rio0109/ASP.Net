using Microsoft.AspNetCore.Mvc;

namespace Zadatak.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoziloController : Controller
    {
        private static List<Vozilo> vozila = new List<Vozilo>
        {
            new Vozilo{Id = 1, Model="Audi A4"},
            new Vozilo{Id = 2, Model="Golf 7"},
            new Vozilo{Id = 3, Model="BMW 3"}
        };
        [HttpGet]
        public ActionResult<Vozilo> GetVozilo(int id)
        {
            var vozilo = vozila.FirstOrDefault(v => v.Id == id);
            if (vozilo == null)
            {
                return NotFound();
            }
            return vozilo;
        }
    }
}
