using MetroSet_UI.Forms;
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
using MaterialSkin.Controls;


namespace FinalProject
{
    public partial class MaenPage : MetroSetForm
    {
        public MaenPage()
        {
            InitializeComponent();
        }
        int s30 = 30;
        int switchTimer = 0;
        
        private void MaenPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            timer2.Start();

            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 30000;
            var Proce = Process.GetProcesses();
            //materialListView1.Items.Clear();
            foreach (Process p in Proce)
            {
                p.Refresh();
               // listBox1.Items.Add(p.StartTime.Day+"/"+ p.StartTime.ToShortDateString() + "\t\t"+p.StartTime);
            }

            var Proc = Process.GetProcesses();
            listView1.Items.Clear();
            
            foreach (Process p in Proc)
            {
                
                ListViewItem item = new ListViewItem(p.ProcessName);
                item.SubItems.Add(p.Id.ToString());
                //item.SubItems.Add(p.StartInfo.UserName);
                var m = Convert.ToString(p.Threads.Count);
                item.SubItems.Add(m);

               // var c = Convert.ToString();
               // item.SubItems.Add(c);



                listView1.Items.Add(item);
                
                
                //listView1.Items.Add(p.ProcessName);
            }

            s30 = 30;
            switchTimer = 0;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] b = Process.GetProcessesByName(listView1.SelectedItems[0].Text);
                b[0].Kill();

                //for refresh

                timer1.Interval = 30000;
                var Proce = Process.GetProcesses();
                foreach (Process p in Proce)
                {
                    p.Refresh();
                }

                var Proc = Process.GetProcesses();
                listView1.Items.Clear();

                foreach (Process p in Proc)
                {

                    ListViewItem item = new ListViewItem(p.ProcessName);
                    item.SubItems.Add(p.Id.ToString());
                    var m = Convert.ToString(p.Threads.Count);
                    item.SubItems.Add(m);
                    listView1.Items.Add(item);
                }

                s30 = 30;
                switchTimer = 0;
                guna2ToggleSwitch1.Checked = false;
            }
            catch(Exception r)
            {
                MetroSetMessageBox.Show(this, "Missing Something \nPleace Try Again", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switchTimer++;
            s30--;
            metroSetLabel1.Text = Convert.ToString(s30);
            guna2CircleProgressBar1.Value = s30;
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            
            
            if (guna2ToggleSwitch1.Checked == true)
            {
                
                  
                timer1.Stop();

                timer2.Stop();
            }
            else if (guna2ToggleSwitch1.Checked == false)
            {
                timer1.Interval = 30000 - switchTimer * 1000;
                timer1.Start();
                timer2.Start();
                
            }
            
        }
        
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] b = Process.GetProcessesByName(listView1.SelectedItems[0].Text);
                Process bb = b[0];
                Details frm = new Details(bb);
                frm.Show();
                

            }
            catch (Exception r)
            {
                MetroSetMessageBox.Show(this, "Missing Something \nPleace Try Again", "ERORR", MessageBoxButtons.OK,MessageBoxIcon.Error);

                //MessageBox.Show( "Missing Something \nPleace Try Agene","ERORR", MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button2);
            }

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 30000;
            var Proce = Process.GetProcesses();
            foreach (Process p in Proce)
            {
                p.Refresh();
            }

            var Proc = Process.GetProcesses();
            listView1.Items.Clear();

            foreach (Process p in Proc)
            {

                ListViewItem item = new ListViewItem(p.ProcessName);
                item.SubItems.Add(p.Id.ToString());
                var m = Convert.ToString(p.Threads.Count);
                item.SubItems.Add(m);
                listView1.Items.Add(item);
            }

            s30 = 30;
            switchTimer = 0;
            guna2ToggleSwitch1.Checked = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
