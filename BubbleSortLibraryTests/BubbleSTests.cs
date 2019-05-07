using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleSortLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortLibrary.Tests
{
    [TestClass()]
    public class BubbleSTests    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            int[] massive = { 5, 2, 4, 1, 3 };
            int[] expected = { 1, 2, 3, 4, 5 };
            var actual = BubbleS.BubbleSort(massive);
            CollectionAssert.AreEqual(actual,expected);
        }
    }
}