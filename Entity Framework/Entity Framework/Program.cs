using Entity_Framework.Context;
using Entity_Framework.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD create/read/update/delete

            using (CompanyDbContext context=new CompanyDbContext())
            {
                #region INSERT
                //Employee employee1 = new Employee() { Id = 1, Name = "Basel", Salary = 1000, Age = 25, Address = "cairo", Email = "basel@gmail.com" };
                //Employee employee2 = new Employee() { Id = 2, Name = "amjad", Salary = 2000, Age = 30, Address = "Gaza", Email = "amjad@gmail.com" };

                //Department department1 = new Department() { Name = "Ds" };
                //Department department2 = new Department() { Name = "hr" };
                //Console.WriteLine(context.Entry(employee1).State);//Detached

                ////EntityState

                ////addlocally not add in data base in sql server
                //context.Employees.Add(employee1);//employess dbset
                //context.Employees.Add(employee2);//employess dbset

                //context.Add(department1);
                //context.Add(department2);
                //Console.WriteLine(context.Entry(employee1).State);//added >>added local not add in table  Employees in data base company in sql server

                //update in data base in sql server
                /*   context.SaveChanges();*///commit >>sava change in data base

                //Console.WriteLine(context.Entry(employee1).State);//unchanged

                //Console.WriteLine(employee1.Id);//1
                //Console.WriteLine(employee2.Id);//2

                //Console.WriteLine(department1.IdDept);//10
                //Console.WriteLine(department2.IdDept);//20
                #endregion

                #region SELECT,UPDATE

                //select
                //var result = context.Employees.Where(emp => emp.Id == 2).FirstOrDefault();
                //Console.WriteLine($"{result.Id} :: {result.Name} :: {result.Email}");

                ////update localy not update in data base in sql server
                //result.Name = "hema";
                //Console.WriteLine(context.Entry(result).State); //Modified

                //context.SaveChanges();
                //Console.WriteLine(context.Entry(result).State); //unchanged

                #endregion


                #region Delete

                //Delete local not delete in data base in sql server


                //context.Employees.Remove(result);
                //context.Remove(result);

                //Console.WriteLine(context.Entry(result).State);//deleted

                //context.SaveChanges();//delete in data base in sql server

                //Console.WriteLine(context.Entry(result).State);//detached

                //var result = context.Employees.Where(emp => emp.Id == 2).FirstOrDefault();
                //context.Remove(result);
                //context.SaveChanges();
                #endregion


                #region AsNoTracking
                //AsNoTracking
                //يعني مابيعمل اي تغير (اضافة/حذف/تعديل) ع 
                //DATA BASE

                var result = context.Employees.Where(e => e.Id == 1).AsNoTracking().FirstOrDefault();//يعني مابيعمل اي تغير ع الموظف الي رقمو واحد
                result.Age = 30;
                Console.WriteLine(context.Entry(result).State);//detached
                context.SaveChanges();

                //or
                // context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;//all in context in data base

                #endregion

            }

        }
    }
}