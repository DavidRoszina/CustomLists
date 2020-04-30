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
        public void AddThreePositiveValues_CheckIndexOne()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 20;
            int itemToAdd3 = 30;
            int expected = 20;
            int actual;


            //act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            actual = testList[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
        // what happens to the last-added item?

        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?
        [TestMethod]
        public void AddFivePositiveValues_CheckCount()
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
        [TestMethod]
        public void IncreaseArrayCapacityTest()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 8;
            int actual;

            //act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            actual = testList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddFourPositiveValuesSubtrackOne_CheckCount()
        {
            //arange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 3;
            int actual;
            //act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Remove(itemToAdd);
            actual = testList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddFourPositiveValuesSubtract2nd_CheckCount()
        {
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 20;
            int itemToAdd3 = 30;
            int itemToAdd4 = 40;
            int expected = 3;
            int actual;
            //act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            testList.Remove(itemToAdd2);
            actual = testList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFourPositiveValuesSubtract2nd_Check3rdIndex()
        {
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 20;
            int itemToAdd3 = 30;
            int itemToAdd4 = 40;
            int expected = 40;
            int actual;
            //act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            testList.Remove(itemToAdd2);
            actual = (testList[2] = 40);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddThreeRemove2ndAddThreeRemove4th_CheckAllValues()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 10;
            int itemToAdd2 = 20;
            int itemToAdd3 = 30;
            int itemToAdd4 = 40;
            int itemToAdd5 = 50;
            int itemToAdd6 = 60;
            int expected1 = 10;
            int expected2 = 30;
            int expected3 = 40;
            int expected4 = 60;
            int actual1;
            int actual2;
            int actual3;
            int actual4;
            //act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Remove(itemToAdd2);
            testList.Add(itemToAdd4);
            testList.Add(itemToAdd5);
            testList.Add(itemToAdd6);
            testList.Remove(itemToAdd5);
            actual1 = testList[0];
            actual2 = testList[1];
            actual3 = testList[2];
            actual4 = testList[4];
            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }
    }
}
