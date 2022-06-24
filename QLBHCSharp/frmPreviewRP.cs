using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine; 
namespace QLBHCSharp
{
    public partial class frmPreviewRP : Form
    {

       public frmPreviewRP(rptDMHH  rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt ;
        }

        private void frmPreviewRP_Load(object sender, EventArgs e)
        {
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
