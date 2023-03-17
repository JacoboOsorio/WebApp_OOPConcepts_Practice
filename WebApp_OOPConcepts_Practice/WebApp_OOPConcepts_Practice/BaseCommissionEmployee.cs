using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts_Practice
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        #region Properties

        public decimal Base { get; set; }

        #endregion

        public override decimal getValueToPay()
        {
            //Taking back the "getValueToPay"
            // method from "CommissionEmployee" instead of writing 
            // "sales * ((decimal)(commissionPercentage/100))"
            return base.getValueToPay() + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Base..... {commissionPercentage/100:P2}\n\t" +
                $"Total..... {getValueToPay():C2}";
        }
    }
}
