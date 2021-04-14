namespace CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int employeeNumber = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 1; i <= employeeNumber; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                employees.Add(new Employee(command[0], double.Parse(command[1]), command[2]));
            }
            List<string> departments = new List<string>(employees.Count);
            foreach (Employee employee in employees.Where(employee => !departments.Contains(employee.Department)))
            {
                departments.Add(employee.Department);
            }
            double salaryHighestAverage = 0;
            string departmentHighestAverage = "";
            foreach (string department in departments)
            {
                double salaryCurrentAverage = Employee.AverageSalary(employees, department);
                if (salaryCurrentAverage > salaryHighestAverage)
                {
                    salaryHighestAverage = salaryCurrentAverage;
                    departmentHighestAverage = department;
                }
            }
            Console.WriteLine($"Highest Average Salary: {departmentHighestAverage}");
            foreach (Employee employee in employees.Where(nameOf => nameOf.Department == departmentHighestAverage).OrderByDescending(valueOf => valueOf.Salary))
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        internal static double AverageSalary(List<Employee> employees, string department)
        {
            double salary = 0;
            int count = 0;
            foreach (Employee employee in employees.Where(nameOf => nameOf.Department == department))
            {
                salary += employee.Salary;
                count++;
            }
            return salary / count;
        }
        public override string ToString()
        {
            return $"{Name} {Salary:f2}";
        }
    }
}