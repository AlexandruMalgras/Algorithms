using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms.Implementation
{
    static class DayOfTheProgrammer
    {
        // The code for the HackerRank challenge Day of the Programmer
        // https://www.hackerrank.com/challenges/day-of-the-programmer/problem?isFullScreen=true
        public static string dayOfProgrammer(int year)
        {
            string date = "";

            DateTime dateTime = default;
            Calendar calendar = default;

            if (year < 1918)
            {
                calendar = new JulianCalendar();
                dateTime = new DateTime(year, 1, 1, calendar);
                dateTime = dateTime.AddDays(255);
            }
            else if (year == 1918)
            {
                calendar = new GregorianCalendar();
                dateTime = new DateTime(year, 1, 1, calendar);
                dateTime = dateTime.AddDays(268);
            }
            else
            {
                calendar = new GregorianCalendar();
                dateTime = new DateTime(year, 1, 1, calendar);
                dateTime = dateTime.AddDays(255);
            }

            date = calendar.GetDayOfMonth(dateTime).ToString("00") + "." + calendar.GetMonth(dateTime).ToString("00") + "." + calendar.GetYear(dateTime);

            return date;
        }
    }
}
