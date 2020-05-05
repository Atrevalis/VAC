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
using Interpretation_Controller;
using System.Diagnostics;


namespace Visual_Module
{
    public partial class Main_Window : Form
    {
        string[] arg;
        int progress = 0;
        static Point Mouse_pos = new Point(0, 0);
        static bool panel_move = false;
        static float zoom = 1;
        public Main_Window(string[] args)
        {
            arg = args;
            InitializeComponent();
            timer1.Start();
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.Items.Insert(1, toolStripMenuItem1);
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
                Controller.name_of_now_project = open.SafeFileName.Split('.')[0];
                Controller.path_of_now_project = open.FileName.Replace(open.SafeFileName, "");

            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Load_save();
        }

        public void Load_save()
        {
            Controller.Load();
            for (int i = 0; i < Controller.load_s.Count; i++)
            {
                switch (Controller.load_s[i].type)
                {
                    case "if":
                        {
                            MVS_Controller.if_operator working_Data = new MVS_Controller.if_operator(this, panel1);
                            string[] text = null;
                            Controller.Create_new_Nod(Controller.load_s[i].name, "if_operator", working_Data, ref text);
                            working_Data.label.Text = Controller.load_s[i].text;
                            working_Data.Butt_ini(text);
                            working_Data.Show();
                            panel1.Controls.Add(working_Data);
                            working_Data.BringToFront();
                            working_Data.Location = new Point(Controller.load_s[i].x, Controller.load_s[i].y);
                            working_Data.Size = new Size(Controller.load_s[i].Whight, Controller.load_s[i].Height);
                        }
                        break;
                    case "Result":
                        {
                            MVS_Controller.Result working_Data = new MVS_Controller.Result(this, panel1);
                            string[] text = null;
                            Controller.Create_new_Nod(Controller.load_s[i].name, "Result", working_Data, ref text);
                            working_Data.label.Text = Controller.load_s[i].text;
                            working_Data.Show();
                            panel1.Controls.Add(working_Data);
                            working_Data.BringToFront();
                            working_Data.Location = new Point(Controller.load_s[i].x, Controller.load_s[i].y);
                            working_Data.Size = new Size(Controller.load_s[i].Whight, Controller.load_s[i].Height);
                        }
                        break;
                    case "operator":
                        {
                            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
                            string[] text = null;
                            Controller.Create_new_Nod(Controller.load_s[i].name, Controller.load_s[i].text.Split('!')[1], working_Data, ref text);
                            working_Data.label.Text = Controller.load_s[i].text.Split('!')[0];
                            working_Data.Show();
                            panel1.Controls.Add(working_Data);
                            working_Data.BringToFront();
                            working_Data.Location = new Point(Controller.load_s[i].x, Controller.load_s[i].y);
                            working_Data.Size = new Size(Controller.load_s[i].Whight, Controller.load_s[i].Height);
                        }
                        break;
                    case "Data":
                        {
                            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
                            string[] text = null;
                            Controller.Create_new_Nod(Controller.load_s[i].name, "Data", working_Data, ref text);
                            working_Data.label.Text = Controller.load_s[i].text;
                            working_Data.Show();
                            panel1.Controls.Add(working_Data);
                            working_Data.BringToFront();
                            working_Data.Location = new Point(Controller.load_s[i].x, Controller.load_s[i].y);
                            working_Data.Size = new Size(Controller.load_s[i].Whight, Controller.load_s[i].Height);
                        }
                        break;
                }
            }
            Controller.Load_connect();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Proper proper = new Proper(this);
            proper.Show();
        }

        private void Main_Window_Shown(object sender, EventArgs e)
        {
            Visible = false;
            Hello_Form hello = new Hello_Form(this, arg);
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
                Noda.Paintt = true;
            }
            if(Noda.enter != null)
            {
                string s = "";
                for(int i = 0; i < Controller.nods.Count; i++)
                {
                    if(Controller.nods[i].Visul == Noda.enter)
                    {
                        s += "Нода № " + (i + 1);
                        switch(Controller.nods[i].information.type)
                        {
                            case "if":
                                {
                                    s += ", Зависит от нод № ";
                                    for(int j = 0; j < (Controller.nods[i].information as External_module.if_operator).up_connection.Count; j++)
                                    {
                                        for(int k = 0; k < Controller.nods.Count; k++)
                                        {
                                            if((Controller.nods[i].information as External_module.if_operator).up_connection[j] == Controller.nods[k].information)
                                            {
                                                s += (k + 1) + ((j+1< (Controller.nods[i].information as External_module.if_operator).up_connection.Count) ? ", " : "");
                                                break;
                                            }
                                        }
                                    }
                                }
                                break;
                            case "Result":
                                {
                                    s += ", Зависит от ноды №  ";
                                        for (int k = 0; k < Controller.nods.Count; k++)
                                        {
                                            if ((Controller.nods[i].information as External_module.Result).up_Conected == Controller.nods[k].information)
                                            {
                                                s += (k + 1) + ", ";
                                                break;
                                            }
                                        }
                                        for(int k = 0; k < Controller.results.Count; k++)
                                        {
                                            if((Controller.nods[i].information as External_module.Result) == Controller.results[k].information)
                                            {
                                                s += "№ выхода для выода " + (k+1);
                                            }
                                        }
                                }
                                break;
                            case "operator":
                                {
                                    s += ", Зависит от нод № ";
                                    for (int j = 0; j < (Controller.nods[i].information as External_module.Operators).up_Conection.Count; j++)
                                    {
                                        for (int k = 0; k < Controller.nods.Count; k++)
                                        {
                                            if ((Controller.nods[i].information as External_module.Operators).up_Conection[j] == Controller.nods[k].information)
                                            {
                                                s += (k + 1) + ((j + 1 < (Controller.nods[i].information as External_module.Operators).up_Conection.Count) ? ", " : "");
                                                break;
                                            }
                                        }
                                    }
                                }
                                break;
                            case "Data":
                                {
                                    for(int j = 0; j < Controller.dates.Count; j++)
                                    {
                                        if ((Controller.nods[i].information as External_module.Data) == Controller.dates[j].information)
                                        {
                                            s += ", № входа данных " + (j + 1);
                                        }
                                    }
                                }
                                break;
                        }
                        break;

                    }
                }
                toolStripStatusLabel1.Text = s;
            }
            else
            {
                toolStripStatusLabel1.Text = "";
            }
            if (Noda.Paintt)
            {
                Refresh();
                Noda.Paintt = false;
            }
            if(Interpretator.progress != progress)
            {
                progress = Interpretator.progress;
                toolStripProgressBar1.Value = progress;
            }
        }


        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("N", "Data", working_Data, ref text);
            working_Data.label.Text = "N";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("Z", "Data", working_Data, ref text);
            working_Data.label.Text = "Z";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("Q", "Data", working_Data, ref text);
            working_Data.label.Text = "Q";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("P", "Data", working_Data, ref text);
            working_Data.label.Text = "P";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void модульЧислаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("ABS", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "ABS";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void минусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("(-1)", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "(-1)";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void производнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("DIF", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "f'(x)";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void старшийКоэфицентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("LED", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "LED";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void степеньПолиномаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("deg", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "deg";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void вынесениеНОКЧислителяИНОДЗнаменателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("FAC", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "НОД/\nНОК";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }


        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("Down", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "⊆";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("up", "Uno_operator", working_Data, ref text);
            working_Data.label.Text = "∈";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("-", "Bin_operator", working_Data, ref text);
            working_Data.label.Text = "SUB";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void делениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("/", "Bin_operator", working_Data, ref text);
            working_Data.label.Text = "DIV";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void остатокОтДеленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("%", "Bin_operator", working_Data, ref text);
            working_Data.label.Text = "MOD";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void суммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("+", "N_operator", working_Data, ref text);
            working_Data.label.Text = "∑";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void произведениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("*", "N_operator", working_Data, ref text);
            working_Data.label.Text = "Π";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void нОДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data working_Data = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("НОД", "N_operator", working_Data, ref text);
            working_Data.label.Text = "НОД";
            working_Data.Show();
            panel1.Controls.Add(working_Data);
            working_Data.BringToFront();
        }

        private void нОКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.Working_data if_Operator = new MVS_Controller.Working_data(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("НОК", "N_operator", if_Operator, ref text);
            if_Operator.label.Text = "НОК";
            if_Operator.Show();
            panel1.Controls.Add(if_Operator);
            if_Operator.BringToFront();
        }

        private void сравнениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.if_operator if_Operator = new MVS_Controller.if_operator(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("COM_NN_D", "if_operator", if_Operator, ref text);
            if_Operator.label.Text = "><=";
            if_Operator.Butt_ini(text);
            if_Operator.Show();
            panel1.Controls.Add(if_Operator);
            if_Operator.BringToFront();
        }

        private void определениеЗнакаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MVS_Controller.if_operator if_Operator = new MVS_Controller.if_operator(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("isDown", "if_operator", if_Operator, ref text);
            if_Operator.label.Text = "isDown";
            if_Operator.Butt_ini(text);
            if_Operator.Show();
            panel1.Controls.Add(if_Operator);
            if_Operator.BringToFront();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Result result = new Result(this, panel1);
            string[] text = null;
            Controller.Create_new_Nod("Result", "Result", result, ref text);
            result.label.Text = "Вывод";
            result.Show();
            panel1.Controls.Add(result);
            result.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(50, 50, 50), 3);
            pen.EndCap = LineCap.ArrowAnchor;
            pen.StartCap = LineCap.Round;
            for (int i = 0; i < Controller.working_Dates.Count; i++)
            {
                for (int j = 0; j < Controller.working_Dates[i].information.down_Contacted.Count; j++)
                {
                    MVS_Controller.Working_data data = Controller.working_Dates[i].Visul as MVS_Controller.Working_data;
                    Noda noda = null;
                    for (int k = 0; k < Controller.nods.Count; k++)
                    {
                        if(Controller.nods[k].information == Controller.working_Dates[i].information.down_Contacted[j])
                        {
                            noda = Controller.nods[k].Visul as Noda;
                            break;
                        }
                    }
                    graphics.DrawLine(pen, data.Location.X + data.Width, data.Location.Y + (data.Height/2), noda.Location.X, noda.Location.Y + (noda.Height/2));
                }
            }
            for (int i = 0; i < Controller.if_Operators.Count; i++)
            {
                for(int j = 0; j < Controller.if_Operators[i].information.exits.Length; j++)
                {
                    Button if_ = (Controller.if_Operators[i].Visul as MVS_Controller.if_operator).down_contacts[j];
                    for(int k = 0; k < Controller.if_Operators[i].information.exits[j].Count; k++)
                    {
                        Noda noda = null;
                        for(int q = 0; q < Controller.nods.Count; q++)
                        {
                            if(Controller.nods[q].information == Controller.if_Operators[i].information.exits[j][k])
                            {
                                noda = Controller.nods[q].Visul as Noda;
                                break;
                            }
                        }
                        graphics.DrawLine(pen, if_.Location.X + if_.Width + if_.Parent.Location.X, if_.Location.Y + (if_.Height / 2) + if_.Parent.Location.Y, noda.Location.X, noda.Location.Y + (noda.Height / 2));
                    }

                }
            }
        }

        public void Main_Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && Noda.Active != null)
            {
                for (int i = 0; i < Controller.nods.Count; i++)
                {
                    if (Noda.Active == Controller.nods[i].Visul)
                    {
                        if (Controller.nods[i].information.isDelete)
                        {
                            Controller.Delete(Noda.Active);
                            panel1.Controls.Remove(Noda.Active);
                            Noda.Active = null;
                        }
                        else
                        {
                            Controller.nods[i].information.Delete();
                            for(int j = 0; j < Controller.nods.Count; j++)
                            {
                                Controller.nods[j].information.Delete_Element(Controller.nods[i].information);
                            }
                        }
                        Refresh();
                        return;
                    }
                }
            }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Interpretation_Controller.Interpretator.Interpretate();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\Resources\\Spravka.docx");
        }
    }
}
