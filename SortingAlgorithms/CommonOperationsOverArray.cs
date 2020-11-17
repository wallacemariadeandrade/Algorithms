namespace Algorithms
{
    public static class CommonOperationsOverArray
    {
        public static void PerformSwapBetween<T>(int pos1, int pos2, T[] array)
        {
            var item1 = array[pos1];
            var item2 = array[pos2];
            array[pos1] = item2;
            array[pos2] = item1;
        }
    }
}