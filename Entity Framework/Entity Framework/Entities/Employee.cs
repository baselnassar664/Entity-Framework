using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Entities
{
    //entity framwork core support 4 ways for mapping class to data base (table,view):
    // 1.convention (defult action)
    //2.data annotation

    //by  convention
    /*
   public  class Employee
    {
        
        public int Id { get; set; }//Id or EntityId >>primary key >>defult identity (1,1)

        public string Name { get; set; } //string >>refrence type >>allow null

        public int Age { get; set; } //value type>>not  Allow Null

        public double? Salary { get; set; } //value type >>  allow null  (nullable)


    }
    */

    //by  data annotation

    [Table("Employess")]
    public class Employee
    {
        [Key] //primary key >>defult identity (1,1)
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //no identity
        public int Id { get; set; }

        [Required]//required not allow null
        [Column(TypeName = "varchar")]//data type varchar  for name 
        [StringLength(50, MinimumLength = 10)]
        //[MaxLength(50)]
        //[MinLength(10)]
        public string Name { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [Column(TypeName = "money")]
        public double? Salary { get; set; }//allow null

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public String Address { get; set; }

        public Department Department { get; set; }// to add primary key (IdDept) table Department  in  table Employee (forgin key ) //for one to one relationship
                                                  //الموظف بدير قسم معين
        [ForeignKey("Department")]
        public int DeptId { get; set; } //add primary key (IdDept) table Department  in  table Employee (forgin key ) //for one to one relationship
    }
}
