using System;
using System.Collections.Generic;
using System.Text;

namespace DataForge
{
    public static partial class Forge
    {

        public static class Text
        {
            public static string GenerateRandomText(int numWords)
            {
                // Lorem Ipsum Text
                string[] loremIpsum = {
                    "Lorem", "ipsum", "dolor", "sit", "amet,", "consectetur", "adipiscing", "elit.",
                    "Sed", "do", "eiusmod", "tempor", "incididunt", "ut", "labore", "et", "dolore", "magna", "aliqua.",
                    "Ut", "enim", "ad", "minim", "veniam,", "quis", "nostrud", "exercitation", "ullamco", "laboris", "nisi", "ut", "aliquip",
                    "ex", "ea", "commodo", "consequat.", "Duis", "aute", "irure", "dolor", "in", "reprehenderit", "in", "voluptate", "velit",
                    "esse", "cillum", "dolore", "eu", "fugiat", "nulla", "pariatur.", "Excepteur", "sint", "occaecat", "cupidatat", "non",
                    "proident,", "sunt", "in", "culpa", "qui", "officia", "deserunt", "mollit", "anim", "id", "est", "laborum."
                };

                StringBuilder sb = new StringBuilder();

                // Generate sentences until the specified number of words is reached
                int wordCount = 0;
                while (wordCount < numWords)
                {
                    int index = random.Next(loremIpsum.Length);
                    sb.Append(loremIpsum[index] + " ");
                    wordCount++;
                }

                // Return generated text
                return sb.ToString().TrimEnd();
            }
        }
    }
}
