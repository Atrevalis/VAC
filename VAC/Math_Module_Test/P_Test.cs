using System;
using LMath;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Math_Module_Test
{
    [TestClass]
    public class P_Test
    {
        [TestMethod]
        public void MODTest1()
        {
            string input = "-13x^5+x^2-100x^3+12x+32";
            string input2 = "x-1";
            string output = "x-69";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(null, input1.MOD(input3));
        }

        [TestMethod]
        public void MODTestZero1()
        {
            string input = "0";
            string input2 = "x-1";
            string output = "0";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(null, input1.MOD(input3));
        }

        [TestMethod]
        public void MODTestZero2()
        {
            string input = "-13x^5+(12i+2)x^2-100x^3+12ix+32";
            string input2 = "0";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            Assert.AreEqual(null, input1.MOD(input3));
        }

        [TestMethod]
        public void REMTest1()
        {
            string input = "-13x^5+x^2-100x^3+12x+32";
            string input2 = "x-1";
            string output = "-68";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, input1.REM(input3));
        }

        [TestMethod]
        public void REMTestZero1()
        {
            string input = "0";
            string input2 = "x-1";
            string output = "0";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, input1.REM(input3));
        }

        [TestMethod]
        public void REMTestZero2()
        {
            string input = "-13x^5+(12i+2)x^2-100x^3+12ix+32";
            string input2 = "0";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            Assert.AreEqual(null, input1.REM(input3));
        }

        [TestMethod]
        public void DIVTest1()
        {
            string input = "-13x^5+x^2-100x^3+x+32";
            string input2 = "x-1";
            string output = "-13x^4-13x^3-113x^2-112x^1-111";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, input1.DIV(input3));
        }

        [TestMethod]
        public void DIVTest2()
        {
            P input1 = P.Create("23x^2+1");
            P input2 = P.Create("x-1");
            P output1 = P.Create("23x+23");
            Assert.AreEqual(output1, input1.DIV(input2));
        }

        [TestMethod]
        public void DIVTestZero1()
        {
            P input1 = P.Create("0");
            P input2 = P.Create("23x^2+1");
            P output1 = P.Create("0");
            Assert.AreEqual(output1, input1.DIV(input2));
        }

        [TestMethod]
        public void DIVTestZero2()
        {
            P input1 = P.Create("23x^2+1");
            P input2 = P.Create("0");
            Assert.AreEqual(null, input1.DIV(input2));
        }

        [TestMethod]
        public void MULTest1()
        {
            string input = "-13x^5+(12i-5)x^2";
            string input2 = "x^3+6i-3";
            string output = "-13x^8+(34-66i)x^5+(-66i-57)x^2";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, input1*input3);
        }

        [TestMethod]
        public void MULTestZero1()
        {
            string input = "-13x^5+(12i-5)x^2";
            string input2 = "0";
            string output = "0";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, input1*input3);
        }

        [TestMethod]
        public void UnarMinusTest1()
        {
            string input = "-13x^5+(12i+2)x^2-100x^3+12ix+32";
            string output = "13x^5-(12i+2)x^2+100x^3-12ix-32";
            P input1 = P.Create(input);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, -input1);
        }

        [TestMethod]
        public void PlusTest1()
        {
            string input = "-13x^5+(12i-5)x^2";
            string input2 = "13x^5-(12i-4)x^2+12ix+32";
            string output = "-x^2+12ix+32";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            input1 = input1 + input3;
            Assert.AreEqual(output1, input1);
        }

        [TestMethod]
        public void PlusTestZero1()
        {
            string input = "-13x^5+(12i-5)x^2";
            string input2 = "0";
            string output = "-13x^5+(12i-5)x^2";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, input1+input3);
        }

        [TestMethod]
        public void MinusTest1()
        {
            string input = "-13x^5+(12i-5)x^2";
            string input2 = "13x^5-(12i-4)x^2+12ix+32";
            string output = "-26x^5+(24i-9)x^2-12ix-32";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, input1.SUB(input3));
        }

        [TestMethod]
        public void MinusTestZero1()
        {
            string input = "-13x^5+(12i-5)x^2";
            string input2 = "0";
            string output = "-13x^5+(12i-5)x^2";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, input1.SUB(input3));
        }

        [TestMethod]
        public void MinusTestZero2()
        {
            string input = "0";
            string input2 = "-13x^5+(12i-5)x^2";
            string output = "13x^5-(12i-5)x^2";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, input1.SUB(input3));
        }

        [TestMethod]
        public void PTTestPC()
        {
            P input1 = P.Create("12/3i+5");
            C output1 = C.Create("12/3i+5");
            C pc = (C)input1;
            Assert.AreEqual(output1, pc);
        }

        [TestMethod]
        public void PTTestCP()
        {
            C input1 = C.Create("12/3i+5");
            P output1 = P.Create("12/3i+5"); 
            P pc = input1;
            Assert.AreEqual(output1, pc);
        }

        [TestMethod]
        public void PTTestPListString()
        {
            P input= P.Create("12x^2+20x");
            List<string> output = new List<string>();
            List<string> result = new List<string>();
            output.Add("12");
            output.Add("x^");
            output.Add("2");
            output.Add("+");
            output.Add("20");
            output.Add("x");
            result = input;
            CollectionAssert.AreEqual(result, output);
        }

        [TestMethod]
        public void GFCTest1()
        {
            P input1 = P.Create("8x^2+4");
            P input2 = P.Create("2");
            P output1 = P.Create("2");
            Assert.AreEqual(output1, input1.GCF(input2));
        }

        [TestMethod]
        public void LCMTest1()
        {
            P input1 = P.Create("8x^2+4");
            P input2 = P.Create("2");
            P output1 = P.Create("8x^2+4");
            Assert.AreEqual(output1, input1.LCM(input2));
        }
    }
}

