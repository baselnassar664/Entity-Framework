using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Entities
{
    public class Course
    {
        public Course() {

            //students=new HashSet<Student>();
            studentsCourse = new HashSet<StudentCourse>();

        }
        public int Id { get; set; }

        public string Title { get; set; }

        //public ICollection<Student> students { get; set; }//الكورس بوخدو اكتر من طالب

        //for many to many relationship

        public ICollection<StudentCourse> studentsCourse { get; set; }////for many to manyrelationship


    }
}
