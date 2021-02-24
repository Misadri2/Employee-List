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

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee # " + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the id that'll have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);  //! Parte mais importante do código para encontrar o Id.
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreasySalary(percentage);
            }
            else
            {
                Console.WriteLine("This Id does not existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Update List of employees: ");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
