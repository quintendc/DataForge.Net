using System;
using System.Collections.Generic;
using System.Text;

namespace DataForge
{
    public static class ForgeDateTimeExtensions
    {
        public static DateTime GenerateRandomDateTimeBetweenYears(this DateTime dateTime, int startYear, int endYear)
        {
            // generate a random year between startyear and endyear(included)
            int year = new Random().Next(startYear, endYear + 1);

            // generate a random month and day of the month
            int month = new Random().Next(1, 13);
            int day = new Random().Next(1, DateTime.DaysInMonth(year, month) + 1);

            // return a new DateTime based on generated values
            return new DateTime(year, month, day);
        }

        public static DateTime GenerateRandomDateTimeBetweenAges(this DateTime dateTime, int minAge, int maxAge)
        {
            // calculate difference between minimal and maximum age
            int ageRange = maxAge - minAge;

            // generate a random year in the range betweeen ages
            int randomAge = new Random().Next(ageRange + 1) + minAge;

            // Determine the date that corresponds to the generated number of years ago
            DateTime datetime = dateTime.AddYears(-randomAge);

            // return a random datetime
            return datetime;
        }
    }
}
