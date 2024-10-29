// === SERVER SETUP (.NET Framework) ===

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using LearningPlatform.Models;

namespace LearningPlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private static List<Course> courses = new List<Course>
        {
            new Course { Id = 1, Title = "Introduction to Programming", Description = "Learn the basics of programming.", Level = "Beginner", Duration = "4 weeks", Instructor = "John Doe", Image = "https://example.com/image1.jpg" },
            new Course { Id = 2, Title = "Advanced Economics", Description = "Dive deep into economic theory.", Level = "Advanced", Duration = "8 weeks", Instructor = "Jane Smith", Image = "https://example.com/image2.jpg" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetCourses()
        {
            return Ok(courses);
        }
    }
}