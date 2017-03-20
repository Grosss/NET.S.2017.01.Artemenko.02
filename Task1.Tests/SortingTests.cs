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

            MergeSort.Sort(actualArray);
            for (int i = 0; i < actualArray.Length; i++)
            {
                Console.WriteLine(actualArray[i]);
            }

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [TestCase(null)]
        public void MergeSort_PassedNullReference_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => MergeSort.Sort(array));
        }

        [TestCase(new int[] { })]
        public void MergeSort_PassedEmptyArray_ThrowsArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => MergeSort.Sort(array));
        }
    }
}
