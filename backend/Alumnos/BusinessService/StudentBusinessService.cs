using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alumnos.DataService;
using Alumnos.models;

namespace Alumnos.BusinessService
{
    public class StudentBusinessService
    {
        private StudentDataService _StudentDataService;

        public StudentBusinessService(StudentDataService studentDataService)
        {
            _StudentDataService = studentDataService;
        }
        public Student GetStudentById(string IdStudent)
        {  
            return _StudentDataService.GetStudentById(IdStudent);
        }
        public List<Student> GetAllStudent(){
            return _StudentDataService.GetAllStudent();
        }
        //---------------------htttp post--------------------------------
        public Student AddStudent(Student student)
        {
            return _StudentDataService.AddStudent(student);
        }
    }
}