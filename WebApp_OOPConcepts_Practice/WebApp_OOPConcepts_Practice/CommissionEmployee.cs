using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts_Practice
{
    public class CommissionEmployee : Employee
    {
        #region Properties

        public double commissionPercentage { get; set; }

        public decimal sales { get; set; }

        #endregion

        public override decimal getValueToPay()
        {
            //Casting
            return sales * ((decimal)(commissionPercentage/100));
        }

        public override string ToString()
        {
            //P2: Whatever it returns (in this case,
            //the commision percentage), turn it into percentage
            // with 2 decimals format
            return $"{base.ToString()}\n\t" +
                $"Commission percentage..... {commissionPercentage/100:P2}\n\t" +
                $"Sales..... {sales:C2}\n\t" +
                $"Value to pay..... {getValueToPay():C2}";
        }
    }
}
