using System;
using Math_Module;
using External_Controller;
using System.IO;
using System.Windows.Forms;

namespace Interpretation_Controller
{
    static public class Interpretator
    {
        public static void Interpretate()
        {
            string input = External_Controller.Controller.input;
            string output = External_Controller.Controller.output;
            FileStream inp, outp;
            try
            {
                inp = new FileStream(input, FileMode.Open);
                outp = new FileStream(output, FileMode.OpenOrCreate);
            }
            catch
            {
                MessageBox.Show("Некоректный путь входного/выходного файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
