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
        internal class EditValueByIndexTestSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
                int index = 2;
                int value = 0;
                ArrayList expectedList = new ArrayList(new int[] { 1, 2, 0, 4, 5, 6 });
                yield return new object[] { value, index, list, expectedList };

                list = new ArrayList(new int[] { 0, -1, 0, 5, 9 });
                index = 0;
                value = -33;
                expectedList = new ArrayList(new int[] { -33, -1, 0, 5, 9 });
                yield return new object[] { value, index, list, expectedList };
            }
        }
    }
}
