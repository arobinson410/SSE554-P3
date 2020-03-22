using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class SortAlgo
    {

        public SortableData sortData;

        public SortAlgo()
        {
            sortData = new SortableData(100);
            sortData.FillList();
            sortData.PrintData();
            MergeSortSync(sortData.data);
            sortData.PrintData();
            Console.ReadLine();
        }
        public void MergeSortSync(List<int> data)
        {
            List<int> tempData = data;
            SplitMerge(tempData, 0, tempData.Count, data);
        }
        
        public void SplitMerge(List<int> tempData, int start, int end, List<int> data)
        {
            // If run size = 1
            if (end - start < 2)
                return;
            int middle = (end + start) / 2;
            SplitMerge(data, start, middle, tempData);
            SplitMerge(data, middle, end, tempData);
            Merge(tempData, start, middle, end, data);
        }

        public void Merge(List<int> data,int start, int middle, int end, List<int> tempData)
        {
            int i = start;
            int j = middle;

            for(int k = i; k < end; k++)
            {
                if(i < middle &&(j>=end||data[i] <= data[j]))
                {
                    tempData[k] = data[i];
                    i++;
                }
                else
                {
                    tempData[k] = data[j];
                    j++;
                }
            }
        }


        public async void MergeSortAsync(List<int> data)
        {

        }
    }
}
