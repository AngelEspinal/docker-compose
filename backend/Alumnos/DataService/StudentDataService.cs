using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alumnos.models;

namespace Alumnos.DataService
{
    public class StudentDataService
    {
        private Context _context;
        public StudentDataService(Context context)
        {
            _context = context;
        }
        public Student GetStudentById(string IdStudent)
        {  
            var student = _context.Tstudent.Find(IdStudent);
            return student;
        }
        public List<Student> GetAllStudent(){

            return _context.Tstudent.ToList();
        }
        //---------------------htttp post--------------------------------
        public Student AddStudent(Student student)
        {
            _context.Tstudent.Add(student);
            _context.SaveChanges();
            return student;
        }
    }
    
}