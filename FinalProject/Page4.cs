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
    public partial class Page4 : MetroSetForm
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Page4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //تشغيل موجه الأوامر مع تنفيذ الأمر الموجود في التكست بوكس
                ProcessStartInfo procInfo = new ProcessStartInfo("cmd");

                procInfo.Arguments = "/c " + guna2TextBox2.Text.Trim();

                //من أجل ان تعود العملية بنتيجة التنفيذ
                procInfo.RedirectStandardOutput = true;
                procInfo.UseShellExecute = false;

                //من أجل عرض او اخفاء نافذة موجه الأوامر
                procInfo.CreateNoWindow = true;

                // ان شاء عملية جديدة
                Process proc = new Process();

                //تحديد معلومات تنفيذ العملية
                proc.StartInfo = procInfo;

                proc.Start();

                // قراءة النتيجة
                string result = proc.StandardOutput.ReadToEnd();

                guna2TextBox1.Text = result;
            }
        }
    }
}
