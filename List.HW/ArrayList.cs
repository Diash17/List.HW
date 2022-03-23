using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_HW
{
    public class ArrayList
    {
        public int Length { get; private set; }
        private int[] _array;

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }
        public ArrayList(int Length)
        {
            _array = new int[(int)(Length * 1.5)];
            this.Length = Length;
        }
        public ArrayList(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                _array = new int[10];
                Length = 0;
            }
            else
            {
                _array = array;
                Length = array.Length;
                UpSize();
            }
        }

        public void Write()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write(_array[i] + " ");
            }
            Console.WriteLine();
        }

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5 + 1);
            int[] newArray = new int[newLength];
            Copy(newArray);
        }
        private void CutSize()
        {
            if (_array.Length / Length > 2)
            {
                int newLenght = (int)(_array.Length / 1.3d);
                int[] newArray = new int[newLenght];
                Copy(newArray);
            }
        }
        private void MoveRight(int index = 0)
        {
            int[] newArray = new int[Length + 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
        }
        private void MoveLeftWithIndex(int index = 0)
        {
            int[] newArray = new int[_array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < _array.Length - 1; i++)
            {
                newArray[i] = _array[i + 1];
            }
            _array = newArray;
        }
        private void MoveLeftWithFewIndex(int elements, int index = 0)
        {
            Length -= elements;
            int[] newArray = new int[Length];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < Length; i++)
            {
                newArray[i] = _array[i + elements];
            }
            _array = newArray;
        }
        private void MoveLeft()
        {
            int[] newArray = new int[Length - 1];
            for (int i = 0; i < Length - 1; i++)
            {
                newArray[i] = _array[i + 1];
            }
            _array = newArray;
        }
        private void Copy(int[] newArray)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        // добавление значения в конец
        public void ChangeLastOne(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

        //добавление значения в начало
        public void ChangeFirstOne(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            MoveRight();

            _array[0] = value;
            Length++;
        }

        //добавление значения по индексу
        public void AddByIndex(int index, int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            MoveRight(index);
            _array[index] = value;
            Length++;
        }

        //удаление из конца одного элемента
        public void DeleteOneFromEnd()
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not delete element");
            }
            Length--;
        }

        //удаление из начала одного элемента
        public void DeleteOneFromBeginning()
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not delete element");
            }
            MoveLeft();
            Length--;
        }
        //удаление по индексу одного элемента
        public void DeleteOneByIndex(int index)
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not delete element");
            }

            if (index < 0 || index > _array.Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            MoveLeftWithIndex(index);
            Length--;
            CutSize();
        }
        //удаление из конца N элементов
        public void DeleteNElementsFromEnd(int value)
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not delete element");
            }

            for (int i = 0; i < value; i++)
            {
                DeleteOneFromEnd();
            }
            CutSize();
        }

        //удаление из начала N элементов
        public void DeleteNElementsFromBeginning(int value)
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not delete element");
            }
            int[] newArray = new int[Length - value];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i + value];
            }
            _array = newArray;
            Length = newArray.Length;
        }
        //удаление по индексу N элементов
        public void DeleteWithFewIndex(int elements, int index)
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not delete element");
            }

            if (index < 0 || index > _array.Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            CutSize();
            MoveLeftWithFewIndex(elements, index);
        }
        //вернуть длину

        public int GetLenght(int count)
        {
            return Length;
        }
        public int AccessByIndex(int index)
        {

            if (index < 0 || index > _array.Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            return _array[index];
        }
        public int FindFirstIndexByValue(int value)
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not find element");
            }
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public void EditValueByIndex(int index, int value)
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not find element");
            }

            if (index < 0 || index > _array.Length)
            {
                throw new IndexOutOfRangeException("index");
            }

            _array[index] = value;
        }
        public void Reverse()
        {
            int[] newArray = new int[Length];
            int j = 0;
            for (int i = Length - 1; i >= 0; i--)
            {
                newArray[j] = _array[i];
                j++;
            }
            _array = newArray;
        }

        // поиск значения максимального элемента
        public int FindMax()
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not find element");
            }
            int max = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (max < _array[i])
                {
                    max = _array[i];
                }
            }
            return max;
        }
        // поиск значения минимального элемента
        public int FindMin()
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not find element");
            }
            int min = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (min > _array[i])
                {
                    min = _array[i];
                }
            }
            return min;
        }
        public int FindIndexOfMax()
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not find element");
            }
            int maxIndex = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > _array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public int FindIndexOfMin()
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not find element");
            }
            int minIndex = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < _array[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public void SortAscending()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        int tmp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }
        public void DescendingSort()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (_array[i] < _array[j])
                    {
                        int tmp = _array[j];
                        _array[j] = _array[i];
                        _array[i] = tmp;
                    }
                }
            }
        }
        public int DeleteFirstByValueGetIndex(int value)
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not delete element");
            }

            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (value == _array[i])
                {
                    index = i;
                    break;
                }
            }
            MoveLeftWithIndex(index);
            Length--;
            CutSize();
            return index;
        }
        public int DeleteAllByValueGetIndex(int value)
        {
            if (Length < 1)
            {
                throw new Exception("Array is null, can not delete element");
            }

            int index = -1;
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                if (value == _array[i])
                {
                    index = i;
                    MoveLeftWithIndex(index);
                    Length--;
                    count++;
                }
            }
            CutSize();
            return count;
        }
        //добавление списка(вашего самодельного) в конец
        public void AddListToEnd(ArrayList list)
        {
            int newLength = Length + list.Length;
            int[] newArray = new int[newLength];
            for (int i = 0; i < Length; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = 0; i < list.Length; i++)
            {
                newArray[i + Length] = list[i];
            }

            _array = newArray;
            Length = newArray.Length;
        }
        //добавление списка в начало
        public void AddListToBeginning(ArrayList list)
        {
            int newLength = Length + list.Length;
            int[] newArray = new int[newLength];
            for (int i = 0; i < list.Length; i++)
            {
                newArray[i] = list[i];
            }
            MoveRight(list.Length);
            for (int i = 0; i < Length; i++)
            {
                newArray[i + list.Length] = _array[i];
            }

            _array = newArray;
            Length = newArray.Length;
        }
        //добавление списка по индексу
        public void AddListByIndex(ArrayList list, int index)
        {
            {
                int newLength = Length + list.Length;
                int[] newArray = new int[newLength];
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = _array[i];
                }
                for (int i = 0; i < list.Length; i++)
                {
                    newArray[i + index] = list[i];
                }
                for (int i = 0; i < Length - index; i++)
                {
                    newArray[i + index + list.Length] = _array[i + index];
                }
                _array = newArray;
                Length = newArray.Length;
            }
        }
    }
}
