using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;


namespace FinalProject
{
    public partial class Page3 : MetroSetForm
    {
        public Page3()
        {
            InitializeComponent();
        }

        public void CPUname()
        {
            ManagementObjectSearcher GG = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " +"Win32_Processor");
           foreach(ManagementObject v in GG.Get())
            {
                labelCPUname.Text = Convert.ToString(v["Name"]);
                
            }
        }

        public void GPUname()
        {
            ManagementObjectSearcher GG = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + "Win32_VideoController ");
            foreach (ManagementObject v in GG.Get())
            {
                labelGPUname.Text = Convert.ToString(v["Name"]);

            }
        }

        private void Page3_Load(object sender, EventArgs e)
        {
            labelPC_Name.Text = Environment.MachineName;
            labelOS_Version.Text = Environment.OSVersion.ToString();
            labelUserName.Text = Environment.UserName;
            labelVersion.Text = Environment.Version.ToString();
            labelDirectory.Text = Environment.SystemDirectory;
            labelCore.Text = Environment.ProcessorCount.ToString();
            labelPlatform.Text = Environment.OSVersion.Platform.ToString();

            if (Environment.Is64BitOperatingSystem == true)
            {
                labelTypeOS.Text = "64-Bit";
            }
            else labelTypeOS.Text = "32-Bit";

            if (Environment.Is64BitProcess == true)
            {
                labelType.Text = "64-Bit";
            }
            else labelType.Text = "32-Bit";



            //get compenent class
            CPUname();
            GPUname();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
