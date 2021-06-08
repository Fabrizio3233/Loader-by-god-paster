using Fabrygame99;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Loader
{
    public partial class FormAccesso : Form
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        static int SW_SHOW = 5;
        static int SW_HIDE = 0;

        bool drag = false;
        Point start_point = new Point(0, 0);

        public FormAccesso()
        { 
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text == "cum")
            {
                this.Hide();
                try
                {
                    string ff = "C:\\ProgramData\\form.ddd";
                    if (File.Exists(ff))
                    {
                        var handle = GetConsoleWindow();
                        ShowWindow(handle, SW_HIDE);
                        Form1 f3 = new Form1();
                        new Thread(new ThreadStart(bhh.accessform)).Start();
                        Application.Run(f3);
                    }
                    else
                    {
                        var handle = GetConsoleWindow();
                        ShowWindow(handle, SW_SHOW);
                        new Thread(new ThreadStart(Program.Loader)).Start();
                    }
                }                        
                catch (Exception)
                {
                    MessageBox.Show("\nError, click OK to retry", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wrong key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormAccesso_Load(object sender, EventArgs e)
        {

        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
