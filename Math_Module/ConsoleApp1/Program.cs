using System;
using System.Collections.Generic;
using Math_Module;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();// { "12", "99999999" }
            List<string> output = new List<string>();// { "12", "99999999" }
            input.Add("12");
            input.Add("99999999");
            output.Add("13");
            output.Add("00000000");
            N n = new N(input);
            N t = new N(output);
            n++;
        }
    }
}
