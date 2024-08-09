namespace KhoraControl.View.UC
{
    partial class Frm_CadastroCheckList_UC
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroCheckList_UC));
            imageList1 = new ImageList(components);
            toolStrip1 = new ToolStrip();
            salvarToolStripButton = new ToolStripButton();
            ajudaToolStripButton = new ToolStripButton();
            groupBox1 = new GroupBox();
            panelCadastroCheckList = new Panel();
            BtnShowPanel = new Button();
            TxtValorRevisao = new TextBox();
            label11 = new Label();
            TxtKmRodados = new TextBox();
            label10 = new Label();
            button2 = new Button();
            TxtDescritivoCheckList = new TextBox();
            label9 = new Label();
            TxtID_CheckList = new TextBox();
            label8 = new Label();
            btnBuscaNotaFiscal = new Button();
            btnBuscaConcessionaria = new Button();
            button1 = new Button();
            label5 = new Label();
            DtpDataLancamento = new DateTimePicker();
            label7 = new Label();
            TxtID_Concessionaria = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            TxtNumNotaFiscal = new TextBox();
            TxtConcessionaria = new TextBox();
            TxtVeiculo = new TextBox();
            TxtId_NotaFiscal = new TextBox();
            label12 = new Label();
            TxtID_Veiculo = new TextBox();
            label2 = new Label();
            TxtID = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panelCadastroCheckList.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Collapse Arrow.ico");
            imageList1.Images.SetKeyName(1, "Expand Arrow.ico");
            // 
            // toolStrip1
            // 
            toolStrip1.BackgroundImage = (Image)resources.GetObject("toolStrip1.BackgroundImage");
            toolStrip1.BackgroundImageLayout = ImageLayout.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { salvarToolStripButton, toolStripSeparator1, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(954, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
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
            groupBox1.Controls.Add(panelCadastroCheckList);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(954, 277);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Veiculo";
            // 
            // panelCadastroCheckList
            // 
            panelCadastroCheckList.Controls.Add(BtnShowPanel);
            panelCadastroCheckList.Controls.Add(TxtValorRevisao);
            panelCadastroCheckList.Controls.Add(label11);
            panelCadastroCheckList.Controls.Add(TxtKmRodados);
            panelCadastroCheckList.Controls.Add(label10);
            panelCadastroCheckList.Controls.Add(button2);
            panelCadastroCheckList.Controls.Add(TxtDescritivoCheckList);
            panelCadastroCheckList.Controls.Add(label9);
            panelCadastroCheckList.Controls.Add(TxtID_CheckList);
            panelCadastroCheckList.Controls.Add(label8);
            panelCadastroCheckList.Controls.Add(btnBuscaNotaFiscal);
            panelCadastroCheckList.Controls.Add(btnBuscaConcessionaria);
            panelCadastroCheckList.Controls.Add(button1);
            panelCadastroCheckList.Controls.Add(label5);
            panelCadastroCheckList.Controls.Add(DtpDataLancamento);
            panelCadastroCheckList.Controls.Add(label7);
            panelCadastroCheckList.Controls.Add(TxtID_Concessionaria);
            panelCadastroCheckList.Controls.Add(label6);
            panelCadastroCheckList.Controls.Add(label4);
            panelCadastroCheckList.Controls.Add(label3);
            panelCadastroCheckList.Controls.Add(TxtNumNotaFiscal);
            panelCadastroCheckList.Controls.Add(TxtConcessionaria);
            panelCadastroCheckList.Controls.Add(TxtVeiculo);
            panelCadastroCheckList.Controls.Add(TxtId_NotaFiscal);
            panelCadastroCheckList.Controls.Add(label12);
            panelCadastroCheckList.Controls.Add(TxtID_Veiculo);
            panelCadastroCheckList.Controls.Add(label2);
            panelCadastroCheckList.Controls.Add(TxtID);
            panelCadastroCheckList.Controls.Add(label1);
            panelCadastroCheckList.Location = new Point(3, 19);
            panelCadastroCheckList.Name = "panelCadastroCheckList";
            panelCadastroCheckList.Size = new Size(931, 236);
            panelCadastroCheckList.TabIndex = 7;
            // 
            // BtnShowPanel
            // 
            BtnShowPanel.Cursor = Cursors.Hand;
            BtnShowPanel.FlatAppearance.BorderSize = 0;
            BtnShowPanel.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnShowPanel.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnShowPanel.FlatStyle = FlatStyle.Flat;
            BtnShowPanel.ImageIndex = 1;
            BtnShowPanel.ImageList = imageList1;
            BtnShowPanel.Location = new Point(410, 131);
            BtnShowPanel.Name = "BtnShowPanel";
            BtnShowPanel.Size = new Size(44, 23);
            BtnShowPanel.TabIndex = 27;
            BtnShowPanel.UseVisualStyleBackColor = true;
            BtnShowPanel.Click += BtnShowPanel_Click;
            // 
            // TxtValorRevisao
            // 
            TxtValorRevisao.Location = new Point(598, 102);
            TxtValorRevisao.Name = "TxtValorRevisao";
            TxtValorRevisao.Size = new Size(127, 23);
            TxtValorRevisao.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(598, 84);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 25;
            label11.Text = "Valor Revisão";
            // 
            // TxtKmRodados
            // 
            TxtKmRodados.Location = new Point(442, 102);
            TxtKmRodados.Name = "TxtKmRodados";
            TxtKmRodados.Size = new Size(127, 23);
            TxtKmRodados.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(442, 84);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 25;
            label10.Text = "Km Rodados";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(726, 189);
            button2.Name = "button2";
            button2.Size = new Size(136, 25);
            button2.TabIndex = 16;
            button2.Text = "Cadastrar CheckList";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TxtDescritivoCheckList
            // 
            TxtDescritivoCheckList.CharacterCasing = CharacterCasing.Upper;
            TxtDescritivoCheckList.Location = new Point(148, 191);
            TxtDescritivoCheckList.Name = "TxtDescritivoCheckList";
            TxtDescritivoCheckList.Size = new Size(550, 23);
            TxtDescritivoCheckList.TabIndex = 15;
            TxtDescritivoCheckList.KeyDown += TxtDescritivoCheckList_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(148, 173);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 18;
            label9.Text = "Descritivo CheckList";
            // 
            // TxtID_CheckList
            // 
            TxtID_CheckList.Location = new Point(21, 191);
            TxtID_CheckList.Name = "TxtID_CheckList";
            TxtID_CheckList.Size = new Size(72, 23);
            TxtID_CheckList.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 173);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 18;
            label8.Text = "ID CheckList";
            // 
            // btnBuscaNotaFiscal
            // 
            btnBuscaNotaFiscal.BackgroundImage = (Image)resources.GetObject("btnBuscaNotaFiscal.BackgroundImage");
            btnBuscaNotaFiscal.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscaNotaFiscal.Cursor = Cursors.Hand;
            btnBuscaNotaFiscal.FlatAppearance.BorderSize = 0;
            btnBuscaNotaFiscal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscaNotaFiscal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscaNotaFiscal.FlatStyle = FlatStyle.Flat;
            btnBuscaNotaFiscal.Location = new Point(667, 39);
            btnBuscaNotaFiscal.Name = "btnBuscaNotaFiscal";
            btnBuscaNotaFiscal.Size = new Size(26, 23);
            btnBuscaNotaFiscal.TabIndex = 7;
            btnBuscaNotaFiscal.UseVisualStyleBackColor = true;
            btnBuscaNotaFiscal.Click += btnBuscaNotaFiscal_Click;
            // 
            // btnBuscaConcessionaria
            // 
            btnBuscaConcessionaria.BackgroundImage = (Image)resources.GetObject("btnBuscaConcessionaria.BackgroundImage");
            btnBuscaConcessionaria.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscaConcessionaria.Cursor = Cursors.Hand;
            btnBuscaConcessionaria.FlatAppearance.BorderSize = 0;
            btnBuscaConcessionaria.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBuscaConcessionaria.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBuscaConcessionaria.FlatStyle = FlatStyle.Flat;
            btnBuscaConcessionaria.Location = new Point(372, 101);
            btnBuscaConcessionaria.Name = "btnBuscaConcessionaria";
            btnBuscaConcessionaria.Size = new Size(25, 23);
            btnBuscaConcessionaria.TabIndex = 11;
            btnBuscaConcessionaria.UseVisualStyleBackColor = true;
            btnBuscaConcessionaria.Click += btnBuscaConcessionaria_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(498, 42);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(725, 8);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 19;
            label5.Text = "Data Lançamento";
            // 
            // DtpDataLancamento
            // 
            DtpDataLancamento.Format = DateTimePickerFormat.Short;
            DtpDataLancamento.Location = new Point(725, 39);
            DtpDataLancamento.Name = "DtpDataLancamento";
            DtpDataLancamento.Size = new Size(100, 23);
            DtpDataLancamento.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 84);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 12;
            label7.Text = "Concessionária";
            // 
            // TxtID_Concessionaria
            // 
            TxtID_Concessionaria.Location = new Point(21, 102);
            TxtID_Concessionaria.Name = "TxtID_Concessionaria";
            TxtID_Concessionaria.Size = new Size(53, 23);
            TxtID_Concessionaria.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 84);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 11;
            label6.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(598, 22);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 10;
            label4.Text = "Nota Fiscal ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 24);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 9;
            label3.Text = "Veiculo";
            // 
            // TxtNumNotaFiscal
            // 
            TxtNumNotaFiscal.Location = new Point(598, 39);
            TxtNumNotaFiscal.Name = "TxtNumNotaFiscal";
            TxtNumNotaFiscal.Size = new Size(64, 23);
            TxtNumNotaFiscal.TabIndex = 6;
            // 
            // TxtConcessionaria
            // 
            TxtConcessionaria.Location = new Point(80, 102);
            TxtConcessionaria.Name = "TxtConcessionaria";
            TxtConcessionaria.Size = new Size(285, 23);
            TxtConcessionaria.TabIndex = 10;
            // 
            // TxtVeiculo
            // 
            TxtVeiculo.Location = new Point(207, 42);
            TxtVeiculo.Name = "TxtVeiculo";
            TxtVeiculo.Size = new Size(285, 23);
            TxtVeiculo.TabIndex = 3;
            // 
            // TxtId_NotaFiscal
            // 
            TxtId_NotaFiscal.Location = new Point(539, 39);
            TxtId_NotaFiscal.Name = "TxtId_NotaFiscal";
            TxtId_NotaFiscal.Size = new Size(53, 23);
            TxtId_NotaFiscal.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(539, 21);
            label12.Name = "label12";
            label12.Size = new Size(18, 15);
            label12.TabIndex = 8;
            label12.Text = "ID";
            // 
            // TxtID_Veiculo
            // 
            TxtID_Veiculo.Location = new Point(148, 42);
            TxtID_Veiculo.Name = "TxtID_Veiculo";
            TxtID_Veiculo.Size = new Size(53, 23);
            TxtID_Veiculo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 24);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 8;
            label2.Text = "ID";
            // 
            // TxtID
            // 
            TxtID.Location = new Point(21, 39);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(53, 23);
            TxtID.TabIndex = 1;
            TxtID.TextChanged += TxtID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkedListBox1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 302);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(954, 284);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Check List";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(3, 19);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(948, 262);
            checkedListBox1.TabIndex = 17;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // Frm_CadastroCheckList_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Name = "Frm_CadastroCheckList_UC";
            Size = new Size(954, 751);
            Load += Frm_CadastroCheckList_UC_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panelCadastroCheckList.ResumeLayout(false);
            panelCadastroCheckList.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private ToolStrip toolStrip1;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton ajudaToolStripButton;
        private GroupBox groupBox1;
        private Panel panelCadastroCheckList;
        private Button BtnShowPanel;
        private TextBox TxtValorRevisao;
        private Label label11;
        private TextBox TxtKmRodados;
        private Label label10;
        private Button button2;
        private TextBox TxtDescritivoCheckList;
        private Label label9;
        private TextBox TxtID_CheckList;
        private Label label8;
        private Button btnBuscaNotaFiscal;
        private Button button1;
        private Label label5;
        private DateTimePicker DtpDataLancamento;
        private Label label7;
        private TextBox TxtID_Concessionaria;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox TxtNumNotaFiscal;
        private TextBox TxtVeiculo;
        private TextBox TxtID_Veiculo;
        private Label label2;
        private TextBox TxtID;
        private Label label1;
        private GroupBox groupBox2;
        private CheckedListBox checkedListBox1;
        private TextBox TxtId_NotaFiscal;
        private Label label12;
        private Button btnBuscaConcessionaria;
        private TextBox TxtConcessionaria;
        private ToolStripSeparator toolStripSeparator1;
    }
}
