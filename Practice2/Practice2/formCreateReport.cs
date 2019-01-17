using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using FastReport.Design;

namespace Practice2
{
    public partial class formCreateReport : Form
    {
        public formCreateReport()
        {
            InitializeComponent();
        }

        private Report FReport;
        private string fileName = "ShopReport.frx";

        private void CreateReport(ref FastReport.Preview.PreviewControl pr)
        {
            FReport = new Report();
            FReport.Preview = pr;

            try
            {
                FReport.Load(fileName);
                FReport.Show();
            }
            catch (Exception ex) { MessageBox.Show("FastReport - " + ex.Message); }
        }
        private void formCreateReport_Load(object sender, EventArgs e)
        {
            FastReport.Preview.PreviewControl p = new FastReport.Preview.PreviewControl();
            p.Size = new Size(this.Size.Width, this.Size.Height);
            this.Controls.Add(p);

            CreateReport(ref p);
        }
        
    }
}
