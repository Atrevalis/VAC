using System;
using Math_Module;
using External_Controller;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Interpretation_Controller
{
    static public class Interpretator
    {
        public static void Interpretate()
        {
            string input = External_Controller.Controller.input;
            string output = External_Controller.Controller.output;
            FileStream inp = null, outp = null;
            try
            {
                inp = new FileStream(input, FileMode.Open);
                outp = new FileStream(output, FileMode.OpenOrCreate);
            }
            catch
            {
                MessageBox.Show("Некоректный путь входного/выходного файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            StreamReader reader = new StreamReader(inp);
            StreamWriter writer = new StreamWriter(outp);
            List<Math_Field> Data = new List<Math_Field>();
            string s;
            try
            {
                for(int i = 0; i < Controller.dates.Count; i++)
                {
                    s = reader.ReadLine();
                    switch(Controller.dates[i].information.name)
                    {
                        case "N":
                            {
                                List<string> dat = new List<string>();
                                for (int j = 0; j < s.Length; j += (int)N.uint_size_div)
                                {
                                    dat.Add(s.Substring(i, (int)N.uint_size_div));
                                }
                                Data.Add(new N(dat));
                            }
                            break;
                        case "Z":
                            {
                                List<string> dat = new List<string>();
                                for (int j = 0; j < s.Length; j += (int)N.uint_size_div)
                                {
                                    dat.Add(s.Substring(i, (int)N.uint_size_div));
                                }
                                Data.Add(new Z(dat));
                            }
                            break;
                        case "Q":
                            {
                                string first = s.Split('/')[0];
                                string second = s.Split('/')[1];
                                List<string> dato = new List<string>();
                                for (int j = 0; j < first.Length; j += (int)N.uint_size_div)
                                {
                                    dato.Add(first.Substring(i, (int)N.uint_size_div));
                                }
                                List<string> datt = new List<string>();
                                for (int j = 0; j < second.Length; j += (int)N.uint_size_div)
                                {
                                    datt.Add(second.Substring(i, (int)N.uint_size_div));
                                }
                                Data.Add(new Q(dato, datt));
                            }
                            break;
                        case "P":
                            {

                            }
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Некоректное содержание входного файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
