using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using P3.SortingAlgorithms;

namespace P3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            MergeSort mergeSort = new MergeSort();

            long tickStart = DateTime.Now.Ticks;
            Console.WriteLine();
            mergeSort.sortData.data = mergeSort.SortNumbers(mergeSort.sortData.data);
            long ticksEnd = DateTime.Now.Ticks;
            Console.WriteLine(ticksEnd - tickStart);

            Console.WriteLine("------------");

            tickStart = DateTime.Now.Ticks;
            MergeSort asyncMerge = new MergeSort();
            Console.WriteLine();
            asyncMerge.sortData.data = Task.Run(() => asyncMerge.SortNumbersAsync(asyncMerge.sortData.data)).Result;
            ticksEnd = DateTime.Now.Ticks;
            Console.WriteLine(ticksEnd - tickStart);
            Console.ReadLine();
        }

        static double PercentChange(long startTick, long endTick)
        {
            double start = Convert.ToDouble(startTick);
            double end = Convert.ToDouble(endTick);

            return end / start * 100;
        }
    }
}
