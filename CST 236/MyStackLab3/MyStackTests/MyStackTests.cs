using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStack;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Data;

namespace MyStack.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class MyStackTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DeploymentItem("TestData.xlsx")]
        [DataSource("System.Data.OleDb", // The provider 
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='TestData.xlsx';Persist Security Info=False;Extended Properties='Excel 8.0'", "StackData$",      // The table name, in this case, the sheet name with a '$' appended.				
         DataAccessMethod.Sequential)]
        public void TestPushPop()
        {
            var pushNumber = (int)(double) TestContext.DataRow["pushNumber"];
            int popNumber= (int)(double)TestContext.DataRow["popNumber"];
            int expectedLeft= (int)(double)TestContext.DataRow["expectedLeft"];

            _stack = new MyStack<int>(10);

           for(var i = 0; i < pushNumber; i++)
            {
                _stack.Push(i);
            }
           for(var i = 0; i < popNumber; i++)
            {
                _stack.Pop();
            }
            Assert.AreEqual(expectedLeft, _stack.Size());
        }

        private MyStack<int> _stack;
        private const int MaxStackSize = 10;
        [TestInitialize]
        public void SetUp()
        {
            _stack = new MyStack<int>(MaxStackSize);
            _stack.Push(5);
            _stack.Push(10);
            _stack.Push(15);
        }
        [TestMethod()]
        public void PopTest()
        {
            _stack.Pop();
            Assert.AreEqual(10, _stack.Top());
            Assert.AreEqual(2, _stack.Size());

        }

        [TestMethod()]
        public void PushTest()
        {
            _stack.Push(1);
            Assert.AreEqual(1, _stack.Top());
        }

        [TestMethod()]
        public void TopTest()
        {
            var top = _stack.Top();
            Assert.IsNotNull(top);
        }

        [TestMethod()]
        public void SizeTest()
        {
            //three already added plus this below should give you 4
            _stack.Push(22);
            Assert.AreEqual(4, _stack.Size());
        }


        [TestMethod()]
        public void ClearTest()
        {
            _stack.Clear();
            Assert.AreEqual(0,_stack.Size());
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestOverFlow()
        {
            _stack = new MyStack<int>(2);
            _stack.Push(3);
            _stack.Push(4);
            _stack.Push(6);

        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestUnderFlow()
        {
            _stack = new MyStack<int>(10);
            _stack.Pop();
        }

        
    }
}