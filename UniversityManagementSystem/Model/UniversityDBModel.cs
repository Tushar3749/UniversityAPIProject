using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Data.Model
{
    public class UniversityDBModel
    {
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public string Group { get; set; }
            public string Batch { get; set; }
            public DateTime Admissiondate { get; set; }
            public string DepartmentID { get; set; }
            public Department Department { get; set; }


        }


        public class Department
        {
            public string DepartmentID { get; set; }
            public string DepartmentName { get; set; }
            public string TotalStudents { get; set; }
            public int DepartmentHeadID { get; set; }
            public DateTime CreatedOn  { get; set; }

            ICollection<Student> Students { get; set; }

        }



    }
}
