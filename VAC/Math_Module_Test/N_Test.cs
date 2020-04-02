using Math_Module;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Math_Module_Test
{

    [TestClass]
    public class N_Test
    {

        //++Test
        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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
        [TestMethod]
        public void NConvertToStringTest1()
        {

            List<string> output = new List<string>();
            output.Add("12");
            output.Add("00000000");
            output.Add("00000009");
            N n = new N(output);
            CollectionAssert.AreEqual((List<string>)n, output);

        }
        [TestMethod]
        public void NConvertToStringTest2()
        {

            List<string> output = new List<string>();
            output.Add("12");
            N n = new N(output);
            List<string> s = n;
            CollectionAssert.AreEqual(s, output);
        }

        [TestMethod]
        public void NConvertToStringTestEx()
        {

            List<string> output = new List<string>();
            output.Add("12");
            output.Add("00000009");
            N n = new N(output);
            Assert.AreNotEqual(null, (List<string>)n);


        }
        //NinStringTest

        //+Test
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
            N n = new N(input);
            input.Add("00000000");
            N i = new N(input);
            N t = new N(output);
            Assert.AreEqual(t, n + i);

        }

        [TestMethod]
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
        [TestMethod]
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
        //+Test

        //-Test
        [TestMethod]
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

        [TestMethod]
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
            Assert.AreEqual(t, n - i);

        }
        [TestMethod]
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

        [TestMethod] 

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
            Assert.AreEqual(t, n * i);

        }


        [TestMethod]
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
            Assert.AreEqual(t, n * i);
        }


        [TestMethod]
        public void multiplicationTestEx()

        {
            List<string> input = new List<string>();

            input.Add("1");
            input.Add("00000000");
            N n = new N(input);
            N i = new N(input);
            Assert.AreNotEqual(null, n * i);
        }
        // Test 

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
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n / i);

        }
        [TestMethod]
        public void devisionTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("1");
            input.Add("11111111");
            input1.Add("1");
            input1.Add("11111111");
            output.Add("1");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n / i);

        }
        [TestMethod]
        public void devisionTest3()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("2");
            input.Add("22222222");
            input1.Add("1");
            input1.Add("11111111");
            output.Add("2");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            Assert.AreEqual(t, n / i);

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
            N n = new N(input);
            N i = new N(input1);
            Assert.AreNotEqual(null, n / i);

        }


        //RoflTest 

        [TestMethod]
        public void RofloTest()
        {
            List<string> input = new List<string>();
            N n = new N(input);
            Assert.AreEqual(false, n.isDown);
        }
        //COM_NN_D(equalForN)Test
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void CloneTest()
        {
            List<string> input = new List<string>();
            input.Add("1");
            input.Add("12345678");
            N n = new N(input);
            N nClone = n.Clone();
            Assert.AreEqual(nClone, n);
        }
        [TestMethod]
        public void CloneTestReference()
        {
            List<string> input = new List<string>();
            input.Add("1");
            input.Add("12345678");
            N n = new N(input);
            N nClone = n.Clone();
            Assert.AreEqual(false, n == nClone);
        }
        [TestMethod]
        public void GCF_NN_NTest1()
        {
            List<string> input = new List<string>();//   1 02833424
            List<string> input1 = new List<string>();// 11 10775896
            List<string> output = new List<string>();// 72
            input.Add("1");
            input.Add("02833424");
            input1.Add("11");
            input1.Add("10775896");
            output.Add("72");
            N n = new N(input);
            N i = new N(input1);
            N o = new N(output);
            N gcfN = N.GCF_NN_N(n, i);
            Assert.AreEqual(o, gcfN);
        }

        [TestMethod]
        public void GCF_NN_NTest2()
        {
            List<string> input = new List<string>(); //  83 76371580
            List<string> input1 = new List<string>();//  20 84747570
            List<string> output = new List<string>();//  170
            input.Add("83");
            input.Add("76371580");
            input1.Add("20");
            input1.Add("84747570");
            output.Add("170");
            N n = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N gcfN = N.GCF_NN_N(n, i);
            Assert.AreEqual(t, gcfN);
        }
        [TestMethod]
        public void GCF_NN_NTestEx()
        {
            List<string> input = new List<string>(); //  
            List<string> input1 = new List<string>();// 
            List<string> output = new List<string>();// 
            input.Add("1");
            input.Add("02833424");
            input1.Add("11");
            input1.Add("10775896");
            output.Add("72");
            N n = new N(input);
            N i = new N(input1);
            N gcfN = N.GCF_NN_N(n, i);
            Assert.AreNotEqual(null, gcfN);
        }
        /*
       [TestMethod]
        public void DIV_NN_DkTest1()
		{
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("3456");
            input1.Add("45");
            output.Add("70");
            N x = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N l = N.DIV_NN_Dk(x,i);
            Assert.AreEqual(t, l);

        }
        /*
        [TestMethod]
        public void DIV_NN_DkTest2()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            List<string> output = new List<string>();
            input.Add("23");
            input.Add("87654321");
            input1.Add("11");
            input1.Add("12345678");
            output.Add("2");
            N x = new N(input);
            N i = new N(input1);
            N t = new N(output);
            N l = N.DIV_NN_Dk(x, i);
            Assert.AreEqual(t, l);

        }
       
        [TestMethod]
        public void DIV_NN_DkTestEx()
        {
            List<string> input = new List<string>();
            List<string> input1 = new List<string>();
            input.Add("3456");
            input1.Add("45");
            N x = new N(input);
            N i = new N(input1);
            N l = N.DIV_NN_Dk(x, i);
            Assert.AreNotEqual(null, l);
           
        } */
        /* [TestMethod]
         public void MUL_ND_NTest1()
         {
             List<string> input = new List<string>();
             List<string> output = new List<string>();
             byte input1 = 3;
             input.Add("87654321");
             output.Add("1");
             output.Add("75308642");
             N x = new N(input);
             N t = new N(output);
             N i = x.MUL_ND_N(input1);
             Assert.AreEqual(t,i);
         }
         [TestMethod]
         public void MUL_ND_NTestEx()
         {
             List<string> input = new List<string>();
             List<string> output = new List<string>();
             byte input1 = 3;
             input.Add("87654321");
             output.Add("1");
             output.Add("75308642");
             N x = new N(input);
             N t = new N(output);
             N i = x.MUL_ND_N(input1);
             Assert.AreNotEqual(null, i);
         }*/
        /*   [TestMethod]
           public void MUL_Nk_NTest1()
           {
               List<string> input = new List<string>();
               List<string> input1 = new List<string>();
               List<string> output = new List<string>();
               input.Add("1");
               input.Add("10000000");
               input1.Add("10");
               input1.Add("00000000");
               output.Add("11");
               output.Add("00000000");
               input1.Add("00000000");
               N x = new N(input);
               N value = new N(input1);
               N t = new N(output);
               N i = x.MUL_Nk_N(value);
               Assert.AreEqual(t, i);
           }
           [TestMethod]
           public void MUL_Nk_NTestEx()
           {
               List<string> input = new List<string>();
               List<string> input1 = new List<string>();
               List<string> output = new List<string>();
               input.Add("1");
               input.Add("10000000");
               input1.Add("10");
               input1.Add("00000000");
               output.Add("11");
               output.Add("00000000");
               input1.Add("00000000");
               N x = new N(input);
               N value = new N(input1);
               N t = new N(output);
               N i = x.MUL_Nk_N(value);
               Assert.AreNotEqual(null, i);
           }*/
    }
}