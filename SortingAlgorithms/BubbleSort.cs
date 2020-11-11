namespace Algorithms.SortingAlgorithms
{
	/// <summary>
	/// From Wikipedia (https://en.wikipedia.org/wiki/Bubble_sort):
	/// Bubble sort, sometimes referred to as sinking sort, is a simple sorting algorithm that 
	/// repeatedly steps through the list, compares adjacent elements and swaps them if they are 
	/// in the wrong order. The pass through the list is repeated until the list is sorted. 
	/// The algorithm, which is a comparison sort, is named for the way smaller or larger elements 
	/// "bubble" to the top of the list.
	/// Bubble sort has a worst-case and average complexity of О(n2), where n is the number of 
	/// items being sorted. Most practical sorting algorithms have substantially better worst-case 
	/// or average complexity, often O(n log n). Even other О(n2) sorting algorithms, such as 
	/// insertion sort, generally run faster than bubble sort, and are no more complex. Therefore, 
	/// bubble sort is not a practical sorting algorithm.
	///
	/// Bubble sort should be avoided in the case of large collections. It will not be efficient in the case of a reverse-ordered collection.
	/// </summary>
    public class BubbleSort
    {
        public int[] Sort(int[] array)
        {
            // Maximum number of iterations is n*n
        	for(int n=0; n<array.Length*array.Length; n++)
        	{
        		// Runs over thr array and perform swaps
        		for(int i=0; i<array.Length-1; i++)
        		{
        			if(array[i] == array[i+1]) continue;
        			if(array[i] < array[i+1]) PerformSwap(i, i+1, array);
        			if(FinishedSorting(array)) return array;
        		}
        	}
        	return array;
        }

        private void PerformSwap(int pos1, int pos2, int[] array)
        {
        	var item1 = array[pos1];
        	var item2 = array[pos2];
        	array[pos1] = item2;
        	array[pos2] = item1;
        }
        
        private bool FinishedSorting(int[] array)
        {
        	for(int i=0; i<array.Length-1; i++)
        	{
        	    if(array[i] >= array[i+1]) continue;
        	    else return false;
        	}
        	return true;
        }
    }
}