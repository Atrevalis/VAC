using NUnit.Framework;
using Math_Module;
using System.Collections.Generic;
using System.IO;

namespace Math_Module_Test
{
    
    public class N_Test
    {

        List<string> input = new List<string>();// { "12", "99999999" }
        List<string> output = new List<string>();// { "12", "99999999" }

        [Test]
        public void nConstructTest()
        {

           // Assert.AreEqual(n++, output);

        }

        [Test]
        public void plusPlusTestOne()
        {
            input.Add("12");
            input.Add("99999999");
            output.Add("13");
            output.Add("00000000");
            N n = new N(input);
            N t = new N(output);
            Assert.AreEqual(n++, t);

        }

        [Test]
        public void plusPlusTestTwo()
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

        }

        [Test]
        public void plusTestOne()
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

        }
    }
}

