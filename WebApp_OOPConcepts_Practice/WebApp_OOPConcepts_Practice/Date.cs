using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_OOPConcepts_Practice
{
    public class Date
    {
        #region Fields

        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods

        public Date(int year, int month, int day)
        {
            _year = CheckYear(year);
            _month = CheckMonth(month);
            _day = CheckDay(day, month, year);
        }

        private int CheckYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }

            throw new YearException("The year is not valid!");
        }

        private int CheckDay(int day, int month, int year)
        {
            if (month == 2 && day == 29 && isLeapYear(year))
            {
                return day;
            }

            //initialized a new array
            int[] daysPerMonth = {
                0, 31, 28, 31, 30, 31, 31, 30, 31,   30, 31, 30, 31
            };

            if (day >= 1 && day <= daysPerMonth[month]) return day;


            throw new DayException("The day is not valid!");
        }

        private bool isLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int CheckMonth(int month)
        {
            if (month <= 12 && month >= 1)
            {
                return month;
            }

            //Catching an exception
            throw new MonthException("The month is not valid!");
        }

        //Using polymorphism with the "ToString" method
        public override string ToString()
        {
            //Normal
            //return(_year + "/" + _month + "/" + _day);

            //Interpolacion
            return $"{_year}/{_month}/{_day}";

            //String.Format
            //return String.Format("{0}/{1}/{2}", _year, _month, _day);
        }

        #endregion
    }
}
