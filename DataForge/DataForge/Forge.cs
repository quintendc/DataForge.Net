using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DataForge
{
    public static class Forge
    {
        private static Random random = new Random();

        public static class Person
        {

            /// <summary>
            /// Generate a random firstname based on gender: MALE, FEMALE or NEUTRAL.
            /// </summary>
            /// <param name="gender">Generate a female name or male name, by default it will return a neutral name.</param>
            /// <returns>random firstname</returns>
            public static string RandomFirstname(Genders gender)
            {
                switch (gender)
                {
                    case Genders.Male:
                        return DataStore.maleNames[random.Next(DataStore.maleNames.Length)];
                    case Genders.Female:
                        return DataStore.femaleNames[random.Next(DataStore.femaleNames.Length)];
                    default:
                        return DataStore.neutralNames[random.Next(DataStore.neutralNames.Length)];
                }
            }

            /// <summary>
            /// Generate a random firstname based on gender: MALE, FEMALE or NEUTRAL.
            /// </summary>
            /// <param name="gender">Generate a female name or male name, by default it will return a neutral name.</param>
            /// <returns>random firstname</returns>
            public static string RandomFirstname(string gender = "NEUTRAL")
            {
                switch (gender.ToUpper())
                {
                    case "MALE":
                        return DataStore.maleNames[random.Next(DataStore.maleNames.Length)];
                    case "FEMALE":
                        return DataStore.femaleNames[random.Next(DataStore.femaleNames.Length)];
                    default:
                        return DataStore.neutralNames[random.Next(DataStore.neutralNames.Length)];
                }
            }

            /// <summary>
            /// Generate a random last name.
            /// </summary>
            /// <returns>random lastname</returns>
            public static string RandomLastname()
            {
                return DataStore.lastNames[random.Next(DataStore.lastNames.Length)];
            }

            /// <summary>
            /// Generate a random gender: MALE, FEMALE or NEUTRAL.
            /// </summary>
            /// <returns>random gender as string</returns>
            public static string RandomGenderString()
            {
                return RandomGenderString(new[] { "MALE", "FEMALE", "NEUTRAL" });
            }

            /// <summary>
            /// Generate a random Gender.
            /// </summary>
            /// <param name="genders">array of genders</param>
            /// <returns>random gender as string</returns>
            public static string RandomGenderString(string[] genders)
            {
                return genders[random.Next(DataStore.neutralNames.Length)];
            }

            /// <summary>
            /// Generate random gender.
            /// </summary>
            /// <returns>random gender as Enum value</returns>
            public static Genders RandomGender()
            {
                return ForgeUtils.GetRandomEnumValue<Genders>();
            }
        }

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

        public static class Communication
        {
            /// <summary>
            /// Generate a random email address, an email address will always be in de following format: "word1.word2@domainname.toplevel".
            /// </summary>
            /// <param name="firstname">optional, if empty a random word will be chosen</param>
            /// <param name="lastname">optional, if empty a random word will be chosen</param>
            /// <returns>random email address, based on firstname an lastname or random words</returns>
            public static string RandomEmailAddress(string firstname = "", string lastname = "")
            {

                string pattern = @"[^\w\s]|\s"; // Regex pattern to match non-alphanumeric characters
                string replacement = "."; // Replacement string
                Regex regex = new Regex(pattern);

                firstname = regex.Replace(firstname, replacement).ToLower();
                lastname = regex.Replace(lastname, replacement).ToLower();

                return $"{((firstname == "") ? DataStore.randomWords[random.Next(DataStore.randomWords.Length)] : firstname)}." +
                        $"{((lastname == "") ? DataStore.randomWords[random.Next(DataStore.randomWords.Length)] : lastname)}@" +
                        $"{DataStore.emailDomains[random.Next(DataStore.emailDomains.Length)]}";
            }

            /// <summary>
            /// Generate a random phone number with the default pattern.
            /// </summary>
            /// <param name="pattern">default pattern is: +32 ## ########</param>
            /// <returns>Random phone number</returns>
            public static string RandomPhoneNumber(string pattern = "+32 ## ########")
            {
                return pattern.RandomStringPatternGenerator(ConversionTypes.Numerical);
            }

            /// <summary>
            /// Generate a random phone number.
            /// </summary>
            /// <param name="plus">boolean to include leading + symbol</param>
            /// <param name="countryCode">used country code</param>
            /// <param name="areaCode">used area code</param>
            /// <returns>Random phone number</returns>
            public static string RandomPhoneNumber(bool plus, string countryCode = "32", string areaCode = "20")
            {
                string res = string.Empty;

                if (plus == true)
                {
                    res += "+";
                }

                res += $"{countryCode} {areaCode}";

                return res += " ########".RandomStringPatternGenerator(ConversionTypes.Numerical);
            }
        }

    }
}
