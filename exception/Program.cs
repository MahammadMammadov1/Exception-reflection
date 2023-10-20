using exception.Models;
using System.Reflection;

namespace exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee employee = new Employee("Mehemmed Memmedov ", "MM", 21, 1, 3000);
                Employee employee1 = new Employee("Eli Eliyev","EE",25,2,6000);
                Employee[] Employees = new Employee[2];
                Employees[0] = employee;
                Employees[1] = employee1;


                for (int i = 0; i < Employees.Length; i++)
                {
                    Employee emp = Employees[i];
                    Console.WriteLine($"ID: {emp.Id}");
                    Console.WriteLine($"Fullname: {emp.FullName}");
                    Console.WriteLine($"DepartmentNo: {emp.DepartmentNo}");
                    Console.WriteLine($"Age: {emp.Age}");
                    Console.WriteLine($"Experience: {emp.Experience}");
                    
                    Console.WriteLine();
                }
                int totalSalary = CalculateSalary(Employees);
                Console.WriteLine($"Total Salary: {totalSalary}");

            }
            catch (InvalidFullNameException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (InvalidAgeException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (InvalidDepartmentN0Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (InvalidExperienceException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public static int CalculateSalary(Employee[] employees) // INTERNETDEN KOMEK ALDIM 
        {

            int totalSalary = 0;

            foreach (Employee employee in employees)
            {
                Type employeeType = employee.GetType();
                FieldInfo salaryField = employeeType.GetField("_salary", BindingFlags.NonPublic | BindingFlags.Instance);
                int salary = (int)salaryField.GetValue(employee);
                totalSalary += salary;
            }

            return totalSalary;



        }
    }
}