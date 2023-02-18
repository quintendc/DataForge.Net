using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DataForge
{
    public static class Forger
    {
        private static Random random = new Random();

        /// <summary>
        /// Generate a ranodm firstname based on gender.
        /// </summary>
        /// <param name="gender">Generate a female name or male name, by default it will return a neutral name.</param>
        /// <returns>random firstname</returns>
        public static string RandomFirstname(DataForgeGenders gender = DataForgeGenders.Neutral)
        {
            switch (gender)
            {
                case DataForgeGenders.Male:
                    return DataStore.maleNames[random.Next(DataStore.maleNames.Length)];
                case DataForgeGenders.Female:
                    return DataStore.femaleNames[random.Next(DataStore.femaleNames.Length)];
                default:
                    return DataStore.neutralNames[random.Next(DataStore.neutralNames.Length)];
            }
        }

        /// <summary>
        /// Genearte a random last name.
        /// </summary>
        /// <returns>random lastname</returns>
        public static string RandomLastname()
        {
            return DataStore.lastNames[random.Next(DataStore.lastNames.Length)];
        }

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
        /// Generate a random value based on a pattern written with hashtags.
        /// </summary>
        /// <param name="pattern">all hashtags will be replaced with a random value</param>
        /// <param name="conversionTypes">random value type: numerical, alphabetical or both</param>
        /// <returns>random string with pattern</returns>
        public static string RandomStringPattern(string pattern, ConversionTypes conversionTypes)
        {
            return pattern.StringPatternGenerator(conversionTypes);
        }
    }
}
