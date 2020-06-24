using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MVS_Controller
{
    public class Nods_bilder
    {

        public static Noda Create(string name, Form parent, Panel panel, Color first, Color therd, Color text)
        { 
            switch (name)
            {
                case "WD":
                    return new Working_data(parent, panel, first, therd, text);
                case "if":
                    return new if_operator(parent, panel, first, therd, text);
                case "Res":
                    return new Result(parent, panel, first, therd, text);
                case "Dot":
                    return new Dot(parent, panel, first, therd, text);
                default:
                    MessageBox.Show("Ошибка конфигурации: Неверное название типа ноды", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                   
            }
            
        }

        public static void Help_ini(Noda noda, string[] text)
        {
            if_operator s = (noda as if_operator);
            if (s != null)
            s.Butt_ini(text);
        }
    }
}
