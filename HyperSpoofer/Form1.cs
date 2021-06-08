using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabrygame99;
using Loader;
using System.Threading;

namespace Loader
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int Handle, int showState);

        [DllImport("kernel32.dll")]
        public static extern int GetConsoleWindow();

        bool drag = false;
        Point start_point = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            //colorchanger();
        }
        public void colorchanger()
        {
            /*label6.ForeColor = Color.DarkCyan;
            Thread.Sleep(1000);
            label6.ForeColor = Color.DarkRed;
            colorchanger();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ooo.re();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 500;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int A = r.Next(0, 255);
            int R = r.Next(0, 255);
            int B = r.Next(0, 255);
            int G = r.Next(0, 255);
            int N = r.Next(254, 255);

            label1.ForeColor = Color.FromArgb(A, R, G, B);
            label3.ForeColor = Color.FromArgb(A, R, G, B);
            label5.ForeColor = Color.FromArgb(A, R, G, B);
            label4.ForeColor = Color.FromArgb(A, R, G, B);
            button2.ForeColor = Color.FromArgb(A, R, G, B);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Perform.changehwid();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            ooo.Permissionforactivation();
        }
    }
}

