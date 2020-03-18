using NUnit.Framework;
using Math_Module;
using System.Collections.Generic;

    namespace Math_Module_Test
    {
        public class Tests
        {

 
            [Test]
            public void PlusPlusTest()
            {
            N s = new N(new List<string>()); 
                Assert.AreEqual(s++,new N(new List<string>()));

            }
        }
    }