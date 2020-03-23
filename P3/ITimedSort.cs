using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace P3
{
    interface ITimedSort
    {

        /// <summary>
        /// Starts the sorting process.
        /// </summary>
        /// <param name="unsortedList"></param>
        /// <param name="sortedList"></param>
        List<int> SortNumbers(List<int> unsortedList);

        /// <summary>
        /// Asynchronous version of Number Sorting.
        /// </summary>
        /// <param name="unsortedList"></param>
        /// <returns></returns>
        Task<List<int>> SortNumbersAsync(List<int> unsortedList);
    }
}
