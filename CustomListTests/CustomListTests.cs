using System;
using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
{
    [TestClass]
    public class CustomListTests
    {
        // unit test for adding multiple items to check position of last item
        // unit test for adding multiple items to check Count property
        // unit test for adding number of items beyond 'Capacity' but it still adds

        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomLists<int> testList = new CustomLists<int>();
            int expected = 12;
            int actual;

            // act
            testList.Add(12);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_CountIncrements()
        {
            // arrange
            CustomLists<int> testList = new CustomLists<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(234);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_AddItemsToList_CountIncrements()
        {
            //arange
            CustomLists<int> testList = new CustomLists<int>();
            int expected = 4;
            int actual;

            //act
            testList.Add(2222);
            testList.Add(2222);
            testList.Add(2222);
            testList.Add(2222);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyList()
        {
            // arrange
            CustomLists<int> testList = new CustomLists<int>();
            int expected = 12;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(10);
            testList.Add(12);
            actual = testList[3];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Add_AddItemsToList_Count()
        {
            //arange
            CustomLists<int> testList = new CustomLists<int>();
            int expected = 6;
            int actual;

            //act
            testList.Add(2222);
            testList.Add(2222);
            testList.Add(2222);
            testList.Add(2222);
            testList.Add(2222);
            testList.Add(2222);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyLists()
        {
            // arrange
            CustomLists<int> testList = new CustomLists<int>();
            int expected = 18;
            int actual;

            // act
            testList.Add(6);
            testList.Add(8);
            testList.Add(10);
            testList.Add(12);
            testList.Add(14);
            testList.Add(16);
            testList.Add(18);
            actual = testList[6];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void CapacityOfList()
        {
            //arange
            CustomLists<int> testList = new CustomLists<int>();
            int expected = 8;
            int actual;

            //act
            testList.Add(23);
            testList.Add(332);
            testList.Add(43);
            testList.Add(32);
            testList.Add(52);
            testList.Add(63);
            testList.Add(82);
            testList.Add(97);
            actual = testList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
