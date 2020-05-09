using Microsoft.VisualStudio.TestTools.UnitTesting;
using LMath;
using System.Collections.Generic;
using System;
namespace Math_Module_Test
{
    [TestClass]
    public class Z_Test
    {
        // -
        [TestMethod]
        public void MinusUnar1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("12");
            input.Add("100");
            input1.Add("-");
            input1.Add("12");
            input1.Add("100");
            Z X = new Z(input);
            Z I = -X;
            Z T = new Z(input1);
            Assert.AreEqual(T, I);
        }

        [TestMethod]
        public void MinusUnar2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("-");
            input.Add("125");
            input1.Add("125");
            Z X = new Z(input);
            Z I = -X;
            Z T = new Z(input1);
            Assert.AreEqual(T, I);
        }

        // -
        [TestMethod]
        public void MinusTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("100");
            input.Add("000");
            input1.Add("12");
            input1.Add("100");
            input1.Add("000");
            output.Add("0");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X - I);
        }

        [TestMethod]
        public void MinusTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("0");
            input1.Add("124");
            input1.Add("367");
            output.Add("-");
            output.Add("124");
            output.Add("367");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X - I);
        }

        [TestMethod]
        public void MinusTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("0");
            input1.Add("-");
            input1.Add("124");
            input1.Add("367");
            output.Add("124");
            output.Add("367");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X - I);
        }

        [TestMethod]
        public void MinusTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("12");
            input.Add("138");
            input1.Add("0");
            output.Add("-");
            output.Add("12");
            output.Add("138");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X - I);
        }

        [TestMethod]
        public void MinusTest5()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("138");
            input1.Add("0");
            output.Add("12");
            output.Add("138");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X - I);
        }

        [TestMethod]
        public void MinusTest6()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("12");
            input1.Add("138");
            input1.Add("276");
            output.Add("-");
            output.Add("138");
            output.Add("288");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X - I);
        }

        [TestMethod]
        public void MinusTest7()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("919");
            input1.Add("138");
            input1.Add("276");
            output.Add("-");
            output.Add("139");
            output.Add("195");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X - I);
        }

        // +
        [TestMethod]
        public void PlusTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("100");
            input.Add("000");
            input1.Add("12");
            input1.Add("100");
            input1.Add("000");
            output.Add("24");
            output.Add("200");
            output.Add("000");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X + I);
        }


        [TestMethod]
        public void PlusTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("100");
            input.Add("000");
            input1.Add("0");
            output.Add("12");
            output.Add("100");
            output.Add("000");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X + I);
        }

        [TestMethod]
        public void PlusTest3()
        {
            List<string> input2 = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input2.Add("12");
            input2.Add("100");
            input2.Add("000");
            input1.Add("0");
            output.Add("12");
            output.Add("100");
            output.Add("000");
            Z X = new Z(input1);
            Z I = new Z(input2);
            Z T = new Z(output);
            Assert.AreEqual(T, X + I);
        }

        [TestMethod]
        public void PlusTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("100");
            input.Add("000");
            input1.Add("-");
            input1.Add("12");
            input1.Add("100");
            input1.Add("000");
            output.Add("0");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X + I);
        }

        [TestMethod]
        public void PlusTest5()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("128");
            input.Add("942");
            input1.Add("213");
            input1.Add("419");
            output.Add("12");
            output.Add("342");
            output.Add("361");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X + I);
        }

        [TestMethod]
        public void ZConvertToStringTest()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("100");
            Z X = new Z(input);
            output = (List<string>)X;
            CollectionAssert.AreEqual(output, input);
        }

        [TestMethod]
        public void isDownTest1()
        {
            List<string> input = new List<string>();
            input.Add("12");
            input.Add("00000009");
            Z z = new Z(input);
            bool i = z.isDown;
            Assert.AreEqual(true, i);
        }
           
        [TestMethod]
        public void isDownTest2()
        {
            List<string> input = new List<string>();
            input.Add("-");
            input.Add("12");
            input.Add("00000009");
            Z z = new Z(input);
            bool i = z.isDown;
            Assert.AreEqual(false, i);
        }

        [TestMethod]
        public void isDownTestEx()
        {
            List<string> input = new List<string>();
            input.Add("12");
            input.Add("00000009");
            Z z = new Z(input);
            bool i = z.isDown;
            Assert.AreNotEqual(null, i);

        }

        // *
        [TestMethod]
        public void MultiplicationTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("2");
            input.Add("159");
            input1.Add("0"); 
            output.Add("0");
            Z z = new Z(input);
            Z x = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t,z*x);
        }

        [TestMethod]
        public void MultiplicationTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("0");
            input1.Add("134");
            input1.Add("279");
            output.Add("0");
            Z z = new Z(input);
            Z x = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, z * x);
        }

        [TestMethod]
        public void MultiplicationTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("224");
            input.Add("457");
            input1.Add("134");
            output.Add("30");
            output.Add("077");
            output.Add("238");
            Z z = new Z(input);
            Z x = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, z * x);
        }

        [TestMethod]
        public void MultiplicationTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("100");
            input.Add("457");
            input1.Add("134");
            input1.Add("278");
            output.Add("-");
            output.Add("13");
            output.Add("489");
            output.Add("165");
            output.Add("046");
            Z z = new Z(input);
            Z x = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, z * x);
        }

        [TestMethod]
        public void MultiplicationTest5()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("156");
            input.Add("457");
            input1.Add("-");
            input1.Add("134");
            input1.Add("210");
            output.Add("20");
            output.Add("998");
            output.Add("093");
            output.Add("970");
            Z z = new Z(input);
            Z x = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, z * x);
        }

        // /
        [TestMethod]
        public void DevisionByZeroTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("-");
            input.Add("273");
            input.Add("145");
            input1.Add("0");
            Z n = new Z(input);
            Z i = new Z(input1);
            Assert.AreEqual(null, n / i);
        }

        [TestMethod]
        public void DevisionByZeroTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("-");
            input.Add("273");
            input.Add("145");
            input1.Add("0");
            Z n = new Z(input1);
            Z i = new Z(input);
            Assert.AreEqual(n, n / i);
        }

        [TestMethod]
        public void DevisionTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("1");
            input.Add("157");
            input.Add("000");
            input1.Add("1");
            input1.Add("157");
            output.Add("1");
            output.Add("000");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n / i);
        }

        [TestMethod]
        public void DevisionTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("154");
            input.Add("278");
            input1.Add("325");
            output.Add("-");
            output.Add("474");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n / i);
        }

        [TestMethod]
        public void DevisionTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("974");
            input.Add("243");
            input1.Add("-");
            input1.Add("167");
            input1.Add("843");
            output.Add("5");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n / i);
        }

        //%
        [TestMethod]
        public void RemainderByZeroTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("-");
            input.Add("758");
            input.Add("168");
            input1.Add("0");
            Z n = new Z(input);
            Z i = new Z(input1);
            Assert.AreEqual(null, n % i);
        }

        [TestMethod]
        public void RemainderByZeroTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("-");
            input.Add("758");
            input.Add("168");
            input1.Add("0");
            Z n = new Z(input1);
            Z i = new Z(input);
            Assert.AreEqual(n, n % i);
        }

        [TestMethod]
        public void RemainderTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("145");
            input.Add("565");
            input1.Add("386");
            output.Add("43");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n % i);
        }

        [TestMethod]
        public void RemainderTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("1");
            input.Add("673");
            input1.Add("1");
            input1.Add("673");
            output.Add("0");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n % i);
        }

        [TestMethod]
        public void RemainderTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("967");
            input.Add("287");
            input1.Add("273");
            input1.Add("571");
            output.Add("126");
            output.Add("997");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n % i);
        }

        [TestMethod]
        public void RemainderTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("967");
            input.Add("287");
            input1.Add("-");
            input1.Add("273");
            input1.Add("571");
            output.Add("146");
            output.Add("574");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n % i);
        }

        [TestMethod]
        public void RemainderTest5()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("967");
            input.Add("287");
            input1.Add("-");
            input1.Add("273");
            input1.Add("571");
            output.Add("146");
            output.Add("574");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n % i);
        }

        [TestMethod]
        public void RemainderTest6()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("7");
            input.Add("287");
            input1.Add("273");
            input1.Add("571");
            output.Add("7");
            output.Add("287");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n % i);
        }

        // ^
        [TestMethod]
        public void DegreeTestZero1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("712");
            input.Add("287");
            input1.Add("0");
            output.Add("1");
            Z n = new Z(input);
            N i = new N(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n ^ i);
        }

        [TestMethod]
        public void DegreeTestZero2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("712");
            input.Add("287");
            input1.Add("0");
            output.Add("0");
            Z n = new Z(input1);
            N i = new N(input);
            Z t = new Z(output);
            Assert.AreEqual(t, n ^ i);
        }

        [TestMethod]
        public void DegreeTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("287");
            input1.Add("12");
            output.Add("312");
            output.Add("307");
            output.Add("749");
            output.Add("504");
            output.Add("346");
            output.Add("137");
            output.Add("016");
            output.Add("129");
            output.Add("649");
            output.Add("281");
            Z n = new Z(input);
            N i = new N(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n ^ i);
        }

        [TestMethod]
        public void DegreeTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("287");
            input1.Add("1");
            output.Add("-");
            output.Add("287");
            Z n = new Z(input);
            N i = new N(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n ^ i);
        }

        [TestMethod]
        public void DegreeTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("287");
            input1.Add("12");
            output.Add("312");
            output.Add("307");
            output.Add("749");
            output.Add("504");
            output.Add("346");
            output.Add("137");
            output.Add("016");
            output.Add("129");
            output.Add("649");
            output.Add("281");
            Z n = new Z(input);
            N i = new N(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n ^ i);
        }

        [TestMethod]
        public void DegreeTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("89");
            input1.Add("11");
            output.Add("2");
            output.Add("775");
            output.Add("173");
            output.Add("073");
            output.Add("766");
            output.Add("990");
            output.Add("340");
            output.Add("489");
            Z n = new Z(input);
            N i = new N(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n ^ i);
        }

        [TestMethod]
        public void ABS_Z_NTest1()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("145");
            input.Add("000");
            output.Add("145");
            output.Add("000");
            Z z = new Z(input);
            N n = z.ABS as N;
            N t = new N(output);
            Assert.AreEqual(t, n);
        }

        [TestMethod]
        public void ABS_Z_NTest2()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("2");
            output.Add("2");
            Z z = new Z(input);
            N n = z.ABS as N;
            N t = new N(output);
            Assert.AreEqual(t, n);
        }
        
        [TestMethod]
        public void POZ_Z_DTest1()
        {
            List<string> input = new List<string>();
            input.Add("145");
            input.Add("000");
            Z z = new Z(input);
            byte i = z.POZ_Z_D;
            byte t = 2;
            Assert.AreEqual(t, i);
        }

        [TestMethod]
        public void POZ_Z_DTest2()
        {
            List<string> input = new List<string>();
            input.Add("-");
            input.Add("145");
            input.Add("000");
            Z z = new Z(input);
            byte i = z.POZ_Z_D;
            byte t = 1;
            Assert.AreEqual(t, i);
        }

        [TestMethod]
        public void POZ_Z_DTest3()
        {
            List<string> input = new List<string>();
            input.Add("0");
            Z z = new Z(input);
            byte i = z.POZ_Z_D;
            byte t = 0;
            Assert.AreEqual(t, i);
        }

        [TestMethod]
        public void CloneTest()
        {
            List<string> input = new List<string>();
            input.Add("1");
            input.Add("658");
            N z = new N(input);
            N zClone = z.Clone();
            Assert.AreEqual(zClone, z);
        }

        [TestMethod]
        public void CloneTestReference()
        {
            List<string> input = new List<string>();
            input.Add("1");
            input.Add("123");
            Z z = new Z(input);
            Z zClone = z.Clone();
            Assert.AreEqual(false, z == zClone);
        }

        [TestMethod]
        public void ZtoNTest1()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input.Add("123");
            Z z = new Z(input);
            N t = new N(input);
            N c = (N)z;
            Assert.AreEqual(t, c);
        }

        [TestMethod]
        public void ZtoNTest2()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("123");
            input.Add("120");
            Z z = new Z(input);
            N c = (N)z;
            Assert.AreEqual(null, c);
        }

        [TestMethod]
        public void ZtoQTest1()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            input.Add("123");
            input.Add("876");
            inputNumerator.Add("123");
            inputNumerator.Add("876");
            inputDenominator.Add("1");
            Z z = new Z(input);
            Q t = new Q(inputNumerator,inputDenominator);
            Q c = (Q)z;
            Assert.AreEqual(t, c);
        }

        [TestMethod]
        public void id()
        {
            List<string> input = new List<string>();
            input.Add("1");
            Z z = new Z(input);
            Assert.AreEqual(2, z.id);
        }

        [TestMethod]
        public void isDown1()
        {
            List<string> input = new List<string>();
            input.Add("1");
            Z z = new Z(input);
            Assert.AreEqual(true, z.isDown);
        }

        [TestMethod]
        public void isDown2()
        {
            List<string> input = new List<string>();
            input.Add("-");
            input.Add("1");
            Z z = new Z(input);
            Assert.AreEqual(false, z.isDown);
        }

        /*
        [TestMethod]
        public void RESTest()
        {
            List<string> input = new List<string>();
            input.Add("-");
            input.Add("2");
            input.Add("231");
            Z n = new Z(input);
            Assert.AreEqual(n, n.RES();
        }*/
    }
}
