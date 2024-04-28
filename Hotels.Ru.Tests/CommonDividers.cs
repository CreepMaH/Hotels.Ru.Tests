using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels.Ru.Tests
{
    public static class CommonDividers
    {
        public static int[] GetCommonDividers(int[] input)
        {
            List<List<int>> dividers = [];
            foreach (int num in input)
            {
                dividers.Add(GetDividers(num));
            }

            if (dividers.Count == 0)
            {
                return [];
            }

            var intersection = dividers
                .Skip(1)
                .Aggregate(
                    new HashSet<int>(dividers[0]),
                    (h, e) => { h.IntersectWith(e); return h; }
                );

            return [.. intersection];
        }

        private static List<int> GetDividers(int number)
        {
            List<int> dividers = [];

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    dividers.Add(i);
                }
            }

            return dividers;
        }
    }
}
