using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Alumnos.BusinessService;
using Alumnos.DataService;
using Alumnos.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Alumnos.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class StudentControllers : ControllerBase
    {
        private StudentBusinessService _StudentBusinessService;


        public StudentControllers(StudentBusinessService studentBusinessService)
        {
            _StudentBusinessService = studentBusinessService;
        }
        //---------------------htttp get--------------------------------
        [HttpGet("[action]")]
        public Student GetStudentById(string IdStudent)
        {
            
            return _StudentBusinessService.GetStudentById(IdStudent);
        }
        [HttpGet]
        public List<Student> GetAllStudent(){
            return _StudentBusinessService.GetAllStudent();
        }
        //---------------------htttp post--------------------------------
        [HttpPost("students")]
        public Student AddStudent(Student student)
        {
            return _StudentBusinessService.AddStudent(student);
        }

        
    }
}