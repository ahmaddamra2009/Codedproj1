using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models
{
    public class Employee
    {
        private string emailAddress;
        // Prop
        public string EmailAddress {
            get { return emailAddress; }
            set {
                if (value.Contains('@'))
                {
                    emailAddress = value;
                }
                else {
                    Console.WriteLine("Invalid Email Address");
                }
            } }

        public void GetEmailAddress()
        {
            Console.WriteLine("My Email is " + emailAddress);
        }

        public int Id { get ; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } 
        public int Age { get; set; }

        // Object List  of Employee
        List<Employee> employeesList = new List<Employee>();


        // AddEmployee
        public void AddEmployee(int id,string name, string email, int age)
        {
            employeesList.Add(new Employee {Id=id, Name = name, Email = email, Age = age });

        }
        // GetEmployees
        public void GetEmployees()
        {
            foreach (var emp in employeesList)
            {
                Console.WriteLine("ID: "+ emp.Id+  " Name: " + emp.Name +
                                 " Email: " + emp.Email +
                                  " Age: " + emp.Age);
            }

        }
    }
}
