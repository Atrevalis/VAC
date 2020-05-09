using LMath;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Math_Module_Test
{

    [TestClass]
    public class N_Test
    {

        //++Test
        [TestMethod]
        public void plusPlusTest1()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("0");
            output.Add("1");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);

        }
        [TestMethod]
        public void plusPlusTest2()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("272");
            output.Add("273");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);

        }

        [TestMethod]
        public void plusPlusTest3()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("279");
            output.Add("280");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);

        }

        [TestMethod]
        public void plusPlusTest4()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("299");
            output.Add("300");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);

        }

        [TestMethod]
        public void plusPlusTest5()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input.Add("123");
            input.Add("123");
            output.Add("123");
            output.Add("123");
            output.Add("124");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);

        }

        [TestMethod]
        public void plusPlusTest6()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input.Add("123");
            input.Add("999");
            output.Add("123");
            output.Add("124");
            output.Add("000");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);

        }

        [TestMethod]
        public void plusPlusTest7()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input.Add("999");
            input.Add("999");
            output.Add("124");
            output.Add("000");
            output.Add("000");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);

        }

        //++Test

        //NinStringTest
        [TestMethod]
        public void NConvertToStringTest1()
        {

            List<string> output = new List<string>();
            output.Add("12");
            output.Add("000");
            output.Add("009");
            N n = new N(output);
            CollectionAssert.AreEqual((List<string>)n, output);

        }
        [TestMethod]
        public void NConvertToStringTest2()
        {

            List<string> output = new List<string>();
            output.Add("12");
            N n = new N(output);
            List<string> s = n;
            CollectionAssert.AreEqual(s, output);
        }

        [TestMethod]
        public void NConvertToStringTest3()
        {

            List<string> output = new List<string>();
            output.Add("12");
            output.Add("009");
            N n = new N(output);
            CollectionAssert.AreEqual(output, (List<string>)n);


        }
        //NinStringTest

        //+Test
        [TestMethod]
        public void plusTest1()
        {
            List<string> input1 = new List<string>();
            List<string> input2 = new List<string>();
            List<string> output = new List<string>();
            input1.Add("123");
            input1.Add("123");
            output.Add("123");
            output.Add("123");
            N n = new N(input1);
            input2.Add("0");
            N i = new N(input2);
            N t = new N(output);
            Assert.AreEqual(t, n + i);

        }

        [TestMethod]
        public void plusTest2()
        {
            List<string> input1 = new List<string>();
            List<string> input2 = new List<string>();
            List<string> output = new List<string>();
            input1.Add("522");
            input2.Add("432");
            output.Add("954");
            N n = new N(input1);
            N i = new N(input2);
            N t = new N(output);
            Assert.AreEqual(t, n + i);


        }
        [TestMethod]
        public void plusTest3()
        {
            List<string> input1 = new List<string>();
            List<string> input2 = new List<string>();
            List<string> output = new List<string>();
            input1.Add("9");
            input2.Add("4");
            output.Add("13");
            N n = new N(input1);
            N i = new N(input2);
            N t = new N(output);
            Assert.AreEqual(t, n + i);

        }

        [TestMethod]
        public void plusTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("120");
            input.Add("120");

            input1.Add("980");

            output.Add("12");
            output.Add("121");
            output.Add("100");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n + i);

        }
        [TestMethod]
        public void plusTest5()
        {
            List<string> input1 = new List<string>();
            List<string> input2 = new List<string>();
            List<string> output = new List<string>();
            input1.Add("224");
            input1.Add("999");
            input1.Add("800");
            input2.Add("224");
            input2.Add("000");
            input2.Add("200");
            N n = new N(input1);
            N i = new N(input2);
            output.Add("449");
            output.Add("000");
            output.Add("000");
            N f = new N(output);
            Assert.AreEqual(f, n + i);

        }
        public void plusTest6()
        {
            List<string> input1 = new List<string>();
            List<string> input2 = new List<string>();
            List<string> output = new List<string>();
            input1.Add("224");
            input1.Add("999");
            input1.Add("800");
            input2.Add("224");
            input2.Add("800");
            input2.Add("200");
            N n = new N(input1);
            N i = new N(input2);
            output.Add("449");
            output.Add("600");
            output.Add("000");
            Assert.AreEqual(output, n + i);

        }
        //+Test

        //-Test
        [TestMethod]
        public void minusTest1()
        {
            List<string> input1 = new List<string>();
            List<string> input2 = new List<string>();
            List<string> output = new List<string>();
            input1.Add("999");
            input1.Add("999");
            input1.Add("999");
            N n = new N(input1);
            input2.Add("1");
            input2.Add("000");
            input2.Add("239");
            N i = new N(input2);
            output.Add("998");
            output.Add("999");
            output.Add("760");
            N t = new N(output);
            Assert.AreEqual(t, n - i);
        }

        [TestMethod]
        public void minusTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("2");
            N i = new N(input);
            input1.Add("1");
            input1.Add("000");
            N n = new N(input1);
            output.Add("998");
            N t = new N(output);
            Assert.AreEqual(t, n - i);
        }

        [TestMethod]
        public void minusTest3()
        {
            List<string> input2 = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input2.Add("2");
            input1.Add("990");
            N n = new N(input1);
            N i = new N(input2);
            output.Add("988");
            N f = new N(output);
            Assert.AreEqual(f, n - i);
        }

        [TestMethod]
        public void minusTest4()
        {
            List<string> input2 = new List<string>();
            List<string> input1 = new List<string>();
            input2.Add("3");
            N i = new N(input2);
            input1.Add("1");
            N n = new N(input1);
            Assert.AreEqual(null, n - i);
        }
        //-Test

        //*Test

        [TestMethod]
        public void multiplicationTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("122");
            input1.Add("0");
            output.Add("0");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n * i);
        }


        [TestMethod]
        public void multiplicationTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("10");
            input1.Add("1");
            output.Add("10");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n * i);
        }


        [TestMethod]
        public void multiplicationTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input1.Add("4");
            output.Add("492");
            N n = new N(input);
            N i = new N(input1);
            N f = new N(output);
            Assert.AreEqual(f, n * i);
        }


        [TestMethod]
        public void multiplicationTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input1.Add("24");
            output.Add("2");
            output.Add("952");
            N n = new N(input);
            N i = new N(input1);
            N f = new N(output);
            Assert.AreEqual(f, n * i);
        }

        [TestMethod]
        public void multiplicationTest5()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input1.Add("24");
            output.Add("2");
            output.Add("952");
            N n = new N(input1);
            N i = new N(input);
            N f = new N(output);
            Assert.AreEqual(f, n * i);
        }
        // Test 
        ///
        [TestMethod]
        public void devisionByZeroTest()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("2");
            input.Add("222");
            input1.Add("0");
            N n = new N(input);
            N i = new N(input1);
            Assert.AreEqual(null, n / i);
        }

        [TestMethod]
        public void devisionTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input1.Add("1");
            input1.Add("120");
            output.Add("0");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n / i);
        }

        [TestMethod]
        public void devisionTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("1");
            input.Add("111");
            input1.Add("1");
            input1.Add("111");
            output.Add("1");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n / i);
        }

        [TestMethod]
        public void devisionTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("2");
            input.Add("222");
            input1.Add("1");
            output.Add("2");
            output.Add("222");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n / i);
        }

        [TestMethod]
        public void devisionTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("0");
            input1.Add("222");
            input1.Add("1");
            output.Add("0");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n / i);
        }

        [TestMethod]
        public void devisionTest5()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("25");
            input1.Add("8");
            output.Add("3");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n / i);
        }

        [TestMethod]
        public void devisionTest6()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input.Add("123");
            input.Add("123");
            input1.Add("122");
            output.Add("1");
            output.Add("009");
            output.Add("205");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n / i);
        }

        //%
        [TestMethod]
        public void remainderByZeroTest()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("1");
            input.Add("123");
            input1.Add("0");
            N n = new N(input);
            N i = new N(input1);
            Assert.AreEqual(null, n % i);
        }

        [TestMethod]
        public void remainderTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("1");
            input.Add("024");
            input1.Add("1");
            input1.Add("024");
            output.Add("0");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n % i);
        }

        [TestMethod]
        public void remainderTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("122");
            input1.Add("123");
            output.Add("122");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n % i);
        }

        [TestMethod]
        public void remainderTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("245");
            input1.Add("123");
            output.Add("122");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n % i);
        }

        [TestMethod]
        public void remainderTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input.Add("123");
            input1.Add("122");
            output.Add("25");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n % i);
        }

        [TestMethod]
        public void remainderTest5()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input.Add("123");
            input.Add("123");
            input1.Add("122");
            input1.Add("000");
            output.Add("25 ");
            output.Add("123");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n % i);
        }

        [TestMethod]
        public void remainderTest6()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("245");
            input1.Add("1");
            output.Add("0");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n % i);
        }

        //^
        [TestMethod]
        public void degreeTestZero1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("245");
            input1.Add("0");
            output.Add("1");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n ^ i);
        }

        [TestMethod]
        public void degreeTestZero2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("0");
            input1.Add("123");
            output.Add("0");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n ^ i);
        }

        [TestMethod]
        public void degreeTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("247");
            input1.Add("1");
            output.Add("247");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n ^ i);
        }

        [TestMethod]
        public void degreeTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("1");
            input1.Add("123");
            output.Add("1");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n ^ i);
        }

        [TestMethod]
        public void degreeTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("2");
            input1.Add("13");
            output.Add("8");
            output.Add("192");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n ^ i);
        }

        [TestMethod]
        public void degreeTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("143");
            input1.Add("15");
            output.Add("213");
            output.Add("816");
            output.Add("177");
            output.Add("893"); 
            output.Add("015");
            output.Add("973");
            output.Add("495");
            output.Add("273");
            output.Add("770");
            output.Add("237");
            output.Add("807");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n ^ i);
        }
        //RoflTest 

        [TestMethod]
        public void isDown()
        {
            List<string> input = new List<string>();
            input.Add("1");
            N n = new N(input);
            Assert.AreEqual(false, n.isDown);
        }

        [TestMethod]
        public void id()
        {
            List<string> input = new List<string>();
            input.Add("1");
            N n = new N(input);
            Assert.AreEqual(1, n.id);
        }

        [TestMethod]
        public void Dawn()
        {
            List<string> input = new List<string>();
            input.Add("1");
            N n = new N(input);
            Assert.AreEqual(n, n.Dawn());
        }

        public void ToListstring()
        {
            List<string> input = new List<string>();
            input.Add("1");
            N n = new N(input);
            Assert.AreEqual(input, n.ToListstring());
        }
        //COM_NN_D(equalForN)Test
        [TestMethod]
        public void COM_NN_DBiggerTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("1");
            input.Add("123");
            input1.Add("123");
            N n = new N(input);
            N i = new N(input1);
            byte t = n.COM(i);
            Assert.AreEqual(2, t);
        }
        [TestMethod]
        public void COM_NN_DBiggerTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("124");
            input.Add("124");
            input1.Add("123");
            input1.Add("123");
            N n = new N(input);
            N i = new N(input1);
            byte t = n.COM(i);
            Assert.AreEqual(2, t);
        }
        [TestMethod]
        public void COM_NN_DLessTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("123");
            input1.Add("1");
            input1.Add("123");
            N n = new N(input);
            N i = new N(input1);
            byte t = n.COM(i);
            Assert.AreEqual(1, t);
        }
        [TestMethod]
        public void COM_NN_DLessTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("1");
            input1.Add("123");
            N n = new N(input);
            N i = new N(input1);
            byte t = n.COM(i);
            Assert.AreEqual(1, t);
        }
        [TestMethod]
        public void COM_NN_DEqualTest()
        {
            List<string> input = new List<string>();
            input.Add("1");
            input.Add("123");
            N n = new N(input);
            N i = new N(input);
            byte t = n.COM(i);
            Assert.AreEqual(0, t);
        }
        [TestMethod]
        public void CloneTest()
        {
            List<string> input = new List<string>();
            input.Add("1");
            input.Add("123");
            N n = new N(input);
            N nClone = n.Clone();
            Assert.AreEqual(nClone, n);
        }
        [TestMethod]
        public void CloneTestReference()
        {
            List<string> input = new List<string>();
            input.Add("234");
            input.Add("157");
            N n = new N(input);
            N nClone = n.Clone();
            Assert.AreEqual(false, n == nClone);
        }
        [TestMethod]
        public void GCF_NN_NTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("13");
            input1.Add("17");
            output.Add("1");
            N n = new N(input);
            N i = new N(input1);
            N o = new N(output);
            N gcfN = n.GCF(i) as N;
            Assert.AreEqual(o, gcfN);
        }

        [TestMethod]
        public void GCF_NN_NTest2()
        {
            List<string> input = new List<string>(); 
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("13");
            input1.Add("26");
            output.Add("13");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N gcfN = n.GCF(i) as N;
            Assert.AreEqual(t, gcfN);
        }

        [TestMethod]
        public void GCF_NN_NTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("123");
            input.Add("140");
            input1.Add("256");
            input1.Add("560");
            output.Add("20");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N gcfN = n.GCF(i) as N;
            Assert.AreEqual(t, gcfN);
        }
        [TestMethod]
        public void GCF_NN_NTest4()
        {
            List<string> input = new List<string>(); 
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("0");
            input1.Add("11");
            output.Add("11");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N gcfN = n.GCF(i) as N;
            Assert.AreEqual(t, gcfN);
        }

        [TestMethod]
        public void GCF_NN_NTest5()
        {
            List<string> input = new List<string>(); 
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("8");
            input.Add("638");
            input1.Add("11");
            input1.Add("106");
            output.Add("1");
            output.Add("234");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N gcfN = n.GCF(i) as N;
            Assert.AreEqual(t, gcfN);
        }
        [TestMethod]
        public void LCM_NN_NTest1()
        {
            List<string> input = new List<string>(); 
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("0");
            input1.Add("113");
            output.Add("0");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N lcmN = n.LCM(i) as N;
            Assert.AreEqual(t, lcmN);
        }
        [TestMethod]
        public void LCM_NN_NTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("1");
            input1.Add("241");
            output.Add("241");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N lcmN = n.LCM(i) as N;
            Assert.AreEqual(t, lcmN);
        }
        [TestMethod]
        public void LCM_NN_NTest3()
        {
            List<string> input = new List<string>(); 
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("512");
            input1.Add("1");
            input1.Add("024");
            output.Add("1");
            output.Add("024");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N lcmN = n.LCM(i) as N;
            Assert.AreEqual(t, lcmN);
        }

        [TestMethod]
        public void LCM_NN_NTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("17");
            input1.Add("13");
            output.Add("221");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N lcmN = n.LCM(i) as N;
            Assert.AreEqual(t, lcmN);
        }

        [TestMethod]

        public void LCM_NN_NTest5()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("2");
            input.Add("231");
            input1.Add("191");
            input1.Add("398");
            output.Add("427");
            output.Add("008");
            output.Add("938");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N lcmN = n.LCM(i) as N;
            Assert.AreEqual(t, lcmN);
        }
        /*
        [TestMethod]
        public void RESTest()
        {
            List<string> input = new List<string>();
            input.Add("2");
            input.Add("231");
            N n = new N(input);
            Assert.AreEqual(n, n.RES();
        }*/
        /*

                [TestMethod]
                public void DIV_NN_DkTest1()
                {
                    List<string> input = new List<string>();
                    List<string> input1 = new List<string>();
                    List<string> output = new List<string>();
                    input.Add("3456");
                    input1.Add("45");
                    output.Add("70");
                    N x = new N(input);
                    N i = new N(input1);
                    N t = new N(output);
                    N l = N.DIV_NN_Dk(x, i);
                    Assert.AreEqual(t, l);
                }


                           [TestMethod]
                           public void DIV_NN_DkTest2()
                           {
                               List<string> input = new List<string>();
                               List<string> input1 = new List<string>();
                               List<string> output = new List<string>();
                               input.Add("23");
                               input.Add("87654321");
                               input1.Add("11");
                               input1.Add("12345678");
                               output.Add("2");
                               N x = new N(input);
                               N i = new N(input1);
                               N t = new N(output);
                               N l = N.DIV_NN_Dk(x, i);
                               Assert.AreEqual(t, l);

                           }

                           [TestMethod]
                           public void DIV_NN_DkTestEx()
                           {
                               List<string> input = new List<string>();
                               List<string> input1 = new List<string>();
                               input.Add("3456");
                               input1.Add("45");
                               N x = new N(input);
                               N i = new N(input1);
                               N l = N.DIV_NN_Dk(x, i);
                               Assert.AreNotEqual(null, l);

                           } 
                           */
        /* [TestMethod]
        public void MUL_ND_NTest1()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            byte input1 = 0;
            input.Add("123");
            output.Add("0");
            N x = new N(input);
            N t = new N(output);
            N i = x.MUL_ND_N(input1);
            Assert.AreEqual(t,i);
        }

        [TestMethod]
        public void MUL_ND_NTestEx()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            byte input1 = 3;
            input.Add("87654321");
            output.Add("1");
            output.Add("75308642");
            N x = new N(input);
            N t = new N(output);
            N i = x.MUL_ND_N(input1);
            Assert.AreNotEqual(null, i);
        }*/
        /*
          [TestMethod]
          public void MUL_Nk_NTest1()
          {
              List<string> input = new List<string>();
              List<string> input1 = new List<string>();
              List<string> output = new List<string>();
              input.Add("1");
              input.Add("10000000");
              input1.Add("10");
              output.Add("110");
              output.Add("00000000");
              output.Add("00000000");
              N x = new N(input);
              N value = new N(input1);
              N t = new N(output);
              N i = x.MUL_Nk_N(value);
              Assert.AreEqual(t, i);
          }

            [TestMethod]
          public void MUL_Nk_NTest2()
          {
              List<string> input = new List<string>();
              List<string> input1 = new List<string>();
              List<string> output = new List<string>();
              input.Add("1");
              input.Add("10000000");
              input1.Add("0");
              output.Add("1");
              output.Add("10000000");
              N x = new N(input);
              N value = new N(input1);
              N t = new N(output);
              N i = x.MUL_Nk_N(value);
              Assert.AreEqual(t, i);
          }

          [TestMethod]
          public void MUL_Nk_NTestEx()
          {
              List<string> input = new List<string>();
              List<string> input1 = new List<string>();
              input.Add("1");
              input.Add("10000000");
              input1.Add("10");
              N x = new N(input);
              N value = new N(input1);
              N i = x.MUL_Nk_N(value);
              Assert.AreNotEqual(null, i);
          } */
        //ТЕСТЫ ПРИВАТОВ
        /*
        [TestMethod]
        public void SUB_NDN_NTest1()
         {
             List<string> input = new List<string>(); //  
             List<string> input1 = new List<string>();// 
             List<string> output = new List<string>();
             byte i = 2;
             input.Add("12");
             input.Add("12345678");
             input1.Add("01172839");
             output.Add("12");
             output.Add("10000000");
             N n = new N(input);
             N c = new N(input1);
             N t = new N(output);
             N u = N.SUB_NDN_N(n,c,i);
             Assert.AreEqual(t,u);
         }
         [TestMethod]
         public void SUB_NDN_NTest2()
         {
             List<string> input = new List<string>(); //  
             List<string> input1 = new List<string>();// 
             byte i = 2;
             input.Add("12");
             input.Add("12345678");
             input1.Add("1172839");
             input1.Add("01172839");
             N n = new N(input);
             N c = new N(input1);
             N u = N.SUB_NDN_N(n, c, i);
             Assert.AreEqual(null, u);
         }
         [TestMethod]
         public void SUB_NDN_NTestEx()
         {
             List<string> input = new List<string>(); //  
             List<string> input1 = new List<string>();// 
             byte i = 2;
             input.Add("12");
             input.Add("12345678");
             input1.Add("01172839");
             N n = new N(input);
             N c = new N(input1);
             N u = N.SUB_NDN_N(n, c, i);
             Assert.AreNotEqual(null, u);
         }*/

        /* [TestMethod]
         public void NZER_N_BTest1()
         {
             List<string> input = new List<string>();
             input.Add("0");
             N n = new N(input);
             bool c = n.NZER_N_B();
             Assert.AreEqual(true,c);
         }

         [TestMethod]
         public void NZER_N_BTest2()
         {
             List<string> input = new List<string>();
             input.Add("123");
             N n = new N(input);
             bool c = n.NZER_N_B();
             Assert.AreEqual(false, c);
         }

         [TestMethod]
         public void NZER_N_BTestEx()
         {
             List<string> input = new List<string>();
             input.Add("0");
             N n = new N(input);
             bool c = n.NZER_N_B();
             Assert.AreNotEqual(null, c);
         }*/


        /*   [TestMethod]
           public void DIV_NN_DkTest1()
           {
               List<string> input = new List<string>();
               List<string> input1 = new List<string>();
               List<string> output = new List<string>();
               input.Add("3456");
               input1.Add("45");
               output.Add("70");
               N x = new N(input);
               N i = new N(input1);
               N t = new N(output);
               N l = N.DIV_NN_Dk(x, i);
               Assert.AreEqual(t, l);
           }



                      [TestMethod]
                      public void DIV_NN_DkTest2()
                      {
                          List<string> input = new List<string>();
                          List<string> input1 = new List<string>();
                          List<string> output = new List<string>();
                          input.Add("23");
                          input.Add("87654321");
                          input1.Add("11");
                          input1.Add("12345678");
                          output.Add("2");
                          N x = new N(input);
                          N i = new N(input1);
                          N t = new N(output);
                          N l = N.DIV_NN_Dk(x, i);
                          Assert.AreEqual(t, l);

                      }

                      [TestMethod]
                      public void DIV_NN_DkTestEx()
                      {
                          List<string> input = new List<string>();
                          List<string> input1 = new List<string>();
                          input.Add("3456");
                          input1.Add("45");
                          N x = new N(input);
                          N i = new N(input1);
                          N l = N.DIV_NN_Dk(x, i);
                          Assert.AreNotEqual(null, l);

                      } */
        /* [TestMethod]
         public void MUL_ND_NTest1()
         {
             List<string> input = new List<string>();
             List<string> output = new List<string>();
             byte input1 = 3;
             input.Add("87654321");
             output.Add("1");
             output.Add("75308642");
             N x = new N(input);
             N t = new N(output);
             N i = x.MUL_ND_N(input1);
             Assert.AreEqual(t,i);
         }
         [TestMethod]
         public void MUL_ND_NTestEx()
         {
             List<string> input = new List<string>();
             List<string> output = new List<string>();
             byte input1 = 3;
             input.Add("87654321");
             output.Add("1");
             output.Add("75308642");
             N x = new N(input);
             N t = new N(output);
             N i = x.MUL_ND_N(input1);
             Assert.AreNotEqual(null, i);
         }
           */
    }
}





