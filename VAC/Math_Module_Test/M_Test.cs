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
            Assert.AreEqual(null, input.MOD(input2));
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
            string num2 = "0_0_0|0_0_0";
            string num = "8_0|0_4";
            M input1 = M.Create(num1);
            M input2 = M.Create(num2);
            Assert.AreEqual(null, input1 / input2);
        }
        [TestMethod]
        public void binDevTest2()

        {
            string num1 = "0_0_0|0_0_0";
            string num2 = "1_2_2|2_1_2|2_2_1";//"-6/10_4/10_4/10|4/10_-6/10_4/10|4/10_4/10_-6/10"
            M input1 = M.Create(num1);
            M input2 = M.Create(num2);
            Assert.AreEqual(null, input1 / input2);
        }
    }

}
