using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVS_Controller;

namespace Visual_Module
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Create_new_project new_Project = new Create_new_project(this);
            new_Project.Show();
            Enabled = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.ShowDialog();
            External_Controller.Controller.name_of_now_project = open.SafeFileName;
            External_Controller.Controller.path_of_now_project = open.FileName.Replace(open.SafeFileName,"");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            External_Controller.Controller.Save();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void Main_Window_Shown(object sender, EventArgs e)
        {
            Visible = false;
            Hello_Form hello = new Hello_Form(this);
            hello.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void Main_Window_ClientSizeChanged(object sender, EventArgs e)
        {
            Update();
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Update();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                string s = Controls[i].ToString();
                Controls[i].Update();
            }
        }
    }
}
