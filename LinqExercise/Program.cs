﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine("Sum of numbers: ");

            Console.WriteLine(numbers.Sum());

            Console.WriteLine("");

            //TODO: Print the Average of numbers

            Console.WriteLine("Average of numbers: ");

            Console.WriteLine(numbers.Average());

            Console.WriteLine("");

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Ascending Order: ");

            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("");

            //TODO: Order numbers in decsending order and print to the console

            Console.WriteLine("Descending Order: ");

            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("");

            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Why was 6 afraid of 7 ? Because : ");

            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("");

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Only print 4 numbers in order : ");

            foreach (var item in numbers.OrderBy(x => x).Take(4))

            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("Changed index 4 to age and in descending order : ");

            numbers.SetValue(33, 4);

            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("");

            // List of employees ****Do not remove this****

            List<Employee> employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("First Name starts with 'C' or 'S' ascending order :");

            employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S')
                .OrderBy(x => x.FirstName)
                .ToList()
                .ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine("");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Name & Age over 26 : ");

            employees.Where(x => x.Age > 26)
                .OrderBy(x => x.Age)
                .ThenBy(x => x.FirstName)
                .ToList()
                .ForEach(x => Console.WriteLine($"Name: {x.FullName} Age: {x.Age}"));

            Console.WriteLine("");

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine($"Sum & Avg of YOE : ");

            int employeeSum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35)
                .Sum(x => x.YearsOfExperience);

            Console.WriteLine(employeeSum);

            Console.WriteLine("");

            Console.WriteLine($"Average of YOE");

            double employeeAvg = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35)
                .Sum(x => x.YearsOfExperience);

            Console.WriteLine("");

            //TODO: Add an employee to the end of the list without using employees.Add()

            Console.WriteLine("New Employee : ");

            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Bob";
            newEmployee.LastName = "Saget";
            newEmployee.YearsOfExperience = 54;

            employees.Append(newEmployee).ToList()
                .ForEach(x => Console.WriteLine(x.FullName));


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
