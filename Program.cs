using System;
using System.Collections.Generic;

namespace EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee>list = new List<Employee>();

            for( int i = 1; i <= n; i++) {
                Console.WriteLine("Employee # " + i );
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee());
                Console.WriteLine();
            }

                Console.WriteLine("Enter the id that'll have salary increase: ");
                int searchId = int.Parse(Console.ReadLine());
                Employee emp = list.Find(x => x.Id == searchId);
                Console.Write("Enter with the salary: ");
                double oldSalary = double.Parse(Console.ReadLine());
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                double newsalary = oldSalary+( oldSalary * percentage / 100);
                Console.Write("New salary is: " + newsalary);
            
        }
    }
}
