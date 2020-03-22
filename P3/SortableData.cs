using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class SortableData
    {
        const int ListSize = 100;
        public List<int> data;

        Random rNumGen = new Random();

        // Randomly generate sortable list of data
        public SortableData()
        {
            data = new List<int>(ListSize);
        }

        
        public SortableData(int _size)
        {
            data = new List<int>(_size);
        }

        public void FillList()
        {
            for (int i = 0; i < data.Capacity; i++)
            {
                data.Add(rNumGen.Next(0, ListSize));
            }
        }

        public void PrintData()
        {
            foreach(int i in data)
            {
                Console.Write(i.ToString() + ',');
            }
            Console.WriteLine();
        }
    }
}
