using System.Collections.Generic;
using System.Linq;
using UniversityManagementSystem.Data.Context;
using static UniversityManagementSystem.Data.Model.UniversityDBModel;

namespace UniversityManagementSystem.Repository
{
    public class StudentRepository
    {
        public readonly UniversityDBContext studentDbContext;
        public StudentRepository(UniversityDBContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }



        public List<Student> getAllStudent()
        {
            return this.studentDbContext.Students.ToList();
        }

        public bool AddStudent(Student student)
        {
           
                this.studentDbContext.Students.Add(student);
                this.studentDbContext.SaveChanges();
                return true;
          
        }

        public bool DeleteStudent(int id)
        {
            Student student = GetStudentbyID(id);
            if (id != null)
            {
                this.studentDbContext.Students.Remove(student);
                return true;
            }
            else
            {
                return false;
            }

        }


        public Student GetStudentbyID(int id)
        {
            return this.studentDbContext.Students.FirstOrDefault(x => x.StudentId == id);
        }

    }
}
