using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using MetroFramework;
using MetroFramework.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        //this code to clear Recycle Bin
        enum RecycleFlags : int
        {
            SHERB_NOCONFIRMATION = 0x00000001, // Don't ask for confirmation
            SHERB_NOPROGRESSUI = 0x00000001, // Don't show progress
            SHERB_NOSOUND = 0x00000004 // Don't make sound when the action is executed
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);
        //end
        //to make header panel move 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //end

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //get the object from DriveInfo 
        System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\");

        private void timer1_Tick(object sender, EventArgs e)
        {
            //cpu Counter => get the value of performace counter
            float fcpu = cpucounter.NextValue();
            //set the value to process bar 
            cpubar.Value = (int)fcpu;
            //ram counter => get the value of ram performance counter 
            float fram = ramcounter.NextValue();
            //set the value to ram bar
            rambar.Value = (int)fram;
            //set the percentage value or cpu and ram 
            cpuper.Text = string.Format("{0:0.00}%", fcpu);
            ramper.Text = string.Format("{0:0.00}%", fram);
            //get the (total size - free size ) of the partition c
            double total = 1.0 * di.TotalSize / (1024 * 1024);
            double free = 1.0 * di.TotalFreeSpace / (1024 * 1024);
            double per = ((total - free) / total) * 100;
            memorybar.Value = (int)(per);
            memoryper.Text = string.Format("{0:0.00%}", per / 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //start the timer 1/min interval
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabpage1");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabpage2");
        }
        //to make header panel move 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Recyclebin_Click(object sender, EventArgs e)
        {
            SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHERB_NOCONFIRMATION);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //go thow all process in the system and compare the process name with in the textbox then kill it
          
                foreach (Process i in Process.GetProcesses())
                {
                    if (endprocrs.Text == i.ProcessName)
                    {
                        i.Kill();
                    }
                }
                endprocrs.Text="";
            
            

        }

        private void uninstaller_Click(object sender, EventArgs e)
        {
            //to open Programs and features 
            System.Diagnostics.Process.Start("control.exe", "appwiz.cpl");
            
        }

        private void startprocrss_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(startp.Text);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this,"This Process name Not Valid","Message",MessageBoxButtons.OK,MessageBoxIcon.Error,150);
            }
            startp.Text = "";
          
        }

        private void shutdown_Click(object sender, EventArgs e)
        {
            //shutdown the system
            Process.Start("shutdown", "/s /t 0");
        }
    }
}

