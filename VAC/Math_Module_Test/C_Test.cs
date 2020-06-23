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

        [TestMethod]
        public void MinusTestZero1()
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

            inputNumeratorimage1.Add("-");
            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("-");
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
            Assert.AreEqual(r, x - t);
        }

        [TestMethod]
        public void MinusTestZero2()
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

            inputNumeratorreal1.Add("-");
            inputNumeratorreal1.Add("234");
            inputDenominatorreal1.Add("1");
            inputDenominatorreal1.Add("302");

            inputNumeratorimage1.Add("-");
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
            Assert.AreEqual(r, x - t);
        }

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

            outputNumeratorreal.Add("705");
            outputDenominatorreal.Add("868");

            outputNumeratorimage.Add("-");
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
            Assert.AreEqual(r, x - t);
        }

        [TestMethod]
        public void MinusTest2()
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

            inputNumeratorreal1.Add("-");
            inputNumeratorreal1.Add("234");
            inputDenominatorreal1.Add("1");
            inputDenominatorreal1.Add("302");

            inputNumeratorimage1.Add("-");
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
            Assert.AreEqual(r, x - t);
        }

        [TestMethod]
        public void MinusTest3()
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

            inputNumeratorreal1.Add("-");
            inputNumeratorreal1.Add("234");
            inputDenominatorreal1.Add("1");
            inputDenominatorreal1.Add("302");

            inputNumeratorimage1.Add("-");
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
            C res = x - t;
            Assert.AreEqual(r, res);
        }

        [TestMethod]
        public void MinusTest4()
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

            inputNumeratorreal1.Add("-");
            inputNumeratorreal1.Add("234");
            inputDenominatorreal1.Add("1");
            inputDenominatorreal1.Add("302");

            inputNumeratorimage1.Add("-");
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
            Assert.AreEqual(r, x - t);
        }

        [TestMethod]
        public void MultiplicationTestZero1()
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

            inputNumeratorreal1.Add("0");
            inputDenominatorreal1.Add("1");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("-");
            outputNumeratorreal.Add("4");
            outputNumeratorreal.Add("602");
            outputDenominatorreal.Add("14");
            outputDenominatorreal.Add("571");
            outputDenominatorreal.Add("767");

            outputNumeratorimage.Add("4");
            outputNumeratorimage.Add("797");
            outputDenominatorimage.Add("29");
            outputDenominatorimage.Add("078");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x * t);
        }

        [TestMethod]
        public void MultiplicationTestZero2()
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

            inputNumeratorreal1.Add("0");
            inputDenominatorreal1.Add("1");

            inputNumeratorimage1.Add("0");
            inputDenominatorimage1.Add("1");

            outputNumeratorreal.Add("0");
            outputDenominatorreal.Add("1");

            outputNumeratorimage.Add("0");
            outputDenominatorimage.Add("1");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x * t);
        }

        [TestMethod]
        public void MultiplicationTest1()
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

            inputNumeratorreal1.Add("123");
            inputDenominatorreal1.Add("167");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("220");
            outputNumeratorreal.Add("353");
            outputNumeratorreal.Add("279");
            outputNumeratorreal.Add("387");
            outputDenominatorreal.Add("326");
            outputDenominatorreal.Add("087");
            outputDenominatorreal.Add("001");
            outputDenominatorreal.Add("926");

            outputNumeratorimage.Add("7");
            outputNumeratorimage.Add("745");
            outputNumeratorimage.Add("233");
            outputNumeratorimage.Add("863");
            outputDenominatorimage.Add("46");
            outputDenominatorimage.Add("583");
            outputDenominatorimage.Add("857");
            outputDenominatorimage.Add("418");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x * t);
        }

        [TestMethod]
        public void MultiplicationTest2()
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
            inputDenominatorreal.Add("134");

            inputNumeratorimage.Add("236");
            inputDenominatorimage.Add("134");
            inputDenominatorimage.Add("302");

            inputNumeratorreal1.Add("123");
            inputDenominatorreal1.Add("167");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("16");
            outputNumeratorreal.Add("767");
            outputNumeratorreal.Add("103");
            outputNumeratorreal.Add("341");
            outputDenominatorreal.Add("46");
            outputDenominatorreal.Add("630");
            outputDenominatorreal.Add("441");
            outputDenominatorreal.Add("275");
            outputDenominatorreal.Add("418");

            outputNumeratorimage.Add("5");
            outputNumeratorimage.Add("233");
            outputNumeratorimage.Add("568");
            outputNumeratorimage.Add("451");
            outputDenominatorimage.Add("3");
            outputDenominatorimage.Add("586");
            outputDenominatorimage.Add("957");
            outputDenominatorimage.Add("021");
            outputDenominatorimage.Add("186");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x * t);
        }

        [TestMethod]
        public void MultiplicationTest3()
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

            inputNumeratorreal1.Add("134");
            inputDenominatorreal1.Add("123");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("14");
            outputNumeratorreal.Add("567");
            outputNumeratorreal.Add("165");
            outputDenominatorreal.Add("14");
            outputDenominatorreal.Add("571");
            outputDenominatorreal.Add("767");

            outputNumeratorimage.Add("817");
            outputNumeratorimage.Add("978");
            outputNumeratorimage.Add("633");
            outputDenominatorimage.Add("4");
            outputDenominatorimage.Add("901");
            outputDenominatorimage.Add("466");
            outputDenominatorimage.Add("606");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x * t);
        }

        [TestMethod]
        public void DivTestZero1()
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

            inputNumeratorreal1.Add("0");
            inputDenominatorreal1.Add("1");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("3");
            outputNumeratorreal.Add("658");
            outputDenominatorreal.Add("374");
            outputDenominatorreal.Add("127");

            outputNumeratorimage.Add("-");
            outputNumeratorimage.Add("9");
            outputNumeratorimage.Add("897");
            outputDenominatorimage.Add("1");
            outputDenominatorimage.Add("742");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x / t);
        }

        [TestMethod]
        public void DivTestZero2()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> inputNumeratorreal1 = new List<string>();
            List<string> inputDenominatorreal1 = new List<string>();
            List<string> inputNumeratorimage1 = new List<string>();
            List<string> inputDenominatorimage1 = new List<string>();
            inputNumeratorreal.Add("123");
            inputDenominatorreal.Add("134");

            inputNumeratorimage.Add("236");
            inputDenominatorimage.Add("134");
            inputDenominatorimage.Add("302");

            inputNumeratorreal1.Add("0");
            inputDenominatorreal1.Add("1");

            inputNumeratorimage1.Add("0");
            inputDenominatorimage1.Add("1");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            Assert.AreEqual(null, x / t);
        }

        [TestMethod]
        public void DivTest1()
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

            inputNumeratorreal1.Add("123");
            inputDenominatorreal1.Add("167");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("380");
            outputNumeratorreal.Add("611");
            outputNumeratorreal.Add("739");
            outputNumeratorreal.Add("708");
            outputNumeratorreal.Add("441");
            outputDenominatorreal.Add("323");
            outputDenominatorreal.Add("434");
            outputDenominatorreal.Add("515");
            outputDenominatorreal.Add("362");
            outputDenominatorreal.Add("100");

            outputNumeratorimage.Add("-");
            outputNumeratorimage.Add("92");
            outputNumeratorimage.Add("103");
            outputNumeratorimage.Add("249");
            outputNumeratorimage.Add("185");
            outputNumeratorimage.Add("563");
            outputDenominatorimage.Add("323");
            outputDenominatorimage.Add("434");
            outputDenominatorimage.Add("515");
            outputDenominatorimage.Add("362");
            outputDenominatorimage.Add("100");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x / t);
        }

        [TestMethod]
        public void DivTest2()
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
            inputDenominatorreal.Add("134");

            inputNumeratorimage.Add("236");
            inputDenominatorimage.Add("134");
            inputDenominatorimage.Add("302");

            inputNumeratorreal1.Add("123");
            inputDenominatorreal1.Add("167");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("79");
            outputNumeratorreal.Add("761");
            outputNumeratorreal.Add("004");
            outputNumeratorreal.Add("216");
            outputNumeratorreal.Add("063");
            outputDenominatorreal.Add("46");
            outputDenominatorreal.Add("251");
            outputDenominatorreal.Add("135");
            outputDenominatorreal.Add("696");
            outputDenominatorreal.Add("780");
            outputDenominatorreal.Add("300");

            outputNumeratorimage.Add("6");
            outputNumeratorimage.Add("991");
            outputNumeratorimage.Add("140");
            outputNumeratorimage.Add("859");
            outputNumeratorimage.Add("807");
            outputDenominatorimage.Add("3");
            outputDenominatorimage.Add("556");
            outputDenominatorimage.Add("779");
            outputDenominatorimage.Add("668");
            outputDenominatorimage.Add("983");
            outputDenominatorimage.Add("100");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x / t);
        }

        [TestMethod]
        public void DivTest3()
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

            inputNumeratorreal1.Add("134");
            inputDenominatorreal1.Add("123");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("6");
            outputNumeratorreal.Add("836");
            outputNumeratorreal.Add("302");
            outputNumeratorreal.Add("484");
            outputNumeratorreal.Add("631");
            outputDenominatorreal.Add("8");
            outputDenominatorreal.Add("331");
            outputDenominatorreal.Add("916");
            outputDenominatorreal.Add("623");
            outputDenominatorreal.Add("749");

            outputNumeratorimage.Add("-");
            outputNumeratorimage.Add("149");
            outputNumeratorimage.Add("322");
            outputNumeratorimage.Add("381");
            outputNumeratorimage.Add("385");
            outputNumeratorimage.Add("485");
            outputDenominatorimage.Add("1");
            outputDenominatorimage.Add("116");
            outputDenominatorimage.Add("476");
            outputDenominatorimage.Add("827");
            outputDenominatorimage.Add("582");
            outputDenominatorimage.Add("366");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x / t);
        }

        [TestMethod]
        public void DegreeTestZero1()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> inputNumeratorDegree = new List<string>();
            List<string> inputDenominatorDegree = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("123");
            inputDenominatorreal.Add("134");

            inputNumeratorimage.Add("236");
            inputDenominatorimage.Add("134");
            inputDenominatorimage.Add("302");

            inputNumeratorDegree.Add("0");
            inputDenominatorDegree.Add("1");

            outputNumeratorreal.Add("1");
            outputDenominatorreal.Add("1");

            outputNumeratorimage.Add("1");
            outputDenominatorimage.Add("1");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q t = new Q(inputNumeratorDegree, inputDenominatorDegree);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x ^ t);
        }

        [TestMethod]
        public void DegreeTestZero2()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> inputNumeratorDegree = new List<string>();
            List<string> inputDenominatorDegree = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("0");
            inputDenominatorreal.Add("1");

            inputNumeratorimage.Add("236");
            inputDenominatorimage.Add("134");
            inputDenominatorimage.Add("302");

            inputNumeratorDegree.Add("2");
            inputDenominatorDegree.Add("1");

            outputNumeratorreal.Add("0");
            outputDenominatorreal.Add("1");

            outputNumeratorimage.Add("55");
            outputNumeratorimage.Add("696");
            outputDenominatorimage.Add("18");
            outputDenominatorimage.Add("037");
            outputDenominatorimage.Add("027");
            outputDenominatorimage.Add("204");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q t = new Q(inputNumeratorDegree, inputDenominatorDegree);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x ^ t);
        }

        [TestMethod]
        public void DegreeTest1()
        {
            List<string> inputNumeratorreal = new List<string>();
            List<string> inputDenominatorreal = new List<string>();
            List<string> inputNumeratorimage = new List<string>();
            List<string> inputDenominatorimage = new List<string>();
            List<string> inputNumeratorDegree = new List<string>();
            List<string> inputDenominatorDegree = new List<string>();
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            inputNumeratorreal.Add("123");
            inputDenominatorreal.Add("134");

            inputNumeratorimage.Add("236");
            inputDenominatorimage.Add("134");
            inputDenominatorimage.Add("302");

            inputNumeratorDegree.Add("2");
            inputDenominatorDegree.Add("1");

            outputNumeratorreal.Add("15");
            outputNumeratorreal.Add("129");
            outputDenominatorreal.Add("17");
            outputDenominatorreal.Add("956");

            outputNumeratorimage.Add("55");
            outputNumeratorimage.Add("696");
            outputDenominatorimage.Add("18");
            outputDenominatorimage.Add("037");
            outputDenominatorimage.Add("027");
            outputDenominatorimage.Add("204");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q t = new Q(inputNumeratorDegree, inputDenominatorDegree);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x ^ t);
        }

        [TestMethod]
        public void ModTest()
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

            inputNumeratorreal1.Add("134");
            inputDenominatorreal1.Add("123");

            inputNumeratorimage1.Add("234");
            inputDenominatorimage1.Add("1");
            inputDenominatorimage1.Add("302");

            outputNumeratorreal.Add("0");
            outputDenominatorreal.Add("1");

            outputNumeratorimage.Add("0");
            outputDenominatorimage.Add("1");
            Q xr = new Q(inputNumeratorreal, inputDenominatorreal);
            Q xi = new Q(inputNumeratorimage, inputDenominatorimage);
            Q tr = new Q(inputNumeratorreal1, inputDenominatorreal1);
            Q ti = new Q(inputNumeratorimage1, inputDenominatorimage1);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C x = new C(xr, xi);
            C t = new C(tr, ti);
            C r = new C(rr, ri);
            Assert.AreEqual(r, x.MOD(t));
        }

        [TestMethod]
        public void CreateTest1()
        {
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            string input = "(12/13)i-2";
            outputNumeratorreal.Add("-");
            outputNumeratorreal.Add("2");
            outputDenominatorreal.Add("1");

            outputNumeratorimage.Add("12");
            outputDenominatorimage.Add("13");
            C n = C.Create(input);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C r = new C(rr, ri);
            Assert.AreEqual(r, n);
        }

        [TestMethod]
        public void CreateTest2()
        {
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            string input = "(12/13)i";
            outputNumeratorreal.Add("0");
            outputDenominatorreal.Add("1");

            outputNumeratorimage.Add("12");
            outputDenominatorimage.Add("13");
            C n = C.Create(input);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C r = new C(rr, ri);
            Assert.AreEqual(r, n);
        }

        [TestMethod]
        public void CreateTest3()
        {
            List<string> outputNumeratorreal = new List<string>();
            List<string> outputDenominatorreal = new List<string>();
            List<string> outputNumeratorimage = new List<string>();
            List<string> outputDenominatorimage = new List<string>();
            string input = "12/13";
            outputNumeratorreal.Add("12");
            outputDenominatorreal.Add("13");

            outputNumeratorimage.Add("0");
            outputDenominatorimage.Add("1");
            C n = C.Create(input);
            Q rr = new Q(outputNumeratorreal, outputDenominatorreal);
            Q ri = new Q(outputNumeratorimage, outputDenominatorimage);
            C r = new C(rr, ri);
            Assert.AreEqual(r, n);
        }
    }
}
