using System.Linq;
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
            Assert.Equal(intArray.OrderBy(x => x).Select(x => x), sortedArray.Reverse());
        }       
    }
}