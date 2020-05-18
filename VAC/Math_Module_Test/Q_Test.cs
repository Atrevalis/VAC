using Microsoft.VisualStudio.TestTools.UnitTesting;
using LMath;
using System.Collections.Generic;
using System;
namespace Math_Module_Test
{
    [TestClass]
    public class Q_Test
    {
        [TestMethod]
        public void MinusTestZero1()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("0");
            inputDenominator.Add("1");
            inputDenominator.Add("877");
            inputNumerator1.Add("234");
            inputDenominator1.Add("1");
            inputDenominator1.Add("302");
            outputNumerator.Add("-");
            outputNumerator.Add("234");
            outputDenominator.Add("1");
            outputDenominator.Add("302");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x - i);
        }

        [TestMethod]
        public void MinusTestZero2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("1");
            inputNumerator.Add("289");
            inputDenominator.Add("1");
            inputDenominator.Add("877");
            inputNumerator1.Add("0");
            inputDenominator1.Add("1");
            inputDenominator1.Add("302");
            outputNumerator.Add("1");
            outputNumerator.Add("289");
            outputDenominator.Add("1");
            outputDenominator.Add("877");
            Q x = new Q(inputNumerator1, inputDenominator1);
            Q i = new Q(inputNumerator, inputDenominator);
            Q t = new Q(outputNumerator, outputDenominator);
            Q res = i - x;
            Assert.AreEqual(t, res);
        }

        [TestMethod]
        public void MinusTest1()
		{
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("1");
            inputNumerator.Add("289");
            inputDenominator.Add("1");
            inputDenominator.Add("877");
            inputNumerator1.Add("248");
            inputNumerator1.Add("405");
            inputDenominator1.Add("1");
            inputDenominator1.Add("302");
            outputNumerator.Add("-");
            outputNumerator.Add("464");
            outputNumerator.Add("577");
            outputNumerator.Add("907");
            outputDenominator.Add("2");
            outputDenominator.Add("443");
            outputDenominator.Add("854");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t,x-i);
        }

        [TestMethod]
        public void MinusTest2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("1");
            inputNumerator.Add("289");
            inputDenominator.Add("1");
            inputDenominator.Add("877");
            inputNumerator1.Add("248");
            inputNumerator1.Add("405");
            inputDenominator1.Add("1");
            inputDenominator1.Add("302");
            outputNumerator.Add("464");
            outputNumerator.Add("577");
            outputNumerator.Add("907");
            outputDenominator.Add("2");
            outputDenominator.Add("443");
            outputDenominator.Add("854");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Q res = i + x;
            Assert.AreEqual(t, res);
        }

        [TestMethod]
        public void MinusTest3()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("1");
            inputNumerator.Add("289");
            inputDenominator.Add("1");
            inputDenominator.Add("877");
            inputNumerator1.Add("-");
            inputNumerator1.Add("248");
            inputNumerator1.Add("405");
            inputDenominator1.Add("1");
            inputDenominator1.Add("302");
            outputNumerator.Add("-");
            outputNumerator.Add("467");
            outputNumerator.Add("934");
            outputNumerator.Add("463");
            outputDenominator.Add("2");
            outputDenominator.Add("443");
            outputDenominator.Add("854");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Q res = x + i;
            Assert.AreEqual(t, res);
        }

        [TestMethod]
        public void MinusTestZero()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("1");
            inputNumerator.Add("289");
            inputDenominator.Add("1");
            inputDenominator.Add("877");
            inputNumerator1.Add("0");
            inputDenominator1.Add("1");
            inputDenominator1.Add("302");
            outputNumerator.Add("1");
            outputNumerator.Add("289");
            outputDenominator.Add("1");
            outputDenominator.Add("877");
            Q x = new Q(inputNumerator1, inputDenominator1);
            Q i = new Q(inputNumerator, inputDenominator);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x + i);
        }

        [TestMethod]
        public void PlusTest1()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("248");
            inputNumerator.Add("405");
            inputDenominator.Add("1");
            inputDenominator.Add("302");
            inputNumerator1.Add("1");
            inputNumerator1.Add("289");
            inputDenominator1.Add("1");
            inputDenominator1.Add("877");
            outputNumerator.Add("467");
            outputNumerator.Add("934");
            outputNumerator.Add("463");
            outputDenominator.Add("2");
            outputDenominator.Add("443");
            outputDenominator.Add("854");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x + i);
        }

        [TestMethod]
        public void PlusTest2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("248");
            inputNumerator.Add("405");
            inputDenominator.Add("1");
            inputDenominator.Add("302");
            inputNumerator1.Add("1");
            inputNumerator1.Add("289");
            inputDenominator1.Add("1");
            inputDenominator1.Add("877");
            outputNumerator.Add("-");
            outputNumerator.Add("464");
            outputNumerator.Add("577");
            outputNumerator.Add("907");
            outputDenominator.Add("2");
            outputDenominator.Add("443");
            outputDenominator.Add("854");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x + i);
        }

        [TestMethod]
        public void PlusTest3()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("248");
            inputNumerator.Add("405");
            inputDenominator.Add("1");
            inputDenominator.Add("302");
            inputNumerator1.Add("-");
            inputNumerator1.Add("1");
            inputNumerator1.Add("289");
            inputDenominator1.Add("1");
            inputDenominator1.Add("877");
            outputNumerator.Add("-");
            outputNumerator.Add("467");
            outputNumerator.Add("934");
            outputNumerator.Add("463");
            outputDenominator.Add("2");
            outputDenominator.Add("443");
            outputDenominator.Add("854");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x + i);
        }


        [TestMethod]
        public void UnarMinusTestZero()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            inputNumerator.Add("0");
            inputDenominator.Add("5");
            inputDenominator.Add("12345678");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = -x;
            Assert.AreEqual(-x,i);
        }

        [TestMethod]
        public void UnarMinusTest1()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("248");
            inputNumerator.Add("405");
            inputDenominator.Add("1");
            inputDenominator.Add("302");
            outputNumerator.Add("248");
            outputNumerator.Add("405");
            outputDenominator.Add("1");
            outputDenominator.Add("302");
            Q x = new Q(inputNumerator, inputDenominator);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, -x);
        }

        [TestMethod]
        public void UnarMinusTest2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("248");
            inputNumerator.Add("405");
            inputDenominator.Add("1");
            inputDenominator.Add("302");
            outputNumerator.Add("-");
            outputNumerator.Add("248");
            outputNumerator.Add("405");
            outputDenominator.Add("1");
            outputDenominator.Add("302");
            Q x = new Q(inputNumerator, inputDenominator);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, -x);
        }

        [TestMethod]
        public void MultiplicationTestZero1()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("0");
            inputDenominator.Add("1");
            inputNumerator1.Add("280");
            inputDenominator1.Add("330");
            outputNumerator.Add("0");
            outputDenominator.Add("1");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x * i);
        }

        [TestMethod]
        public void MultiplicationTestZero2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("0");
            inputDenominator.Add("1");
            inputNumerator1.Add("280");
            inputDenominator1.Add("330");
            outputNumerator.Add("0");
            outputDenominator.Add("1");
            Q x = new Q(inputNumerator1, inputDenominator1);
            Q i = new Q(inputNumerator, inputDenominator);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x * i);
        }

        [TestMethod]
        public void multiplicationTest1()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("835");
            inputDenominator.Add("151");
            inputNumerator1.Add("288");
            inputDenominator1.Add("335");
            outputNumerator.Add("48");
            outputNumerator.Add("096");
            outputDenominator.Add("10");
            outputDenominator.Add("117");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x * i);
        }

        [TestMethod]
        public void MultiplicationTest2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("835");
            inputDenominator.Add("151");
            inputNumerator1.Add("288");
            inputDenominator1.Add("335");
            outputNumerator.Add("-");
            outputNumerator.Add("48");
            outputNumerator.Add("096");
            outputDenominator.Add("10");
            outputDenominator.Add("117");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x * i);
        }

        [TestMethod]
        public void MultiplicationTest3()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("835");
            inputDenominator.Add("151");
            inputNumerator1.Add("-");
            inputNumerator1.Add("288");
            inputDenominator1.Add("335");
            outputNumerator.Add("-");
            outputNumerator.Add("48");
            outputNumerator.Add("096");
            outputDenominator.Add("10");
            outputDenominator.Add("117");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x * i);
        }

        [TestMethod]
        public void MultiplicationTest4()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("835");
            inputDenominator.Add("151");
            inputNumerator1.Add("-");
            inputNumerator1.Add("288");
            inputDenominator1.Add("335");
            outputNumerator.Add("48");
            outputNumerator.Add("096");
            outputDenominator.Add("10");
            outputDenominator.Add("117");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x * i);
        }

        [TestMethod]
        public void isDownTest()
		{
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("14");
            inputNumerator.Add("246");
            inputDenominator.Add("1");
            Q x = new Q(inputNumerator,inputDenominator);
            bool i = x.isDown;
            bool t = true;
            Assert.AreEqual(t,i);
		}

        [TestMethod]
        public void isDownTest1()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            inputNumerator.Add("14");
            inputNumerator.Add("247");
            inputDenominator.Add("12");
            Q x = new Q(inputNumerator, inputDenominator);
            bool i = x.isDown;
            bool t = false;
            Assert.AreEqual(t, i);
        }

       [TestMethod]
        public void POZ_Q_DTest1()
		{
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();

            inputNumerator.Add("1");
            inputNumerator.Add("123");
            inputDenominator.Add("12");
            inputDenominator.Add("123");
            Q x = new Q(inputNumerator,inputDenominator);
            byte t = 2;
            byte i = x.POZ_Q_D;
            Assert.AreEqual(t,i);
        }

        [TestMethod]
        public void POZ_Q_DTest2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("1");
            inputNumerator.Add("123");
            inputDenominator.Add("12");
            inputDenominator.Add("123");
            Q x = new Q(inputNumerator, inputDenominator);
            byte t = 1;
            byte i = x.POZ_Q_D;
            Assert.AreEqual(t, i);
        }

        [TestMethod]
        public void POZ_Q_DTest3()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            inputNumerator.Add("0");
            inputDenominator.Add("12");
            inputDenominator.Add("123");
            Q x = new Q(inputNumerator, inputDenominator);
            byte t = 0;
            byte i = x.POZ_Q_D;
            Assert.AreEqual(t, i);
        }

        [TestMethod]
        public void DivisionTestZero1()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("0");
            inputDenominator.Add("4");
            inputDenominator.Add("764");
            inputNumerator1.Add("2");
            inputDenominator1.Add("3");
            outputNumerator.Add("0");
            outputDenominator.Add("1");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x / i);
        }

        [TestMethod]
        public void DivisionTestZero2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            inputNumerator.Add("0");
            inputDenominator.Add("4");
            inputDenominator.Add("764");
            inputNumerator1.Add("2");
            inputDenominator1.Add("3");
            Q x = new Q(inputNumerator1, inputDenominator1);
            Q i = new Q(inputNumerator, inputDenominator);
            Assert.AreEqual(null, x / i);
        }

        [TestMethod]
        public void DivisionTest1() 
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();      
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("1");
            inputNumerator.Add("457");
            inputDenominator.Add("4");
            inputDenominator.Add("764");
            inputNumerator1.Add("2");
            inputDenominator1.Add("3");
            outputNumerator.Add("1");
            outputNumerator.Add("457");
            outputDenominator.Add("3");
            outputDenominator.Add("176");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x / i);
        }

        [TestMethod]
        public void DivisionTest2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();      
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("623");
            inputDenominator.Add("938");
            inputNumerator1.Add("281");
            inputDenominator1.Add("404");
            outputNumerator.Add("-");
            outputNumerator.Add("17");
            outputNumerator.Add("978");
            outputDenominator.Add("18");
            outputDenominator.Add("827");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x / i);
        }

        [TestMethod]
        public void DivisionTest3()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("623");
            inputDenominator.Add("938");
            inputNumerator1.Add("-");
            inputNumerator1.Add("281");
            inputDenominator1.Add("404");
            outputNumerator.Add("17");
            outputNumerator.Add("978");
            outputDenominator.Add("18");
            outputDenominator.Add("827");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Q res = x / i;
            Assert.AreEqual(t, res);
        }

        [TestMethod]

        public void RemainderTestZero1()
		{
            List<string> inputNumerator = new List<string>();     
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> output = new List<string>();
            inputNumerator.Add("12");
            inputDenominator.Add("51");
            inputNumerator1.Add("1");
            inputDenominator1.Add("5");
            output.Add("0");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            N t = new N(output);
            Assert.AreEqual(t, x % i);
        }

        [TestMethod]
        public void CloneTest()
		{
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> outputNumerator = new List<string>();   
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("1");
            inputNumerator.Add("246");
            inputDenominator.Add("1");
            inputDenominator.Add("867");
            Q x = new Q(inputNumerator,inputDenominator);
            Q i = x.Clone();
            Q t = new Q(inputNumerator,inputDenominator);
            Assert.AreEqual(t,i);
        }

        [TestMethod]
        public void QtoZTest1()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> outputNumerator = new List<string>();       
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("1");
            inputNumerator.Add("246");
            inputDenominator.Add("1");
            inputDenominator.Add("867");
            Q x = new Q(inputNumerator, inputDenominator);
            Q i = x.Clone();
            Q t = new Q(inputNumerator, inputDenominator);
            Assert.AreEqual(t, x);
        }

        [TestMethod]
        public void QinStringTest()
		{
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> output = new List<string>();
            inputNumerator.Add("1");
            inputNumerator.Add("246");
            inputDenominator.Add("1");
            inputDenominator.Add("867");
            output.Add("1");
            output.Add("246");
            output.Add("/");
            output.Add("1");
            output.Add("867");
            Q x = new Q(inputNumerator, inputDenominator);
            List<string> i = x;
            CollectionAssert.AreEqual(output,i);
        }

        [TestMethod]
        public void DegreeTestZero1()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> input = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("0");
            inputDenominator.Add("938");
            input.Add("21");
            outputNumerator.Add("0");
            outputDenominator.Add("1");
            Q x = new Q(inputNumerator, inputDenominator);
            Z i = new Z(input);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x ^ i);
        }

        [TestMethod]
        public void DegreeTestZero2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> input = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("237");
            inputDenominator.Add("938");
            input.Add("0");
            outputNumerator.Add("1");
            outputDenominator.Add("1");
            Q x = new Q(inputNumerator, inputDenominator);
            Z i = new Z(input);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x ^ i);
        }

        [TestMethod]
        public void DegreeTest1()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> input = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("237");
            inputDenominator.Add("938");
            input.Add("3");
            outputNumerator.Add("13");
            outputNumerator.Add("312");
            outputNumerator.Add("053");
            outputDenominator.Add("825");
            outputDenominator.Add("293");
            outputDenominator.Add("672");
            Q x = new Q(inputNumerator, inputDenominator);
            Z i = new Z(input);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x ^ i);
        }

        [TestMethod]
        public void DegreeTest2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> input = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("237");
            inputDenominator.Add("938");
            input.Add("3");
            outputNumerator.Add("-");
            outputNumerator.Add("13");
            outputNumerator.Add("312");
            outputNumerator.Add("053");
            outputDenominator.Add("825");
            outputDenominator.Add("293");
            outputDenominator.Add("672");
            Q x = new Q(inputNumerator, inputDenominator);
            Z i = new Z(input);
            Q t = new Q(outputNumerator, outputDenominator);
            Q res = x ^ i;
            Assert.AreEqual(t, res);
        }

        [TestMethod]
        public void DegreeTest3()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> input = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("-");
            inputNumerator.Add("237");
            inputDenominator.Add("938");
            input.Add("4");
            outputNumerator.Add("3");
            outputNumerator.Add("154");
            outputNumerator.Add("956");
            outputNumerator.Add("561");
            outputDenominator.Add("774");
            outputDenominator.Add("125");
            outputDenominator.Add("464");
            outputDenominator.Add("336");
            Q x = new Q(inputNumerator, inputDenominator);
            Z i = new Z(input);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x ^ i);
        }

        /*
        [TestMethod]
        public void RESTest()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            inputNumerator.Add("1");
            inputNumerator.Add("246");
            inputDenominator.Add("1");
            inputDenominator.Add("867");
            Q x = new Q(inputNumerator, inputDenominator);
            Assert.AreEqual(x, x.RES();
        }*/

        /*
                [TestMethod]
                public void RED_Q_Q1()
                {
                    List<string> inputNumerator = new List<string>();//
                    List<string> inputDenominator = new List<string>();//
                    List<string> outputNumerator = new List<string>();//
                    List<string> outputDenominator = new List<string>();//

                    inputNumerator.Add("6");
                    inputDenominator.Add("9");

                    outputNumerator.Add("2");
                    outputDenominator.Add("3");
                    Q x = new Q(inputNumerator, inputDenominator);
                    Q t = new Q(outputNumerator, outputDenominator);
                    x.RED_Q_Q();
                    Assert.AreEqual(t, x);
                }

                [TestMethod]
                public void RED_Q_Q2()
                {
                    List<string> inputNumerator = new List<string>();// 371 63026560
                    List<string> inputDenominator = new List<string>();// 538 26730400
                    List<string> outputNumerator = new List<string>();// 2 32268916
                    List<string> outputDenominator = new List<string>();//  3 36417065

                    inputNumerator.Add("371");
                    inputNumerator.Add("63026560");
                    inputDenominator.Add("3");
                    inputDenominator.Add("36417065");


                    outputNumerator.Add("74");
                    outputNumerator.Add("32605312");
                    outputDenominator.Add("67283413");

                    Q x = new Q(inputNumerator, inputDenominator);
                    Q t = new Q(outputNumerator, outputDenominator);
                    x.RED_Q_Q();
                    Assert.AreEqual(t, x);
                }


                [TestMethod]
                public void RED_Q_Q3()
                {
                    List<string> inputNumerator = new List<string>();// 371 63026560
                    List<string> inputDenominator = new List<string>();// 538 26730400
                    List<string> outputNumerator = new List<string>();// 26 37876108
                    List<string> outputDenominator = new List<string>();//  30 30103650

                    inputNumerator.Add("26");
                    inputNumerator.Add("37876108");
                    inputDenominator.Add("30");
                    inputDenominator.Add("30103650");

                    outputNumerator.Add("62806574");
                    outputDenominator.Add("72145325");

                    Q x = new Q(inputNumerator, inputDenominator);
                    Q t = new Q(outputNumerator, outputDenominator);
                    x.RED_Q_Q();
                    Assert.AreEqual(t, x);
                }

                [TestMethod]
                public void RED_Q_Q4()
                {
                    List<string> inputNumerator = new List<string>();// 371 63026560
                    List<string> inputDenominator = new List<string>();// 538 26730400
                    List<string> outputNumerator = new List<string>();// 2 32268916       
                    List<string> outputDenominator = new List<string>();//  3 36417065     

                    inputNumerator.Add("371");
                    inputNumerator.Add("63026560");
                    inputDenominator.Add("2");
                    inputDenominator.Add("32268916");

                    outputNumerator.Add("160");
                    outputDenominator.Add("1");

                    Q x = new Q(inputNumerator, inputDenominator);
                    Q t = new Q(outputNumerator, outputDenominator);
                    x.RED_Q_Q();
                    Assert.AreEqual(t, x);
                }
                */
        /*
        [TestMethod]
        public void space()
        {
             List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();

            inputNumerator.Add("14");
            inputNumerator.Add("24684684");
            inputDenominator.Add("1");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("23");
            inputNumerator1.Add("24989000");
            inputDenominator1.Add("12");
            inputDenominator1.Add("23456008");

            outputNumerator.Add("34019073");
            outputNumerator.Add("17645193");
            outputDenominator.Add("3569923");
            outputDenominator.Add("77683021");

            AssertAreEqual(,);
        }*/

        /*
    [TestMethod]
    public void plusTest1_for_P()
    {
        List<List<string>[]> input = new List<List<string>[]>();
        List<List<string>[]> input1 = new List<List<string>[]>();
        List<List<string>[]> output = new List<List<string>[]>();

        input.Add(new List<string>[2]);
        input[0][0] = new List<string>();
        input[0][0].Add("1");
        input[0][1] = new List<string>();
        input[0][1].Add("4");
        input.Add(new List<string>[2]);
        input[1][0] = new List<string>();
        input[1][0].Add("-8");
        input[1][1] = new List<string>();
        input[1][1].Add("3");
        input.Add(new List<string>[2]);
        input[2][0] = new List<string>();
        input[2][0].Add("18");
        input[2][1] = new List<string>();
        input[2][1].Add("2");
        input.Add(new List<string>[2]);
        input[3][0] = new List<string>();
        input[3][0].Add("-27");
        input[3][1] = new List<string>();
        input[3][1].Add("0");

        input1.Add(new List<string>[2]);
        input1[0][0] = new List<string>();
        input1[0][0].Add("-3");
        input1[0][1] = new List<string>();
        input1[0][1].Add("4");
        input1.Add(new List<string>[2]);
        input1[1][0] = new List<string>();
        input1[1][0].Add("8");
        input1[1][1] = new List<string>();
        input1[1][1].Add("3");
        input.Add(new List<string>[2]);
        input[2][0] = new List<string>();
        input[2][0].Add("2");
        input[2][1] = new List<string>();
        input[2][1].Add("2");
        input1[3][0] = new List<string>();
        input1[3][0].Add("-27");
        input1[3][1] = new List<string>();
        input1[3][1].Add("1");

        output.Add(new List<string>[2]);
        output[0][0] = new List<string>();
        output[0][0].Add("-2");
        output[0][1] = new List<string>();
        output[0][1].Add("4");
        output.Add(new List<string>[2]);
        output[1][0] = new List<string>();
        output[1][0].Add("20");
        output[1][1] = new List<string>();
        output[1][1].Add("2");
        output.Add(new List<string>[2]);
        output[2][0] = new List<string>();
        output[2][0].Add("-27");
        output[2][1] = new List<string>();
        output[2][1].Add("1");
        output[3][0] = new List<string>();
        output[3][0].Add("-27");
        output[3][1] = new List<string>();
        output[3][1].Add("0");

        P x = new P(input);
        P i = new P(input1);
        P t = new P(output);

        Assert.AreEqual(t, x + i);
    }
    [TestMethod]
    public void plusTest2_for_P()
    {
        List<List<string>[]> input = new List<List<string>[]>();
        List<List<string>[]> input1 = new List<List<string>[]>();
        List<List<string>[]> output = new List<List<string>[]>();

        input.Add(new List<string>[2]);
        input[0][0] = new List<string>();
        input[0][0].Add("1");
        input[0][1] = new List<string>();
        input[0][1].Add("4");
        input.Add(new List<string>[2]);
        input[1][0] = new List<string>();
        input[1][0].Add("-8");
        input[1][1] = new List<string>();
        input[1][1].Add("3");
        input.Add(new List<string>[2]);
        input[2][0] = new List<string>();
        input[2][0].Add("18");
        input[2][1] = new List<string>();
        input[2][1].Add("2");

        input1.Add(new List<string>[2]);
        input1[0][0] = new List<string>();
        input1[0][0].Add("3");
        input1[0][1] = new List<string>();
        input1[0][1].Add("4");
        input1.Add(new List<string>[2]);
        input1[1][0] = new List<string>();
        input1[1][0].Add("-8");
        input1[1][1] = new List<string>();
        input1[1][1].Add("3");


        output.Add(new List<string>[2]);
        output[0][0] = new List<string>();
        output[0][0].Add("4");
        output[0][1] = new List<string>();
        output[0][1].Add("4");
        output.Add(new List<string>[2]);
        output[1][0] = new List<string>();
        output[1][0].Add("-16");
        output[1][1] = new List<string>();
        output[1][1].Add("3");
        output.Add(new List<string>[2]);
        output[2][0] = new List<string>();
        output[2][0].Add("18");
        output[2][1] = new List<string>();
        output[2][1].Add("2");

        P x = new P(input);
        P i = new P(input1);
        P t = new P(output);

        Assert.AreEqual(t, x + i);

    }
    [TestMethod]
    public void plusTest3_for_P()
    {
        List<M> input = new List<M>();

        M four;
        List<string> fourNum = new List<string>();
        fourNum.Add("2");
        List<string> fourDen = new List<string>();
        fourDen.Add("3");
        four.coef = new Q(fourNum, fourDen);
        List<string> fourDegree = new List<string>();
        fourDegree.Add("4");
        four.degree = new N(fourDegree);
        input.Add(four);

        M two;
        List<string> twoNum = new List<string>();
        twoNum.Add("2");
        List<string> twoDen = new List<string>();
        twoDen.Add("1");
        two.coef = new Q(twoNum, twoDen);
        List<string> twoDegree = new List<string>();
        twoDegree.Add("2");
        two.degree = new N(twoDegree);
        input.Add(two);

        List<M> input1 = new List<M>();

        M four1;
        List<string> four1Num = new List<string>();
        four1Num.Add("3");
        List<string> four1Den = new List<string>();
        four1Den.Add("2");
        four1.coef = new Q(four1Num, four1Den);
        List<string> four1Degree = new List<string>();
        four1Degree.Add("4");
        four1.degree = new N(four1Degree);
        input1.Add(four1);

        M three1;
        List<string> three1Num = new List<string>();
        three1Num.Add("1");
        three1Num.Add("12345678");
        List<string> three1Den = new List<string>();
        three1Den.Add("1");
        three1.coef = new Q(three1Num, three1Den);
        List<string> three1Degree = new List<string>();
        three1Degree.Add("3");
        three1.degree = new N(three1Degree);
        input1.Add(three1);

        List<M> output = new List<M>();

        M four3;
        List<string> four3Num = new List<string>();
        four3Num.Add("13");
        List<string> four3Den = new List<string>();
        four3Den.Add("6");
        four3.coef = new Q(four3Num, four3Den);
        List<string> four3Degree = new List<string>();
        four3Degree.Add("4");
        four3.degree = new N(four3Degree);
        output.Add(four3);

        M two3;
        List<string> two3Num = new List<string>();
        two3Num.Add("2");
        List<string> two3Den = new List<string>();
        two3Den.Add("1");
        two3.coef = new Q(two3Num, two3Den);
        List<string> two3Degree = new List<string>();
        two3Degree.Add("2");
        two3.degree = new N(two3Degree);
        output.Add(two3);

        P x = new P(input);
        P i = new P(input1);
        P t = new P(input1);

        Assert.AreEqual(t, x + i);


    }
    [TestMethod]
    public void plusTestEx_for_P()
    {
        List<List<string>[]> input = new List<List<string>[]>();
        List<List<string>[]> input1 = new List<List<string>[]>();

        input.Add(new List<string>[2]);
        input[0][0] = new List<string>();
        input[0][0].Add("1");
        input[0][1] = new List<string>();
        input[0][1].Add("4");
        input.Add(new List<string>[2]);
        input[1][0] = new List<string>();
        input[1][0].Add("-8");
        input[1][1] = new List<string>();
        input[1][1].Add("3");
        input.Add(new List<string>[2]);
        input[2][0] = new List<string>();
        input[2][0].Add("18");
        input[2][1] = new List<string>();
        input[2][1].Add("2");

        input1.Add(new List<string>[2]);
        input1[0][0] = new List<string>();
        input1[0][0].Add("3");
        input1[0][1] = new List<string>();
        input1[0][1].Add("4");
        input1.Add(new List<string>[2]);
        input1[1][0] = new List<string>();
        input1[1][0].Add("-8");
        input1[1][1] = new List<string>();
        input1[1][1].Add("3");




        P x = new P(input);
        P i = new P(input1);

        Assert.AreNotEqual(null, x + i);

    }

    [TestMethod]
    public void minusTest1_for_P()
    {
        List<List<string>[]> input = new List<List<string>[]>();
        List<List<string>[]> input1 = new List<List<string>[]>();
        List<List<string>[]> output = new List<List<string>[]>();

        input.Add(new List<string>[2]);
        input[0][0] = new List<string>();
        input[0][0].Add("1");
        input[0][1] = new List<string>();
        input[0][1].Add("4");
        input.Add(new List<string>[2]);
        input[1][0] = new List<string>();
        input[1][0].Add("-8");
        input[1][1] = new List<string>();
        input[1][1].Add("3");
        input.Add(new List<string>[2]);
        input[2][0] = new List<string>();
        input[2][0].Add("18");
        input[2][1] = new List<string>();
        input[2][1].Add("2");
        input.Add(new List<string>[2]);
        input[3][0] = new List<string>();
        input[3][0].Add("27");
        input[3][1] = new List<string>();
        input[3][1].Add("0");

        input1.Add(new List<string>[2]);
        input1[0][0] = new List<string>();
        input1[0][0].Add("-3");
        input1[0][1] = new List<string>();
        input1[0][1].Add("4");
        input1.Add(new List<string>[2]);
        input1[1][0] = new List<string>();
        input1[1][0].Add("8");
        input1[1][1] = new List<string>();
        input1[1][1].Add("3");
        input.Add(new List<string>[2]);
        input[2][0] = new List<string>();
        input[2][0].Add("18");
        input[2][1] = new List<string>();
        input[2][1].Add("2");
        input1[3][0] = new List<string>();
        input1[3][0].Add("26");
        input1[3][1] = new List<string>();
        input1[3][1].Add("1");

        output.Add(new List<string>[2]);
        output[0][0] = new List<string>();
        output[0][0].Add("4");
        output[0][1] = new List<string>();
        output[0][1].Add("4");
        output.Add(new List<string>[2]);
        output[1][0] = new List<string>();
        output[1][0].Add("-16");
        output[1][1] = new List<string>();
        output[1][1].Add("3");
        output.Add(new List<string>[2]);
        output[2][0] = new List<string>();
        output[2][0].Add("-26");
        output[2][1] = new List<string>();
        output[2][1].Add("1");
        output[3][0] = new List<string>();
        output[3][0].Add("27");
        output[3][1] = new List<string>();
        output[3][1].Add("0");

        P x = new P(input);
        P i = new P(input1);
        P t = new P(output);

        Assert.AreEqual(t, x + i);
    }
    [TestMethod]
    public void minusTest2_for_P()//вроде недоделка
    {

        List<M> input = new List<M>();

        M four;
        List<string> fourNum = new List<string>();
        fourNum.Add("23");
        List<string> fourDen = new List<string>();
        fourDen.Add("15");
        four.coef = new Q(fourNum, fourDen);
        List<string> fourDegree = new List<string>();
        fourDegree.Add("4");
        four.degree = new N(fourDegree);
        input.Add(four);

        M one;
        List<string> oneNum = new List<string>();
        oneNum.Add("2");
        List<string> oneDen = new List<string>();
        oneDen.Add("1");
        one.coef = new Q(oneNum, oneDen);
        List<string> oneDegree = new List<string>();
        oneDegree.Add("2");
        one.degree = new N(oneDegree);
        input.Add(one);

        List<M> input1 = new List<M>();

        M four1;
        List<string> four1Num = new List<string>();
        four1Num.Add("3");
        List<string> four1Den = new List<string>();
        four1Den.Add("2");
        four1.coef = new Q(four1Num, four1Den);
        List<string> four1Degree = new List<string>();
        four1Degree.Add("4");
        four1.degree = new N(four1Degree);
        input1.Add(four1);

        M three1;
        List<string> three1Num = new List<string>();
        three1Num.Add("1");
        three1Num.Add("12345678");
        List<string> three1Den = new List<string>();
        three1Den.Add("1");
        three1.coef = new Q(three1Num, three1Den);
        List<string> three1Degree = new List<string>();
        three1Degree.Add("3");
        three1.degree = new N(three1Degree);
        input1.Add(three1);

        List<M> output = new List<M>();

        M four3;
        List<string> four3Num = new List<string>();
        four3Num.Add("13");
        List<string> four3Den = new List<string>();
        four3Den.Add("6");
        four3.coef = new Q(four3Num, four3Den);
        List<string> four3Degree = new List<string>();
        four3Degree.Add("4");
        four3.degree = new N(four3Degree);
        output.Add(four3);

        M two3;
        List<string> two3Num = new List<string>();
        two3Num.Add("2");
        List<string> two3Den = new List<string>();
        two3Den.Add("1");
        two3.coef = new Q(two3Num, two3Den);
        List<string> two3Degree = new List<string>();
        two3Degree.Add("2");
        two3.degree = new N(two3Degree);
        output.Add(two3);

        P x = new P(input);
        P i = new P(input1);
        P t = new P(input1);

        Assert.AreEqual(t, x + i);
    }
    [TestMethod]
    public void minusTestEx_for_P()
    {


    }
    public void NMR_P_PTest_for_P()
    {
        List<List<string>[]> first = new List<List<string>[]>();
        first.Add(new List<string>[2]);
        first[0][0] = new List<string>();
        first[0][0].Add("1");
        first[0][1] = new List<string>();
        first[0][1].Add("4");
        first.Add(new List<string>[2]);
        first[1][0] = new List<string>();
        first[1][0].Add("-8");
        first[1][1] = new List<string>();
        first[1][1].Add("3");
        first.Add(new List<string>[2]);
        first[2][0] = new List<string>();
        first[2][0].Add("18");
        first[2][1] = new List<string>();
        first[2][1].Add("2");
        first.Add(new List<string>[2]);
        first[3][0] = new List<string>();
        first[3][0].Add("-27");
        first[3][1] = new List<string>();
        first[3][1].Add("0");
        List<List<string>[]> second = new List<List<string>[]>();
        second.Add(new List<string>[2]);
        second[0][0] = new List<string>();
        second[0][0].Add("1");
        second[0][1] = new List<string>();
        second[0][1].Add("2");
        second.Add(new List<string>[2]);
        second[1][0] = new List<string>();
        second[1][0].Add("-2");
        second[1][1] = new List<string>();
        second[1][1].Add("1");
        second.Add(new List<string>[2]);
        second[2][0] = new List<string>();
        second[2][0].Add("-3");
        second[2][1] = new List<string>();
        second[2][1].Add("0");
        //P firstP = new P(first);
        // P secondP = new P(second);
        //Assert.AreEqual(firstP.NMR_P_P(), secondP);
    }
    */

    }
}