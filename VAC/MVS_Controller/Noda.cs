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
        static private Noda Size_change = null;
        static private Noda enter = null;
        static private Noda Loc_change = null;
        static private Point Mouse_pos = new Point(0, 0);

        public Noda(Form parent, Panel panel)
        {
            InitializeComponent();
            Height = 100;
            Width = 100;
            Location = new Point(parent.Width/2 - 50 - panel.Location.X, parent.Height/2 - 50 - panel.Location.Y);
            MouseDown += new MouseEventHandler(Noda_click);
            MouseUp += new MouseEventHandler(Noda_up);
            MouseEnter += new EventHandler(Noda_enter);
            MouseLeave += new EventHandler(Noda_leave);
            MouseMove += new MouseEventHandler(Noda_MoseMove);
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
                case MouseButtons.Right:
                    {
                        Loc_change = sender as Noda;
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

                case MouseButtons.Right:
                    {
                        Loc_change = null;
                    }
                    break;
            }
        }

        private static void Noda_enter(object sender, EventArgs e)
        {
            enter = (sender as Noda);
        }

        private static void Noda_leave(object sender, EventArgs e)
        {
            enter = null;
        }

        private static void Noda_MoseMove(object sender, MouseEventArgs e)
        {
            Point delta = new Point((e.Location.X - Mouse_pos.X), (e.Location.Y - Mouse_pos.Y));
            Noda nod = sender as Noda;
            if (Size_change != null)
            {
                nod.Size = new Size( nod.Width + delta.X, nod.Height + delta.Y);
            }
            else
            {
                if(Loc_change != null)
                {
                    nod.DoDragDrop(nod, DragDropEffects.Move);
                }
            }
            Mouse_pos = e.Location;
        }
    }
}
