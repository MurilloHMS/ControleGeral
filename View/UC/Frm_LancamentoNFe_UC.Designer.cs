namespace KhoraControl.View.UC
{
    partial class Frm_LancamentoNFe_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LancamentoNFe_UC));
            toolStrip1 = new ToolStrip();
            abrirToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            groupBox1 = new GroupBox();
            CbNaturezaOpe = new ComboBox();
            label10 = new Label();
            DtpDataRevisao = new DateTimePicker();
            DtpDataEmissao = new DateTimePicker();
            mTxtCnpjDes = new MaskedTextBox();
            mTxtCnpjRem = new MaskedTextBox();
            BtnBuscaVeiculo = new Button();
            TxtNumNFe = new TextBox();
            label6 = new Label();
            TxtSerie = new TextBox();
            label5 = new Label();
            TxtChave = new TextBox();
            label4 = new Label();
            TxtTotProd = new TextBox();
            label11 = new Label();
            TxtTotNFe = new TextBox();
            label9 = new Label();
            TxtRzSocialDest = new TextBox();
            label8 = new Label();
            label13 = new Label();
            TxtRzSocialRem = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            label7 = new Label();
            TxtVeiculo = new TextBox();
            label3 = new Label();
            TxtID_Veiculo = new TextBox();
            label2 = new Label();
            TxtID = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            DgvDadosNFe = new DataGridView();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDadosNFe).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Lavender;
            toolStrip1.BackgroundImage = Properties.Resources._64px_HD_transparent_picture;
            toolStrip1.Items.AddRange(new ToolStripItem[] { abrirToolStripButton, salvarToolStripButton, toolStripSeparator1, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(980, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 22);
            abrirToolStripButton.Text = "&Abrir";
            abrirToolStripButton.Click += abrirToolStripButton_Click;
            // 
            // salvarToolStripButton
            // 
            salvarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarToolStripButton.Image = (Image)resources.GetObject("salvarToolStripButton.Image");
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(23, 22);
            salvarToolStripButton.Text = "&Salvar";
            salvarToolStripButton.Click += salvarToolStripButton_Click;
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
            groupBox1.Controls.Add(CbNaturezaOpe);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(DtpDataRevisao);
            groupBox1.Controls.Add(DtpDataEmissao);
            groupBox1.Controls.Add(mTxtCnpjDes);
            groupBox1.Controls.Add(mTxtCnpjRem);
            groupBox1.Controls.Add(BtnBuscaVeiculo);
            groupBox1.Controls.Add(TxtNumNFe);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TxtSerie);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtChave);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtTotProd);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(TxtTotNFe);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(TxtRzSocialDest);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(TxtRzSocialRem);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtVeiculo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtID_Veiculo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtID);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(980, 274);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados NFe";
            // 
            // CbNaturezaOpe
            // 
            CbNaturezaOpe.DropDownStyle = ComboBoxStyle.DropDownList;
            CbNaturezaOpe.FormattingEnabled = true;
            CbNaturezaOpe.Location = new Point(132, 54);
            CbNaturezaOpe.Name = "CbNaturezaOpe";
            CbNaturezaOpe.Size = new Size(121, 23);
            CbNaturezaOpe.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(132, 36);
            label10.Name = "label10";
            label10.Size = new Size(108, 15);
            label10.TabIndex = 4;
            label10.Text = "Natureza Operação";
            // 
            // DtpDataRevisao
            // 
            DtpDataRevisao.Format = DateTimePickerFormat.Short;
            DtpDataRevisao.Location = new Point(615, 230);
            DtpDataRevisao.Name = "DtpDataRevisao";
            DtpDataRevisao.Size = new Size(99, 23);
            DtpDataRevisao.TabIndex = 9;
            // 
            // DtpDataEmissao
            // 
            DtpDataEmissao.Enabled = false;
            DtpDataEmissao.Format = DateTimePickerFormat.Short;
            DtpDataEmissao.Location = new Point(615, 180);
            DtpDataEmissao.Name = "DtpDataEmissao";
            DtpDataEmissao.Size = new Size(99, 23);
            DtpDataEmissao.TabIndex = 8;
            // 
            // mTxtCnpjDes
            // 
            mTxtCnpjDes.Location = new Point(443, 229);
            mTxtCnpjDes.Mask = "00,000,000/0000-00";
            mTxtCnpjDes.Name = "mTxtCnpjDes";
            mTxtCnpjDes.Size = new Size(129, 23);
            mTxtCnpjDes.TabIndex = 7;
            // 
            // mTxtCnpjRem
            // 
            mTxtCnpjRem.Location = new Point(443, 179);
            mTxtCnpjRem.Mask = "00,000,000/0000-00";
            mTxtCnpjRem.Name = "mTxtCnpjRem";
            mTxtCnpjRem.Size = new Size(129, 23);
            mTxtCnpjRem.TabIndex = 7;
            // 
            // BtnBuscaVeiculo
            // 
            BtnBuscaVeiculo.BackColor = Color.Transparent;
            BtnBuscaVeiculo.BackgroundImage = Properties.Resources.Search;
            BtnBuscaVeiculo.BackgroundImageLayout = ImageLayout.Zoom;
            BtnBuscaVeiculo.Cursor = Cursors.Hand;
            BtnBuscaVeiculo.FlatAppearance.BorderSize = 0;
            BtnBuscaVeiculo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnBuscaVeiculo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnBuscaVeiculo.FlatStyle = FlatStyle.Flat;
            BtnBuscaVeiculo.Location = new Point(288, 114);
            BtnBuscaVeiculo.Name = "BtnBuscaVeiculo";
            BtnBuscaVeiculo.Size = new Size(30, 23);
            BtnBuscaVeiculo.TabIndex = 6;
            BtnBuscaVeiculo.UseVisualStyleBackColor = false;
            BtnBuscaVeiculo.Click += BtnBuscaVeiculo_Click;
            // 
            // TxtNumNFe
            // 
            TxtNumNFe.Location = new Point(425, 114);
            TxtNumNFe.Name = "TxtNumNFe";
            TxtNumNFe.Size = new Size(75, 23);
            TxtNumNFe.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 96);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 4;
            label6.Text = "Número NFe";
            // 
            // TxtSerie
            // 
            TxtSerie.Location = new Point(506, 114);
            TxtSerie.Name = "TxtSerie";
            TxtSerie.Size = new Size(47, 23);
            TxtSerie.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(506, 96);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Serie";
            // 
            // TxtChave
            // 
            TxtChave.Location = new Point(559, 114);
            TxtChave.Name = "TxtChave";
            TxtChave.Size = new Size(293, 23);
            TxtChave.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(559, 96);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 4;
            label4.Text = "Chave de Acesso";
            // 
            // TxtTotProd
            // 
            TxtTotProd.Location = new Point(735, 230);
            TxtTotProd.Name = "TxtTotProd";
            TxtTotProd.Size = new Size(117, 23);
            TxtTotProd.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(735, 212);
            label11.Name = "label11";
            label11.Size = new Size(112, 15);
            label11.TabIndex = 4;
            label11.Text = "Valor Total Produtos";
            // 
            // TxtTotNFe
            // 
            TxtTotNFe.Location = new Point(735, 179);
            TxtTotNFe.Name = "TxtTotNFe";
            TxtTotNFe.Size = new Size(117, 23);
            TxtTotNFe.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(735, 161);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 4;
            label9.Text = "Valor Total NFe";
            // 
            // TxtRzSocialDest
            // 
            TxtRzSocialDest.Location = new Point(35, 229);
            TxtRzSocialDest.Name = "TxtRzSocialDest";
            TxtRzSocialDest.Size = new Size(368, 23);
            TxtRzSocialDest.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 211);
            label8.Name = "label8";
            label8.Size = new Size(138, 15);
            label8.TabIndex = 4;
            label8.Text = "Razão Social Destinatário";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(443, 210);
            label13.Name = "label13";
            label13.Size = new Size(100, 15);
            label13.TabIndex = 4;
            label13.Text = "CNPJ Destinatário";
            // 
            // TxtRzSocialRem
            // 
            TxtRzSocialRem.Location = new Point(35, 178);
            TxtRzSocialRem.Name = "TxtRzSocialRem";
            TxtRzSocialRem.Size = new Size(368, 23);
            TxtRzSocialRem.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(618, 212);
            label15.Name = "label15";
            label15.Size = new Size(74, 15);
            label15.TabIndex = 4;
            label15.Text = "Data Revisão";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(618, 161);
            label14.Name = "label14";
            label14.Size = new Size(77, 15);
            label14.TabIndex = 4;
            label14.Text = "Data Emissão";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(443, 160);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 4;
            label12.Text = "CNPJ Remetente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 160);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 4;
            label7.Text = "Razão Social Remetente";
            // 
            // TxtVeiculo
            // 
            TxtVeiculo.Location = new Point(84, 114);
            TxtVeiculo.Name = "TxtVeiculo";
            TxtVeiculo.Size = new Size(198, 23);
            TxtVeiculo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 96);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Veiculo";
            // 
            // TxtID_Veiculo
            // 
            TxtID_Veiculo.Location = new Point(35, 114);
            TxtID_Veiculo.Name = "TxtID_Veiculo";
            TxtID_Veiculo.Size = new Size(43, 23);
            TxtID_Veiculo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 96);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(35, 54);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(43, 23);
            TxtID.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvDadosNFe);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 299);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(980, 357);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Conteudo NFe";
            // 
            // DgvDadosNFe
            // 
            DgvDadosNFe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDadosNFe.Dock = DockStyle.Fill;
            DgvDadosNFe.Location = new Point(3, 19);
            DgvDadosNFe.Name = "DgvDadosNFe";
            DgvDadosNFe.Size = new Size(974, 335);
            DgvDadosNFe.TabIndex = 0;
            // 
            // Frm_LancamentoNFe_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Name = "Frm_LancamentoNFe_UC";
            Size = new Size(980, 685);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDadosNFe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ajudaToolStripButton;
        private TextBox TxtVeiculo;
        private Label label3;
        private TextBox TxtID_Veiculo;
        private Label label2;
        private TextBox TxtID;
        private Label label1;
        private Button BtnBuscaVeiculo;
        private TextBox TxtNumNFe;
        private Label label6;
        private TextBox TxtSerie;
        private Label label5;
        private TextBox TxtChave;
        private Label label4;
        private DateTimePicker DtpDataRevisao;
        private DateTimePicker DtpDataEmissao;
        private MaskedTextBox mTxtCnpjDes;
        private MaskedTextBox mTxtCnpjRem;
        private TextBox TxtTotProd;
        private Label label11;
        private Label label10;
        private TextBox TxtTotNFe;
        private Label label9;
        private TextBox TxtRzSocialDest;
        private Label label8;
        private Label label13;
        private TextBox TxtRzSocialRem;
        private Label label15;
        private Label label14;
        private Label label12;
        private Label label7;
        private ComboBox CbNaturezaOpe;
        private DataGridView DgvDadosNFe;
    }
}
