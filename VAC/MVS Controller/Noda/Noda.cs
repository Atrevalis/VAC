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
        public string name_of_type;
        public static Button up_conected = null;
        public static Noda down_conected = null;
        public static Button conect_nod = null;
        public Label label = new Label(); 
        static public Noda Active = null;
        static private Noda Size_change = null;
        static public Noda enter = null;
        static private Noda Loc_change = null;
        static private Point Mouse_pos = new Point(0, 0);
        public static bool Paintt = false;
        static Color first, therd, text;

        public Noda(Form parent, Panel panel, Color first, Color therd, Color text)
        {
            Noda.first = first;
            Noda.therd = therd;
            Noda.text = text;
            InitializeComponent();
            Height = 100;
            Width = 100;
            BackColor = therd;
            Location = new Point(parent.Width/2 - 50 - panel.Location.X, parent.Height/2 - 50 - panel.Location.Y);
            MouseDown += new MouseEventHandler(Noda_click);
            MouseUp += new MouseEventHandler(Noda_up);
            MouseEnter += new EventHandler(Noda_enter);
            MouseLeave += new EventHandler(Noda_leave);
            MouseMove += new MouseEventHandler(Noda_MoseMove);
            ClientSizeChanged += new EventHandler(Size_chenge);
            label.Location = new Point((int)(Width*0.16), (int)(Height * 0.25));
            label.Size = new Size((int)(Width * 0.62), Height/2);
            label.Font = new System.Drawing.Font("Trebuchet MS", label.Height>label.Width? label.Width/3.5f:label.Height/3.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.ForeColor = text;
            label.TextAlign = ContentAlignment.TopCenter;
            Controls.Add(label);
            label.MouseDown += new MouseEventHandler(Label_click);
            label.MouseUp += new MouseEventHandler(Label_up);
            label.MouseMove += new MouseEventHandler(Label_Mouse_Move);
            label.MouseEnter += new EventHandler(Label_Mouse_Enter);
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
                        if (conect_nod == null)
                        {
                            if (Active == null)
                            {
                                (sender as Noda).BackColor = first;
                                Active = sender as Noda;
                            }
                            else
                            {
                                if (Active == sender as Noda)
                                {
                                    Active = null;
                                    (sender as Noda).BackColor = therd;
                                }
                                else
                                {
                                    Active.BackColor = therd;
                                    Active = sender as Noda;
                                    (sender as Noda).BackColor = first;
                                }
                            }
                        }
                        else
                        {
                            if(conect_nod.Parent == sender)
                            {
                                conect_nod.BackColor = first;
                                conect_nod = null;
                            }
                            else
                            {
                                up_conected = conect_nod;
                                down_conected = sender as Noda;
                                conect_nod.BackColor = first;
                                conect_nod = null;
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
                    nod.Location = new Point(nod.Location.X + (int)(delta.X* 0.5), nod.Location.Y + (int)(delta.Y*0.5   ));
                    Paintt = true;
                }
            }
            Mouse_pos = e.Location;
        }

        private static void Size_chenge(object sender, EventArgs e)
        {
            Noda nod = sender as Noda;
            Label label = nod.Controls[0] as Label;
            label.Location = new Point((int)(nod.Width * 0.16), (int)(nod.Height * 0.25));
            label.Size = new Size((int)(nod.Width * 0.62), nod.Height / 2);
            Paintt = true;
            try
            {
                label.Font = new System.Drawing.Font("Trebuchet MS", label.Height > label.Width ? label.Width / 3.5f : label.Height / 3.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            }
            catch
            {

            }
        }

        private static void Label_click(object sender, MouseEventArgs e)
        {
            Noda_click((sender as Label).Parent, e);
        }

        private static void Label_up(object sender, MouseEventArgs e)
        {
            Noda_up((sender as Label).Parent, e);
        }

        private static void Label_Mouse_Move(object sender, MouseEventArgs e)
        {
            Noda_MoseMove((sender as Label).Parent, e);
        }

        private static void Label_Mouse_Enter(object sender, EventArgs e)
        {
            Noda_enter((sender as Label).Parent, e);
        }

    }
}
