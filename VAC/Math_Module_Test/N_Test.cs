using NUnit.Framework;
using Math_Module;
using System.Collections.Generic;
using System;

namespace Math_Module_Test
{


    public class N_Test
    {

        //++Test
        [Test]
        public void plusPlusTest1()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("99999999");
            output.Add("13");
            output.Add("00000000");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);

        }

        [Test]
        public void plusPlusTest2()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("00000000");
            input.Add("00000000");
            output.Add("12");
            output.Add("00000000");
            output.Add("00000001");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);

        }

        [Test]
        public void plusPlusTestEx()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("00000000");
            input.Add("00000009");
            N n = new N(input);
            Assert.AreNotEqual(n++, null);


        }
        //++Test

        //NinStringTest
        [Test]
        public void NConvertToStringTest1()
        {

            List<string> output = new List<string>();
            output.Add("12");
            output.Add("00000000");
            output.Add("00000009");
            N n = new N(output);
            Assert.AreEqual((List<string>)n, output);

        }
        [Test]
        public void NConvertToStringTest2()
        {

            List<string> output = new List<string>();
            output.Add("12");
            N n = new N(output);
            List<string> s = n;
            Assert.AreEqual(output, s);



        }

        [Test]
        public void NConvertToStringTestEx()
        {

            List<string> output = new List<string>();
            output.Add("12");
            output.Add("00000009");
            N n = new N(output);
            Assert.AreNotEqual(null,(List<string>)n );


        }
        //NinStringTest

        //+Test
        [Test]
        public void plusTest1()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("10000000");
            output.Add("12");
            output.Add("10000012");
            output.Add("10000000");
            N n = new N(input);
            input.Add("00000000");
            N i = new N(input);
            N t = new N(output);
            Assert.AreEqual(t, n + i);

        }

        [Test]
        public void plusTest2()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("50000000");
            output.Add("1");
            output.Add("00000000");
            N n = new N(input);
            N i = new N(input);
            N t = new N(output);
            Assert.AreEqual( t,n + i);


        }
        [Test]
        public void plusTestEx()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("49999999");
            input.Add("50000000");
            N n = new N(input);
            N i = new N(input);
            Assert.AreNotEqual(null,n + i );

        }
        //+Test

        //-Test
        [Test]
        public void minusTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("142");//142
            input.Add("12345678");
            N n = new N(input);
            input1.Add("131");
            input1.Add("12000000");


            N i = new N(input1);

            output.Add("11");
            output.Add("00345678");
            N t = new N(output);

            Assert.AreEqual(t, n - i);

        }

        [Test]
        public void minusTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("2");
            N i = new N(input);

            input1.Add("1");
            input1.Add("00000000");
            N n = new N(input1);

            output.Add("99999998");
            N t = new N(output);
            Assert.AreEqual(t,n - i );

        }
        [Test]
        public void minusTestEx()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("2");
            N i = new N(input);
            input1.Add("1");
            input1.Add("00000000");
            N n = new N(input1);
            output.Add("99999998");
            N t = new N(output);

            Assert.AreNotEqual(null, n - i);

        }
        //-Test
        
        //*Test
    
        [Test]
        public void multiplicationTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("12345678");
            input1.Add("2345678");
            output.Add("28437725");
            output.Add("85279684");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n* i);
            
        }
/*
        [Test]
        public void multiplicationTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("1");
            input1.Add("2");
            output.Add("2");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual( t,n * i);
        }
        */
        [Test]
        public void multiplicationTestEx()
        {
            List<string> input = new List<string>();
            
            input.Add("1");
            input.Add("00000000");
            N n = new N(input);
            N i = new N(input);
            Assert.AreNotEqual(null,n * i );
        }
        //*  Test



        //RoflTest 

      [Test]
      public void RofloTest()
      {
            List<string> input = new List<string>();
            N n = new N(input);
            Assert.AreEqual(false,n.isDown);
      }
        //COM_NN_D(equalForN)Test
        [Test]
        public void COM_NN_DBiggerTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("1");
            input.Add("12345678");
            input1.Add("12345678");
            N n = new N(input);
            N i = new N(input1);
            byte t = N.COM_NN_D(n, i);
            Assert.AreEqual(2, t);
        }
        [Test]
        public void COM_NN_DBiggerTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("12345679");
            input1.Add("12345678");
            N n = new N(input);
            N i = new N(input1);
            byte t = N.COM_NN_D(n, i);
            Assert.AreEqual(2, t);
        }
        [Test]
        public void COM_NN_DLessTest1()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("12345678");
            input1.Add("1");
            input1.Add("12345678");
            N n = new N(input);
            N i = new N(input1);
            byte t = N.COM_NN_D(n, i);
            Assert.AreEqual(1, t);
        }
        [Test]
        public void COM_NN_DLessTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("12345678");
            input1.Add("12345679");
            N n = new N(input);
            N i = new N(input1);
            byte t = N.COM_NN_D(n, i);
            Assert.AreEqual(1, t);
        }
        [Test]
        public void COM_NN_DEqualTest()
        {
            List<string> input = new List<string>();
            input.Add("1");
            input.Add("12345678");
            N n = new N(input);
            N i = new N(input);
            byte t = N.COM_NN_D(n, i);
            Assert.AreEqual(0, t);
        }

    }
}