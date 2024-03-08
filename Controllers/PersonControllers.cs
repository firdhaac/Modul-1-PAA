using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TugasMandiri1.Models;
namespace PercobaanApi1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("{id_person}")]
        public ActionResult GetPerson(int id_person)
        {
            PersonContext context = new PersonContext();
            Person person = context.GetPerson(id_person);

            if (person == null) 
           {
                return NotFound();
           }
            return Ok(person);

        }
    }
}