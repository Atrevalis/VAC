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
        static public Noda Active = null;
        static public Noda Size_change = null;
        public Noda(Form parent, Panel panel)
        {
            InitializeComponent();
            Height = 100;
            Width = 100;
            Location = new Point(parent.Width/2 - 50 - panel.Location.X, parent.Height/2 - 50 - panel.Location.Y);
            MouseDown += new MouseEventHandler(Noda_click);
            MouseUp += new MouseEventHandler(Noda_up);
            MouseEnter += new EventHandler(Noda_enter);
        }

        private static void  Noda_click(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Middle:
                    {
                        Size_change = sender as Noda;
                    }
                    break;

                case MouseButtons.Left:
                    {
                        if (Active == null)
                        {
                            (sender as Noda).BackColor = Color.FromArgb(200, 200, 200);
                            Active = sender as Noda;
                        }
                        else
                        {
                            if (Active == sender as Noda)
                            {
                                Active = null;
                                (sender as Noda).BackColor = Color.FromArgb(50, 50, 50);
                            }
                            else
                            {
                                Active.BackColor = Color.FromArgb(50, 50, 50);
                                Active = sender as Noda;
                                (sender as Noda).BackColor = Color.FromArgb(200, 200, 200);
                            }
                        }
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
                        Size_change = null;
                    }
                    break;
            }
        }

        private static void Noda_enter(object sender, EventArgs e)
        {

        }
    }
}
