using LMath;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Math_Module_Test
{
     [TestClass]
    public class M_Test
    {
        [TestMethod]
        public void CreateTest1()
        {
            P input1 = new P(123);
            P input2 = new P(234);
            P input3 = new P(345);
            P input4 = new P(456);
            P input5 = new P(567);
            P input6 = new P(678);
            List<P> matrix = new List<P>();
            matrix.Add(input1);
            matrix.Add(input2);
            matrix.Add(input3);
            matrix.Add(input4);
            matrix.Add(input5);
            matrix.Add(input6);
            M output = new M(2, 3, matrix);
            M input = M.Create("123_234|345_456|567_678");
            Assert.AreEqual(output, input);
        }

        [TestMethod]
        public void unarMinusTest1()

        {
            string num = "1_2_3|4_5_6|7_8_9";
            string num1 = "-1_-2_-3|-4_-5_-6|-7_-8_-9";
            M input = M.Create(num);
            M output = M.Create(num1);
            Assert.AreEqual(output,-input);
        }
        [TestMethod]
        public void unarMinusTest2()

        {
            string num = "1_2_3|4_5_6|7_8_9";
            string num1 = "-1_-2_-3|-4_-5_-6|-7_-8_-9";
            M input = M.Create(num1);
            M output = M.Create(num);
            Assert.AreEqual(output, -input);
        }
        [TestMethod]
        public void binPlusTest1()

        {
            string num = "1_2_3|4_5_6|7_8_9|1_2_3|4_5_6|";
            string num1 = "2_4_6|8_10_12|14_16_18|2_4_6|8_10_12|";
            M input = M.Create(num);
            M output = M.Create(num1);
            Assert.AreEqual(output, input + input);
        }
        [TestMethod]
        public void binPlusTest2()

        {
            string num2 = "1_2_3|4_5_6|7_8_9";
            string num1 = "-1_-2_-3|-4_-5_-6|-7_-8_-9";
            string num = "0_0_0|0_0_0|0_0_0";
            M input = M.Create(num1);
            M input2 = M.Create(num2);
            M output = M.Create(num);
            Assert.AreEqual(output, input+input2);
        }
        [TestMethod]
        public void binMinTest1()

        {
            string num1 = "1_2_3|4_5_6|7_8_9";
            string num2 = "-1_-2_-3|-4_-5_-6|-7_-8_-9";
            string num = "2_4_6|8_10_12|14_16_18|";
            M input = M.Create(num1);
            M input2 = M.Create(num2);
            M output = M.Create(num);
            Assert.AreEqual(output, input - input2);
        }

        [TestMethod]
        public void binMinTest2()

        {
            string num1 = "1_2_3|4_5_6|7_8_9";
            string num = "0_0_0|0_0_0|0_0_0";
            M input = M.Create(num1);
            M output = M.Create(num);
            Assert.AreEqual(output, input - input);
        }

        [TestMethod]
        public void binMinTest3()

        {
            string num1 = "0_0_0|0_0_0|0_0_0";
            string num2 = "1_2_3|4_5_6|7_8_9";
            string num = "-1_-2_-3|-4_-5_-6|-7_-8_-9";
            M input = M.Create(num1);
            M input2 = M.Create(num2);
            M output = M.Create(num);
            Assert.AreEqual(output, input - input2);
        }

        [TestMethod]
        public void RemTest1()
        {
            string num1 = "0|0|0";
            string num2 = "1_2|4_5|7_8";
            M input = M.Create(num1);
            M input2 = M.Create(num2);
            Assert.AreEqual(null, input.REM(input2));
        }

        [TestMethod]
        public void RemTest2()
        {
            string num1 = "0_0_0|0_0_0|0_0_0";
            string num2 = "1_2_3|4_5_6|7_8_9";
            string num = "0";
            M input = M.Create(num1);
            M input2 = M.Create(num2);
            M output = M.Create(num);
            Assert.AreEqual(output, input.REM(input2));
        }

        [TestMethod]
        public void RemTest3()
        {
            string num1 = "0_0_0|0_0_0|0_0_0";
            string num2 = "0_2_3|4_0_6|7_8_0";
            M input = M.Create(num1);
            M input2 = M.Create(num2);
            Assert.AreEqual(null, input.REM(input2));
        }

        [TestMethod]
        public void MODTest1()
        {
            string num1 = "0|0|0";
            string num2 = "1_2|4_5|7_8";
            M input = M.Create(num1);
            M input2 = M.Create(num2);
            Assert.AreEqual(input, input.MOD(input2));
        }

        [TestMethod]
        public void MODTest2()
        {
            string num1 = "0_0_0|0_0_0|0_0_0";
            string num2 = "1_2_3|4_5_6|7_8_9";
            string num = "0";
            M input = M.Create(num1);
            M input2 = M.Create(num2);
            M output = M.Create(num);
            Assert.AreEqual(output, input.MOD(input2));
        }

        [TestMethod]
        public void MODTest3()
        {
            string num1 = "0_0_0|0_0_0|0_0_0";
            string num2 = "0_2_3|4_0_6|7_8_0";
            M input = M.Create(num1);
            M input2 = M.Create(num2);
            Assert.AreEqual(null, input.MOD(input2));
        }

        [TestMethod]
        public void binMultTest1()

        {
            string num1 = "0_0_0|0_0_0|0_0_0";
            string num2 = "1_2_3|4_5_6|7_8_9";
            M input = M.Create(num1);
            M input2 = M.Create(num2);
            M output = M.Create(num1);
            Assert.AreEqual(output, input * input2);
        }
        [TestMethod]
        public void binMultTest2()

        {
            string num1 = "0_0_0|0_0_0|0_0_0";
            string num2 = "1_2_3|4_5_6|7_8_9";
            M input = M.Create(num1);
            M input2 = M.Create(num2);
            M output = M.Create(num1);
            Assert.AreEqual(output, input2 * input);
        }

        [TestMethod]
        public void binMultTest3()

        {
            string num1 = "2_0|0_2|2_0";
            string num2 = "2_0_2|0_2_0";
            string num = "4_0_4|0_4_0|4_0_4";
            M input1 = M.Create(num1);
            M input2 = M.Create(num2);
            M output = M.Create(num1);
            Assert.AreEqual(output, input1 * input2);
        }
        [TestMethod]
        public void binMultTest4()

        {
            string num1 = "2_0|0_2|2_0";
            string num2 = "2_0_2|0_2_0";
            string num = "8_0|0_4";
            M input1 = M.Create(num1);
            M input2 = M.Create(num2);
            M output = M.Create(num1);
            Assert.AreEqual(output, input1 * input2);
        }

        [TestMethod]
        public void binDevTest1()

        {
            string num1 = "2_0|0_2|2_0";
            string num2 = "0_0_0|0_0_0|0_0_0";
            M input1 = M.Create(num1);
            M input2 = M.Create(num2);
            Assert.AreEqual(null, input1 / input2);
        }
        [TestMethod]
        public void binDevTest2()

        {
            string num1 = "0_0_0|0_0_0|0_0_0";
            string num2 = "1_2_2|2_1_2|2_2_1";//"-6/10_4/10_4/10|4/10_-6/10_4/10|4/10_4/10_-6/10"
            M input1 = M.Create(num1);
            M input2 = M.Create(num2);
            Assert.AreEqual(input1, input1 / input2);
        }
        [TestMethod]
        public void procTest1()

        {
            string num1 = "2_0|0_2|2_0";
            string num2 = "1_2|2_1";
            string num = "0";
            M input1 = M.Create(num1);
            M input2 = M.Create(num2);
            M output = M.Create(num);
            Assert.AreEqual(output, input1 % input2);
        }
        [TestMethod]
        public void procTest2()

        {
            string num1 = "2_0|0_2|2_0";
            string num2 = "0_0|2_1";
            M input1 = M.Create(num1);
            M input2 = M.Create(num2);
            Assert.AreEqual(null, input1 % input2);
        }
        [TestMethod]
        public void ReversTest1()

        {
            string num = "-6/10_4/10_4/10|4/10_-6/10_4/10|4/10_4/10_-6/10";
            string num1 = "1_2_2|2_1_2|2_2_1";
            M input = M.Create(num1);
            M output = M.Create(num);
            Assert.AreEqual(output, M.Reverse());

        }
        [TestMethod]
        public void ReverseTest2()

        {
            string num = "-6/10_4/10_4/10|4/10_-6/10_4/10|4/10_4/10_-6/10";
            string num1 = "1_2_2|2_1_2|2_2_1";
            M input = M.Create(num1);
            M output = M.Create(num);
        }


        [TestMethod]
        public void PTTestPM()
        {
            P input1 = P.Create("23/11x^2");
            M output1 = M.Create("23/11^2");
            M pm = input1;
            Assert.AreEqual(output1, pm);
        }

        [TestMethod]
        public void PTTestMP()
        {
            M input1 = M.Create("23/11x^2");
            P output1 = P.Create("23/11x^2");
            P mp = (P)input1;
            Assert.AreEqual(output1, mp);
        }

        [TestMethod]
        public void PTTestMListString()
        {
            M input = M.Create("3_2_1|1_1_1|1_2_3");
            List<string> output = new List<string>();
            List<string> result = new List<string>();
            output.Add("3_2");
            output.Add("_1|");
            output.Add("1_1");
            output.Add("_1|");
            output.Add("1_2");
            output.Add("_3");
            result = input;
            Assert.AreEqual(result, input);
        }


    }

}
