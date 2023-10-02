using System.Collections.Generic;
using static UniversityManagementSystem.Data.Model.UniversityDBModel;

namespace UniversityManagementSystem.Interface

{
    public interface IStudentService
    {

        List<Student> getAllStudents();
        bool addStudent(Student student);
        Student getStudentbyID(int id);
        bool deleteStudent(int id);

    }
}
