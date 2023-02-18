using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataForge
{
    public static class ForgeStringExtensions
    {

        private static Random random = new Random();

        /// <summary>
        /// generate random text
        /// </summary>
        /// <param name="sourceText">if empty random words will be generated, else it will generate a random text of the words in the source text.</param>
        /// <param name="length">numbers of words in the generated text.</param>
        /// <returns>random text</returns>
        public static string RandomText(this string sourceText, int length = 10)
        {
            if (String.IsNullOrEmpty(sourceText))
            {
                sourceText = DataStore.loremIpsum;
            }

            string[] words = sourceText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var selectedWords = Enumerable.Range(0, length)
                .Select(i => words[random.Next(words.Length)])
                .ToList();

            return string.Join(" ", selectedWords);
        }


        /// <summary>
        /// convert hashtags to random numbers, this can be usefull to generate phonenumbers zipcodes, etc...
        /// </summary>
        /// <param name="sourceText">input pattern, every hashtag will be replaced</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string RandomStringPatternGenerator(this string sourceText, ConversionTypes characterTypes)
        {
            if (string.IsNullOrWhiteSpace(sourceText) || string.IsNullOrEmpty(sourceText))
            {
                throw new ArgumentException("Source can't be null, empty or whitespace. This function will replace all '#' with a random number!");
            }

            var rand = new Random();
            var result = new StringBuilder();

            switch (characterTypes)
            {
                case ConversionTypes.Numerical:
                    foreach (var c in sourceText)
                    {
                        if (c == '#')
                        {
                            result.Append(rand.Next(10));
                        }
                        else
                        {
                            result.Append(c);
                        }
                    }
                    break;
                case ConversionTypes.Alphabetical:
                    foreach (var c in sourceText)
                    {
                        if (c == '#')
                        {
                            result.Append((char)rand.Next(65, 91));
                        }
                        else
                        {
                            result.Append(c);
                        }
                    }
                    break;
                case ConversionTypes.Both:
                    foreach (var c in sourceText)
                    {
                        if (c == '#')
                        {
                            int path = rand.Next(0, 2);
                            if (path == 0)
                            {
                                result.Append(rand.Next(10));
                            }
                            else
                            {
                                result.Append((char)rand.Next(65, 91));
                            }
                        }
                        else
                        {
                            result.Append(c);
                        }
                    }
                    break;
            }

            return result.ToString();
        }

    }
}
