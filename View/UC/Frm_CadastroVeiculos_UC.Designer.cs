namespace KhoraControl.View.UC
{
    partial class Frm_CadastroVeiculos_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroVeiculos_UC));
            groupBox1 = new GroupBox();
            cbEmpresa = new ComboBox();
            cbConcessionária = new ComboBox();
            TxtIDEmpresa = new TextBox();
            label19 = new Label();
            cbTipoVeiculo = new ComboBox();
            button1 = new Button();
            DtpDataProximaRevisao = new DateTimePicker();
            DtpDataUltimaRevisao = new DateTimePicker();
            DtpDataDaCompra = new DateTimePicker();
            TxtLocalSalvamento = new TextBox();
            label14 = new Label();
            TxtObs = new TextBox();
            label13 = new Label();
            TxtSugestaoConcessionaria = new TextBox();
            label12 = new Label();
            TxtNotaFiscalDeCompra = new TextBox();
            label18 = new Label();
            label11 = new Label();
            TxtKmProximaRevisao = new TextBox();
            label17 = new Label();
            label10 = new Label();
            TxtKmUltimaRevisao = new TextBox();
            label16 = new Label();
            label9 = new Label();
            TxtIDConcessionaria = new TextBox();
            label8 = new Label();
            TxtKmQuandoComprado = new TextBox();
            label21 = new Label();
            label20 = new Label();
            label15 = new Label();
            label7 = new Label();
            TxtModelo = new TextBox();
            label6 = new Label();
            TxtAno = new TextBox();
            label5 = new Label();
            TxtKmRodados = new TextBox();
            label4 = new Label();
            TxtPlaca = new TextBox();
            label3 = new Label();
            TxtMarca = new TextBox();
            label2 = new Label();
            TxtID = new TextBox();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cbEmpresa);
            groupBox1.Controls.Add(cbConcessionária);
            groupBox1.Controls.Add(TxtIDEmpresa);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(cbTipoVeiculo);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(DtpDataProximaRevisao);
            groupBox1.Controls.Add(DtpDataUltimaRevisao);
            groupBox1.Controls.Add(DtpDataDaCompra);
            groupBox1.Controls.Add(TxtLocalSalvamento);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(TxtObs);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(TxtSugestaoConcessionaria);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(TxtNotaFiscalDeCompra);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(TxtKmProximaRevisao);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(TxtKmUltimaRevisao);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(TxtIDConcessionaria);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(TxtKmQuandoComprado);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TxtModelo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TxtAno);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtKmRodados);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtPlaca);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtMarca);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(682, 501);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações Veiculo";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbEmpresa
            // 
            cbEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmpresa.FormattingEnabled = true;
            cbEmpresa.Location = new Point(464, 62);
            cbEmpresa.Name = "cbEmpresa";
            cbEmpresa.Size = new Size(191, 23);
            cbEmpresa.TabIndex = 22;
            cbEmpresa.SelectedIndexChanged += cbEmpresa_SelectedIndexChanged;
            // 
            // cbConcessionária
            // 
            cbConcessionária.DropDownStyle = ComboBoxStyle.DropDownList;
            cbConcessionária.FormattingEnabled = true;
            cbConcessionária.Location = new Point(163, 62);
            cbConcessionária.Name = "cbConcessionária";
            cbConcessionária.Size = new Size(211, 23);
            cbConcessionária.TabIndex = 22;
            cbConcessionária.SelectedIndexChanged += cbConcessionária_SelectedIndexChanged;
            // 
            // TxtIDEmpresa
            // 
            TxtIDEmpresa.Location = new Point(418, 62);
            TxtIDEmpresa.Name = "TxtIDEmpresa";
            TxtIDEmpresa.Size = new Size(35, 23);
            TxtIDEmpresa.TabIndex = 21;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(416, 44);
            label19.Name = "label19";
            label19.Size = new Size(18, 15);
            label19.TabIndex = 20;
            label19.Text = "ID";
            // 
            // cbTipoVeiculo
            // 
            cbTipoVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoVeiculo.FormattingEnabled = true;
            cbTipoVeiculo.Location = new Point(493, 273);
            cbTipoVeiculo.Name = "cbTipoVeiculo";
            cbTipoVeiculo.Size = new Size(162, 23);
            cbTipoVeiculo.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(640, 462);
            button1.Name = "button1";
            button1.Size = new Size(36, 23);
            button1.TabIndex = 18;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DtpDataProximaRevisao
            // 
            DtpDataProximaRevisao.Format = DateTimePickerFormat.Short;
            DtpDataProximaRevisao.Location = new Point(30, 232);
            DtpDataProximaRevisao.Name = "DtpDataProximaRevisao";
            DtpDataProximaRevisao.Size = new Size(122, 23);
            DtpDataProximaRevisao.TabIndex = 12;
            // 
            // DtpDataUltimaRevisao
            // 
            DtpDataUltimaRevisao.Format = DateTimePickerFormat.Short;
            DtpDataUltimaRevisao.Location = new Point(322, 171);
            DtpDataUltimaRevisao.Name = "DtpDataUltimaRevisao";
            DtpDataUltimaRevisao.Size = new Size(108, 23);
            DtpDataUltimaRevisao.TabIndex = 10;
            // 
            // DtpDataDaCompra
            // 
            DtpDataDaCompra.Format = DateTimePickerFormat.Short;
            DtpDataDaCompra.Location = new Point(30, 174);
            DtpDataDaCompra.Name = "DtpDataDaCompra";
            DtpDataDaCompra.Size = new Size(122, 23);
            DtpDataDaCompra.TabIndex = 8;
            // 
            // TxtLocalSalvamento
            // 
            TxtLocalSalvamento.Location = new Point(30, 462);
            TxtLocalSalvamento.Name = "TxtLocalSalvamento";
            TxtLocalSalvamento.ReadOnly = true;
            TxtLocalSalvamento.Size = new Size(604, 23);
            TxtLocalSalvamento.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(30, 444);
            label14.Name = "label14";
            label14.Size = new Size(171, 15);
            label14.TabIndex = 0;
            label14.Text = "Local Salvamento Documentos";
            // 
            // TxtObs
            // 
            TxtObs.Location = new Point(326, 332);
            TxtObs.Multiline = true;
            TxtObs.Name = "TxtObs";
            TxtObs.Size = new Size(333, 83);
            TxtObs.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(326, 314);
            label13.Name = "label13";
            label13.Size = new Size(74, 15);
            label13.TabIndex = 0;
            label13.Text = "Observações";
            // 
            // TxtSugestaoConcessionaria
            // 
            TxtSugestaoConcessionaria.Location = new Point(30, 332);
            TxtSugestaoConcessionaria.Multiline = true;
            TxtSugestaoConcessionaria.Name = "TxtSugestaoConcessionaria";
            TxtSugestaoConcessionaria.Size = new Size(268, 83);
            TxtSugestaoConcessionaria.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 314);
            label12.Name = "label12";
            label12.Size = new Size(138, 15);
            label12.TabIndex = 0;
            label12.Text = "Sugestão Concessionária";
            // 
            // TxtNotaFiscalDeCompra
            // 
            TxtNotaFiscalDeCompra.Location = new Point(30, 273);
            TxtNotaFiscalDeCompra.Name = "TxtNotaFiscalDeCompra";
            TxtNotaFiscalDeCompra.ReadOnly = true;
            TxtNotaFiscalDeCompra.Size = new Size(446, 23);
            TxtNotaFiscalDeCompra.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(493, 255);
            label18.Name = "label18";
            label18.Size = new Size(71, 15);
            label18.TabIndex = 0;
            label18.Text = "Tipo Veiculo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 255);
            label11.Name = "label11";
            label11.Size = new Size(127, 15);
            label11.TabIndex = 0;
            label11.Text = "Nota Fiscal de Compra";
            // 
            // TxtKmProximaRevisao
            // 
            TxtKmProximaRevisao.Location = new Point(176, 232);
            TxtKmProximaRevisao.Name = "TxtKmProximaRevisao";
            TxtKmProximaRevisao.Size = new Size(122, 23);
            TxtKmProximaRevisao.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(30, 214);
            label17.Name = "label17";
            label17.Size = new Size(124, 15);
            label17.TabIndex = 0;
            label17.Text = "Data Proxima Revisão ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(176, 214);
            label10.Name = "label10";
            label10.Size = new Size(115, 15);
            label10.TabIndex = 0;
            label10.Text = "Km Proxima Revisão";
            // 
            // TxtKmUltimaRevisao
            // 
            TxtKmUltimaRevisao.Location = new Point(447, 171);
            TxtKmUltimaRevisao.Name = "TxtKmUltimaRevisao";
            TxtKmUltimaRevisao.Size = new Size(108, 23);
            TxtKmUltimaRevisao.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(322, 153);
            label16.Name = "label16";
            label16.Size = new Size(111, 15);
            label16.TabIndex = 0;
            label16.Text = "Data ultima Revisão";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(447, 156);
            label9.Name = "label9";
            label9.Size = new Size(106, 15);
            label9.TabIndex = 0;
            label9.Text = "Km Ultima Revisão";
            // 
            // TxtIDConcessionaria
            // 
            TxtIDConcessionaria.Location = new Point(119, 62);
            TxtIDConcessionaria.Name = "TxtIDConcessionaria";
            TxtIDConcessionaria.Size = new Size(38, 23);
            TxtIDConcessionaria.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 156);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 0;
            label8.Text = "Data da Compra";
            // 
            // TxtKmQuandoComprado
            // 
            TxtKmQuandoComprado.Location = new Point(176, 174);
            TxtKmQuandoComprado.Name = "TxtKmQuandoComprado";
            TxtKmQuandoComprado.Size = new Size(131, 23);
            TxtKmQuandoComprado.TabIndex = 9;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(471, 44);
            label21.Name = "label21";
            label21.Size = new Size(52, 15);
            label21.TabIndex = 0;
            label21.Text = "Empresa";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(167, 44);
            label20.Name = "label20";
            label20.Size = new Size(87, 15);
            label20.TabIndex = 0;
            label20.Text = "Concessionária";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(117, 44);
            label15.Name = "label15";
            label15.Size = new Size(18, 15);
            label15.TabIndex = 0;
            label15.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 156);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 0;
            label7.Text = "Km Quando Comprado";
            // 
            // TxtModelo
            // 
            TxtModelo.Location = new Point(499, 122);
            TxtModelo.Name = "TxtModelo";
            TxtModelo.Size = new Size(156, 23);
            TxtModelo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(499, 104);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 0;
            label6.Text = "MODELO";
            // 
            // TxtAno
            // 
            TxtAno.Location = new Point(368, 122);
            TxtAno.Name = "TxtAno";
            TxtAno.Size = new Size(108, 23);
            TxtAno.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(368, 104);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 0;
            label5.Text = "ANO";
            // 
            // TxtKmRodados
            // 
            TxtKmRodados.Location = new Point(451, 229);
            TxtKmRodados.Name = "TxtKmRodados";
            TxtKmRodados.Size = new Size(104, 23);
            TxtKmRodados.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 211);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 0;
            label4.Text = "KM RODADOS";
            // 
            // TxtPlaca
            // 
            TxtPlaca.Location = new Point(248, 122);
            TxtPlaca.Name = "TxtPlaca";
            TxtPlaca.Size = new Size(100, 23);
            TxtPlaca.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 104);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "PLACA";
            // 
            // TxtMarca
            // 
            TxtMarca.Location = new Point(30, 122);
            TxtMarca.Name = "TxtMarca";
            TxtMarca.Size = new Size(212, 23);
            TxtMarca.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 104);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 0;
            label2.Text = "MARCA";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(30, 62);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(49, 23);
            TxtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, salvarToolStripButton, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(714, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // novaToolStripButton
            // 
            novaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            novaToolStripButton.Image = (Image)resources.GetObject("novaToolStripButton.Image");
            novaToolStripButton.ImageTransparentColor = Color.Magenta;
            novaToolStripButton.Name = "novaToolStripButton";
            novaToolStripButton.Size = new Size(23, 22);
            novaToolStripButton.Text = "&Novo";
            novaToolStripButton.ToolTipText = "Cadastrar Novo Veiculo";
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 22);
            abrirToolStripButton.Text = "&Abrir";
            abrirToolStripButton.ToolTipText = "Selecionar Documento De Compra";
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
            salvarToolStripButton.ToolTipText = "Salvar Alterações";
            salvarToolStripButton.Click += salvarToolStripButton_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
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
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 559);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(714, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // Frm_CadastroVeiculos_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Name = "Frm_CadastroVeiculos_UC";
            Size = new Size(714, 581);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private StatusStrip statusStrip1;
        private TextBox TxtLocalSalvamento;
        private Label label14;
        private TextBox TxtObs;
        private Label label13;
        private TextBox TxtSugestaoConcessionaria;
        private Label label12;
        private TextBox TxtNotaFiscalDeCompra;
        private Label label11;
        private TextBox TxtKmProximaRevisao;
        private Label label10;
        private TextBox TxtKmUltimaRevisao;
        private Label label9;
        private TextBox TxtIDConcessionaria;
        private Label label8;
        private TextBox TxtKmQuandoComprado;
        private Label label7;
        private TextBox TxtModelo;
        private Label label6;
        private TextBox TxtAno;
        private Label label5;
        private TextBox TxtKmRodados;
        private Label label4;
        private TextBox TxtPlaca;
        private Label label3;
        private TextBox TxtMarca;
        private Label label2;
        private TextBox TxtID;
        private Label label1;
        private DateTimePicker DtpDataProximaRevisao;
        private DateTimePicker DtpDataUltimaRevisao;
        private DateTimePicker DtpDataDaCompra;
        private Label label15;
        private Label label17;
        private Label label16;
        private Button button1;
        private ComboBox cbTipoVeiculo;
        private TextBox TxtIDEmpresa;
        private Label label19;
        private Label label18;
        private ComboBox cbEmpresa;
        private ComboBox cbConcessionária;
        private Label label21;
        private Label label20;
    }
}
