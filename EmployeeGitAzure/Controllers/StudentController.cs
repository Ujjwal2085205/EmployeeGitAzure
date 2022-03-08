using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeGitAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        List<Student> students = new List<Student>
        {
            new Student{ Name="ramu" , address="Pune", Mobile=9932980982 },
            new Student{ Name="Shyam" , address="Banglore" , Mobile=7788902832}
        };

        public List<Student> GetStudents()
        {
            return students;

        }

    }
}
