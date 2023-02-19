using System;
using System.Collections.Generic;
using System.Text;

namespace DataForge
{

    public static partial class Forge
    {

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
                return Utils.GetRandomEnumValue<Genders>();
            }
        }
    }
}
