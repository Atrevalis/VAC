using NUnit.Framework;
using Math_Module;
using System.Collections.Generic;
using System;
namespace Math_Module_Test
{
    public class Z_Test
    {
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
            N x = new N(input);
            input.Add("00000000");
            N i = new N(input);
            N t = new N(output);
            Z X = new Z(x);
            Z I = new Z(i);
            Z T = new Z(t);
            Assert.AreEqual(T, X + I);

        }
        /*
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
            Assert.AreEqual(t, n + i);


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
            Assert.AreNotEqual(null, n + i);

        }
        */
    }
}
