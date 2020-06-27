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
            string input = "-13x^5+(12i+2)x^2-100x^3+12ix+32";
            string input2 = "x-1";
            string output = "143";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, input1.MOD(input3));
        }

        [TestMethod]
        public void REMTest1()
        {
            string input = "-13x^5+(12i+2)x^2-100x^3+12ix+32";
            string input2 = "x-1";
            string output = "143";
            P input1 = P.Create(input);
            P input3 = P.Create(input2);
            P output1 = P.Create(output);
            Assert.AreEqual(output1, input1.REM(input3));
        }
    }
}
