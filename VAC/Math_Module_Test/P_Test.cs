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
    }
}
