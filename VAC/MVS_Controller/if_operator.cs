using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MVS_Controller
{
    public partial class if_operator : Noda
    {
        public Button[] down_contacts;
        public if_operator(Form parent, Panel panel) : base(parent, panel)
        {
            InitializeComponent();
            InitializeComponent();
            SizeChanged += new EventHandler(SizeChange);
        }

        public void Butt_ini(string[] args)
        {
            down_contacts = new Button[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                down_contacts[i] = new Button();
                Controls.Add(down_contacts[i]);
                down_contacts[i].FlatStyle = FlatStyle.Popup;
                down_contacts[i].BackgroundImageLayout = ImageLayout.Stretch;
                down_contacts[i].Size = new Size((int)(Width * 0.16), Height/args.Length);
                down_contacts[i].Location = new Point((int)(Width - (Width * 0.16)), i*(Height/args.Length));
                down_contacts[i].BackgroundImage = butt_image;
                down_contacts[i].BackColor = Color.Gray;
                down_contacts[i].Click += new EventHandler(Connect_start);
                down_contacts[i].Text = args[i];
                down_contacts[i].Font = new System.Drawing.Font("Trebuchet MS", down_contacts[i].Height > down_contacts[i].Width ? down_contacts[i].Width / 3.5f : down_contacts[i].Height / 3.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                down_contacts[i].Show();
            }
        }

        private static void SizeChange(object sender, EventArgs e)
        {
            if_operator if_ = sender as if_operator;
            for (int i = 0; i < if_.down_contacts.Length; i++)
            {
                if_.down_contacts[i].Size = new Size((int)(if_.Width * 0.16), if_.Height/ if_.down_contacts.Length);
                if_.down_contacts[i].Location = new Point((int)((if_).Width - ((if_).Width * 0.16)), i * (if_.Height / if_.down_contacts.Length));
                if_.down_contacts[i].Font = new System.Drawing.Font("Trebuchet MS", if_.down_contacts[i].Height > if_.down_contacts[i].Width ? if_.down_contacts[i].Width / 3.5f : if_.down_contacts[i].Height / 3.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            }
        }

        private static void Connect_start(object sender, EventArgs e)
        {
            if (conect_nod != (sender as Button))
            {
                if (conect_nod == null)
                {
                    (sender as Button).BackgroundImage = null;
                    conect_nod = (sender as Button);
                }
                else
                {
                    conect_nod.BackgroundImage = butt_image;
                    conect_nod = null;
                }
            }
            else
            {
                (sender as Button).BackgroundImage = butt_image;
                conect_nod = null;
            }
        }
    }
}
