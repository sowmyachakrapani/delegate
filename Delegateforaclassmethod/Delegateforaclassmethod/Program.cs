using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegateforaclassmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { ID = 1, Name = "SOWMYA", Salary = 5000, exp = 5 });
            emplist.Add(new Employee() { ID = 1, Name = "MUKUND", Salary = 6000, exp = 6 });
            IsPromotable ispromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(emplist,ispromotable);
            //foreach (Employee emp in emplist)
            //{
            //    ispromotable(emp);
            //}
        }
        public static bool Promote(Employee emp)
        {
            if (emp.exp >= 5)
                return true;
            else
                return false;
        }
    }

    delegate bool IsPromotable(Employee emp);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int exp { get; set; }

        public static void PromoteEmployee(List<Employee> emplist, IsPromotable EmptoPromote)
        {
            foreach (Employee emp in emplist)
            {
                if (EmptoPromote(emp))
                {
                    Console.WriteLine(emp.Name + "is Promoted");
                }
            }
        }



    }
}
