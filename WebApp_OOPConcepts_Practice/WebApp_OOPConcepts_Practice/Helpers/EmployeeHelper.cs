using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts_Practice.Helpers
{
    public class EmployeeHelper
    {
        private Employee _salaryEmployee;

        private Employee _commissionEmployee;

        private Employee _hourlyEmployee;

        private Employee _baseCommissionEmployee;

        public EmployeeHelper(Employee salaryEmployee, Employee commissionEmployee, Employee hourlyEmployee, Employee baseCommissionEmployee)
        {
            _salaryEmployee = salaryEmployee;
            _commissionEmployee = commissionEmployee;
            _hourlyEmployee = hourlyEmployee;
            _baseCommissionEmployee = baseCommissionEmployee;
        }

        public decimal getPayrollFromActiveEmployees()
        {
            //ICollection: List
            //Declaring a new variable called "employees"
            ICollection<Employee> employees = new List<Employee>()
                {
                    _salaryEmployee,
                    _commissionEmployee,
                    _hourlyEmployee,
                    _baseCommissionEmployee
                };

            decimal payroll = 0;

            //Foreach loop to show all the elements of the list
            foreach (Employee employee in employees)
            {
                if (employee.isActive)
                {
                    Console.WriteLine(employee);
                    payroll += employee.getValueToPay();
                    Console.WriteLine(" ");
                }
            }

            return payroll;
        }
    }
}
