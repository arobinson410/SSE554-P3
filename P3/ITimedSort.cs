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
        /// Starts the sorting timer.
        /// </summary>
        /// <param name="timerType"></param>
        /// <param name="timer"></param>
        void StartTimer(SortableData.TimerType timerType, Timer timer);

        /// <summary>
        /// Ends the sorting timer.
        /// </summary>
        /// <param name="timer"></param>
        void EndTimer(Timer timer);

    }
}
