using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UniversityManagementSystem.Service;
using static UniversityManagementSystem.Data.Model.UniversityDBModel;

namespace UniversityManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        protected readonly StudentService _studentService;
        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        [Route("api/get/all/students")]
        public List<Student> GetAllStudent()
        {
            try
            {
                return _studentService.getAllStudents();

            }
            catch (Exception e)
            {

                throw e;
            }

        }

        [HttpGet]
        [Route("api/get/student/by/id")]
        public Student getStudentById(int id)
        {
            try
            {
                return _studentService.getStudentbyID(id);

            }
            catch (Exception e)
            {

                throw e;
            }

        }


        [HttpPost]
        [Route("api/add/student")]
        public bool AddStudent(Student student)
        {
            try
            {
                return _studentService.addStudent(student);

            }
            catch (Exception e)
            {

                throw e;
            }

        }


        //[HttpPut]
        //[Route("api/add/student")]
        //public bool AddStudent(Student student)
        //{
        //    try
        //    {
        //        return _studentService.addStudent(student);

        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }

        //}

        [HttpDelete]
        [Route("api/delete/student/by/id")]
        public bool deleteStudentById(int id)
        {
            try
            {
                return _studentService.deleteStudent(id);

            }
            catch (Exception e)
            {

                throw e;
            }

        }




    }
}
