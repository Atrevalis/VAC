using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using External_Controller;

namespace Visual_Module
{
    public partial class Hello_Form : Form
    {
        Main_Window main;
        string[] arg;
        public Hello_Form(Main_Window main_, string[] args)
        {
            arg = args;
            InitializeComponent();
            main = main_;
            ClientSize = new System.Drawing.Size(800, 440);
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Resources\\Image\\Logo.jpg");
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += new EventHandler(this.timer_Tick);
            timer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
                pictureBox1.Dispose();
                (sender as Timer).Stop();
                ClientSize = new System.Drawing.Size(399, 395);
                if (arg != null && arg.Length > 0)
                {
                    OpenFileDialog open = new OpenFileDialog();
                    open.Multiselect = false;
                    open.FileName = arg[0];
                    External_Controller.Controller.name_of_now_project = open.SafeFileName.Split('.')[0];
                    External_Controller.Controller.path_of_now_project = open.FileName.Replace(open.SafeFileName, "");
                    main.Show();
                    Close();
                    main.Load_save();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.Show();
            main.Enabled = false;
            Create_new_project create = new Create_new_project(main, false);
            create.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.ShowDialog();
            try
            {
                External_Controller.Controller.name_of_now_project = open.SafeFileName.Split('.')[0];
                External_Controller.Controller.path_of_now_project = open.FileName.Replace(open.SafeFileName, "");
                main.Show();
                Close();
                main.Load_save();
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
