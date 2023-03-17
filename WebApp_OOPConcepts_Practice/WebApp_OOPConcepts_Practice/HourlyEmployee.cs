using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts_Practice
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public float hours { get; set; }

        public decimal hourValue { get; set; }

        #endregion

        public override decimal getValueToPay()
        {
            return hourValue * (decimal)hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Hours..... {hours}\n\t" +
                $"Value per hour..... {hourValue:C2}\n\t" +
                $"Value to pay..... {getValueToPay():C2}";
        }
    }
}
