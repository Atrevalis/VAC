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
    public partial class Working_data : Noda
    {
        Button down_contacts = new Button();
        public Working_data(Form parent) : base(parent)
        {
            
            InitializeComponent();
            Controls.Add(down_contacts);
            BackColor = Color.FromArgb(50, 50, 50);
            down_contacts.Show();
        }
    }
}
