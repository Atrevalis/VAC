using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVS_Controller
{
    public partial class Noda : UserControl
    {
        bool Size_changer;
        Point Size_change;
        public Noda(Form parent)
        {
            InitializeComponent();
            Height = 100;
            Width = 100;
            Location = new Point(parent.Width/2 - 50, parent.Height/2 - 50);
            MouseDown += new MouseEventHandler(Noda_click);
            MouseUp += new MouseEventHandler(Noda_up);
            MouseEnter += new EventHandler(Noda_enter);
            MouseMove += new MouseEventHandler(Noda_MouseMove);
        }

        private static void  Noda_click(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Middle:
                    {

                    }
                    break;
            }
        }

        private static void Noda_up(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Middle:
                    {

                    }
                    break;
            }
        }

        private static void Noda_enter(object sender, EventArgs e)
        {

        }
        private static void Noda_MouseMove(object sender, EventArgs e)
        {
            if((sender as Noda).Size_changer)
            {

            }
        }
    }
}
