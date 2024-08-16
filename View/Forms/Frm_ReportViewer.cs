using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhoraControl.View.Forms
{
    public partial class Frm_ReportViewer : Form
    {
        public Frm_ReportViewer()
        {
            InitializeComponent();
        }

        private void Frm_ReportViewer_Load(object sender, EventArgs e)
        {
            reportGeralVeiculos.LocalReport.DataSources.Clear();

            reportGeralVeiculos.LocalReport.ReportEmbeddedResource = "khoraControl.View.Reports.ReportVeiculosGeral.rdlc";
            reportGeralVeiculos.RefreshReport();
        }
    }
}
