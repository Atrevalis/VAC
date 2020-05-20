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
    public partial class Working_data : Noda
    {
        public Button down_contacts = new Button();
        public Working_data(Form parent, Panel panel, Color first, Color therd, Color text) : base(parent, panel, first, therd, text)
        {
            name_of_type = "WD";
            InitializeComponent();
            SizeChanged += new EventHandler(SizeChange);
            Controls.Add(down_contacts);
            down_contacts.FlatStyle = FlatStyle.Popup;
            down_contacts.BackgroundImageLayout = ImageLayout.Stretch;
            down_contacts.Location = new Point((int)(Width - (Width*0.16)), 0);
            down_contacts.Size = new Size((int)(Width * 0.16), Height);
            down_contacts.BackColor = first;
            down_contacts.Click += new EventHandler(Connect_start);
            down_contacts.Show();
            Working_data.first = first;
            Working_data.therd = therd;
        }

        static Color first, therd;

        private static void SizeChange(object sender, EventArgs e)
        {
            (sender as Working_data).down_contacts.Location = new Point((int)((sender as Working_data).Width - ((sender as Working_data).Width * 0.16)), 0);
            (sender as Working_data).down_contacts.Size = new Size((int)((sender as Working_data).Width * 0.16), (sender as Working_data).Height);
        }

        private static void Connect_start(object sender, EventArgs e)
        {
            if (conect_nod != (sender as Button))
            {
                if (conect_nod == null)
                {
                    (sender as Button).BackColor = therd;
                    conect_nod = (sender as Button);
                }
                else
                {
                    conect_nod.BackColor = first;
                    conect_nod = null;
                }
            }
            else
            {
                (sender as Button).BackColor = first;
                conect_nod = null;
            }
        }


    }
}
