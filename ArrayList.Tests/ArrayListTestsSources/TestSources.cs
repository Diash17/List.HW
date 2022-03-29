using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLists.Tests.ArrayListTestsSources
{
    internal class AddLastOneTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 6;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            yield return new object[] { value, list, expectedList };


            value = 0;
            list = new ArrayList(new int[] { 0, 0, 0, 0 });
            expectedList = new ArrayList(new int[] { 0, 0, 0, 0, 0 });
            yield return new object[] { value, list, expectedList };
        }
    }
    internal class AddFirstOneTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 0;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 0, 1, 2, 3, 4, 5 });
            yield return new object[] { value, list, expectedList };


            value = -1;
            list = new ArrayList(new int[] { 0, 0, 0, 0 });
            expectedList = new ArrayList(new int[] { -1, 0, 0, 0, 0 });
            yield return new object[] { value, list, expectedList };
        }
    }
    internal class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            int value = 20;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 20, 3, 4, 5 });
            yield return new object[] { value, index, list, expectedList };


            index = 3;
            value = -1;
            list = new ArrayList(new int[] { 0, 0, 0, 0 });
            expectedList = new ArrayList(new int[] { 0, 0, 0, -1, 0 });
            yield return new object[] { value, index, list, expectedList };
        }
    }
    internal class DeleteOneFromEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4 });
            yield return new object[] { list, expectedList };



            list = new ArrayList(new int[] { 0, 0, 0, 0 });
            expectedList = new ArrayList(new int[] { 0, 0, 0 });
            yield return new object[] { list, expectedList };
        }
    }
    internal class DeleteOneFromBeginningTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 2, 3, 4, 5 });
            yield return new object[] { list, expectedList };



            list = new ArrayList(new int[] { 0, 0, 0, 0 });
            expectedList = new ArrayList(new int[] { 0, 0, 0 });
            yield return new object[] { list, expectedList };
        }
    }

    internal class DeleteOneByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int index = 2;
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 4, 5 });
            yield return new object[] { index, list, expectedList };



            list = new ArrayList(new int[] { -2, -1, 0, 5, 9 });
            index = 3;
            expectedList = new ArrayList(new int[] { -2, -1, 0, 9 });
            yield return new object[] { index, list, expectedList };
        }
    }
    internal class DeleteNElementsFromEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { 1, 2, 2, 2 });
            int value = 2;
            ArrayList expectedList = new ArrayList(new int[] { 1, 2 });
            yield return new object[] { value, list, expectedList };

            list = new ArrayList(new int[] { -2, -1, 0, 5, 9 });
            value = 3;
            expectedList = new ArrayList(new int[] { -2, -1 });
            yield return new object[] { value, list, expectedList };
        }
    }
    internal class DeleteNElementsFromBeginningTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { 1, 2, 2, 2 });
            int value = 2;
            ArrayList expectedList = new ArrayList(new int[] { 2, 2 });
            yield return new object[] { value, list, expectedList };

            list = new ArrayList(new int[] { -2, -1, 0, 5, 9 });
            value = 3;
            expectedList = new ArrayList(new int[] { 5, 9 });
            yield return new object[] { value, list, expectedList };
        }
    }
    internal class DeleteWithFewIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 2, 2 });
            int index = 2;
            int elements = 0;
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 2, 2 });
            yield return new object[] { elements, index, list, expectedList };

            list = new ArrayList(new int[] { -2, -1, 0, 5, 9 });
            index = 1;
            elements = 3;
            expectedList = new ArrayList(new int[] { -2, 9 });
            yield return new object[] { elements, index, list, expectedList };
        }
    }
    internal class FindFirstIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 2, 2 });
            int expected = 1;
            int value = 2;

            yield return new object[] { expected, value, list };

            list = new ArrayList(new int[] { -2, -1, 0, 5, 9 });
            expected = 2;
            value = 0;

            yield return new object[] { expected, value, list };
        }
    }
    internal class GetLengthTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 2, 2 });
            int expected = 4;
            yield return new object[] { expected, list };

            list = new ArrayList(new int[] { -2, -1, 0, 5, 9 });
            expected = 5;
            yield return new object[] { expected, list };

            list = new ArrayList(new int[] { -2, -1, 0, 5, 9 });
            expected = 5;
            yield return new object[] { expected, list };
        }
    }
    internal class AccessByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4 });
            int expected = 3;
            int index = 2;
            yield return new object[] { expected, index, list };

            list = new ArrayList(new int[] { -2, -1, 0, 5, 9 });
            expected = -2;
            index = 0;
            yield return new object[] { expected, index, list };

            list = new ArrayList(new int[] { 44, 55, 66, 77, 0 });
            expected = 0;
            index = 4;
            yield return new object[] { expected, index, list };
        }
    }
    internal class EditValueByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = 2;
            int value = 0;
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 0, 4, 5, 6 });
            yield return new object[] { index, value, list, expectedList };

            list = new ArrayList(new int[] { 0, -1, 0, 5, 9 });
            index = 0;
            value = -33;
            expectedList = new ArrayList(new int[] { -33, -1, 0, 5, 9 });
            yield return new object[] { index, value, list, expectedList };
        }
    }
    internal class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            ArrayList expectedList = new ArrayList(new int[] { 6, 5, 4, 3, 2, 1 });
            yield return new object[] { list, expectedList };

            list = new ArrayList(new int[] { 0, -1, 0, 5, 9 });
            expectedList = new ArrayList(new int[] { 9, 5, 0, -1, 0 });
            yield return new object[] { list, expectedList };
        }
    }
    internal class FindMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 5;
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { actuallist, expected };


            expected = 0;
            actuallist = new ArrayList(new int[] { -1, -2, -3, -4, -5, 0 });
            yield return new object[] { actuallist, expected };

        }
    }
    internal class FindMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 1;
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { actuallist, expected };


            expected = -5;
            actuallist = new ArrayList(new int[] { -1, -2, -3, -4, -5, 0 });
            yield return new object[] { actuallist, expected };

        }
    }
    internal class FindIndexOfMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 4;
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { actuallist, expected };


            expected = 5;
            actuallist = new ArrayList(new int[] { -1, -2, -3, -4, -5, 0 });
            yield return new object[] { actuallist, expected };

        }
    }
    internal class FindIndexOfMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 0;
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { actuallist, expected };


            expected = 4;
            actuallist = new ArrayList(new int[] { -1, -2, -3, -4, -5, 0 });
            yield return new object[] { actuallist, expected };

        }
    }
    internal class SortAscendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            yield return new object[] { list, expectedList };

            list = new ArrayList(new int[] { 0, -1, 0, 5, 9 });
            expectedList = new ArrayList(new int[] { -1, 0, 0, 5, 9 });
            yield return new object[] { list, expectedList };
        }
    }
    internal class DescendingSortTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            ArrayList expectedList = new ArrayList(new int[] { 6, 5, 4, 3, 2, 1 });
            yield return new object[] { list, expectedList };

            list = new ArrayList(new int[] { 0, -1, 0, 5, 9 });
            expectedList = new ArrayList(new int[] { 9, 5, 0, 0,-1 });
            yield return new object[] { list, expectedList };
        }
    }
    internal class DeleteFirstByValueGetIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            int value = 6;
            int index = 5;
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { value, index, list, expectedList };

            list = new ArrayList(new int[] { 0, -1, 0, 5, 9 });
            value = -1;
            index = 1;
            expectedList = new ArrayList(new int[] { 0, 0, 5, 9 });
            yield return new object[] { value, index, list, expectedList };
        }
    }
    internal class DeleteAllByValueGetNumberTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            int number = 0;
            int value = 7;
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            yield return new object[] { value, number, list, expectedList };

            list = new ArrayList(new int[] { 0, -1, 0, 5, 9 });
            number = 2;
            value = 0;
            expectedList = new ArrayList(new int[] { -1, 5, 9 });
            yield return new object[] { value, number, list, expectedList };
        }
    }
    internal class AddListToEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList expectedList = new ArrayList(new int[] { 6, 5, 4, 3, 2, 1, 9, 9, 9, 9 });
            ArrayList list = new ArrayList(new int[] { 6, 5, 4, 3, 2, 1 });
            ArrayList secondList = new ArrayList(new int[] { 9, 9, 9, 9 });
            yield return new object[] { secondList, list, expectedList };


            list = new ArrayList(new int[] { 9, 9, 9, 9 });
            expectedList = new ArrayList(new int[] { 9, 9, 9, 9,0 });
            secondList = new ArrayList(new int[] { 0});
            yield return new object[] { secondList, list, expectedList };
        }
    }

    internal class AddListToBeginningTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList expectedList = new ArrayList(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 });
            ArrayList list = new ArrayList(new int[] { 6, 5, 4, 3, 2, 1 });
            ArrayList secondList = new ArrayList(new int[] { 8, 7 });
            yield return new object[] { secondList, list, expectedList };

            list = new ArrayList(new int[] { 1, 1, 1, 1 });
            expectedList = new ArrayList(new int[] { 2, 2, 2, 2, 1, 1, 1, 1 });
            secondList = new ArrayList(new int[] { 2, 2, 2, 2 });
            yield return new object[] { secondList, list,expectedList};
        }
    }
    internal class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList expectedList = new ArrayList(new int[] { 6, 5, 4, 3, 2, 9, 9, 9, 9, 1 });
            int index = 5;
            ArrayList list = new ArrayList(new int[] { 6, 5, 4, 3, 2, 1 });
            ArrayList secondList = new ArrayList(new int[] { 9, 9, 9, 9 });
            yield return new object[] { index, secondList, list, expectedList };

            list = new ArrayList(new int[] { 9, 9, 9, 9 });
            index = 4;
            expectedList = new ArrayList(new int[] { 9, 9, 9, 9, 0, 1, 2, 3, 4, 5 });
            secondList = new ArrayList(new int[] { 0, 1, 2, 3, 4, 5, });
            yield return new object[] { index, secondList, list, expectedList };

            list = new ArrayList(new int[] { 1, 1, 1, 1 });
            index = 0;
            expectedList = new ArrayList(new int[] { 2, 2, 2, 2, 1, 1, 1, 1 });
            secondList = new ArrayList(new int[] { 2, 2, 2, 2 });
            yield return new object[] { index, secondList, list, expectedList };
        }
    }
}

