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

namespace FinalProject
{
    public partial class Page5 : MetroSetForm
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Page5_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = guna2TextBox1.Text;
                guna2TextBox1.Clear();
                p.Start();
            }
            catch (Exception r)
            { }
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = guna2TextBox1.Text;
                guna2TextBox1.Clear();
                p.Start();
            }
            catch(Exception r)
            { }
            }
        }
    }
}
