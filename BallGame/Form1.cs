using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGame
{
    public partial class Form1 : Form
    {
        Graphics g;
        Timer t = new Timer();
        bool b;
        public Form1()
        {
            InitializeComponent();
            t.Interval = 100;
        }
        public int i, q;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            i = 358;
            q = 0;
            for (int j = 0; j < 50; j++)
            {
                t.Tick += new EventHandler(timer1_Tick);
            }
                t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (0==i)
            {
                b = false;
            }
            if(i==358)
            {
                q++;
                b = true;
                if (q == 2)
                    t.Stop();
            }
            if (b)
            {
                i--;
            }
            else
            {
                i++;
            }
            pictureBox1.Location = new Point(193, i);
        }
    }
}
