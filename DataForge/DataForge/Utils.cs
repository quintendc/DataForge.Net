using System;
using System.Collections.Generic;
using System.Text;

namespace DataForge
{
    public static partial class Forge
    {

        public static class Utils
        {
            /// <summary>
            /// Generate a random value of any enum.
            /// </summary>
            /// <typeparam name="T">Enum type</typeparam>
            /// <returns>Random enum value</returns>
            public static T GetRandomEnumValue<T>() where T : struct, Enum
            {
                var values = Enum.GetValues(typeof(T));
                var random = new Random();
                var randomEnumValue = (T)values.GetValue(random.Next(values.Length));
                return randomEnumValue;
            }

            /// <summary>
            /// Generate a random value based on a pattern written with hashtags.
            /// </summary>
            /// <param name="pattern">all hashtags will be replaced with a random value</param>
            /// <param name="conversionTypes">random value type: numerical, alphabetical or both</param>
            /// <returns>random string with pattern</returns>
            public static string RandomStringPattern(string pattern, ConversionTypes conversionTypes)
            {
                return pattern.RandomStringPatternGenerator(conversionTypes);
            }
        }
    }
}
