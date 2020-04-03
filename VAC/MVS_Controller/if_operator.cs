using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MVS_Controller
{
    public partial class if_operator : Noda
    {
        Button down_contacts = new Button();
        static Image butt_image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\Image\\Start.png");
        public if_operator(Form parent, Panel panel) : base(parent, panel)
        {
            InitializeComponent();
            InitializeComponent();
            SizeChanged += new EventHandler(SizeChange);
            Controls.Add(down_contacts);
            down_contacts.FlatStyle = FlatStyle.Popup;
            down_contacts.BackgroundImageLayout = ImageLayout.Stretch;
            down_contacts.Location = new Point((int)(Width - (Width * 0.16)), 0);
            down_contacts.Size = new Size((int)(Width * 0.16), Height);
            down_contacts.BackgroundImage = butt_image;
            down_contacts.BackColor = Color.Gray;
            down_contacts.Click += new EventHandler(Connect_start);
            down_contacts.Show();
        }

        private static void SizeChange(object sender, EventArgs e)
        {
            (sender as if_operator).down_contacts.Location = new Point((int)((sender as if_operator).Width - ((sender as if_operator).Width * 0.16)), 0);
            (sender as if_operator).down_contacts.Size = new Size((int)((sender as if_operator).Width * 0.16), (sender as if_operator).Height);
        }

        private static void Connect_start(object sender, EventArgs e)
        {
            if (conect_nod != (sender as Button).Parent as Noda)
            {
                if (conect_nod == null)
                {
                    (sender as Button).BackgroundImage = null;
                    conect_nod = (sender as Button).Parent as Noda;
                }
            }
            else
            {
                (sender as Button).BackgroundImage = butt_image;
                conect_nod = null;
            }
        }
    }
}
