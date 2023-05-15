using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace FileClose
{
    public partial class Form1 : Form
    {
        public Process bruh;
        private Timer timer1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.FormBorderStyle = FormBorderStyle.None;
         // this.TopMost = true;
        //   WindowState = FormWindowState.Maximized;
           this.ShowInTaskbar = false;
            //  foreach (Process windows in Process.GetProcessesByName("fa_rss"))
            //     windows.Kill();
            //  InitTimer();
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo("explorer.exe");
            p.StartInfo.Arguments = "/select";
            p.Start();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Process notepad in Process.GetProcessesByName("notepad"))
                notepad.Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Process unity in Process.GetProcessesByName("notepad"))
                unity.Kill();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

       
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lol();
        }
        public void lol()
        {
            foreach (Process windows in Process.GetProcessesByName("fa_rss"))
                windows.Kill();
           // this.FormBorderStyle = FormBorderStyle.None;
            //this.TopMost = true;
          //  WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "34541624162356516545136544654146551467567586756767344546234234342141231454432484685546554175564565846754885447834458324452444244284536454754876749740167419856143154213544f121v4v51561n5145121421441151456171781749179174184645434412413121214ad141jty1t41u1j4tr1y45t2652w5tge5g52ew95g2w5g52hg5tr41urh52ew5f5wef845h8r5j8r52bn5kuiy8l5y8kf58ge58f5w8f5ws85f85v5r21th5t1y4k1y1k8te/g*wf8w5fs8f5w45f1w95g1r9eh15rt1jh4r1j4f1k41utk4fnijfqewrjunoifewruhygtr5ejuhfgrjhfdrgjuhfdgtrvjhnjuhnffjuhgrg41gw41fg8er1gw541f59e1f5er1gersg15fd54851927137963756236929552th85serh54w8544874248465t6y5841y5tr841y5wtr84t65y4t54641t6y541t6y5t6y5")
            {
              //  Process.Start("shutdown", "/r /t 0"); 

            }
        }
    }
}
