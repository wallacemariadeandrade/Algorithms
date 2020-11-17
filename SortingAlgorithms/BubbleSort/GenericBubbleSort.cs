using System.Collections.Generic;
using System.Linq;
using static Algorithms.CommonOperationsOverArray;

namespace Algorithms.SortingAlgorithms.BubbleSort
{
    public class GenericBubbleSort : ISorter
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> set, IComparer<T> comparer, Order order = Order.Ascending)
        {
            var innerArray = set.ToArray();
            var swapped = false;
            for (int n = 0; n < innerArray.Length*innerArray.Length; n++)
            {
                // Runs over thr array and perform swaps
        		for(int i=0; i<innerArray.Length-1; i++)
        		{
                    if(comparer.Compare(innerArray[i], innerArray[i+1]) == 0) continue;
                    if(comparer.Compare(innerArray[i], innerArray[i+1]) > 0)
                    {
                        PerformSwapBetween<T>(i, i+1, innerArray);
                        swapped = true;
                    }  			
        		}
                if(!swapped) return order == Order.Ascending ? innerArray : innerArray.Reverse();
                swapped = false;
            }
            return order == Order.Ascending ? innerArray : innerArray.Reverse();
        }
    }
}