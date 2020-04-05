using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Module
{
    public partial class Proper : Form
    {
        Main_Window main;
        public Proper(Main_Window main_)
        {
            InitializeComponent();
            main = main_;
            main.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            main.Enabled = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            textBox1.Text = fileDialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            textBox2.Text = fileDialog.FileName;
        }
    }
}
