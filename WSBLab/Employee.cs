using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSBLab
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; } //= "ABC";
        public string Password { get; set; }// = "DEF";

        public decimal Salary { get; set; }


        public string FullName { { return $"{FirstName} & {LastName}"; } }
        //public string FullName() => $"{FirstName} & {LastName}";

        int XYZ = 0; // private
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        

        public enum Education
        {
            Primary,
            Secondary,
            Higher
        }

        public Education ItsEducation { get; set; }

        //finalizator
        ~Employee()
        {
            Console.WriteLine("bye");
        }

        public Employee(string login, string password)
        {
            Console.WriteLine("I'm creating an object");
            Login = login;
            Password = password;
        }




        public void PrintInfo()
        {
            Console.WriteLine($"Name is: {FirstName} | LastName is: {LastName}");
            Console.WriteLine(LastName);
            Console.WriteLine(Age);
            Console.WriteLine(Salary);
        }

        
        public bool IsAdult1()
        {
            if (Age >= 18) { 
            return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAdult2()
        {
            return Age >= 18 ? true : false;
        }

        public bool CheckLogin(string login, string password)
        {
            if (Login == login && Password == password)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
