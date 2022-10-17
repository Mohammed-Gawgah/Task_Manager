using MetroSet_UI;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : MetroSetForm
    {
        public Form1()
        {

            //Thread thread = new Thread(new ThreadStart(run));
            //thread.Start();
            //Thread.Sleep(10000);
            InitializeComponent();
            //thread.Abort();
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            timer2.Start();

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel1.Controls.Clear();
            MaenPage frm = new MaenPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.guna2Panel1.Controls.Add(frm);
            frm.Show();

            
            


            //guna2Button1.FillColor = Color.Blue;
            

            


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel1.Controls.Clear();
            Page2 frm2 = new Page2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.guna2Panel1.Controls.Add(frm2);
            frm2.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            float a=0;
            var processCu = threadsCounter.NextValue() ;
            guna2CircleProgressBar1.Value = (int)fcpu;
            guna2CircleProgressBar2.Value = (int)fram;
            label7.Text = processCu.ToString();
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                a++;
            }
            label6.Text = a.ToString();
        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Panel1.Controls.Clear();
            Page3 frm = new Page3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.guna2Panel1.Controls.Add(frm);
            frm.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Panel1.Controls.Clear();
            Page4 frm = new Page4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.guna2Panel1.Controls.Add(frm);
            frm.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2Panel1.Controls.Clear();
            Page5 frm = new Page5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.guna2Panel1.Controls.Add(frm);
            frm.Show();
        }

        
         
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            //using(
            PageInfo frmInfo = new PageInfo() { Dock = DockStyle.Fill, TopLevel = true, TopMost = true };
                //)
           // {
                frmInfo.Show();
                //if(frmInfo.Closed==true)
               // guna2Button9.Enabled = false;
          //  }
                

            
            
        }

        private void guna2Button9_EnabledChanged(object sender, EventArgs e)
        {
            
            
               // guna2Button9.Enabled = true;
            
        }

        private void metroSetControlBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            MetroSetMessageBox.Show(this,"Have Great Experience With Our Application", "Welcom User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guna2WinProgressIndicator1.Visible = false;
            guna2Button10.Visible = true;
            
        }
    }
}
