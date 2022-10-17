using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class splash_screen : MetroSetForm
    {
        int move = 2;
        public splash_screen()
        {

            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Panel22.Left += 2;

            if(Panel22.Left >255)
            {
                Panel22.Left = 0;

            }
            if(Panel22.Left < 0)
            {
                move = 0;
            }
        }

        private void splash_screen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();

        }

        private void run()
        {
            Application.Run(new Form1());
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            Form1 MyApp = new Form1();
            this.Hide();
            MyApp.Show();
            
        }
    }
}
