using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math_Module;
using System.Collections.Generic;
using System;
namespace Math_Module_Test
{
    [TestClass]
    public class Q_Test
    {

        [TestMethod]
        public void minusTest1()
		{
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();

            inputNumerator.Add("2");
            inputNumerator.Add("12345678");
            inputDenominator.Add("5");
            inputDenominator.Add("34444444");

            inputNumerator1.Add("1");
            inputNumerator1.Add("74668888");
            inputDenominator1.Add("6");
            inputDenominator1.Add("75555555");

            outputNumerator.Add("83500809");
            outputDenominator.Add("36980503");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t,x-i);
        }
        [TestMethod]
        public void minusTest2()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();
            inputNumerator.Add("4");
            inputNumerator.Add("24684684");
            inputDenominator.Add("10");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("-");
            inputNumerator1.Add("89000");
            inputDenominator1.Add("3");
            inputDenominator1.Add("23456008");

            outputNumerator.Add("8591470");
            outputNumerator.Add("806920217");
            outputDenominator.Add("2");
            outputDenominator.Add("19696511");
            outputDenominator.Add("69820839");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x - i);
        }
        [TestMethod]
        public void minusTest3()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();

            inputNumerator.Add("-");
            inputNumerator.Add("4");
            inputNumerator.Add("24684684");
            inputDenominator.Add("10");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("-");
            inputNumerator1.Add("89000");
            inputDenominator1.Add("3");
            inputDenominator1.Add("23456008");

            outputNumerator.Add("-");
            outputNumerator.Add("85793807");
            outputNumerator.Add("61252467");
            outputDenominator.Add("2");
            outputDenominator.Add("19696511");
            outputDenominator.Add("69820839");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x - i);
        }
        [TestMethod]
        public void minusTest4()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> inputNumerator1 = new List<string>();
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();

            inputNumerator.Add("14");
            inputNumerator.Add("24684684");
            inputDenominator.Add("1");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("23");
            inputNumerator1.Add("24989000");
            inputDenominator1.Add("12");
            inputDenominator1.Add("23456008");

            outputNumerator.Add("8");
            outputNumerator.Add("18035868");
            outputNumerator.Add("12364967");
            outputDenominator.Add("14");
            outputDenominator.Add("42796951");
            outputDenominator.Add("07320839");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x - i);
        }
        [TestMethod]
        public void minusTestEx()
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

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            
            Assert.AreNotEqual(null, x - i);
        }
        [TestMethod]
        public void plusTest1()
        {
            List<string> inputNumerator = new List<string>();//   212345678
            List<string> inputDenominator = new List<string>();// 534444444
            List<string> inputNumerator1 = new List<string>();//  174668888
            List<string> inputDenominator1 = new List<string>();//675555555
            List<string> outputNumerator = new List<string>();//   49333774 80924991
            List<string> outputDenominator = new List<string>();// 75218106 87147634
            inputNumerator.Add("2");
            inputNumerator.Add("12345678");
            inputDenominator.Add("5");
            inputDenominator.Add("34444444");

            inputNumerator1.Add("1");
            inputNumerator1.Add("74668888");
            inputDenominator1.Add("6");
            inputDenominator1.Add("75555555");

            outputNumerator.Add("3");
            outputNumerator.Add("94670198");
            outputNumerator.Add("47399927");
            outputDenominator.Add("6");
            outputDenominator.Add("01744854");
            outputDenominator.Add("97181070");


            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x + i);
        }
        [TestMethod]
        public void plusTest2()
        {
            List<string> inputNumerator = new List<string>();//   4 24684684
            List<string> inputDenominator = new List<string>();//10 86745678
            List<string> inputNumerator1 = new List<string>();// -89000 
            List<string> inputDenominator1 = new List<string>();//         3 23456008
            List<string> outputNumerator = new List<string>();//     85793807 61252467
            List<string> outputDenominator = new List<string>();//2 19696511 69820840
            inputNumerator.Add("4");
            inputNumerator.Add("24684684");
            inputDenominator.Add("10");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("-");
            inputNumerator1.Add("89000");
            inputDenominator1.Add("3");
            inputDenominator1.Add("23456008");

            outputNumerator.Add("42941993");
            outputNumerator.Add("15653046");
            outputDenominator.Add("54021645");
            outputDenominator.Add("73563111");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x + i);
        }
        [TestMethod]
        public void plusTest3()
        {
            List<string> inputNumerator = new List<string>();//    -4 24684684
            List<string> inputDenominator = new List<string>();//     10 86745678
            List<string> inputNumerator1 = new List<string>(); //      -
            List<string> inputDenominator1 = new List<string>();
            List<string> outputNumerator = new List<string>();//       85914708 06920217
            List<string> outputDenominator = new List<string>();//   2 19696511 69820840

            inputNumerator.Add("-");
            inputNumerator.Add("4");
            inputNumerator.Add("24684684");
            inputDenominator.Add("10");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("-");
            inputNumerator1.Add("89000");
            inputDenominator1.Add("3");
            inputDenominator1.Add("23456008");

            outputNumerator.Add("-");
            outputNumerator.Add("42941993");
            outputNumerator.Add("15653046");
            outputDenominator.Add("54021645");
            outputDenominator.Add("73563111");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x + i);
        }

        [TestMethod]
        public void plusTest4()
        {
            List<string> inputNumerator = new List<string>();//14 24684684
            List<string> inputDenominator = new List<string>();//1 86745678
            List<string> inputNumerator1 = new List<string>();//23 24989000
            List<string> inputDenominator1 = new List<string>();//12 23456008
            List<string> outputNumerator = new List<string>();// 34019073 17645193
            List<string> outputDenominator = new List<string>();//356992377683021

            inputNumerator.Add("14");
            inputNumerator.Add("24684684");
            inputDenominator.Add("1");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("23");
            inputNumerator1.Add("24989000");
            inputDenominator1.Add("12");
            inputDenominator1.Add("23456008");

            outputNumerator.Add("13");
            outputNumerator.Add("60762927");
            outputNumerator.Add("05807717");
            outputDenominator.Add("1");
            outputDenominator.Add("42796951");
            outputDenominator.Add("07320839");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x + i);
        }
        [TestMethod]
        public void plusTestEx()
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


            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);

            Assert.AreNotEqual(null, x + i);
        }

        [TestMethod]
        public void unarMinusTest()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();
            List<string> outputNumerator = new List<string>();
            List<string> outputDenominator = new List<string>();

            inputNumerator.Add("3");
            inputNumerator.Add("12345678");
            inputDenominator.Add("5");
            inputDenominator.Add("12345678");

            outputNumerator.Add("-");
            outputNumerator.Add("3");
            outputNumerator.Add("12345678");
            outputDenominator.Add("5");
            outputDenominator.Add("12345678");

            Q x = new Q(inputNumerator, inputDenominator);
            Q t = new Q(outputNumerator, outputDenominator);
            Q i = -x;
            Assert.AreEqual(t,i);
        }

        [TestMethod]
        public void unarMinusTestEx()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();

            inputNumerator.Add("3");
            inputNumerator.Add("12345678");
            inputDenominator.Add("5");
            inputDenominator.Add("12345678");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = -x;
            Assert.AreNotEqual(null, i);
        }

        //////
        ///
        [TestMethod]
        public void multiplicationTest1()
        {
            List<string> inputNumerator = new List<string>();//14 24684684
            List<string> inputDenominator = new List<string>();//1 86745678
            List<string> inputNumerator1 = new List<string>();//23 24989000
            List<string> inputDenominator1 = new List<string>();//12 23456008
            List<string> outputNumerator = new List<string>();//        2 58779392 09128720
            List<string> outputDenominator = new List<string>();//       17849618 88415105

            inputNumerator.Add("14");
            inputNumerator.Add("24684684");
            inputDenominator.Add("1");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("23");
            inputNumerator1.Add("24989000");
            inputDenominator1.Add("12");
            inputDenominator1.Add("23456008");

            outputNumerator.Add("2");
            outputNumerator.Add("58779392");
            outputNumerator.Add("09128720");
            outputDenominator.Add("17849618");
            outputDenominator.Add("88415105");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x * i);
        }
        [TestMethod]
        public void multiplicationTest2()
        {
            List<string> inputNumerator = new List<string>();//14 24684684
            List<string> inputDenominator = new List<string>();//1 86745678
            List<string> inputNumerator1 = new List<string>();//23 24989000
            List<string> inputDenominator1 = new List<string>();//12 23456008
            List<string> outputNumerator = new List<string>();//        2 58779392 09128720
            List<string> outputDenominator = new List<string>();//       17849618 88415105

            inputNumerator.Add("-");
            inputNumerator.Add("14");
            inputNumerator.Add("24684684");
            inputDenominator.Add("1");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("23");
            inputNumerator1.Add("24989000");
            inputDenominator1.Add("12");
            inputDenominator1.Add("23456008");

            outputNumerator.Add("-");
            outputNumerator.Add("2");
            outputNumerator.Add("58779392");
            outputNumerator.Add("09128720");
            outputDenominator.Add("17849618");
            outputDenominator.Add("88415105");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x * i);
        }

        [TestMethod]
        public void multiplicationTest3()
        {
            List<string> inputNumerator = new List<string>();//14 24684684
            List<string> inputDenominator = new List<string>();//1 86745678
            List<string> inputNumerator1 = new List<string>();//23 24989000
            List<string> inputDenominator1 = new List<string>();//12 23456008
            List<string> outputNumerator = new List<string>();//        2 58779392 09128720
            List<string> outputDenominator = new List<string>();//       17849618 88415105

            inputNumerator.Add("-");
            inputNumerator.Add("14");
            inputNumerator.Add("24684684");
            inputDenominator.Add("1");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("-");
            inputNumerator1.Add("23");
            inputNumerator1.Add("24989000");
            inputDenominator1.Add("12");
            inputDenominator1.Add("23456008");

            outputNumerator.Add("2");
            outputNumerator.Add("58779392");
            outputNumerator.Add("09128720");
            outputDenominator.Add("17849618");
            outputDenominator.Add("88415105");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x * i);
        }

        [TestMethod]
        public void multiplicationTestEx()
        {
            List<string> inputNumerator = new List<string>();//14 24684684
            List<string> inputDenominator = new List<string>();//1 86745678
            List<string> inputNumerator1 = new List<string>();//23 24989000
            List<string> inputDenominator1 = new List<string>();//12 23456008
            

            inputNumerator.Add("-");
            inputNumerator.Add("14");
            inputNumerator.Add("24684684");
            inputDenominator.Add("1");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("-");
            inputNumerator1.Add("23");
            inputNumerator1.Add("24989000");
            inputDenominator1.Add("12");
            inputDenominator1.Add("23456008");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Assert.AreNotEqual(null, x * i);
        }

       
        [TestMethod]
        public void isDownTest()
		{
            List<string> inputNumerator = new List<string>();//14 24684684
            List<string> inputDenominator = new List<string>();//1

            inputNumerator.Add("-");
            inputNumerator.Add("14");
            inputNumerator.Add("24684684");
            inputDenominator.Add("1");

            Q x = new Q(inputNumerator,inputDenominator);
            bool i = x.isDown;
            bool t = true;
            Assert.AreEqual(t,i);
		}

        [TestMethod]
        public void isDownTest1()
        {
            List<string> inputNumerator = new List<string>();//14 24684684
            List<string> inputDenominator = new List<string>();//1

            inputNumerator.Add("14");
            inputNumerator.Add("24684684");
            inputDenominator.Add("12");

            Q x = new Q(inputNumerator, inputDenominator);
            bool i = x.isDown;
            bool t = false;
            Assert.AreEqual(t, i);
        }

        [TestMethod]
        public void isDownTestEx()
        {
            List<string> inputNumerator = new List<string>();//14 24684684
            List<string> inputDenominator = new List<string>();//1

            inputNumerator.Add("14");
            inputNumerator.Add("24684684");
            inputDenominator.Add("12");

            Q x = new Q(inputNumerator, inputDenominator);
            bool i = x.isDown;
            Assert.AreNotEqual(null, i);
        }

       [TestMethod]
        public void POZ_Q_DTest1()
		{
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();

            inputNumerator.Add("1");
            inputNumerator.Add("12345678");
            inputDenominator.Add("12");
            inputDenominator.Add("12345678");
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
            inputNumerator.Add("12345678");
            inputDenominator.Add("12");
            inputDenominator.Add("12345678");

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
            inputDenominator.Add("12345678");

            Q x = new Q(inputNumerator, inputDenominator);
            byte t = 0;
            byte i = x.POZ_Q_D;
            Assert.AreEqual(t, i);
        }

        [TestMethod]
        public void POZ_Q_DTestEx()
        {
            List<string> inputNumerator = new List<string>();
            List<string> inputDenominator = new List<string>();

            inputNumerator.Add("0");
            inputDenominator.Add("12");
            inputDenominator.Add("12345678");

            Q x = new Q(inputNumerator, inputDenominator);
            byte i = x.POZ_Q_D;
            Assert.AreNotEqual(null, i);
        }

        [TestMethod]
        public void divisionTest1() // не готово

        {
            List<string> inputNumerator = new List<string>();//1 24684684
            List<string> inputDenominator = new List<string>();//1 86745678
            List<string> inputNumerator1 = new List<string>();//2 24989000
            List<string> inputDenominator1 = new List<string>();//3 23456008
            List<string> outputNumerator = new List<string>();//       
            List<string> outputDenominator = new List<string>();//       

            inputNumerator.Add("1");
            inputNumerator.Add("24684684");
            inputDenominator.Add("1");
            inputDenominator.Add("86745678");

            inputNumerator1.Add("2");
            inputNumerator1.Add("24989000");
            inputDenominator1.Add("3");
            inputDenominator1.Add("23456008");

            outputNumerator.Add("");
            outputNumerator.Add("");
            outputNumerator.Add("");
            outputDenominator.Add("");
            outputDenominator.Add("");

            Q x = new Q(inputNumerator, inputDenominator);
            Q i = new Q(inputNumerator1, inputDenominator1);
            Q t = new Q(outputNumerator, outputDenominator);
            Assert.AreEqual(t, x * i);
        }


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

    }
}