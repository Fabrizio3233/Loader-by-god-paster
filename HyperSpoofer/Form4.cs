using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();

            Process f = new Process();

            f.StartInfo.FileName = "cmd.exe";

            f.StartInfo.RedirectStandardInput = true;

            f.StartInfo.RedirectStandardError = true;

            f.StartInfo.RedirectStandardOutput = true;

            f.StartInfo.UseShellExecute = false;

            f.StartInfo.CreateNoWindow = true;

            f.Start();

            f.StandardInput.WriteLine("slmgr //B /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99");

            f.StandardInput.WriteLine("slmgr //B /skms kms8.msguides.com");

            f.StandardInput.WriteLine("slmgr //B /ato");

            MessageBox.Show("Done! Check if Windows is activated! \nIf any errors contact me on discord.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void HomeN_Click(object sender, EventArgs e)
        {
            this.Hide();

            Process f = new Process();

            f.StartInfo.FileName = "cmd.exe";

            f.StartInfo.RedirectStandardInput = true;

            f.StartInfo.RedirectStandardError = true;

            f.StartInfo.RedirectStandardOutput = true;

            f.StartInfo.UseShellExecute = false;

            f.StartInfo.CreateNoWindow = true;

            f.Start();

            f.StandardInput.WriteLine("slmgr //B /ipk 3KHY7-WNT83-DGQKR-F7HPR-844BM");

            f.StandardInput.WriteLine("slmgr //B /skms kms8.msguides.com");

            f.StandardInput.WriteLine("slmgr //B /ato");

            MessageBox.Show("Done! Check if Windows is activated! \nIf any errors contact me on discord.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Pro_Click(object sender, EventArgs e)
        {
            this.Hide();

            Process f = new Process();

            f.StartInfo.FileName = "cmd.exe";

            f.StartInfo.RedirectStandardInput = true;

            f.StartInfo.RedirectStandardError = true;

            f.StartInfo.RedirectStandardOutput = true;

            f.StartInfo.UseShellExecute = false;

            f.StartInfo.CreateNoWindow = true;

            f.Start();

            f.StandardInput.WriteLine("slmgr //B /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX");

            f.StandardInput.WriteLine("slmgr //B /skms kms8.msguides.com");

            f.StandardInput.WriteLine("slmgr //B /ato");

            MessageBox.Show("Done! Check if Windows is activated! \nIf any errors contact me on discord.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ProN_Click(object sender, EventArgs e)
        {
            this.Hide();

            Process f = new Process();

            f.StartInfo.FileName = "cmd.exe";

            f.StartInfo.RedirectStandardInput = true;

            f.StartInfo.RedirectStandardError = true;

            f.StartInfo.RedirectStandardOutput = true;

            f.StartInfo.UseShellExecute = false;

            f.StartInfo.CreateNoWindow = true;

            f.Start();

            f.StandardInput.WriteLine("slmgr //B /ipk MH37W-N47XK-V7XM9-C7227-GCQG9");

            f.StandardInput.WriteLine("slmgr //B /skms kms8.msguides.com");

            f.StandardInput.WriteLine("slmgr //B /ato");

            MessageBox.Show("Done! Check if Windows is activated! \nIf any errors contact me on discord.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Enterprise_Click(object sender, EventArgs e)
        {
            this.Hide();

            Process f = new Process();

            f.StartInfo.FileName = "cmd.exe";

            f.StartInfo.RedirectStandardInput = true;

            f.StartInfo.RedirectStandardError = true;

            f.StartInfo.RedirectStandardOutput = true;

            f.StartInfo.UseShellExecute = false;

            f.StartInfo.CreateNoWindow = true;

            f.Start();

            f.StandardInput.WriteLine("slmgr //B /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43");

            f.StandardInput.WriteLine("slmgr //B /skms kms8.msguides.com");

            f.StandardInput.WriteLine("slmgr //B /ato");

            MessageBox.Show("Done! Check if Windows is activated! \nIf any errors contact me on discord.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void EnterpriseN_Click(object sender, EventArgs e)
        {
            this.Hide();

            Process f = new Process();

            f.StartInfo.FileName = "cmd.exe";

            f.StartInfo.RedirectStandardInput = true;

            f.StartInfo.RedirectStandardError = true;

            f.StartInfo.RedirectStandardOutput = true;

            f.StartInfo.UseShellExecute = false;

            f.StartInfo.CreateNoWindow = true;

            f.Start();

            f.StandardInput.WriteLine("slmgr //B /ipk DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4");

            f.StandardInput.WriteLine("slmgr //B /skms kms8.msguides.com");

            f.StandardInput.WriteLine("slmgr //B /ato");

            MessageBox.Show("Done! Check if Windows is activated! \nIf any errors contact me on discord.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Education_Click(object sender, EventArgs e)
        {
            this.Hide();

            Process f = new Process();

            f.StartInfo.FileName = "cmd.exe";

            f.StartInfo.RedirectStandardInput = true;

            f.StartInfo.RedirectStandardError = true;

            f.StartInfo.RedirectStandardOutput = true;

            f.StartInfo.UseShellExecute = false;

            f.StartInfo.CreateNoWindow = true;

            f.Start();

            f.StandardInput.WriteLine("slmgr //B /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2");

            f.StandardInput.WriteLine("slmgr //B /skms kms8.msguides.com");

            f.StandardInput.WriteLine("slmgr //B /ato");

            MessageBox.Show("Done! Check if Windows is activated! \nIf any errors contact me on discord.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void EducationN_Click(object sender, EventArgs e)
        {
            this.Hide();

            Process f = new Process();

            f.StartInfo.FileName = "cmd.exe";

            f.StartInfo.RedirectStandardInput = true;

            f.StartInfo.RedirectStandardError = true;

            f.StartInfo.RedirectStandardOutput = true;

            f.StartInfo.UseShellExecute = false;

            f.StartInfo.CreateNoWindow = true;

            f.Start();

            f.StandardInput.WriteLine("slmgr //B /ipk 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ");

            f.StandardInput.WriteLine("slmgr //B /skms kms8.msguides.com");

            f.StandardInput.WriteLine("slmgr //B /ato");

            MessageBox.Show("Done! Check if Windows is activated! \nIf any errors contact me on discord.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
