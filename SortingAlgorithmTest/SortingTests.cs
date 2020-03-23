using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3.SortingAlgorithms;


namespace SortingAlgorithmTest
{
    [TestClass]
    public class SortingTests
    {
        
        [TestMethod]
        public void TestMergeSort()
        {
            MergeSort mergeSort = new MergeSort();
            mergeSort.sortData.PrintData();
            mergeSort.SortNumbers(mergeSort.sortData.data);
            mergeSort.sortData.PrintData();
        }

        [TestMethod]
        public void TestQuickSort()
        {
   
        }

        [TestMethod]
        public void TestSelectionSort()
        {

        }

        [TestMethod]
        public void TestBubbleSort()
        {

        }
    }
}
