using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace CGSystem
{
    public partial class VisorReportes : Form
    {
        private ServiciosVencidos ServiciosVencidos1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        public VisorReportes(string nombre_reporte)
        {
            InitializeComponent();
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(nombre_reporte);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(708, 471);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorReportes
            // 
            this.ClientSize = new System.Drawing.Size(708, 471);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "VisorReportes";
            this.ResumeLayout(false);

        }
    }
}
