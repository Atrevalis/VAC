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
        public void minusUnar()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("12");
            input.Add("10000000");
            input1.Add("-");
            input1.Add("12");
            input1.Add("10000000");
            Z X = new Z(input);
            Z I = -X;
            Z T = new Z(input1);
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
        public void minusTest()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("10000000");
            input.Add("00000000");
           
            input1.Add("10000000");
            input1.Add("00000000");
            output.Add("12");
            output.Add("00000000");
            output.Add("00000000");
            Z X = new Z(input);
            Z I = new Z(input1);
            Z T = new Z(output);
            Assert.AreEqual(T, X - I);

        }
        [TestMethod]
        public void MinusUnarMinusTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("12");
            input.Add("10000000");
            input.Add("00000000");
            input1.Add("-");
            input1.Add("10000000");
            input1.Add("00000000");
            output.Add("-");
            output.Add("12");
            output.Add("00000000");
            output.Add("00000000");
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
            CollectionAssert.AreEqual(output, input);
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


        [TestMethod]
        public void multiplicationTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("2");
            input.Add("00000000");
            input1.Add("134");
            input1.Add("00000000");
            output.Add("268");
            output.Add("00000000"); 
            output.Add("00000000");
            Z z = new Z(input);
            Z x = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t,z*x);
        }
        [TestMethod]
        public void multiplicationTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("2");
            input.Add("00000000");
            input1.Add("134");
            input1.Add("00000000");
            output.Add("268");
            output.Add("00000000");
            output.Add("00000000");
            Z z = new Z(input);
            Z x = new Z(input1);
            Z t = new Z(output);
            t = -t;
            Assert.AreEqual(t, z * x);
        }
        [TestMethod]
        public void multiplicationTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("2");
            input.Add("00000000");
            input1.Add("134");
            input1.Add("00000000");
            output.Add("-");
            output.Add("268");
            output.Add("00000000");
            output.Add("00000000");
            Z z = new Z(input);
            Z x = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, z * x);
        }
        [TestMethod]
        public void multiplicationTestEx()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("2");
            input.Add("00000000");
            input1.Add("134");
            input1.Add("00000000");
            Z z = new Z(input);
            Z x = new Z(input1);
            Assert.AreNotEqual(null, z * x);
        }
        [TestMethod]
        public void devisionTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("1");
            input.Add("12345675");
            input.Add("00000000");
            input1.Add("1");
            input1.Add("12345675");
            output.Add("1");
            output.Add("00000000");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n / i);

        }
        [TestMethod]
        public void devisionTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("1");
            input.Add("11111111");
            input1.Add("1");
            input1.Add("11111111");
            output.Add("-");
            output.Add("1");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n / i);

        }
        [TestMethod]
        public void devisionTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("2");
            input.Add("22222222");
            input1.Add("-");
            input1.Add("1");
            input1.Add("11111111");
            output.Add("2");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n / i);

        }
        [TestMethod]
        public void devisionByZeroTest4()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("-");
            input.Add("2");
            input.Add("22222222");
            input1.Add("0");
            Z n = new Z(input);
            Z i = new Z(input1);
            Assert.AreEqual(null, n / i);

        }
        [TestMethod]
        public void devisionTestEx()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("1");
            input.Add("12345675");
            input.Add("00000000");
            input1.Add("1");
            input1.Add("12345675");
            Z n = new Z(input);
            Z i = new Z(input1);
            Assert.AreNotEqual(null, n / i);

        }

        [TestMethod]//%
        public void remainderTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("145");
            input.Add("56543564");
            input1.Add("1");
            input1.Add("00003564");//145 00516780
            output.Add("56026784");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n % i);
        }
        [TestMethod]
        public void remainderTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("1");
            input.Add("00000000");
            input1.Add("1");
            input1.Add("00000000");
            output.Add("0");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n % i);
        }
        [TestMethod]//%
        public void remainderTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("10");
            input.Add("00000002");
            input1.Add("5");
            input1.Add("00000000");
            output.Add("4");
            output.Add("99999998");
            Z n = new Z(input);
            Z i = new Z(input1);
            Z t = new Z(output);
            Assert.AreEqual(t, n % i);
        }
        public void remainderByZeroTest()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("-");
            input.Add("10");
            input.Add("00000002");
            input1.Add("0");
            Z n = new Z(input);
            Z i = new Z(input1);
            Assert.AreEqual(null, n % i);
        }
        [TestMethod]
        public void remainderTestEx()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("1");
            input.Add("00000000");
            input1.Add("1");
            input1.Add("00000000");
            Z n = new Z(input);
            Z i = new Z(input1);
           
            Assert.AreNotEqual(null, n % i);
        }



        [TestMethod]
        public void ABS_Z_NTest1()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("145");
            input.Add("00000002");
            output.Add("145");
            output.Add("00000002");
            Z z = new Z(input);
            N n = z.ABS_Z_N;
            N t = new N(output);
            Assert.AreEqual(t, n);
        }
        [TestMethod]
        public void ABS_Z_NTest2()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("-");
            input.Add("2");
            output.Add("2");
            Z z = new Z(input);
            N n = z.ABS_Z_N;
            N t = new N(output);
            Assert.AreEqual(t, n);
        }
        [TestMethod]
        public void ABS_Z_NTestEx()
        {
            List<string> input = new List<string>();
            input.Add("-");
            input.Add("145");
            input.Add("00000002");
            Z z = new Z(input);
            N n = z.ABS_Z_N;
            Assert.AreNotEqual(null, n);
        }
        
            [TestMethod]
        public void POZ_Z_DTest1()
        {
            List<string> input = new List<string>();
            input.Add("145");
            input.Add("00000002");
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
            input.Add("00000002");
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
        public void POZ_Z_DTestEx()
        {
            List<string> input = new List<string>();
            input.Add("0");
            Z z = new Z(input);
            byte i = z.POZ_Z_D;
            Assert.AreNotEqual(null, i);
        }
        [TestMethod]
        public void CloneTest()
        {
            List<string> input = new List<string>();
            input.Add("1");
            input.Add("12345678");
            N z = new N(input);
            N zClone = z.Clone();
            Assert.AreEqual(zClone, z);
        }
        [TestMethod]
        public void CloneTestReference()
        {
            List<string> input = new List<string>();
            input.Add("1");
            input.Add("12345678");
            Z z = new Z(input);
            Z zClone = z.Clone();
            Assert.AreEqual(false, z == zClone);
        }
        [TestMethod]
        public void ZtoNTest1()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("1234");
            input.Add("12345678");
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
            input.Add("1234");
            input.Add("12345678");
            Z z = new Z(input);
            N c = (N)z;
            Assert.AreEqual(null, c);
        }
        [TestMethod]
        public void ZtoNTestEx()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("1234");
            input.Add("12345678");
            Z z = new Z(input);
            N t = new N(input);
            N c = (N)z;
            Assert.AreNotEqual(null, c);
        }

    }
}
