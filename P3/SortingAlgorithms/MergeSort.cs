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
            sortData = new SortableData(100000);
            sortData.FillList();
        }

        public async Task<List<int>> SortNumbersAsync(List<int> unsortedList)
        {
            if (unsortedList.Count < 2)
                return unsortedList;

            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            int middle = unsortedList.Count / 2;

            for (int i = 0; i < middle; i++)
                Left.Add(unsortedList[i]);
            for (int i = middle; i < unsortedList.Count; i++)
                Right.Add(unsortedList[i]);

            Left =  SortNumbers(Left);
            Right = SortNumbers(Right);
            return await Merge(Left, Right);
        }

        public void EndTimer(Timer timer)
        {
            throw new NotImplementedException();
        }

        public List<int> SortNumbers(List<int> unsortedList)
        {
            if (unsortedList.Count < 2)
                return unsortedList;

            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            int middle = unsortedList.Count / 2;

            for (int i = 0; i < middle; i++)
                Left.Add(unsortedList[i]);
            for (int i = middle; i < unsortedList.Count; i++)
                Right.Add(unsortedList[i]);

            Left = SortNumbers(Left);
            Right = SortNumbers(Right);
            return Merge(Left, Right).Result;
        }

        private async Task<List<int>> Merge(List<int> Left, List<int> Right)
        {
            List<int> sortedResult = new List<int>();

            while(Left.Count > 0 || Right.Count > 0)
            {
                if(Left.Count > 0 && Right.Count > 0)
                {
                    if(Left[0] <= Right[0])
                    {
                        sortedResult.Add(Left[0]);
                        Left.Remove(Left[0]);
                    }
                    else
                    {
                        sortedResult.Add(Right[0]);
                        Right.Remove(Right[0]);
                    }
                }
                else if (Left.Count >0)
                {
                    sortedResult.Add(Left[0]);
                    Left.Remove(Left[0]);
                }
                else if (Right.Count > 0)
                {
                    sortedResult.Add(Right[0]);
                    Right.Remove(Right[0]);
                }
            }
            return sortedResult;
        }

        public void StartTimer(SortableData.TimerType timerType, Timer timer)
        {
            throw new NotImplementedException();
        }
    }
}
