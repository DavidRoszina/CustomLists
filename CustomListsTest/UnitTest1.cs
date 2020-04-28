using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLists;

namespace CustomListsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        [TestMethod]
        public void AddToExistingArrayTest()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int expected1 = 20;
            int expected2 = 30;
            int actual;
            int actual1;
            int actual2;

            //act
            testList.Add(itemToAdd); 
            testList.Add(itemToAdd);
            //Above assumes 2 items have already been in the list
            testList.Add(itemToAdd * 2);
            testList.Add(itemToAdd * 3);
            actual = testList[0, 1];
            actual1 = testList[2];
            actual2 = testList[3];

            //assert
            Assert.IsTrue(expected == actual && expected1 == actual1 && expected2 == actual2);
        }
        // what happens to the last-added item?

        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?
        [TestMethod]
        public void IncreaseArrayCapacityTest()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 5;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}
