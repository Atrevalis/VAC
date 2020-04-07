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
        public void plusTest()
        {
            List<List<string>[]> f = new List<List<string>[]>();
            f.Add(new List<string>[2]);
            f[0][0] = new List<string>();
            f[0][0].Add("123");
            f[0][1] = new List<string>();
            f[0][1].Add("2");

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
