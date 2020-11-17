using static Algorithms.CommonOperationsOverArray;

namespace Algorithms.SortingAlgorithms.SelectionSort
{
    public class SelectionSort
    {
        public int[] Sort(int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                var indexOfMinor = FindIndexOfMinorNumberIn(array, i);          
                PerformSwapBetween<int>(i, indexOfMinor, array);
            }
            return array;
        }

        private int FindIndexOfMinorNumberIn(int[] array, int startPosition)
        {
            int indexOfMinor = startPosition;
            // Suppose the minor number is the first in array
            var minorNumber = array[startPosition];
            // Loops and find the min value
            for(int j=startPosition; j<array.Length; j++)
            {
                var actualNumber = array[j];
                if(actualNumber < minorNumber)
                {
                    minorNumber = actualNumber;
                    indexOfMinor = j;
                }
            }
            return indexOfMinor;
        }
    }
}