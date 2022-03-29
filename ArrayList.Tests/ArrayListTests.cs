using NUnit.Framework;
using System.Collections;
using MyLists.Tests.ArrayListTestsSources;
using MyLists.Tests.ArrayListNegativeTestSources;
using System;

namespace MyLists.Tests
{
    public class Tests
    {
        [TestCaseSource(typeof(AddLastOneTestSource))]
        public void AddLastOneTest(int value, ArrayList list, ArrayList expectedList)
        {

            ArrayList actualList = list;
            actualList.AddLastOne(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddFirstOneTestSource))]
        public void AddFirstOneTest(int value, ArrayList list, ArrayList expectedList)
        {

            ArrayList actualList = list;
            actualList.AddFirstOne(value);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int value, int index, ArrayList list, ArrayList expectedList)
        {

            ArrayList actualList = list;
            actualList.AddByIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexNegativeTestSource_WhenIndexIsOutOfLength_ShouldThrowException))]
        public void AddByIndexTest_WhenIndexIsOutOfLength_ShouldThrowException(int value, int index, ArrayList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AddByIndex(index, value));
        }

        [TestCaseSource(typeof(DeleteOneFromEndTestSource))]
        public void DeleteOneFromEndTest
            (ArrayList list, ArrayList expectedList)
        {

            ArrayList actualList = list;
            actualList.DeleteOneFromEnd();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteOneFromEndNegativeTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void DeleteOneFromEndTest_WhenLengthEqualZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteOneFromEnd());
        }

        [TestCaseSource(typeof(DeleteOneFromBeginningTestSource))]
        public void DeleteOneFromBeginningTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteOneFromBeginning();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteOneFromBeginningNegativeTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void DeleteOneFromBeginningTest_WhenLengthEqualZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteOneFromBeginning());
        }

        [TestCaseSource(typeof(DeleteOneByIndexTestSource))]
        public void DeleteOneByIndexTest(int index, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteOneByIndex(index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteOneByIndexNegativeTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void DeleteOneByIndexTest_WhenLengthEqualZero_ShouldThrowException(int index, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteOneByIndex(index));
        }

        [TestCaseSource(typeof(DeleteOneByIndexNegativeTestSource_WhenIndexIsOutOfLength_ShouldThrowException))]
        public void DeleteOneByIndexTest_WhenIndexIsOutOfLength_ShouldThrowException(int index, ArrayList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteOneByIndex(index));
        }


        [TestCaseSource(typeof(DeleteNElementsFromEndTestSource))]
        public void DeleteNElementsFromEndTest(int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteNElementsFromEnd(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNElementsFromEndNegativeTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void DeleteNElementsFromEndNegativeTestSource_WhenLengthEqualZero_ShouldThrowException(int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteNElementsFromEnd(value));
        }

        [TestCaseSource(typeof(DeleteNElementsFromBeginningTestSource))]
        public void DeleteNElementsFromBeginningTest(int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteNElementsFromBeginning(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNElementsFromBeginningNegativeTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void DeleteNElementsFromBeginningNegativeTestSource_WhenLengthEqualZero_ShouldThrowException(int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteNElementsFromBeginning(value));
        }

        [TestCaseSource(typeof(DeleteWithFewIndexTestSource))]
        public void DeleteWithFewIndexTest(int elements, int index, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteWithFewIndex(elements, index);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(DeleteWithFewIndexTestSource_WhenIndexIsOutOfLength_ShouldThrowException))]
        public void DeleteWithFewIndexTest_WhenIndexIsOutOfLength_ShouldThrowException(int index, ArrayList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteOneByIndex(index));
        }

        [TestCaseSource(typeof(FindFirstIndexByValueTestSource))]
        public void FindFirstIndexByValueTest(int expected, int value, ArrayList list)
        {
            int actual = list.FindFirstIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindFirstIndexByValueTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void FindFirstIndexByValueTest_WhenLengthEqualZero_ShouldThrowException(int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindFirstIndexByValue(value));

        }


        [TestCaseSource(typeof(GetLengthTestSource))]
        public void GetLengthTest(int expected, ArrayList list)
        {
            int actual = list.GetLength(list.Length);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(AccessByIndexTestSource))]
        public void AccessByIndexTest(int expected, int index, ArrayList list)
        {
            int actual = list.GetLength(list.Length);
            Assert.AreEqual(expected, index, actual);
        }

        [TestCaseSource(typeof(AccessByIndexTestSource_WhenIndexIsOutOfLength_ShouldThrowException))]
        public void AccessByIndexTest_WhenIndexIsOutOfLength_ShouldThrowException(int index, ArrayList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AccessByIndex(index));
        }


        [TestCaseSource(typeof(EditValueByIndexTestSource))]
        public void EditValueByIndexTest(int index, int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.EditValueByIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(EditValueByIndexTestSource_WhenIndexIsOutOfLength_ShouldThrowException))]
        public void EditValueByIndexTest_WhenIndexIsOutOfLength_ShouldThrowException(int index, int value, ArrayList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.EditValueByIndex(index, value));
        }

        [TestCaseSource(typeof(EditValueByIndexTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void EditValueByIndexTest_WhenLengthEqualZero_ShouldThrowException(int index, int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.EditValueByIndex(index, value));
        }


        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.Reverse();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(ArrayList list, int expected)
        {
            int actual = list.FindMax();
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(FindMaxTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void FindMaxTest_WhenLengthEqualZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindMax());
        }

        [TestCaseSource(typeof(FindIndexOfMinTestSource))]
        public void FindIndexOfMinTest(ArrayList list, int expected)
        {
            int actual = list.FindIndexOfMin();
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(FindIndexOfMinTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void FindIndexOfMinTest_WhenLengthEqualZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMin());
        }

        [TestCaseSource(typeof(FindIndexOfMaxTestSource))]
        public void FindIndexOfMaxTest(ArrayList list, int expected)
        {
            int actual = list.FindIndexOfMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMaxTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void FindIndexOfMaxTest_WhenLengthEqualZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMax());
        }

        [TestCaseSource(typeof(FindMinTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void FindMinTest_WhenLengthEqualZero_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindMin());
        }

        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(ArrayList list, int expected)
        {
            int actual = list.FindMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SortAscendingTestSource))]
        public void SortAscendingTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.SortAscending();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DescendingSortTestSource))]
        public void DescendingSortTest(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DescendingSort();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstByValueGetIndexTestSource))]
        public void DeleteFirstByValueGetIndexTest(int value, int index, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            int expectedIndex = actualList.DeleteFirstByValueGetIndex(value);
            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expectedIndex, index);
        }

        [TestCaseSource(typeof(DeleteFirstByValueGetIndexTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void DeleteFirstByValueGetIndexTest_WhenLengthEqualZero_ShouldThrowException(int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFirstByValueGetIndex(value));
        }

        [TestCaseSource(typeof(DeleteAllByValueGetNumberTestSource))]
        public void DeleteAllByValueGetNumberTest(int value, int number, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            int expectedNumber = actualList.DeleteAllByValueGetNumber(value);
            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expectedNumber, number);
        }

        [TestCaseSource(typeof(DeleteAllByValueGetNumberTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void DeleteAllByValueGetNumberTest_WhenLengthEqualZero_ShouldThrowException(int value, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteAllByValueGetNumber(value));
        }

        [TestCaseSource(typeof(AddListToEndTestSource))]
        public void AddListToEndTest(ArrayList list, ArrayList actualList, ArrayList expectedList)
        {
            actualList.AddListToEnd(list);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToEndNegativeTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void AddListToEndNegativeTest_WhenLengthEqualZero_ShouldThrowException(ArrayList list, ArrayList actualList)
        {
            Assert.Throws<Exception>(() => actualList.AddListToEnd(list));
        }

        [TestCaseSource(typeof(AddListToBeginningTestSource))]
        public void AddListToBeginningTest(ArrayList list, ArrayList actualList, ArrayList expectedList)
        {
            actualList.AddListToBeginning(list);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToBeginningNegativeTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void AddListToBeginningNegativeTest_WhenLengthEqualZero_ShouldThrowException(ArrayList list, ArrayList actualList)
        {
            Assert.Throws<Exception>(() => actualList.AddListToBeginning(list));
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(int index, ArrayList list, ArrayList actualList, ArrayList expectedList)
        {
            actualList.AddListByIndex(list, index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndexNegativeTestSource_WhenLengthEqualZero_ShouldThrowException))]
        public void AddListByIndexNegativeTest_WhenLengthEqualZero_ShouldThrowException(int index, ArrayList list, ArrayList actualList)
        {
            Assert.Throws<Exception>(() => actualList.AddListByIndex(list, index));
        }
        [TestCaseSource(typeof(AddListByIndexNegativeTestSource_WhenIndexIsOutOfLength_ShouldThrowException))]
        public void AddListByIndexNegativeTest_WhenIndexIsOutOfLength_ShouldThrowException(int index, ArrayList list, ArrayList actualList)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actualList.AddListByIndex(list, index));
        }

    }
}
