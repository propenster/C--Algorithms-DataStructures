using System.Collections.Generic;
using Algorithms.Common;


namespace Sorting 

{

public static class BubbleSort
    {
        public static void BubbleSort<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            collection.BubbleSortAscending(comparer);
        }

        //Now sort ascending
        public static void BubbleSortAscending<T>(this IList<T>collection, Comparer<T> comparer)
        {
            for (int i=0; i<collection.Count; i++)
            {
                for(int index = 0; index<collection.Count - i -1; index++)
                {
                    if(comparer.Compare(collection[index], collection[index +1]) > 0)
                    {
                        collection.Swap(index, index+1);
                    }
                }
            }
        }

        //Now sort descending...
        public static void BubbleSorDescending<T>(this IList<T> collection, Comparer<T> comparer)
        {
            for(int i = 0; i < collection.Count -1; i++)
            {
                for(int index = 0; index<collection.Count -i; index++)
                {
                    if(comparer.Compare(collection[index], collection[index-1]) > 0)
                    {
                        collection.Swap(index -1, index);
                    }
                }
            }
        }
    }

}