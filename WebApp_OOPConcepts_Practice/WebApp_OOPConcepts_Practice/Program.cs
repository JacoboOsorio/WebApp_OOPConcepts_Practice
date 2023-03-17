using System;
using System.Data;

namespace WebApp_OOPConcepts_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("********************************");
                Console.WriteLine("My first Date class");
                Console.WriteLine("********************************");
                Console.WriteLine("");

                Console.Write("Please type your year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                Console.Write("Please type your month: ");
                int month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                Console.Write("Please type your day: ");
                int day = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");

                var dateObject = new Date(year, month, day);
                Console.Write($"The data entered is: {dateObject}");

                Employee salaryEmployee = new SalaryEmployee()
                {
                    Id  = 1,
                    firstName = "Patricia",
                    lastName = "Alvarez",
                    birthDate = dateObject,
                    hiringDate = dateObject,
                    isActive = true,
                    salary = 1160000
                };

                Console.WriteLine(salaryEmployee);
                Console.WriteLine("");

                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = 2,
                    firstName = "Julio",
                    lastName = "Perez",
                    birthDate = dateObject,
                    hiringDate = dateObject,
                    isActive = false,
                    commissionPercentage = 5,
                    sales = 20000000,
                };

                Console.WriteLine(commissionEmployee);
            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }

            
        }
    }
}