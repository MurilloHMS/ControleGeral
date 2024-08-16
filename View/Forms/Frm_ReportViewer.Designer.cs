namespace KhoraControl.View.Forms
{
    partial class Frm_ReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reportGeralVeiculos = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportGeralVeiculos
            // 
            reportGeralVeiculos.AutoSize = true;
            reportGeralVeiculos.Dock = DockStyle.Fill;
            reportGeralVeiculos.Location = new Point(0, 0);
            reportGeralVeiculos.Name = "ReportViewer";
            reportGeralVeiculos.ServerReport.BearerToken = null;
            reportGeralVeiculos.Size = new Size(800, 450);
            reportGeralVeiculos.TabIndex = 0;
            // 
            // Frm_ReportViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Frm_ReportViewer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_ReportViewer";
            Load += Frm_ReportViewer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportGeralVeiculos;
    }
}