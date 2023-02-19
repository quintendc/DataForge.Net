using System;
using System.Collections.Generic;
using System.Text;

namespace DataForge
{
    public static partial class Forge
    {

        public static class Address
        {
            /// <summary>
            /// Generate random address line without city and zipcode.
            /// </summary>
            /// <param name="includeNumber">include house number</param>
            /// <returns>random street</returns>
            public static string RandomStreet(bool includeNumber = false)
            {
                int number = random.Next(0, 101);

                string result = $"{DataStore.streetNames[random.Next(DataStore.streetNames.Length)]}";

                if (includeNumber)
                {
                    result += $" {number}";
                }

                return result;
            }

            /// <summary>
            /// Generate a ranom city
            /// </summary>
            /// <returns>random city name</returns>
            public static string RandomCity()
            {
                return DataStore.cities[random.Next(DataStore.cities.Length)];
            }
        }
    }
}
