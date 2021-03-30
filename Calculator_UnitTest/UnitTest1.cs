using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{

    namespace Calculator_UnitTest
    {
        [TestClass]
        public class UnitTest1 : Form1
        {
            [TestMethod]
            public void Input_SUCCESS()
            {

                Validate v = new Validate();
                bool verify = v.check("5.2");
                Assert.AreEqual(verify, true);

            }


            [TestMethod]
            public void Input_FAIL()
            {
                Validate v = new Validate();
                bool verify = v.check("hello");
                Assert.AreEqual(verify, false);

            }

            [TestMethod]

            public void MemoryStore_SUCCESS()
            {
                Memory m = new Memory();

                m.MemoryStore(5);

                Assert.AreEqual(5, m.MemoryValue);
            }

            [TestMethod]
            public void MemoryValue()
            {
                Memory m = new Memory();

                m.MemoryValue = 10;

                Assert.AreEqual(10, m.MemoryValue);
            }
            [TestMethod]
            public void MemoryAdd_SUCCESS()
            {
                Memory m = new Memory();
                m.MemoryValue = 10;
                m.MemoryAdd(10);
                Assert.AreEqual(20, m.MemoryValue);
            }
            [TestMethod]
            public void MemoryClear_SUCCESS()
            {
                Memory m = new Memory();
                m.MemoryClear();
                Assert.AreEqual(m.MemoryValue, 0);
            }
            [TestMethod]
            public void MemoryRecall_SUCCESS()
            {
                Memory m = new Memory();

                m.MemoryValue = 10;

                decimal something = m.MemoryRecall();
                Assert.AreEqual(something, 10);
            }




            [TestMethod]
            public void CalculatordefConstr_SUCCESS()
            {
                Calculator c = new Calculator();
                Assert.AreEqual(0, c.Op);
                Assert.AreEqual(0, c.Operand1);
                Assert.AreEqual(0, c.Operand2);
            }

            [TestMethod]
            public void CalculatorEqual_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Equals(10);
                Assert.AreEqual(10, c.Operand2);
            }

            [TestMethod]
            public void CalculatorSqrt_SUCCESS()
            {
                Calculator c = new Calculator();
                double d = c.SquareRoot(4);
                Assert.AreEqual(d, 2);
            }
            [TestMethod]
            public void CalculatorAdd_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Add(10);
                Assert.AreEqual(10, c.Operand1);
                Assert.AreEqual(0, c.Op);
            }
            [TestMethod]
            public void CalculatorSubtract_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Subtract(10);
                Assert.AreEqual(10, c.Operand1);
                Assert.AreEqual(1, c.Op);
            }
            [TestMethod]
            public void CalculatorMultiply_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Multiply(10);
                Assert.AreEqual(10, c.Operand1);
                Assert.AreEqual(2, c.Op);
            }
            [TestMethod]
            public void CalculatorDivide_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Divide(10);
                Assert.AreEqual(10, c.Operand1);
                Assert.AreEqual(3, c.Op);
            }
            [TestMethod]
            public void CalculatorClear_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Clear();
                Assert.AreEqual(0, c.Operand1);
                Assert.AreEqual(0, c.Operand2);
                Assert.AreEqual(0, c.CurrentValue);
                Assert.AreEqual(0, c.Op);
            }
            [TestMethod]
            public void CalculatorEqualRepeatAdd_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Operand2 = 10;
                c.Op = 0;
                c.EqualsRepeat(20);
                Assert.AreEqual(30, c.CurrentValue);
            }
            [TestMethod]
            public void CalculatorEqualRepeatSubtract_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Operand2 = 10;
                c.Op = 1;
                c.EqualsRepeat(20);
                Assert.AreEqual(10, c.CurrentValue);
            }

            [TestMethod]
            public void CalculatorEqualRepeatMultiply_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Operand2 = 10;
                c.Op = 2;
                c.EqualsRepeat(20);
                Assert.AreEqual(200, c.CurrentValue);
            }

            [TestMethod]
            public void CalculatorEqualRepeatDivide_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Operand2 = 10;
                c.Op = 3;
                c.EqualsRepeat(20);
                Assert.AreEqual(2, c.CurrentValue);
            }
            [TestMethod]
            [ExpectedException(typeof(DivideByZeroException))]
            public void CalculatorEqualRepeatDivideException_SUCCESS()
            {
                Calculator c = new Calculator();


                c.Operand2 = 0;
                c.Op = 3;
                c.EqualsRepeat(20);

            }
            [TestMethod]
            public void CalculatorEqualrepeatDefault_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Op = 5;
                c.EqualsRepeat(20);
                Assert.AreEqual(0, c.CurrentValue);
            }
            [TestMethod]
            public void CalculatorResultAdd_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Op = 0;
                c.Operand1 = 10;
                c.Operand2 = 10;
                c.Result();
                Assert.AreEqual(20, c.CurrentValue);
            }
            [TestMethod]
            public void CalculatorResultSubtract_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Op = 1;
                c.Operand1 = 10;
                c.Operand2 = 20;
                c.Result();
                Assert.AreEqual(-10, c.CurrentValue);
            }
            [TestMethod]
            public void CalculatorResultMultiply_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Op = 2;
                c.Operand1 = 10;
                c.Operand2 = 20;
                c.Result();
                Assert.AreEqual(200, c.CurrentValue);
            }
            [TestMethod]
            public void CalculatorResultDivide_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Op = 3;
                c.Operand1 = 8;
                c.Operand2 = 2;
                c.Result();
                Assert.AreEqual(4, c.CurrentValue);
            }
            [TestMethod]
            [ExpectedException(typeof(DivideByZeroException))]
            public void CalculatorResultDivideException_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Op = 3;
                c.Operand1 = 8;
                c.Operand2 = 0;
                c.Result();

            }
            [TestMethod]
            public void CalculatorResultDefault_SUCCESS()
            {
                Calculator c = new Calculator();
                c.Op = 5;
                c.Result();
                Assert.AreEqual(0, c.CurrentValue);
            }
            [TestMethod]
            public void CalculatorclearKeys_SUCCESS0()
            {
                Form1 f = new Form1();
                f.clearkeys('0');
            }
            [TestMethod]
            public void CalculatorclearKeys_SUCCESS1()
            {
                Form1 f = new Form1();
                f.clearkeys('1');
            }
            [TestMethod]
            public void CalculatorclearKeys_SUCCESS2()
            {
                Form1 f = new Form1();
                f.clearkeys('2');
            }
            [TestMethod]
            public void CalculatorclearKeys_SUCCESS3()
            {
                Form1 f = new Form1();
                f.clearkeys('3');
            }
            [TestMethod]
            public void CalculatorclearKeys_SUCCESS4()
            {
                Form1 f = new Form1();
                f.clearkeys('4');
            }
            [TestMethod]
            public void CalculatorclearKeys_SUCCESS5()
            {
                Form1 f = new Form1();
                f.clearkeys('5');
            }
            [TestMethod]
            public void CalculatorclearKeys_SUCCESS6()
            {
                Form1 f = new Form1();
                f.clearkeys('6');
            }
            [TestMethod]
            public void CalculatorclearKeys_SUCCESS7()
            {
                Form1 f = new Form1();
                f.clearkeys('7');
            }
            [TestMethod]
            public void CalculatorclearKeys_SUCCESS8()
            {
                Form1 f = new Form1();
                f.clearkeys('8');
            }
            [TestMethod]
            public void CalculatorclearKeys_SUCCESS9()
            {
                Form1 f = new Form1();
                f.clearkeys('9');
            }
            [TestMethod]
            public void c()
            {
                Form1 f = new Form1();
                //.Equal();
            }
        }
    }
}
