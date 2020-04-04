using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSBLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("\tABC\nDEF\t\r\nYY");
            Employee employee = new Employee();
            
            employee.FirstName = "Chanlder";
            employee.LastName = "Ding";
            employee.Age = 30;
            employee.Salary = 2599.99m;
            employee.ItsEducation = Employee.Education.Higher;
            //employee.Login = "ABC";
            //employee.Password = "DEF";


              //  employee.PrintInfo();

            Employee secondEmployee = new Employee();
            secondEmployee.FirstName = "Ala";
            secondEmployee.LastName = "Placek";
            secondEmployee.Age = 25;
            secondEmployee.ItsEducation = Employee.Education.Higher;

            //secondEmployee.PrintInfo();

            Employee isAdult =  new Employee();
            isAdult.FirstName = "Ala";
            isAdult.LastName = "Placek2";
            isAdult.Age = 20;

            Employee thirdEmployee= new Employee();
            thirdEmployee.FirstName = "Joey";
            thirdEmployee.LastName = "HEHE";
            thirdEmployee.Login = "ABC";
            thirdEmployee.Password = "DEF";
            thirdEmployee.Age = 30;
            thirdEmployee.Salary = 1000.99m;
            thirdEmployee.ItsEducation = Employee.Education.Secondary;


            Console.WriteLine(isAdult.IsAdult1());
            Console.WriteLine(isAdult.IsAdult2());

            Console.WriteLine(employee.Login);

            Console.WriteLine(employee.CheckLogin("ABC","DEF"));

            isAdult.PrintInfo();

            Console.WriteLine("******************* database *******************");

            // ******** database ********

            EmployeeDb database = new EmployeeDb();
            database.Add(employee);
            database.Add(secondEmployee);
            database.Add(thirdEmployee);
            database.Print();

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee);
            Console.WriteLine(employeeList.Count);
            employeeList.Add(secondEmployee);
            Console.WriteLine(employeeList.Count);
            employeeList.Add(thirdEmployee);
            Console.WriteLine(employeeList.Count);

            /*
            for (int i = 0; i < employeeList.Count; i++)
             {
             employeeList[i].PrintInfo();
             }
            */

            foreach (Employee employeee in employeeList)
            {
                employee.PrintInfo();
            }

            Console.WriteLine("**********************************");
            Console.WriteLine("**********************************");
            Console.WriteLine("**********************************");
            //Console.WriteLine(employee.FullName);
            Console.ReadLine();
        }
    }
}
