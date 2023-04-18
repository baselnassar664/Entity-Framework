using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Entities
{
    public class Student
    {
        public Student()
        {
            //courses=new List<Course>();
            Coursestudents = new List<StudentCourse>();
        }

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Range(18, 30)]
        public int? Age{ get; set; }

        //public ICollection<Course> courses { get; set; }//الطالب بوخد اكتر من كورس

        //for many to manyrelationship

        public ICollection<StudentCourse> Coursestudents { get; set; } //for many to manyr elationship
    }
}
