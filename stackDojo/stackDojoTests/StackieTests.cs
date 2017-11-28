using Microsoft.VisualStudio.TestTools.UnitTesting;
using stackDojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackDojo.Tests
{
    [TestClass()]
    public class StackieTests
    {
        private Stackie<int> intStack;
        private Stackie<string> stringStack;

        private void IntSetup() { intStack = new Stackie<int>(); }

        private void StringSetup() { stringStack = new Stackie<string>(); }

        [TestMethod()]
        public void StackieIntTest()
        {
            IntSetup();
            Assert.IsNotNull(intStack);
        }

        [TestMethod()]
        public void StackieStringTest()
        {
            StringSetup();
            Assert.IsNotNull(stringStack);
        }
         
        [TestMethod()]
        public void PushTest()
        {
            IntSetup();
            int value = 0;
            intStack.Push(value);
            Assert.AreEqual(intStack.Get(0), value);
        }
        [TestMethod()]
        public void PushTest_2()
        {
            StringSetup();
            string value = "test";
            stringStack.Push(value);
            value = "test2";
            stringStack.Push(value);
            Assert.AreEqual(stringStack.Peek(), value);
        }

        [TestMethod()]
        public void PopTest()
        {
            IntSetup();
            int loop = 5;
            for (int i = 0; i < loop; i++)
            {
                intStack.Push(i);
            }
            intStack.Pop();     // last number == loop-1 btw
            Assert.AreEqual(loop-2, intStack.Peek());
        }

        [TestMethod()]
        public void PeekTest()
        {
            StringSetup();
            string firstString = "apple";
            stringStack.Push(firstString);
            string secondString = "banana";
            stringStack.Push(secondString);
            Assert.AreEqual(stringStack.Peek(), secondString);
        }

        [TestMethod()]
        public void SizeTest()
        {
            IntSetup();
            int loopAndSize = 7;
            for (int i = 0; i < loopAndSize; i++)
            {
                intStack.Push(i);
            }
            Assert.AreEqual(intStack.Size(), loopAndSize);
        }

        [TestMethod()]
        public void FreeSpacesTest()
        {
            StringSetup();
            string[] valueArray = new string[] { "a", "b", "c", "d" };
            for (int i = 0; i < valueArray.Length; i++)
            {
                stringStack.Push(valueArray[i]);
            }
            int expected = 10 - valueArray.Length;
            Assert.AreEqual(stringStack.FreeSpaces(), expected);
        }
    }
}