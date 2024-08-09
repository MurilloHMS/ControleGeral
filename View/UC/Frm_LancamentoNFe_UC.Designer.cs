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
            panelLancamentoPedido = new Panel();
            btnRegistrar = new Button();
            TxtValorUnitario = new TextBox();
            label19 = new Label();
            TxtQuantidade = new TextBox();
            label18 = new Label();
            TxtDescricao = new TextBox();
            label17 = new Label();
            TxtReferencia = new TextBox();
            label16 = new Label();
            TxtID = new TextBox();
            CbNaturezaOpe = new ComboBox();
            label1 = new Label();
            label10 = new Label();
            label2 = new Label();
            DtpDataRevisao = new DateTimePicker();
            TxtID_Veiculo = new TextBox();
            DtpDataEmissao = new DateTimePicker();
            label3 = new Label();
            mTxtCnpjDes = new MaskedTextBox();
            TxtVeiculo = new TextBox();
            mTxtCnpjRem = new MaskedTextBox();
            label7 = new Label();
            BtnBuscaVeiculo = new Button();
            label12 = new Label();
            TxtNumNFe = new TextBox();
            label14 = new Label();
            label6 = new Label();
            label15 = new Label();
            TxtSerie = new TextBox();
            TxtRzSocialRem = new TextBox();
            label5 = new Label();
            label13 = new Label();
            TxtChave = new TextBox();
            label8 = new Label();
            label4 = new Label();
            TxtRzSocialDest = new TextBox();
            TxtTotProd = new TextBox();
            label9 = new Label();
            label11 = new Label();
            TxtTotNFe = new TextBox();
            groupBox2 = new GroupBox();
            DgvDadosNFe = new DataGridView();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panelLancamentoPedido.SuspendLayout();
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
            toolStrip1.Size = new Size(894, 25);
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
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(panelLancamentoPedido);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(894, 419);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados NFe";
            // 
            // panelLancamentoPedido
            // 
            panelLancamentoPedido.Controls.Add(btnRegistrar);
            panelLancamentoPedido.Controls.Add(TxtValorUnitario);
            panelLancamentoPedido.Controls.Add(label19);
            panelLancamentoPedido.Controls.Add(TxtQuantidade);
            panelLancamentoPedido.Controls.Add(label18);
            panelLancamentoPedido.Controls.Add(TxtDescricao);
            panelLancamentoPedido.Controls.Add(label17);
            panelLancamentoPedido.Controls.Add(TxtReferencia);
            panelLancamentoPedido.Controls.Add(label16);
            panelLancamentoPedido.Controls.Add(TxtID);
            panelLancamentoPedido.Controls.Add(CbNaturezaOpe);
            panelLancamentoPedido.Controls.Add(label1);
            panelLancamentoPedido.Controls.Add(label10);
            panelLancamentoPedido.Controls.Add(label2);
            panelLancamentoPedido.Controls.Add(DtpDataRevisao);
            panelLancamentoPedido.Controls.Add(TxtID_Veiculo);
            panelLancamentoPedido.Controls.Add(DtpDataEmissao);
            panelLancamentoPedido.Controls.Add(label3);
            panelLancamentoPedido.Controls.Add(mTxtCnpjDes);
            panelLancamentoPedido.Controls.Add(TxtVeiculo);
            panelLancamentoPedido.Controls.Add(mTxtCnpjRem);
            panelLancamentoPedido.Controls.Add(label7);
            panelLancamentoPedido.Controls.Add(BtnBuscaVeiculo);
            panelLancamentoPedido.Controls.Add(label12);
            panelLancamentoPedido.Controls.Add(TxtNumNFe);
            panelLancamentoPedido.Controls.Add(label14);
            panelLancamentoPedido.Controls.Add(label6);
            panelLancamentoPedido.Controls.Add(label15);
            panelLancamentoPedido.Controls.Add(TxtSerie);
            panelLancamentoPedido.Controls.Add(TxtRzSocialRem);
            panelLancamentoPedido.Controls.Add(label5);
            panelLancamentoPedido.Controls.Add(label13);
            panelLancamentoPedido.Controls.Add(TxtChave);
            panelLancamentoPedido.Controls.Add(label8);
            panelLancamentoPedido.Controls.Add(label4);
            panelLancamentoPedido.Controls.Add(TxtRzSocialDest);
            panelLancamentoPedido.Controls.Add(TxtTotProd);
            panelLancamentoPedido.Controls.Add(label9);
            panelLancamentoPedido.Controls.Add(label11);
            panelLancamentoPedido.Controls.Add(TxtTotNFe);
            panelLancamentoPedido.Location = new Point(3, 19);
            panelLancamentoPedido.MinimumSize = new Size(0, 250);
            panelLancamentoPedido.Name = "panelLancamentoPedido";
            panelLancamentoPedido.Size = new Size(913, 378);
            panelLancamentoPedido.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(743, 331);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(139, 25);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "Adicionar Registro";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // TxtValorUnitario
            // 
            TxtValorUnitario.Location = new Point(556, 333);
            TxtValorUnitario.Name = "TxtValorUnitario";
            TxtValorUnitario.Size = new Size(176, 23);
            TxtValorUnitario.TabIndex = 19;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(556, 315);
            label19.Name = "label19";
            label19.Size = new Size(78, 15);
            label19.TabIndex = 11;
            label19.Text = "Valor Unitário";
            // 
            // TxtQuantidade
            // 
            TxtQuantidade.Location = new Point(556, 287);
            TxtQuantidade.Name = "TxtQuantidade";
            TxtQuantidade.Size = new Size(176, 23);
            TxtQuantidade.TabIndex = 18;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(556, 269);
            label18.Name = "label18";
            label18.Size = new Size(69, 15);
            label18.TabIndex = 11;
            label18.Text = "Quantidade";
            // 
            // TxtDescricao
            // 
            TxtDescricao.CharacterCasing = CharacterCasing.Upper;
            TxtDescricao.Location = new Point(43, 333);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(471, 23);
            TxtDescricao.TabIndex = 17;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(43, 315);
            label17.Name = "label17";
            label17.Size = new Size(58, 15);
            label17.TabIndex = 11;
            label17.Text = "Descricao";
            // 
            // TxtReferencia
            // 
            TxtReferencia.CharacterCasing = CharacterCasing.Upper;
            TxtReferencia.Location = new Point(43, 287);
            TxtReferencia.Name = "TxtReferencia";
            TxtReferencia.Size = new Size(471, 23);
            TxtReferencia.TabIndex = 16;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(43, 269);
            label16.Name = "label16";
            label16.Size = new Size(62, 15);
            label16.TabIndex = 11;
            label16.Text = "Referencia";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(32, 24);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(43, 23);
            TxtID.TabIndex = 1;
            // 
            // CbNaturezaOpe
            // 
            CbNaturezaOpe.DropDownStyle = ComboBoxStyle.DropDownList;
            CbNaturezaOpe.FormattingEnabled = true;
            CbNaturezaOpe.Location = new Point(129, 24);
            CbNaturezaOpe.Name = "CbNaturezaOpe";
            CbNaturezaOpe.Size = new Size(121, 23);
            CbNaturezaOpe.TabIndex = 2;
            CbNaturezaOpe.SelectedIndexChanged += CbNaturezaOpe_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 6);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(129, 6);
            label10.Name = "label10";
            label10.Size = new Size(108, 15);
            label10.TabIndex = 4;
            label10.Text = "Natureza Operação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 66);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // DtpDataRevisao
            // 
            DtpDataRevisao.Format = DateTimePickerFormat.Short;
            DtpDataRevisao.Location = new Point(612, 200);
            DtpDataRevisao.Name = "DtpDataRevisao";
            DtpDataRevisao.Size = new Size(99, 23);
            DtpDataRevisao.TabIndex = 13;
            // 
            // TxtID_Veiculo
            // 
            TxtID_Veiculo.Location = new Point(32, 84);
            TxtID_Veiculo.Name = "TxtID_Veiculo";
            TxtID_Veiculo.Size = new Size(43, 23);
            TxtID_Veiculo.TabIndex = 3;
            // 
            // DtpDataEmissao
            // 
            DtpDataEmissao.Enabled = false;
            DtpDataEmissao.Format = DateTimePickerFormat.Short;
            DtpDataEmissao.Location = new Point(612, 150);
            DtpDataEmissao.Name = "DtpDataEmissao";
            DtpDataEmissao.Size = new Size(99, 23);
            DtpDataEmissao.TabIndex = 8;
            DtpDataEmissao.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 66);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Veiculo";
            // 
            // mTxtCnpjDes
            // 
            mTxtCnpjDes.Location = new Point(440, 199);
            mTxtCnpjDes.Mask = "00,000,000/0000-00";
            mTxtCnpjDes.Name = "mTxtCnpjDes";
            mTxtCnpjDes.Size = new Size(129, 23);
            mTxtCnpjDes.TabIndex = 12;
            // 
            // TxtVeiculo
            // 
            TxtVeiculo.CharacterCasing = CharacterCasing.Upper;
            TxtVeiculo.Location = new Point(81, 84);
            TxtVeiculo.Name = "TxtVeiculo";
            TxtVeiculo.Size = new Size(198, 23);
            TxtVeiculo.TabIndex = 4;
            // 
            // mTxtCnpjRem
            // 
            mTxtCnpjRem.Location = new Point(440, 149);
            mTxtCnpjRem.Mask = "00,000,000/0000-00";
            mTxtCnpjRem.Name = "mTxtCnpjRem";
            mTxtCnpjRem.Size = new Size(129, 23);
            mTxtCnpjRem.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 130);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 4;
            label7.Text = "Razão Social Remetente";
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
            BtnBuscaVeiculo.Location = new Point(285, 84);
            BtnBuscaVeiculo.Name = "BtnBuscaVeiculo";
            BtnBuscaVeiculo.Size = new Size(30, 23);
            BtnBuscaVeiculo.TabIndex = 5;
            BtnBuscaVeiculo.UseVisualStyleBackColor = false;
            BtnBuscaVeiculo.Click += BtnBuscaVeiculo_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(440, 130);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 4;
            label12.Text = "CNPJ Remetente";
            // 
            // TxtNumNFe
            // 
            TxtNumNFe.CharacterCasing = CharacterCasing.Upper;
            TxtNumNFe.Location = new Point(422, 84);
            TxtNumNFe.Name = "TxtNumNFe";
            TxtNumNFe.Size = new Size(75, 23);
            TxtNumNFe.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(615, 131);
            label14.Name = "label14";
            label14.Size = new Size(77, 15);
            label14.TabIndex = 4;
            label14.Text = "Data Emissão";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(422, 66);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 4;
            label6.Text = "Número NFe";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(615, 182);
            label15.Name = "label15";
            label15.Size = new Size(74, 15);
            label15.TabIndex = 4;
            label15.Text = "Data Revisão";
            // 
            // TxtSerie
            // 
            TxtSerie.CharacterCasing = CharacterCasing.Upper;
            TxtSerie.Location = new Point(503, 84);
            TxtSerie.Name = "TxtSerie";
            TxtSerie.Size = new Size(47, 23);
            TxtSerie.TabIndex = 7;
            // 
            // TxtRzSocialRem
            // 
            TxtRzSocialRem.CharacterCasing = CharacterCasing.Upper;
            TxtRzSocialRem.Location = new Point(32, 148);
            TxtRzSocialRem.Name = "TxtRzSocialRem";
            TxtRzSocialRem.Size = new Size(368, 23);
            TxtRzSocialRem.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(503, 66);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Serie";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(440, 180);
            label13.Name = "label13";
            label13.Size = new Size(100, 15);
            label13.TabIndex = 4;
            label13.Text = "CNPJ Destinatário";
            // 
            // TxtChave
            // 
            TxtChave.CharacterCasing = CharacterCasing.Upper;
            TxtChave.Location = new Point(556, 84);
            TxtChave.Name = "TxtChave";
            TxtChave.Size = new Size(293, 23);
            TxtChave.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 181);
            label8.Name = "label8";
            label8.Size = new Size(138, 15);
            label8.TabIndex = 4;
            label8.Text = "Razão Social Destinatário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(556, 66);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 4;
            label4.Text = "Chave de Acesso";
            // 
            // TxtRzSocialDest
            // 
            TxtRzSocialDest.CharacterCasing = CharacterCasing.Upper;
            TxtRzSocialDest.Location = new Point(32, 199);
            TxtRzSocialDest.Name = "TxtRzSocialDest";
            TxtRzSocialDest.Size = new Size(368, 23);
            TxtRzSocialDest.TabIndex = 11;
            // 
            // TxtTotProd
            // 
            TxtTotProd.Location = new Point(732, 200);
            TxtTotProd.Name = "TxtTotProd";
            TxtTotProd.Size = new Size(117, 23);
            TxtTotProd.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(732, 131);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 4;
            label9.Text = "Valor Total NFe";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(732, 182);
            label11.Name = "label11";
            label11.Size = new Size(112, 15);
            label11.TabIndex = 4;
            label11.Text = "Valor Total Produtos";
            // 
            // TxtTotNFe
            // 
            TxtTotNFe.Location = new Point(732, 149);
            TxtTotNFe.Name = "TxtTotNFe";
            TxtTotNFe.Size = new Size(117, 23);
            TxtTotNFe.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvDadosNFe);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 444);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(894, 357);
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
            DgvDadosNFe.Size = new Size(888, 335);
            DgvDadosNFe.TabIndex = 0;
            // 
            // Frm_LancamentoNFe_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Lavender;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Name = "Frm_LancamentoNFe_UC";
            Size = new Size(894, 685);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panelLancamentoPedido.ResumeLayout(false);
            panelLancamentoPedido.PerformLayout();
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
        private Panel panelLancamentoPedido;
        private Label label16;
        private TextBox TxtValorUnitario;
        private Label label19;
        private TextBox TxtQuantidade;
        private Label label18;
        private TextBox TxtDescricao;
        private Label label17;
        private TextBox TxtReferencia;
        private Button btnRegistrar;
    }
}
