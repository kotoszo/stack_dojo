using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackDojo
{
    public class Stackie<T>
    {
        private int index, maxSize = 10;
        private T[] list;

        public Stackie()
        {
            list = new T[maxSize];
            index = 0;
        }

        public void push(T value)
        {
            if (list.Length == maxSize) { throw new StackOverflowException(); }
            list[index] = value;
            index++;
        }
        
        public void Pop()
        {
            if (list.Length == 0) { throw new NullReferenceException(); }
            list[index] = default(T);
            index--;
        }

        public T Peek()
        {
            return list[index];
        }

        public int Size()
        {
            return list.Length;
        }

        public int FreeSpaces()
        {
            int times = 0;
            foreach (var item in list)
            {
                if (item.Equals(default(T)))
                {
                    times++;
                }
            }
            return times;
        }
    }
}
