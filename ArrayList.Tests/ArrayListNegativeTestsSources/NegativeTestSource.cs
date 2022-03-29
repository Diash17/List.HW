using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLists.Tests.ArrayListNegativeTestSources
{
    internal class AddByIndexNegativeTestSource_WhenIndexIsOutOfLength_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -2;
            int value = 20;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { value, index, list };

            index = -2;
            value = -1;
            list = new ArrayList(new int[] { 0, 0, 0, 0 });
            yield return new object[] { value, index, list };
        }
    }
    internal class DeleteOneFromEndNegativeTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });
            yield return new object[] { list };

            list = new ArrayList(new int[] { });
            yield return new object[] { list };
        }
    }
    internal class DeleteOneFromBeginningNegativeTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });
            yield return new object[] { list };

            list = new ArrayList(new int[] { });
            yield return new object[] { list };
        }
    }
    internal class DeleteOneByIndexNegativeTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });
            int index = 1;
            yield return new object[] { index, list };
        }
    }
    internal class DeleteOneByIndexNegativeTestSource_WhenIndexIsOutOfLength_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -2;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, list };
        }
    }
    internal class DeleteNElementsFromEndNegativeTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });
            int value = 5;
            yield return new object[] { value, list };
        }
    }

    internal class DeleteNElementsFromBeginningNegativeTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });
            int value = 5;
            yield return new object[] { value, list };
        }
    }
    internal class DeleteWithFewIndexTestSource_WhenIndexIsOutOfLength_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -2;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, list };

            index = -5;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, list };
        }
    }
    internal class FindFirstIndexByValueTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });
            int value = 2;
            yield return new object[] { value,list };
        }
    } 
    internal class AccessByIndexTestSource_WhenIndexIsOutOfLength_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1,2,3});
            int index = -1;
            yield return new object[] {index,list };
        }
    } 
    internal class EditValueByIndexTestSource_WhenIndexIsOutOfLength_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1,2});
            int index = -1;
            int value = 2;
            yield return new object[] {index,value,list };
        }
    }
    internal class EditValueByIndexTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });
            int index = 1;
            int value = 2;
            yield return new object[] {index,value,list };
        }
    }
    internal class FindMaxTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });         
            yield return new object[] {list };
        }
    }
    internal class FindMinTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });         
            yield return new object[] {list };
        }
    }
    internal class FindIndexOfMaxTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });         
            yield return new object[] {list };
        }
    }
    internal class FindIndexOfMinTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });         
            yield return new object[] {list };
        }
    }
    internal class DeleteFirstByValueGetIndexTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });
            int value = 1;
            yield return new object[] {value,list };
        }
    }
    internal class DeleteAllByValueGetNumberTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });
            int value = 1;
            yield return new object[] {value,list };
        }
    }
    internal class AddListToEndNegativeTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1,2,3});
            ArrayList secondList = new ArrayList(new int[] { });
            yield return new object[] {secondList,list };
        }
    }
    internal class AddListToBeginningNegativeTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] {1,2,3 });
            ArrayList secondList = new ArrayList(new int[] { });
            yield return new object[] { secondList, list };
        }
    }
    internal class AddListByIndexNegativeTestSource_WhenLengthEqualZero_ShouldThrowException : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 9, 9, 9, 9 });
            int index = 0;
            ArrayList secondList = new ArrayList(new int[] { });
            yield return new object[] { index, secondList, list };


        }
    }
}






