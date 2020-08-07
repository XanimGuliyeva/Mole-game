using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostebek__oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random say = new Random();
        int xal = 0;
        public void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            for (int i = 0; i <= 11; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.Red;
                btn.ForeColor = Color.Black;
                btn.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(btn);
                btn.Width = 70;
                btn.Height = 70;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int texmini = say.Next(1, 11);
            foreach (var a in flowLayoutPanel1.Controls)
            {
                Button btn=a as Button;
                if ( btn.Text ==texmini.ToString())
                {
                    btn.BackColor = Color.Yellow;
                    btn.Click +=new EventHandler(btn_click);
                }
                else
                {
                    btn.BackColor = Color.Red;
                }
            }
        }

        void btn_click(object sender, EventArgs e) {

            Button btn = sender as Button;
            if (btn.BackColor==Color.Yellow)
            {
                xal ++;
                label2.Text = xal.ToString();
            }
            else
            {
                xal --;
                label2.Text = xal.ToString();
            }
         
        }
    }
}
