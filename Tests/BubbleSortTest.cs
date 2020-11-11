using System.Collections.Generic;
using Algorithms.SortingAlgorithms;

namespace Xunit
{
    public class BubbleSortTest
    {
        [Fact]
        public void SortIntArray()
        {
            var bubbleSort = new BubbleSort();
            var intArray = new int[] { 2, 1, 1, 10, 25, 43 };
            var sortedArray = bubbleSort.Sort(intArray);
            Assert.Equal(new int[]{ 43, 25, 10, 2, 1, 1 }, sortedArray);
        }     

        [Fact]
        public void SortIntArrayWithGenericApproach()
        {
            var bubbleSort = new GenericBubbleSort();
            var intArray = new int[] { 2, 1, 1, 10, 25, 43 };
            var ascendingSortedArray = bubbleSort.Sort<int>(intArray, new IntOrCharComparer(), Order.Ascending);
            var descendingSortedArray = bubbleSort.Sort<int>(intArray, new IntOrCharComparer(), Order.Descending);
            Assert.Equal(new int[]{ 1, 1, 2, 10, 25, 43 }, ascendingSortedArray);
            Assert.Equal(new int[]{ 43, 25, 10, 2, 1, 1 }, descendingSortedArray);
        }  

        [Fact]
        public void SortCharArrayWithGenericApproach()
        {
            var bubbleSort = new GenericBubbleSort();
            var charArray = new char[] { 'a', 'f', 'z', 'a', 'b', 'u', 'w' };
            var ascendingSortedArray = bubbleSort.Sort<char>(charArray, new IntOrCharComparer(), Order.Ascending);
            var descendingSortedArray = bubbleSort.Sort<char>(charArray, new IntOrCharComparer(), Order.Descending);
            Assert.Equal(new char[]{ 'a', 'a', 'b', 'f', 'u', 'w', 'z' }, ascendingSortedArray);
            Assert.Equal(new char[]{ 'z', 'w', 'u', 'f', 'b', 'a', 'a' }, descendingSortedArray);
        }
    }

    public class IntOrCharComparer : IComparer<int>, IComparer<char>
    {
        public int Compare(int x, int y)
        {
            if(x == y) return 0;
            if(x > y) return 1;
            return -1;
        }

        public int Compare(char x, char y) => Compare((int)x, (int)y);
    }
}