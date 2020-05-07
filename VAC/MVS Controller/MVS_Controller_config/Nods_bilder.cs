using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVS_Controller
{
    public class Nods_bilder
    {

        public static Noda Create(string name, Form parent, Panel panel)
        { 
            switch (name)
            {
                case "WD":
                    Noda wd = new Noda(parent,panel);
                    return wd;
                case "if":
                    Noda nif = new Noda(parent, panel);
                    return nif;
                case "Res":
                    Noda res = new Noda(parent, panel);
                    return res;
                default:
                    MessageBox.Show("Ошибка конфигурации: Неверное название типа ноды", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                   
            }
            
        }

        public static void Help_ini(Noda noda, string[] text)
        {

        }
    }
}
