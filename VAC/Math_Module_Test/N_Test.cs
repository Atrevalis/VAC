using NUnit.Framework;
using Math_Module;
using System.Collections.Generic;
using System;
using FluentAssertions;

namespace Math_Module_Test
{


    public class N_Test
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void nConstructTest()
        {
            // Assert.AreEqual(n++, output);
        }

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
            n++;
            n.Should().BeEquivalentTo(t);
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
            n++;
            n.Should().BeEquivalentTo(t);
        }
        [Test]
        public void plusPlusTest3()
        {
            List<string> input = new List<string>();
            List<string> output = new List<string>();
            input.Add("12");
            input.Add("00000000");
            input.Add("00000000");
            output.Add("12");
            output.Add("00000000");
            output.Add("00000000");
            N n = new N(input);
            N t = new N(output);
            n++;
            n.Should().NotBeEquivalentTo(t);
        }

    }


}
