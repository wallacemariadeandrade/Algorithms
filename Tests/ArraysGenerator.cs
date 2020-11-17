using System;
using System.Linq;

namespace Xunit
{
    public static class ArraysGenerator
    {
        public static int[] RandomIntArray(int length, int minValue, int maxValue)
        {
            var generator = new Random();
            return Enumerable.Repeat(0, length)
                    .Select(number => generator.Next(minValue, maxValue))
                    .ToArray();
        }
    }
}