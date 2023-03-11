using System.Collections.Generic;
using System.Linq;
using CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All" , Name = "GetAllStudents")]
        public IEnumerable<Student> GetStudents()
        {
            return CollegeRepository.Students;
        }

       // [HttpGet("{id}")]
       [HttpGet]
       [Route("{id}" , Name = "GetStudentById")]
        public Student GetStudentById(int id)
        {
            return CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
        }

         [HttpGet("{name}", Name = "GetStudentByName")]
         //[Route()]
        public Student GetStudentByName(string name)
        {
            return CollegeRepository.Students.Where(n => n.StudentName == name).FirstOrDefault();
        }

         [HttpDelete("{id}" , Name = "DeleteStudentById")]
        public bool DeleteStudent(int id)
        {
            var student =  CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
            CollegeRepository.Students.Remove(student);

            return true;
        }
    }
}