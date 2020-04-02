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
        static Point Mouse_pos = new Point(0, 0);
        static bool panel_move = false;
        static byte zoom = 1;
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    {
                        panel_move = true;
                    }
                    break;

                case MouseButtons.Right:
                    {
                        if(zoom < 3)
                        {
                            zoom++;
                        }
                        else
                        {
                            zoom = 1;
                        }
                    }
                    break;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                panel_move = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Point delta = new Point((e.Location.X/2 - Mouse_pos.X/2), (e.Location.Y/2 - Mouse_pos.Y/2));
            if(panel_move == true)
            {
                Point newLoc = new Point(panel1.Location.X + delta.X, panel1.Location.Y + delta.Y);
                if(newLoc.X <= 0 && newLoc.Y <= 0 && newLoc.X + panel1.Width >= Width && newLoc.Y + panel1.Height >= Height)
                panel1.Location = newLoc;
            }
            Mouse_pos = e.Location;
        }

        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (panel1.Location.X + e.Delta <= 0 && panel1.Location.X + panel1.Width >= Width)
                panel1.Location = new Point(panel1.Location.X + e.Delta, panel1.Location.Y);
        }
    }
}
