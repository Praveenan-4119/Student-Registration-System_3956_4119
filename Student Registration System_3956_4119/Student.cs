using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System_3956_4119
{
    public class Student
    {

        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string RegNum { get; set; }

        public string GPA { get; set; }

    }
}
