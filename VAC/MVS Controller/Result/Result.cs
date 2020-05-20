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
        public Result(Form parent, Panel panel, Color first,  Color therd, Color text) : base(parent, panel, first, therd, text)
        {
            name_of_type = "Res";
            InitializeComponent();
        }
    }
}
