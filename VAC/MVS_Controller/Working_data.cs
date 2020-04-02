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
        Button down_contacts = new Button();
        public Working_data(Form parent, Panel panel) : base(parent, panel)
        {
            InitializeComponent();
            SizeChanged += new EventHandler(SizeChange);
            Controls.Add(down_contacts);
            BackColor = Color.FromArgb(50, 50, 50);
            down_contacts.Location = new Point((int)(Width - (Width*0.16)), 0);
            down_contacts.Size = new Size((int)(Width * 0.16), Height);
            down_contacts.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\Image\\Start.png");
            down_contacts.Show();
        }

        private static void SizeChange(object sender, EventArgs e)
        {
            (sender as Working_data).down_contacts.Location = new Point((int)((sender as Working_data).Width - ((sender as Working_data).Width * 0.16)), 0);
            (sender as Working_data).down_contacts.Size = new Size((int)((sender as Working_data).Width * 0.16), (sender as Working_data).Height);
        }
    }
}
