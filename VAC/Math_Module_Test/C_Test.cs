using System;
using LMath;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Math_Module_Test
{
    [TestClass]
    public class C_Test
    {
        /*           Музей
         [TestMethod]
         public void MinusTest1()
         {
             List<string> inputNumeratorreal = new List<string>();
             List<string> inputDenominatorreal = new List<string>();
             List<string> inputNumeratorimage = new List<string>();
             List<string> inputDenominatorimage = new List<string>();
             List<string> inputNumeratorreal1 = new List<string>();
             List<string> inputDenominatorreal1 = new List<string>();
             List<string> inputNumeratorimage1 = new List<string>();
             List<string> inputDenominatorimage1 = new List<string>();
             List<string> outputNumeratorreal = new List<string>();
             List<string> outputDenominatorreal = new List<string>();
             List<string> outputNumeratorimage = new List<string>();
             List<string> outputDenominatorimage = new List<string>();
             inputNumeratorreal.Add("0");
             inputDenominatorreal.Add("1");
             inputDenominatorreal.Add("877");

             inputNumeratorimage.Add("234");
             inputDenominatorimage.Add("1");
             inputDenominatorimage.Add("302");

             inputNumeratorreal1.Add("-");
             inputNumeratorreal1.Add("234");
             inputDenominatorreal1.Add("1");
             inputDenominatorreal1.Add("302");

             inputNumeratorimage1.Add("234");
             inputDenominatorimage1.Add("1");
             inputDenominatorimage1.Add("302");

             outputNumeratorreal.Add("0");
             outputDenominatorreal.Add("1");
             outputDenominatorreal.Add("877");

             outputNumeratorimage.Add("234");
             outputDenominatorimage.Add("1");
             outputDenominatorimage.Add("302");
             Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
             Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
             Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
             Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
             Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
             Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
             C x = new C(xr, xi);
             C t = new C(tr, ti);
             C r = new C(rr, ri);
             Assert.AreEqual(r, x - t);
         }
         */

        [TestMethod]
        public void UnarMinusTestZero1()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("0");
            inputDenominatorreal.Add("1");

            inputNumeratorimage.Add("234");
            inputDenominatorimage.Add("1");
            inputDenominatorimage.Add("302");

            outputNumeratorreal.Add("0");
            outputDenominatorreal.Add("1");

            outputNumeratorimage.Add("-");
            outputNumeratorimage.Add("234");
            outputDenominatorimage.Add("1");
            outputDenominatorimage.Add("302");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C r = new C(rr, ri);
            Assert.AreEqual(r, -x);
        }

        [TestMethod]
        public void UnarMinusTestZero2()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("123");
            inputDenominatorreal.Add("1");
            inputDenominatorreal.Add("877");

            inputNumeratorimage.Add("0");
            inputDenominatorimage.Add("1");

            outputNumeratorreal.Add("-");
            outputNumeratorreal.Add("123");
            outputDenominatorreal.Add("1");
            outputDenominatorreal.Add("877");

            outputNumeratorimage.Add("0");
            outputDenominatorimage.Add("1");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C r = new C(rr, ri);
            Assert.AreEqual(r, -x);
        }

        [TestMethod]
        public void UnarMinusTest1()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("345");
            inputDenominatorreal.Add("1");
            inputDenominatorreal.Add("877");

            inputNumeratorimage.Add("234");
            inputDenominatorimage.Add("1");
            inputDenominatorimage.Add("302");

            outputNumeratorreal.Add("-");
            outputNumeratorreal.Add("345");
            outputDenominatorreal.Add("1");
            outputDenominatorreal.Add("877");

            outputNumeratorimage.Add("-");
            outputNumeratorimage.Add("234");
            outputDenominatorimage.Add("1");
            outputDenominatorimage.Add("302");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C r = new C(rr, ri);
            Assert.AreEqual(r, -x);
        }

        [TestMethod]
        public void PlusTestZero1()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> inputNumeratorreal1 = new List<string>();
            List<string> inputDenominatorreal1 = new List<string>();
            List<string> inputNumeratorimage1 = new List<string>();
            List<string> inputDenominatorimage1 = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("0");
            inputDenominatorreal.Add("1");

            inputNumeratorimage.Add("234");
            inputDenominatorimage.Add("1");
            inputDenominatorimage.Add("302");

            inputNumeratorreal1.Add("234");
            inputDenominatorreal1.Add("1");
            inputDenominatorreal1.Add("302");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("234");
            outputDenominatorreal.Add("1");
            outputDenominatorreal.Add("302");

            outputNumeratorimage.Add("468");
            outputDenominatorimage.Add("1");
            outputDenominatorimage.Add("302");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x + t);
        }

        [TestMethod]
        public void PlusTestZero2()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> inputNumeratorreal1 = new List<string>();
            List<string> inputDenominatorreal1 = new List<string>();
            List<string> inputNumeratorimage1 = new List<string>();
            List<string> inputDenominatorimage1 = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("0");
            inputDenominatorreal.Add("1");

            inputNumeratorimage.Add("0");
            inputDenominatorimage.Add("1");

            inputNumeratorreal1.Add("234");
            inputDenominatorreal1.Add("1");
            inputDenominatorreal1.Add("302");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("234");
            outputDenominatorreal.Add("1");
            outputDenominatorreal.Add("302");

            outputNumeratorimage.Add("234");
            outputDenominatorimage.Add("1");
            outputDenominatorimage.Add("302");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x + t);
        }

        [TestMethod]
        public void PlusTest1()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> inputNumeratorreal1 = new List<string>();
            List<string> inputDenominatorreal1 = new List<string>();
            List<string> inputNumeratorimage1 = new List<string>();
            List<string> inputDenominatorimage1 = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("123");
            inputDenominatorreal.Add("134");

            inputNumeratorimage.Add("236");
            inputDenominatorimage.Add("134");
            inputDenominatorimage.Add("302");

            inputNumeratorreal1.Add("234");
            inputDenominatorreal1.Add("1");
            inputDenominatorreal1.Add("302");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("31");
            outputNumeratorreal.Add("917");
            outputDenominatorreal.Add("29");
            outputDenominatorreal.Add("078");

            outputNumeratorimage.Add("377");
            outputNumeratorimage.Add("785");
            outputDenominatorimage.Add("2");
            outputDenominatorimage.Add("081");
            outputDenominatorimage.Add("681");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            C res = x + t;
            Assert.AreEqual(r, x + t);
        }

        [TestMethod]
        public void PlusTest2()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> inputNumeratorreal1 = new List<string>();
            List<string> inputDenominatorreal1 = new List<string>();
            List<string> inputNumeratorimage1 = new List<string>();
            List<string> inputDenominatorimage1 = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("123");
            inputDenominatorreal.Add("134");

            inputNumeratorimage.Add("-");
            inputNumeratorimage.Add("236");
            inputDenominatorimage.Add("134");
            inputDenominatorimage.Add("302");

            inputNumeratorreal1.Add("234");
            inputDenominatorreal1.Add("1");
            inputDenominatorreal1.Add("302");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("31");
            outputNumeratorreal.Add("917");
            outputDenominatorreal.Add("29");
            outputDenominatorreal.Add("078");

            outputNumeratorimage.Add("370");
            outputNumeratorimage.Add("469");
            outputDenominatorimage.Add("2");
            outputDenominatorimage.Add("081");
            outputDenominatorimage.Add("681");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x + t);
        }

        [TestMethod]
        public void PlusTest3()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> inputNumeratorreal1 = new List<string>();
            List<string> inputDenominatorreal1 = new List<string>();
            List<string> inputNumeratorimage1 = new List<string>();
            List<string> inputDenominatorimage1 = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("-");
            inputNumeratorreal.Add("123");
            inputDenominatorreal.Add("134");

            inputNumeratorimage.Add("236");
            inputDenominatorimage.Add("134");
            inputDenominatorimage.Add("302");

            inputNumeratorreal1.Add("234");
            inputDenominatorreal1.Add("1");
            inputDenominatorreal1.Add("302");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("-");
            outputNumeratorreal.Add("705");
            outputDenominatorreal.Add("868");

            outputNumeratorimage.Add("377");
            outputNumeratorimage.Add("785");
            outputDenominatorimage.Add("2");
            outputDenominatorimage.Add("081");
            outputDenominatorimage.Add("681");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            C res = x + t;
            Assert.AreEqual(r, res);
        }

        [TestMethod]
        public void PlusTest4()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> inputNumeratorreal1 = new List<string>();
            List<string> inputDenominatorreal1 = new List<string>();
            List<string> inputNumeratorimage1 = new List<string>();
            List<string> inputDenominatorimage1 = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("-");
            inputNumeratorreal.Add("123");
            inputDenominatorreal.Add("134");

            inputNumeratorimage.Add("-");
            inputNumeratorimage.Add("236");
            inputDenominatorimage.Add("134");
            inputDenominatorimage.Add("302");

            inputNumeratorreal1.Add("234");
            inputDenominatorreal1.Add("1");
            inputDenominatorreal1.Add("302");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("-");
            outputNumeratorreal.Add("705");
            outputDenominatorreal.Add("868");

            outputNumeratorimage.Add("370");
            outputNumeratorimage.Add("469");
            outputDenominatorimage.Add("2");
            outputDenominatorimage.Add("081");
            outputDenominatorimage.Add("681");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x + t);
        }
    }
}
