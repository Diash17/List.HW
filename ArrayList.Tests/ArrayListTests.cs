using NUnit.Framework;
using System.Collections;
using MyLists.Tests.ArrayListTestsSources;

namespace MyLists.Tests
{
    public class Tests
    {
        [TestCaseSource(typeof(AddLastOneTestSource))]
        public void AddLastOne(int value, ArrayList list, ArrayList expectedList)
        {

            ArrayList actualList = list;
            actualList.AddLastOne(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddFirstOneTestSource))]
        public void AddFirstOne(int value, ArrayList list, ArrayList expectedList)
        {

            ArrayList actualList = list;
            actualList.AddFirstOne(value);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndex(int value, int index, ArrayList list, ArrayList expectedList)
        {

            ArrayList actualList = list;
            actualList.AddByIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(DeleteOneFromEndTestSource))]
        public void DeleteOneFromEnd(ArrayList list, ArrayList expectedList)
        {

            ArrayList actualList = list;
            actualList.DeleteOneFromEnd();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteOneFromBeginningTestSource))]
        public void DeleteOneFromBeginning(ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteOneFromBeginning();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteOneByIndexTestSource))]
        public void DeleteOneByIndex(int index, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteOneByIndex(index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNElementsFromEndTestSource))]
        public void DeleteNElementsFromEnd(int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteNElementsFromEnd(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNElementsFromBeginningTestSource))]
        public void DeleteNElementsFromBeginning(int value, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteNElementsFromBeginning(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteWithFewIndexTestSource))]
        public void DeleteWithFewIndex(int elements, int index, ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.DeleteWithFewIndex(elements, index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindFirstIndexByValueTestSource))]
        public void FindFirstIndexByValue(int expected, int value,ArrayList list)
        {
            int actual = list.FindFirstIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCaseSource(typeof(GetLengthTestSource))]
        public void GetLength(int expected,ArrayList list)
        {
            int actual = list.GetLength(list.Length);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(AccessByIndexTestSource))]
        public void AccessByIndex(int expected,int index,ArrayList list)
        {
            int actual = list.GetLength(list.Length);
            Assert.AreEqual(expected,index, actual);
        }
        
        [TestCaseSource(typeof(EditValueByIndexTestSource))]
        public void EditValueByIndex(int index, int value,ArrayList list, ArrayList expectedList)
        {
            ArrayList actualList = list;
            actualList.EditValueByIndex(index,value);
            Assert.AreEqual(expectedList, actualList);
        }

    }
}
