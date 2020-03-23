using NUnit.Framework;
using Math_Module;
using System.Collections.Generic;
using System;

namespace Math_Module_Test
{


    public class N_Test
    {

        List<string> input = new List<string>();
        List<string> output = new List<string>();

        [Test]
        public void nConstructTest()//отложено на потом
        {
            
        }
        //++Test
        [Test]
        public void plusPlusTest1()
        {
          
            input.Add("12");
            input.Add("99999999");
            output.Add("13");
            output.Add("00000000");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);
            input.Clear();
            output.Clear();
        }

        [Test]
        public void plusPlusTest2()
        {
           
            input.Add("12");
            input.Add("00000000");
            input.Add("00000000");
            output.Add("12");
            output.Add("00000000");
            output.Add("00000001");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);
            input.Clear();
            output.Clear();
        }
        [Test]
        public void plusPlusTestEx()
        {
            input.Add("12");
            input.Add("00000000");
            input.Add("00000009");
            N n = new N(input);
            Assert.AreNotEqual(n++, null);
            input.Clear();
            output.Clear();
        }
        //NinStringTest
        [Test]
        public void NConvertToStringTest1()
        {
            output.Add("12");
            output.Add("00000000");
            output.Add("00000009");
            N n = new N(output);
            Assert.AreEqual((List<string>)n, output);
            input.Clear();
            output.Clear();
        }
        [Test]
        public void NConvertToStringTest2()
        {
            output.Add("12");
            N n = new N(output);
            List<string> s = n;
            Assert.AreEqual(s, output);
            input.Clear();
            output.Clear();
        }

        [Test]
        public void NConvertToStringTestEx()
        {
            output.Add("12");
            output.Add("00000009");
            N n = new N(output);
            Assert.AreNotEqual((List<string>)n, null);
            input.Clear();
            output.Clear();
        }
        //+
        [Test]
        public void plusTest1()
        {
            input.Add("12");
            input.Add("10000000");
            output.Add("12");
            output.Add("10000012");
            output.Add("10000000");
            N n = new N(input);
            input.Add("00000000");
            N i = new N(input);
            N t = new N(output);
            Assert.AreEqual(n + i, t);
            input.Clear();
            output.Clear();
        }

        [Test]
        public void plusTest2()
        {
            input.Add("49999999");
            input.Add("50000000");
            output.Add("1");
            output.Add("00000000");
            output.Add("00000000");
            N n = new N(input);
            N i = new N(input);
            N t = new N(output);
            Assert.AreEqual(n+i, t);
            input.Clear();
            output.Clear();
        }
        [Test]
        public void plusTestEx()
        {
            input.Add("49999999");
            input.Add("50000000");
            N n = new N(input);
            N i = new N(input);
            Assert.AreNotEqual(n + i, null);
            input.Clear();
            output.Clear();
        }
        //-
        [Test]
        public void minusTest1()
        {
            input.Add("142");
            input.Add("12345678");
            N n = new N(input);
            input.Clear();

            input.Add("131");
            input.Add("12000000");
            N i = new N(input);

            output.Add("11");
            output.Add("00345678");
            N t = new N(output);

            Assert.AreEqual(n - i, t);
            input.Clear();
            output.Clear();
        }

        [Test]
        public void minusTest2()
        {
            input.Add("1");
            input.Add("00000000");
            N n = new N(input);
            input.Clear();

            input.Add("2");
            N i = new N(input);

            output.Add("99999998");
            N t = new N(output);

            Assert.AreEqual(n - i, t);
            input.Clear();
            output.Clear();
        }
        [Test]
        public void minusTestEx()
        {
            input.Add("1");
            input.Add("00000000");
            N n = new N(input);
            input.Clear();

            input.Add("2");
            N i = new N(input);

            output.Add("99999998");
            N t = new N(output);

            Assert.AreNotEqual(n - i, null);
            input.Clear();
            output.Clear();
        }
    }


}
