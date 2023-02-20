using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using DataForge.Extensions;

namespace DataForge
{
    public static partial class Forge
    {

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
