using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Module
{
    public struct data
    {
        public string name;
        public string text;
        public int image_number;
        public data(string n, string t, string i)
        {
            name = n;
            text = t;
            try
            {
                image_number = Convert.ToInt32(i);
            }
            catch { image_number = 0; }
        }
    }

    public partial class Info : Form
    {
        Main_Window main;
        List<data> datas = new List<data>();
        public Info(Main_Window main_)
        {
            main = main_;
            InitializeComponent(main_.first, main_.second, main_.therd, main_.text);
            FileStream file = new FileStream(Application.StartupPath + "\\Resources\\Spravka\\Spravka.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            while(!reader.EndOfStream)
            {
                string[] s = new string[3];
                for(int i = 0; i < 3; i++)
                {
                    for(string read = reader.ReadLine(); read != "~"; read = reader.ReadLine())
                    {
                        s[i] += read + ((i < 2) ?"\n" : "");
                    }
                }
                datas.Add(new data(s[0], s[1], s[2]));
            }
            reader.Close();
            file.Close();
            FormClosing += new FormClosingEventHandler(Close_Event);
            int x = 15, w = Convert.ToInt32(panel2.Width*0.8), h = 30, y = 10;
            for(int i = 0; i < datas.Count; i++)
            {
                Button button = new Button();
                button.Text = datas[i].name;
                button.Location = new Point(x, y);
                y += 10 + h;
                button.Size = new Size(w, h);
                button.BackColor = main_.therd;
                button.ForeColor = main_.text;
                panel2.Controls.Add(button);
                button.Show();
                button.Click += new EventHandler(Button_Click);
            }
            
        }


        void Button_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Text;
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            for (int i = 0; i < datas.Count; i++)
            {
                if(name == datas[i].name)
                {
                    label1.Text = datas[i].text;
                    if (datas[i].image_number != 0) pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Resources\\Spravka\\" + datas[i].image_number + ".jpg");
                    pictureBox1.Location = new Point(pictureBox1.Location.X, label1.Location.Y + label1.Height + 10);
                    break;
                }
            }
        }

        void Close_Event(object sender, FormClosingEventArgs e)
        {
            main.Enabled = true;
        }


    }
}
