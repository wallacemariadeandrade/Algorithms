using System.Collections.Generic;
using System.Linq;

namespace Algorithms.SortingAlgorithms.BubbleSort
{
    public class GenericBubbleSort : ISorter
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> set, IComparer<T> comparer, Order order = Order.Descending)
        {
            var innerArray = set.ToArray();
            var swapped = false;
            for (int n = 0; n < innerArray.Length*innerArray.Length; n++)
            {
                // Runs over thr array and perform swaps
        		for(int i=0; i<innerArray.Length-1; i++)
        		{
                    if(comparer.Compare(innerArray[i], innerArray[i+1]) == 0) continue;
                    if(comparer.Compare(innerArray[i], innerArray[i+1]) < 0)
                    {
                        PerformSwap(i, i+1, innerArray);
                        swapped = true;
                    }  			
        		}
                if(!swapped) return order == Order.Descending ? innerArray : innerArray.Reverse();
                swapped = false;
            }
            return order == Order.Descending ? innerArray : innerArray.Reverse();
        }

        private void PerformSwap<T>(int pos1, int pos2, T[] array)
        {
            var item1 = array[pos1];
        	var item2 = array[pos2];
        	array[pos1] = item2;
        	array[pos2] = item1;
        }
    }
}