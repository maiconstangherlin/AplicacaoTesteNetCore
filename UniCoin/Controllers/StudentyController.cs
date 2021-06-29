using Microsoft.AspNetCore.Mvc;
using UniCoin.Models;

namespace UniCoin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentyController : Controller
    {

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("/{id}")]
        public ActionResult GetById(long id)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Add([FromBody] Studenty student)
        {
            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

        [HttpDelete("/{id}")]
        public ActionResult delete(long id)
        {
            return Ok();
        }
    }
}
