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
                    return new Working_data(parent, panel);
                case "if":
                    return new if_operator(parent, panel);
                case "Res":
                    return new Result(parent, panel);
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
