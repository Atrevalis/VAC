using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Visual_Module
{
    public partial class Create_new_project : Form
    {
        Main_Window main;
        public Create_new_project(Main_Window main_, bool butt3)
        {
            main = main_;
            InitializeComponent();
            if (!butt3) button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main.Enabled = true;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Name_of_project.Text == "")
            {
                MessageBox.Show("Пустое имя","Пустое имя", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Directory.Exists(path_of_project.Text))
                {
                    if(checkBox1.Checked == true)
                    {
                        string full_name_of_project = path_of_project.Text + Name_of_project.Text;
                        Directory.CreateDirectory(full_name_of_project);
                        path_of_project.Text = full_name_of_project;
                    }
                    External_Controller.Controller.name_of_now_project = Name_of_project.Text;
                    External_Controller.Controller.path_of_now_project = path_of_project.Text;
                    main.Enabled = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Некоректный адрес", "Некоректный адрес", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            path_of_project.Text =  folder.SelectedPath;
        }
    }
}
