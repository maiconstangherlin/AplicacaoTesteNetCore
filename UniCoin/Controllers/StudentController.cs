using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UniCoin.Models;
using UniversatyCoin.Persistence;

namespace UniCoin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly UniversatyDbContext dbContext;

        public StudentController(UniversatyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var students = dbContext.Students.ToList();
            return Ok(students);
        }

        [HttpGet("/{id}")]
        public ActionResult GetById(long id)
        {
            var student = dbContext.Students.SingleOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost]
        public ActionResult Add([FromBody] Student student)
        {
            dbContext.Students.Add(student);
            dbContext.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

        [HttpDelete("/{id}")]
        public ActionResult delete(long id)
        {
            var student = dbContext.Students.SingleOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();

            dbContext.Students.Remove(student);
            dbContext.SaveChanges();

            return NoContent();
        }
    }
}
