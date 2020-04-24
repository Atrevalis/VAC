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

            Assert.AreEqual(t, x + i);

        }
        [TestMethod]
        public void plusTest3()
        {
            List<M> input = new List<M>();

            M four;
            List<string> fourNum = new List<string>();
            fourNum.Add("2");
            List<string> fourDen = new List<string>();
            fourDen.Add("3");
            four.coef = new Q(fourNum,fourDen);
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
            output.Add(three1);

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

        [TestMethod]
        public void minusTest1()
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
      /*   [TestMethod]
       public void minusTest2()//вроде недоделка
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
            oneDegree.Add("1");
            one.degree = new N(oneDegree);
            input.Add(one);

            List<M> input1 = new List<M>();

            M two1;
            List<string> two1Num = new List<string>();
            two1Num.Add("3");
            List<string> two1Den = new List<string>();
            two1Den.Add("2");
            two1.coef = new Q(two1Num, two1Den);
            List<string> two1Degree = new List<string>();
            two1Degree.Add("4");
            two1.degree = new N(two1Degree);
            input1.Add(two1);

            M one1;
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

            M zero3;
            List<string> four3Num = new List<string>();
            four3Num.Add("13");
            List<string> four3Den = new List<string>();
            four3Den.Add("6");
            four3.coef = new Q(four3Num, four3Den);
            List<string> four3Degree = new List<string>();
            four3Degree.Add("4");
            four3.degree = new N(four3Degree);
            output.Add(four3);

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
            output.Add(three1);

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
        }*/
        [TestMethod]
        public void minusTestEx()
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
            //P firstP = new P(first);
            // P secondP = new P(second);
            //Assert.AreEqual(firstP.NMR_P_P(), secondP);
        }

    }
}
