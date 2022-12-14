using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ub8ljw_api.Models;

namespace ub8ljw_api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        [HttpGet]
        [Route("instructor/all")]
        public IActionResult M1()
        {
            InstructorContext context = new InstructorContext();

            var tanárok = from x in context.Instructor
                          select x;

            return Ok(tanárok);
        }

        [HttpPost]
        [Route("instructor/new")]
        public void POST([FromBody] Instructor ujTanar)
        {
            Models.InstructorContext context = new Models.InstructorContext();
            context.Instructor.Add(ujTanar);
            context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            InstructorContext context = new InstructorContext();

            var törlendőTanár = (from x in context.Instructor
                                 where x.InstructorSk == id
                                 select x).FirstOrDefault();

            context.Instructor.Remove(törlendőTanár);
            context.SaveChanges();
        }

    }
}
