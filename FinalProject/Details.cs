using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using System.Diagnostics;

namespace FinalProject
{
    public partial class Details : MetroSetForm
    {
        public Details(Process value)
        {
            InitializeComponent();
            this.Value = value;
        }

        public Process Value { get; set; }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void Details_Load(object sender, EventArgs e)
        {
            labelName.Text = Value.ProcessName;
            label_ID.Text = Value.Id.ToString();
            label_StartTime.Text = Value.StartTime.ToString();
            labelM_name.Text = Value.MainModule.ModuleName;
            labelThreeds.Text = Value.Threads.Count.ToString();
            labelDescription.Text = Value.MainModule.FileVersionInfo.FileDescription;
            label_P_title.Text = Value.MainWindowTitle;
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
