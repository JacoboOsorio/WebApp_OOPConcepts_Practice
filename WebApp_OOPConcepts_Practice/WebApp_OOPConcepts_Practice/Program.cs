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
                Console.WriteLine("");

                Console.WriteLine("Please type your ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type your first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Please type your last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Please type if it's active: ");
                bool isActive = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type the number of hours: ");
                float hours = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type the value per hour: ");
                decimal hourValue = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("");

                Employee hourlyEmployee = new HourlyEmployee()
                {
                    Id = id,
                    firstName = firstName,
                    lastName = lastName,
                    birthDate = dateObject,
                    hiringDate = dateObject,
                    isActive = isActive,
                    hours = hours,
                    hourValue = hourValue
                };

                Console.WriteLine(hourlyEmployee);
            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }

            
        }
    }
}