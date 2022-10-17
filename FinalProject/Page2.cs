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
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject
{
    public partial class Page2 : MetroSetForm
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Page2_Load(object sender, EventArgs e)
        {
           var Proc = Process.GetProcesses();
            foreach(Process p in Proc)
            {
                //listView1.Items.Add(p.ProcessName);
                //listView1.Items.Add(p.ProcessName);
            }
            timer1.Start();
            

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            //cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis { Title = "cpu" });
            //cartesianChart1.Series.Clear();
            //LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
            //series.Add(new LineSeries() { Title = "cpu" ,Values=new ChartValues<double>(fcpu) } );
            //cartesianChart1.Series["CPU"]




            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);

        }
    }
}
