using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVS_Controller;
using External_Controller;

namespace Visual_Module
{
    public partial class Main_Window : Form
    {
        static Point Mouse_pos = new Point(0, 0);
        static bool panel_move = false;
        static float zoom = 1;
        public Main_Window()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Create_new_project new_Project = new Create_new_project(this, true);
            new_Project.Show();
            Enabled = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.ShowDialog();
            try
            {
                External_Controller.Controller.name_of_now_project = open.SafeFileName;
                External_Controller.Controller.path_of_now_project = open.FileName.Replace(open.SafeFileName, "");
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        if(zoom < 4)
                        {
                            zoom*=2;
                        }
                        else
                        {
                            zoom = 1;
                        }

                        for(int i = 0; i < panel1.Controls.Count; i++)
                        {
                            Control bufer = panel1.Controls[i]; 
                            float deltaZoom = zoom != 1 ? 2 : 0.25f;
                            float tr = zoom != 1 ? 1 : -3.66666666666666666666666f;
                            bufer.Size = new Size((int)(bufer.Width * deltaZoom), (int)(bufer.Height * deltaZoom));
                            bufer.Location = new Point(bufer.Location.X + (int)((bufer.Location.X - e.Location.X)*deltaZoom * tr), bufer.Location.Y + (int)((bufer.Location.Y - e.Location.Y) * deltaZoom * tr));
                            if (bufer.Location.X < 0) bufer.Location = new Point(0, bufer.Location.Y);
                            if (bufer.Location.Y < 0) bufer.Location = new Point(bufer.Location.X, 0);
                            if (bufer.Location.X + bufer.Width > panel1.Width) bufer.Location = new Point(bufer.Location.X + bufer.Width, bufer.Location.Y);
                            if (bufer.Location.X + bufer.Width > panel1.Width) bufer.Location = new Point(bufer.Location.X, bufer.Location.Y + bufer.Height);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Noda.down_conected != null && Noda.up_conected != null)
            {
                Controller.new_Conect(Noda.up_conected, Noda.down_conected);
                Noda.down_conected = null;
                Noda.up_conected = null;
                Noda.Paint = true;
            }
            if(Noda.enter != null)
            {
                toolStripStatusLabel1.Text = Noda.enter.ToString();
            }
            else
            {
                toolStripStatusLabel1.Text = "";
            }
            if (Noda.Paint)
            {
                Refresh();
                Noda.Paint = false;
            }
        }


        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("N", "Data", working_Data, ref text);
            working_Data.label.Text = "N";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("Z", "Data", working_Data, ref text);
            working_Data.label.Text = "Z";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("Q", "Data", working_Data, ref text);
            working_Data.label.Text = "Q";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("P", "Data", working_Data, ref text);
            working_Data.label.Text = "P";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void модульЧислаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("ABS", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "ABS";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void минусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("(-1)", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "(-1)";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void производнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("DIF", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "f '(x)";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void старшийКоэфицентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("LED", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "LED";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void степеньПолиномаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("deg", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "deg";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void вынесениеНОКЧислителяИНОДЗнаменателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("FAC", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "НОД/\nНОК";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }


        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("Down", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "⊆";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("up", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "∈";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("-", "Bin_operator", working_Data, ref text);
            working_Data.label.Text = "SUB";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void делениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("/", "Bin_operator", working_Data, ref text);
            working_Data.label.Text = "DIV";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void остатокОтДеленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("%", "Bin_operator", working_Data, ref text);
            working_Data.label.Text = "MOD";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void суммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("+", "N_operator", working_Data, ref text);
            working_Data.label.Text = "∑";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void произведениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("*", "N_operator", working_Data, ref text);
            working_Data.label.Text = "Π";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void нОДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data working_Data = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("НОД", "N_operator", working_Data, ref text);
            working_Data.label.Text = "НОД";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
        }

        private void нОКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Working_data if_Operator = new Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("НОД", "N_operator", if_Operator, ref text);
            if_Operator.label.Text = "НОК";
            if_Operator.Show();
            panel1.Controls.Add(if_Operator);
        }

        private void сравнениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if_operator if_Operator = new if_operator(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("COM_NN_D", "if_operator", if_Operator, ref text);
            if_Operator.label.Text = "><=";
            if_Operator.Butt_ini(text);
            if_Operator.Show();
            panel1.Controls.Add(if_Operator);
        }

        private void определениеЗнакаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if_operator if_Operator = new if_operator(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("isDown", "if_operator", if_Operator, ref text);
            if_Operator.label.Text = "isDown";
            if_Operator.Butt_ini(text);
            if_Operator.Show();
            panel1.Controls.Add(if_Operator);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Result result = new Result(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("Result", "Result", result, ref text);
            result.label.Text = "Вывод";
            result.Show();
            panel1.Controls.Add(result);
        }

        private static void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(50, 50, 50), 6);
            pen.EndCap = LineCap.ArrowAnchor;
            pen.StartCap = LineCap.Round;
            for (int i = 0; i < Controller.working_Dates.Count; i++)
            {
                for (int j = 0; j < Controller.working_Dates[i].information.down_Contacted.Count; j++)
                {
                    Working_data data = Controller.working_Dates[i].Visul as Working_data;
                    Noda noda = null;
                    for (int k = 0; k < Controller.nods.Count; k++)
                    {
                        if(Controller.nods[k].information == Controller.working_Dates[i].information.down_Contacted[j])
                        {
                            noda = Controller.nods[k].Visul as Noda;
                        }
                    }
                    graphics.DrawLine(pen, data.Location.X + data.Width, data.Location.Y + (data.Height/2), noda.Location.X, noda.Location.Y + (noda.Height/2));
                }
            }
        }
    }
}
