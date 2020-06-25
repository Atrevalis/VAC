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
        public void MinusTest1()
        {
            string input;
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            input = "";
            outputNumeratorreal.Add("0");
            outputDenominatorreal.Add("1");
            outputDenominatorreal.Add("877");

            outputNumeratorimage.Add("234");
            outputDenominatorimage.Add("1");
            outputDenominatorimage.Add("302");
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C r = new C(rr, ri);
            Assert.AreEqual(r, null);
        }
    }
}
