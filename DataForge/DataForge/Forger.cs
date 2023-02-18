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
        /// <returns>firstname</returns>
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
        /// <returns>lastname</returns>
        public static string RandomLastname()
        {
            return DataStore.lastNames[random.Next(DataStore.lastNames.Length)];
        }

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
    }
}
