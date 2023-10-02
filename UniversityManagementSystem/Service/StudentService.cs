
using System.Collections.Generic;
using UniversityManagementSystem.Interface;
using static UniversityManagementSystem.Data.Model.UniversityDBModel;
using UniversityManagementSystem.Data.Context;
using System;
using System.Linq;
using UniversityManagementSystem.Repository;

namespace UniversityManagementSystem.Service
{
    public class StudentService : IStudentService
    {
        public readonly StudentRepository _repoStudent;
        public StudentService(StudentRepository repoStudent)
        {
            _repoStudent = repoStudent;
        }
        public List<Student> getAllStudents()
        {
            return _repoStudent.getAllStudent();
        }

        public bool addStudent(Student student)
        {

            try
            {
               return _repoStudent.AddStudent(student);
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public bool deleteStudent(int id)
        {
           return  _repoStudent.DeleteStudent(id);
        }

        public Student getStudentbyID(int id)
        {
           return (Student) _repoStudent.GetStudentbyID(id);
        }
    }
}


