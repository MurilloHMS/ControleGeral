namespace KhoraControl.View.UC
{
    partial class Frm_Dashboard_Uc
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            label2 = new Label();
            panel3 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            label1 = new Label();
            TxtQuantVeiculo = new Label();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            panel2 = new Panel();
            DgvVeiculos = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvVeiculos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(13, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(904, 244);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dash Informações Veiculos";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(700, 19);
            label2.Name = "label2";
            label2.Size = new Size(182, 36);
            label2.TabIndex = 5;
            label2.Text = "Resumo De Veiculos Ativos e Inativos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(chart1);
            panel3.Location = new Point(682, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 170);
            panel3.TabIndex = 4;
            // 
            // chart1
            // 
            chart1.BackColor = Color.Lavender;
            chart1.BorderlineColor = Color.Lavender;
            chart1.BorderlineWidth = 0;
            chartArea1.BackColor = Color.Lavender;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.BackColor = Color.Lavender;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Margin = new Padding(0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieLabelStyle=Disabled, CollectedColor=Transparent";
            series1.LabelForeColor = Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(200, 170);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TxtQuantVeiculo);
            panel1.Location = new Point(16, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 129);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Total de Veiculos ";
            // 
            // TxtQuantVeiculo
            // 
            TxtQuantVeiculo.Dock = DockStyle.Fill;
            TxtQuantVeiculo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtQuantVeiculo.Location = new Point(0, 0);
            TxtQuantVeiculo.Name = "TxtQuantVeiculo";
            TxtQuantVeiculo.Size = new Size(120, 129);
            TxtQuantVeiculo.TabIndex = 0;
            TxtQuantVeiculo.Text = "0";
            TxtQuantVeiculo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(806, 267);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(105, 23);
            comboBox4.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(695, 267);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(105, 23);
            comboBox3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(DgvVeiculos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(898, 346);
            panel2.TabIndex = 2;
            // 
            // DgvVeiculos
            // 
            DgvVeiculos.AllowUserToAddRows = false;
            DgvVeiculos.AllowUserToDeleteRows = false;
            DgvVeiculos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVeiculos.Location = new Point(0, 0);
            DgvVeiculos.Name = "DgvVeiculos";
            DgvVeiculos.ReadOnly = true;
            DgvVeiculos.Size = new Size(898, 346);
            DgvVeiculos.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(panel2);
            groupBox2.Location = new Point(13, 296);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(904, 368);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veiculos";
            // 
            // Frm_Dashboard_Uc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(groupBox2);
            Controls.Add(comboBox4);
            Controls.Add(groupBox1);
            Controls.Add(comboBox3);
            Name = "Frm_Dashboard_Uc";
            Size = new Size(931, 685);
            Load += Frm_Dashboard_Uc_Load;
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvVeiculos).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Panel panel1;
        private Label TxtQuantVeiculo;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Panel panel2;
        private DataGridView DgvVeiculos;
        private Panel panel3;
        private GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label2;
    }
}
