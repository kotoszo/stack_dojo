using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackDojo
{
    public class Stackie<T>
    {
        private int index;
        private int maxSize = 10;
        private T[] list;

        public Stackie()
        {
            list = new T[1];
            index = 0;
        }

        public void Push(T value)
        {
            if (list.Length-1 < index) { MakeArrayGreatAgain(); }
            if (index == maxSize) { throw new StackOverflowException(); }
            list[index] = value;
            index++;
        }

        private void MakeArrayGreatAgain()
        {
            T[] temp = new T[list.Length+1];
            for (int i = 0; i < list.Length; i++)
            {
                temp[i] = list[i];
            }
            list = temp;
        }

        public void Pop()
        {
            if (list.Length == 0) { throw new NullReferenceException(); }
            T[] temp = new T[list.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = list[i];
            }
            list = temp;
            index--;
        }

        public T Peek()
        {
            return list.Last();
        }

        public int Size()
        {
            return list.Length;
        }

        public int FreeSpaces()
        {
            return maxSize - list.Length;
        }
        public T Get(int index)
        {
            return list[index];
        }
    }
}
