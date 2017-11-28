using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stackie<int> a = new Stackie<int>();
            a.Push(0);
            a.Push(1);
        }
    }
}
