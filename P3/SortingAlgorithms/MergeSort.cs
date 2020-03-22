using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace P3.SortingAlgorithms
{
    public class MergeSort : ITimedSort
    {

        public SortableData sortData;

        public MergeSort()
        {
            sortData = new SortableData(100);
            sortData.FillList();
        }

        public void Run()
        {

        }

        private void EndTimer(Timer timer)
        {
            throw new NotImplementedException();
        }

        private void SortNumbers(List<int> unsortedList, List<int> sortedList)
        {
            
        }

        private void StartTimer(SortableData.TimerType timerType, Timer timer)
        {
            throw new NotImplementedException();
        }
    }
}
