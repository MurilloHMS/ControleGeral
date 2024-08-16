namespace KhoraControl.View.UC
{
    partial class Frm_ConsultaVeiculos_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultaVeiculos_UC));
            toolStrip1 = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            imprimirToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            recortarToolStripButton = new ToolStripButton();
            copiarToolStripButton = new ToolStripButton();
            colarToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtQuantNFe = new TextBox();
            txtQuantRevisoes = new TextBox();
            txtPlaca = new TextBox();
            txtAno = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtID = new TextBox();
            groupBox2 = new GroupBox();
            dgvRevisoes = new DataGridView();
            dtgNotasFiscais = new GroupBox();
            dgvNFe = new DataGridView();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevisoes).BeginInit();
            dtgNotasFiscais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNFe).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackgroundImage = Properties.Resources._64px_HD_transparent_picture;
            toolStrip1.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, salvarToolStripButton, imprimirToolStripButton, toolStripSeparator, recortarToolStripButton, copiarToolStripButton, colarToolStripButton, toolStripSeparator1, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(904, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // novaToolStripButton
            // 
            novaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            novaToolStripButton.Image = Properties.Resources.Search;
            novaToolStripButton.ImageTransparentColor = Color.Magenta;
            novaToolStripButton.Name = "novaToolStripButton";
            novaToolStripButton.Size = new Size(23, 22);
            novaToolStripButton.Text = "&BuscarVeiculo";
            novaToolStripButton.Click += novaToolStripButton_Click;
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 22);
            abrirToolStripButton.Text = "&Abrir";
            // 
            // salvarToolStripButton
            // 
            salvarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarToolStripButton.Image = (Image)resources.GetObject("salvarToolStripButton.Image");
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(23, 22);
            salvarToolStripButton.Text = "&Salvar";
            // 
            // imprimirToolStripButton
            // 
            imprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            imprimirToolStripButton.Image = (Image)resources.GetObject("imprimirToolStripButton.Image");
            imprimirToolStripButton.ImageTransparentColor = Color.Magenta;
            imprimirToolStripButton.Name = "imprimirToolStripButton";
            imprimirToolStripButton.Size = new Size(23, 22);
            imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // recortarToolStripButton
            // 
            recortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            recortarToolStripButton.Image = (Image)resources.GetObject("recortarToolStripButton.Image");
            recortarToolStripButton.ImageTransparentColor = Color.Magenta;
            recortarToolStripButton.Name = "recortarToolStripButton";
            recortarToolStripButton.Size = new Size(23, 22);
            recortarToolStripButton.Text = "R&ecortar";
            // 
            // copiarToolStripButton
            // 
            copiarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copiarToolStripButton.Image = (Image)resources.GetObject("copiarToolStripButton.Image");
            copiarToolStripButton.ImageTransparentColor = Color.Magenta;
            copiarToolStripButton.Name = "copiarToolStripButton";
            copiarToolStripButton.Size = new Size(23, 22);
            copiarToolStripButton.Text = "&Copiar";
            // 
            // colarToolStripButton
            // 
            colarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            colarToolStripButton.Image = (Image)resources.GetObject("colarToolStripButton.Image");
            colarToolStripButton.ImageTransparentColor = Color.Magenta;
            colarToolStripButton.Name = "colarToolStripButton";
            colarToolStripButton.Size = new Size(23, 22);
            colarToolStripButton.Text = "&Colar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(23, 22);
            ajudaToolStripButton.Text = "Aju&da";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtQuantNFe);
            groupBox1.Controls.Add(txtQuantRevisoes);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(txtAno);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(txtID);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(904, 139);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Veiculo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(621, 22);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 1;
            label8.Text = "Quant. NFes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(621, 68);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 1;
            label7.Text = "Quant. Revisões";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(492, 68);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 1;
            label6.Text = "Placa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(492, 21);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 1;
            label4.Text = "Ano";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 68);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 1;
            label3.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 21);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Marca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtQuantNFe
            // 
            txtQuantNFe.Location = new Point(621, 40);
            txtQuantNFe.Name = "txtQuantNFe";
            txtQuantNFe.ReadOnly = true;
            txtQuantNFe.Size = new Size(91, 23);
            txtQuantNFe.TabIndex = 0;
            // 
            // txtQuantRevisoes
            // 
            txtQuantRevisoes.Location = new Point(621, 87);
            txtQuantRevisoes.Name = "txtQuantRevisoes";
            txtQuantRevisoes.ReadOnly = true;
            txtQuantRevisoes.Size = new Size(91, 23);
            txtQuantRevisoes.TabIndex = 0;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(492, 87);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.ReadOnly = true;
            txtPlaca.Size = new Size(92, 23);
            txtPlaca.TabIndex = 0;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(492, 40);
            txtAno.Name = "txtAno";
            txtAno.ReadOnly = true;
            txtAno.Size = new Size(83, 23);
            txtAno.TabIndex = 0;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(109, 87);
            txtModelo.Name = "txtModelo";
            txtModelo.ReadOnly = true;
            txtModelo.Size = new Size(302, 23);
            txtModelo.TabIndex = 0;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(109, 40);
            txtMarca.Name = "txtMarca";
            txtMarca.ReadOnly = true;
            txtMarca.Size = new Size(302, 23);
            txtMarca.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(25, 39);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(49, 23);
            txtID.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvRevisoes);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(904, 194);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Revisões";
            // 
            // dgvRevisoes
            // 
            dgvRevisoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevisoes.Dock = DockStyle.Fill;
            dgvRevisoes.Location = new Point(3, 19);
            dgvRevisoes.Name = "dgvRevisoes";
            dgvRevisoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRevisoes.Size = new Size(898, 172);
            dgvRevisoes.TabIndex = 0;
            // 
            // dtgNotasFiscais
            // 
            dtgNotasFiscais.Controls.Add(dgvNFe);
            dtgNotasFiscais.Dock = DockStyle.Top;
            dtgNotasFiscais.Location = new Point(0, 358);
            dtgNotasFiscais.Name = "dtgNotasFiscais";
            dtgNotasFiscais.Size = new Size(904, 203);
            dtgNotasFiscais.TabIndex = 1;
            dtgNotasFiscais.TabStop = false;
            dtgNotasFiscais.Text = "Notas Fiscais";
            // 
            // dgvNFe
            // 
            dgvNFe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNFe.Dock = DockStyle.Fill;
            dgvNFe.Location = new Point(3, 19);
            dgvNFe.Name = "dgvNFe";
            dgvNFe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNFe.Size = new Size(898, 181);
            dgvNFe.TabIndex = 0;
            // 
            // Frm_ConsultaVeiculos_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(dtgNotasFiscais);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Name = "Frm_ConsultaVeiculos_UC";
            Size = new Size(904, 581);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRevisoes).EndInit();
            dtgNotasFiscais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNFe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton recortarToolStripButton;
        private ToolStripButton copiarToolStripButton;
        private ToolStripButton colarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ajudaToolStripButton;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtQuantNFe;
        private TextBox txtQuantRevisoes;
        private TextBox txtPlaca;
        private TextBox txtMarca;
        private TextBox textBox5;
        private TextBox txtAno;
        private TextBox txtModelo;
        private TextBox textBox2;
        private TextBox txtID;
        private GroupBox groupBox2;
        private DataGridView dgvRevisoes;
        private GroupBox dtgNotasFiscais;
        private DataGridView dgvNFe;
    }
}
