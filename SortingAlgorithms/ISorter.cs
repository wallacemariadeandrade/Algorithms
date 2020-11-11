using System.Collections.Generic;

namespace Algorithms.SortingAlgorithms
{
    public interface ISorter
    {
        IEnumerable<T> Sort<T>(IEnumerable<T> set, IComparer<T> comparer, Order order = Order.Descending);
    }
}