using System;
using System.Collections.Generic;
using System.Text;

namespace DataForge
{
    public static partial class Forge
    {

        public static class DateTime
        {
            public static System.DateTime GenerateRandomDateTimeBetweenYears(int startYear, int endYear)
            {
                // generate a random year between startyear and endyear(included)
                int year = random.Next(startYear, endYear + 1);

                // generate a random month and day of the month
                int month = random.Next(1, 13);
                int day = random.Next(1, System.DateTime.DaysInMonth(year, month) + 1);

                // return a new DateTime based on generated values
                return new System.DateTime(year, month, day);

            }


            public static System.DateTime GenerateRandomDateTimeBetweenAges(int minAge, int maxAge)
            {
                // calculate difference between minimal and maximum age
                int ageRange = maxAge - minAge;

                // generate a random year in the range betweeen ages
                int randomAge = random.Next(ageRange + 1) + minAge;

                // Determine the date that corresponds to the generated number of years ago
                System.DateTime datetime = System.DateTime.Now.AddYears(-randomAge);

                // return a random birthday
                return datetime;
            }
        }
    }
}
