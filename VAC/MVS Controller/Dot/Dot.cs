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
    public partial class Dot: Noda
    {
        static Color first, therd;


        public Dot(Form parent, Panel panel, Color f, Color t, Color te) : base(parent, panel, f, t, te)
        {
            first = f;
            therd = t;
            name_of_type = "Dot";
            InitializeComponent();
            Size = new Size(10,10);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            Click += new EventHandler(Connect_start);
            path.AddEllipse(0, 0, 10, 10);
            Region rgn = new Region(path);
            Region = rgn;

        }
        protected override void Noda_MoseMove(object sender, MouseEventArgs e)
        {
            Point delta = new Point((e.Location.X - Mouse_pos.X), (e.Location.Y - Mouse_pos.Y));
            Noda nod = sender as Noda;
                if (Loc_change != null)
                {
                    nod.Location = new Point(nod.Location.X + (int)(delta.X * 0.5), nod.Location.Y + (int)(delta.Y * 0.5));
                    Paintt = true;
                }
            
            Mouse_pos = e.Location;
        }

        private static void Connect_start(object sender, EventArgs e)
        {
            if (conect_nod != (sender as Control))
            {
                if (conect_nod == null)
                {
                    (sender as Dot).BackColor = therd;
                    conect_nod = (sender as Dot).label;
                }
                else
                {
                    conect_nod.BackColor = first;
                    conect_nod = null;
                }
            }
            else
            {
                (sender as Dot).BackColor = first;
                conect_nod = null;
            }
        }

        protected override void Label_click(object sender, MouseEventArgs e)
        {
            base.Label_click(sender, e);
            Connect_start((sender as Control).Parent, e);
        }
    }
    
}
