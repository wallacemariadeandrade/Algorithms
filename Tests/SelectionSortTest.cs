using System.Linq;
using Algorithms.SortingAlgorithms.SelectionSort;

namespace Xunit
{
    public class SelectionSortTests
    {
        [Fact]
        public void SortIntArray()
        {
            var intArray = ArraysGenerator.RandomIntArray(20, 0, 100);
            var sorter = new SelectionSort();
            var ascendingResult = sorter.Sort(intArray);
            Assert.Equal(intArray.OrderBy(x => x), ascendingResult);
        }
    }
}