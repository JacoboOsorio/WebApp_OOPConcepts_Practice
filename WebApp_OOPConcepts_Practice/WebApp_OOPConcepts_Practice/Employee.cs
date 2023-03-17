using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts_Practice
{
    public abstract class Employee
    {
        #region Properties

        public int Id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public Date birthDate { get; set; }

        public Date hiringDate { get; set; }

        public bool isActive { get; set; }

        #endregion

        #region Methods

        public abstract decimal getValueToPay();

        public override string ToString()
        {
            return $"---- EMPLOYEE ----\n\t" +
                $"ID ..... {Id}\n\t" +
                $"First name..... {firstName}\n\t" +
                $"Last name..... {lastName}\n\t" +
                $"Birth date..... {birthDate}\n\t" +
                $"Hiring date..... {hiringDate}\n\t" +
                $"Is active?..... {isActive}";
        }

        #endregion
    }
}
