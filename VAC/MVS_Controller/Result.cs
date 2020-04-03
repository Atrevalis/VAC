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
    public partial class Result : Noda
    {
        public Result(Form parent, Panel panel) : base(parent, panel)
        {
            InitializeComponent();
            label.MouseDown += new MouseEventHandler(Label_click);
            label.MouseUp += new MouseEventHandler(Label_up);
        }

        private static void Label_click(object sender, MouseEventArgs e)
        {
            Noda_click((sender as Label).Parent, e);
        }

        private static void Label_up(object sender, MouseEventArgs e)
        {
            Noda_up((sender as Label).Parent, e);
        }
    }
}
