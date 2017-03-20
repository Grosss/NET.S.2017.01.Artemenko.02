using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests
{
    [TestFixture]
    public class SortingTests
    {
        [Test]
        public void MergeSort_PassedArray_ExpectedSortedArray()
        {
            int[] actualArray = { 4, 2, 13, 34, 18, 65, 83, 7, 52, 39 };
            int[] expectedArray = { 4, 2, 13, 34, 18, 65, 83, 7, 52, 39 };            
            Array.Sort(expectedArray);

            Sorting.MergeSort(actualArray);            

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestCase(null)]
        public void MergeSort_PassedNullReference_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => Sorting.MergeSort(array));
        }

        [TestCase(new int[] { })]
        public void MergeSort_PassedEmptyArray_ThrowsArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Sorting.MergeSort(array));
        }
    }
}
