using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts_Practice
{
    public class SalaryEmployee : Employee
    {
        #region Properties

        public decimal salary { get; set; }

        #endregion

        public override decimal getValueToPay()
        {
            return salary;
        }

        public override string ToString()
        {
            //C2: Whatever it returns (in this case,
            //the salary), turn it into the currency
            // with 2 decimals format
            return $"{base.ToString()}\n\t" +
                $"Salary..... {getValueToPay():C2}";
        }
    }
}
