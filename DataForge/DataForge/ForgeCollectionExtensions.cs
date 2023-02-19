using System;
using System.Collections.Generic;
using System.Text;

namespace DataForge
{
    public static class ForgeCollectionExtensions
    {
        private static readonly Random random = new Random();

        public static T RandomElement<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            var list = collection as IList<T> ?? new List<T>(collection);
            var count = list.Count;

            if (count == 0)
            {
                throw new InvalidOperationException("The collection is empty.");
            }

            var index = random.Next(count);
            return list[index];
        }
    }
}
