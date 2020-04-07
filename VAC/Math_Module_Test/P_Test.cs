using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math_Module;

namespace Math_Module_Test
{
    [TestClass]
    class P_Test
    {
        [TestMethod]
        public void plusTest1()
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
        public void plusTest2()
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

            Assert.AreEqual(t,x+i);

        }
        [TestMethod]
        public void plusTestEx()
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
        public void NMR_P_PTest()
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
            P firstP = new P(first);
            P secondP = new P(second);
            Assert.AreEqual(firstP.NMR_P_P(), secondP);
        }

    }
}
