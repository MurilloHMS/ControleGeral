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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            panel4 = new Panel();
            chartVeiculosPorMarca = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            chartVeiculosAtIn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            label1 = new Label();
            TxtQuantVeiculo = new Label();
            panel2 = new Panel();
            DgvVeiculos = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVeiculosPorMarca).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVeiculosAtIn).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvVeiculos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(13, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(857, 244);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dash Informações Veiculos";
            // 
            // panel4
            // 
            panel4.Controls.Add(chartVeiculosPorMarca);
            panel4.Location = new Point(214, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(431, 170);
            panel4.TabIndex = 6;
            // 
            // chartVeiculosPorMarca
            // 
            chartVeiculosPorMarca.BackColor = Color.Lavender;
            chartVeiculosPorMarca.BorderlineColor = Color.Lavender;
            chartArea1.Name = "ChartArea1";
            chartVeiculosPorMarca.ChartAreas.Add(chartArea1);
            chartVeiculosPorMarca.Dock = DockStyle.Fill;
            legend1.BackColor = Color.Lavender;
            legend1.Name = "Legend1";
            chartVeiculosPorMarca.Legends.Add(legend1);
            chartVeiculosPorMarca.Location = new Point(0, 0);
            chartVeiculosPorMarca.Name = "chartVeiculosPorMarca";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartVeiculosPorMarca.Series.Add(series1);
            chartVeiculosPorMarca.Size = new Size(431, 170);
            chartVeiculosPorMarca.TabIndex = 0;
            chartVeiculosPorMarca.Text = "chart1";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(316, 19);
            label3.Name = "label3";
            label3.Size = new Size(213, 36);
            label3.TabIndex = 5;
            label3.Text = "Resumo de Veiculos por Marca";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(619, 19);
            label2.Name = "label2";
            label2.Size = new Size(182, 36);
            label2.TabIndex = 5;
            label2.Text = "Resumo De Veiculos Ativos e Inativos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(chartVeiculosAtIn);
            panel3.Location = new Point(601, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 170);
            panel3.TabIndex = 4;
            // 
            // chartVeiculosAtIn
            // 
            chartVeiculosAtIn.BackColor = Color.Lavender;
            chartVeiculosAtIn.BorderlineColor = Color.Lavender;
            chartVeiculosAtIn.BorderlineWidth = 0;
            chartArea2.BackColor = Color.Lavender;
            chartArea2.Name = "ChartArea1";
            chartVeiculosAtIn.ChartAreas.Add(chartArea2);
            chartVeiculosAtIn.Dock = DockStyle.Fill;
            legend2.BackColor = Color.Lavender;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            chartVeiculosAtIn.Legends.Add(legend2);
            chartVeiculosAtIn.Location = new Point(0, 0);
            chartVeiculosAtIn.Margin = new Padding(0);
            chartVeiculosAtIn.Name = "chartVeiculosAtIn";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieLabelStyle=Disabled, CollectedColor=Transparent";
            series2.LabelForeColor = Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartVeiculosAtIn.Series.Add(series2);
            chartVeiculosAtIn.Size = new Size(200, 170);
            chartVeiculosAtIn.TabIndex = 1;
            chartVeiculosAtIn.Text = "chart1";
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
            // panel2
            // 
            panel2.Controls.Add(DgvVeiculos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 375);
            panel2.TabIndex = 2;
            // 
            // DgvVeiculos
            // 
            DgvVeiculos.AllowUserToAddRows = false;
            DgvVeiculos.AllowUserToDeleteRows = false;
            DgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVeiculos.Dock = DockStyle.Fill;
            DgvVeiculos.Location = new Point(0, 0);
            DgvVeiculos.Name = "DgvVeiculos";
            DgvVeiculos.ReadOnly = true;
            DgvVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvVeiculos.Size = new Size(851, 375);
            DgvVeiculos.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(panel2);
            groupBox2.Location = new Point(16, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(857, 397);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Veiculos";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Location = new Point(16, 715);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(854, 258);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resumo Custos Veiculos";
            // 
            // Frm_Dashboard_Uc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Lavender;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_Dashboard_Uc";
            Size = new Size(887, 703);
            Load += Frm_Dashboard_Uc_Load;
            groupBox1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartVeiculosPorMarca).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartVeiculosAtIn).EndInit();
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
        private Panel panel2;
        private DataGridView DgvVeiculos;
        private Panel panel3;
        private GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVeiculosAtIn;
        private Label label2;
        private Panel panel4;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVeiculosPorMarca;
        private GroupBox groupBox3;
    }
}
