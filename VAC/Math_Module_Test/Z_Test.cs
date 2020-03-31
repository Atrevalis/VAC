using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math_Module;
using System.Collections.Generic;
using System;
namespace Math_Module_Test
{
    [TestClass]
    public class Z_Test
    {
        [TestMethod]
        public void minusUnarEx()   
		{
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("10000000");
            input1.Add("-");
            input1.Add("12");
            input1.Add("10000000");
            Z X = new Z(input);
            Z I = -X;
            Z T = new Z(input);
            Assert.AreEqual(T, I);
        }
        [TestMethod]
        public void MinusUnarMinusTest()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("10000000");
            input.Add("00000000");
            input1.Add("-");
            input1.Add("12");
            input1.Add("10000000");
            output.Add("12");
            output.Add("10000012");
            output.Add("10000000");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X - I);

        }
        [TestMethod]
        public void PlusUnarMinusTest()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("10000000");
            input1.Add("-");
            input1.Add("10000000");
            output.Add("12");
            output.Add("00000000");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X + I);

        }
       

        [TestMethod]
        public void plusTest1()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("10000000");
            output.Add("12");
            output.Add("10000012");
            output.Add("10000000");
            N x = new N(input);
            input.Add("00000000");
            N i = new N(input);
            N t = new N(output);
            Z X = new Z(x);
            Z I = new Z(i);
            Z T = new Z(t);
            Assert.AreEqual(T, X + I);

        }

        [TestMethod]
        public void plusTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("10000000");
            input1.Add("-");
            input1.Add("10000000");
            output.Add("12");
            output.Add("00000000");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X + I);

        }
        [TestMethod]
        public void plusTestEx()
        {
            List<string> input = new List<string>();
            input.Add("12");
            input.Add("10000000");
            Z X = new Z(input);
            Z I = new Z(input);
            Assert.AreNotEqual(null, X + I);
        }

        [TestMethod]
        public void ZConvertToStringTest()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("10000000");
   
            Z X = new Z(input);
            output = (List<string>)X;
            CollectionAssert.AreEqual(output,input);
        }

        [TestMethod]
        public void ZConvertToStringTestEx()
        { 
            List<string> input = new List<string>();
            input.Add("12");
            input.Add("00000009");
            Z z = new Z(input);
            CollectionAssert.AreNotEqual(null, (List<string>)z);
        }

        [TestMethod]
        public void isDownTest()
		{
            List<string> input = new List<string>();
            input.Add("12");
            input.Add("00000009");
            Z z = new Z(input);
            N n = new N(input);
            N ZtoN = z.isDown;
            Assert.AreEqual(n,ZtoN);

        }

        [TestMethod]
        public void isDownTestEx()
        {
            List<string> input = new List<string>();
            input.Add("12");
            input.Add("00000009");
            Z z = new Z(input);
            N ZtoN = z.isDown;
            Assert.AreNotEqual(null,ZtoN);
        }


    }
}
