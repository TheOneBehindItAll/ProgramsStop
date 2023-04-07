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

namespace fa_rss_stoper
{
    public partial class Form1 : Form
    {
        private Timer timer1;
        public string proccessName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTimer();
            textBox2.Text = Properties.Settings.Default.ProgramOne;
            textBox6.Text = Properties.Settings.Default.ProgramTwo;
            textBox8.Text = Properties.Settings.Default.ProgramThree;
            textBox10.Text = Properties.Settings.Default.ProgramFour;
            textBox12.Text = Properties.Settings.Default.ProgramFive;
            textBox14.Text = Properties.Settings.Default.ProgramSix;
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
            proccessName = textBox2.Text;
            foreach (Process Prosess in Process.GetProcessesByName(proccessName))
             Prosess.Kill();
            proccessName = textBox6.Text;
            foreach (Process Prosess in Process.GetProcessesByName(proccessName))
                Prosess.Kill();
            proccessName = textBox8.Text;
            foreach (Process Prosess in Process.GetProcessesByName(proccessName))
                Prosess.Kill();
            proccessName = textBox10.Text;
            foreach (Process Prosess in Process.GetProcessesByName(proccessName))
                Prosess.Kill();
            proccessName = textBox12.Text;
            foreach (Process Prosess in Process.GetProcessesByName(proccessName))
                Prosess.Kill();
            proccessName = textBox14.Text;
            foreach (Process Prosess in Process.GetProcessesByName(proccessName))
                Prosess.Kill();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //save
            Properties.Settings.Default.ProgramOne = textBox2.Text;
            Properties.Settings.Default.ProgramTwo = textBox6.Text;
            Properties.Settings.Default.ProgramThree = textBox8.Text;
            Properties.Settings.Default.ProgramFour = textBox10.Text;
            Properties.Settings.Default.ProgramFive = textBox12.Text;
            Properties.Settings.Default.ProgramSix = textBox14.Text;
            Properties.Settings.Default.Save();
        }
    }
}
