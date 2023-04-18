using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Entities
{
    public class Department
    {
        public Department()
        {
            Employees=new List<Employee>();
        }

        public int IdDept{ get; set; }
        public string Name { get; set; }
        public DateTime YearOfCreation { get; set; }

       
        public Employee Employee { get; set; }//for one to many relashionship

        
        public ICollection<Employee> Employees { get; set; }//القسم عندو اكثر من موظف
                                                                 //one to many relationship


    }
}
