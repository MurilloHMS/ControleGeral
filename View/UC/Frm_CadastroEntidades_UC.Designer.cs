namespace KhoraControl.View.UC
{
    partial class Frm_CadastroEntidades_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroEntidades_UC));
            groupBox1 = new GroupBox();
            RbConcessionaria = new RadioButton();
            RbEmpresa = new RadioButton();
            TxtIE = new MaskedTextBox();
            TxtCPNJ = new MaskedTextBox();
            TxtID = new TextBox();
            TxtNome = new TextBox();
            label4 = new Label();
            label11 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            TxtNumero = new TextBox();
            label10 = new Label();
            TxtUF = new TextBox();
            label9 = new Label();
            TxtLocalidade = new TextBox();
            label8 = new Label();
            TxtBairro = new TextBox();
            label7 = new Label();
            TxtComplemento = new TextBox();
            label6 = new Label();
            TxtLogradouro = new TextBox();
            label1 = new Label();
            TxtCep = new MaskedTextBox();
            label5 = new Label();
            toolStrip1 = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            imprimirToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(RbConcessionaria);
            groupBox1.Controls.Add(RbEmpresa);
            groupBox1.Controls.Add(TxtIE);
            groupBox1.Controls.Add(TxtCPNJ);
            groupBox1.Controls.Add(TxtID);
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // RbConcessionaria
            // 
            RbConcessionaria.AutoSize = true;
            RbConcessionaria.Location = new Point(731, 44);
            RbConcessionaria.Name = "RbConcessionaria";
            RbConcessionaria.Size = new Size(105, 19);
            RbConcessionaria.TabIndex = 3;
            RbConcessionaria.TabStop = true;
            RbConcessionaria.Text = "Concessionária";
            RbConcessionaria.UseVisualStyleBackColor = true;
            // 
            // RbEmpresa
            // 
            RbEmpresa.AutoSize = true;
            RbEmpresa.Location = new Point(731, 22);
            RbEmpresa.Name = "RbEmpresa";
            RbEmpresa.Size = new Size(70, 19);
            RbEmpresa.TabIndex = 3;
            RbEmpresa.TabStop = true;
            RbEmpresa.Text = "Empresa";
            RbEmpresa.UseVisualStyleBackColor = true;
            // 
            // TxtIE
            // 
            TxtIE.Location = new Point(559, 44);
            TxtIE.Name = "TxtIE";
            TxtIE.Size = new Size(140, 23);
            TxtIE.TabIndex = 2;
            // 
            // TxtCPNJ
            // 
            TxtCPNJ.Location = new Point(413, 44);
            TxtCPNJ.Mask = "00,000,000/0000-00";
            TxtCPNJ.Name = "TxtCPNJ";
            TxtCPNJ.Size = new Size(140, 23);
            TxtCPNJ.TabIndex = 2;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(14, 44);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(54, 23);
            TxtID.TabIndex = 1;
            // 
            // TxtNome
            // 
            TxtNome.CharacterCasing = CharacterCasing.Upper;
            TxtNome.Location = new Point(121, 44);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(286, 23);
            TxtNome.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(559, 26);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 0;
            label4.Text = "IE";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 26);
            label11.Name = "label11";
            label11.Size = new Size(18, 15);
            label11.TabIndex = 0;
            label11.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 26);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 0;
            label3.Text = "CNPJ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 26);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(TxtNumero);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(TxtUF);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(TxtLocalidade);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(TxtBairro);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(TxtComplemento);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TxtLogradouro);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TxtCep);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(17, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(864, 254);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações endereço";
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
            button1.Location = new Point(97, 56);
            button1.Name = "button1";
            button1.Size = new Size(27, 23);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(512, 172);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(115, 23);
            TxtNumero.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(512, 154);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 0;
            label10.Text = "Número";
            // 
            // TxtUF
            // 
            TxtUF.CharacterCasing = CharacterCasing.Upper;
            TxtUF.Location = new Point(465, 172);
            TxtUF.Name = "TxtUF";
            TxtUF.Size = new Size(41, 23);
            TxtUF.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(465, 154);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 0;
            label9.Text = "UF";
            // 
            // TxtLocalidade
            // 
            TxtLocalidade.CharacterCasing = CharacterCasing.Upper;
            TxtLocalidade.Location = new Point(356, 172);
            TxtLocalidade.Name = "TxtLocalidade";
            TxtLocalidade.Size = new Size(103, 23);
            TxtLocalidade.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 154);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 0;
            label8.Text = "Localidade";
            // 
            // TxtBairro
            // 
            TxtBairro.CharacterCasing = CharacterCasing.Upper;
            TxtBairro.Location = new Point(14, 172);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.Size = new Size(336, 23);
            TxtBairro.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 154);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 0;
            label7.Text = "Bairro";
            // 
            // TxtComplemento
            // 
            TxtComplemento.CharacterCasing = CharacterCasing.Upper;
            TxtComplemento.Location = new Point(356, 114);
            TxtComplemento.Name = "TxtComplemento";
            TxtComplemento.Size = new Size(277, 23);
            TxtComplemento.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(356, 96);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 0;
            label6.Text = "Complemento";
            // 
            // TxtLogradouro
            // 
            TxtLogradouro.CharacterCasing = CharacterCasing.Upper;
            TxtLogradouro.Location = new Point(19, 114);
            TxtLogradouro.Name = "TxtLogradouro";
            TxtLogradouro.Size = new Size(331, 23);
            TxtLogradouro.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 96);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Logradouro";
            // 
            // TxtCep
            // 
            TxtCep.Location = new Point(19, 56);
            TxtCep.Mask = "00000-000";
            TxtCep.Name = "TxtCep";
            TxtCep.Size = new Size(72, 23);
            TxtCep.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 38);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 0;
            label5.Text = "CEP";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, salvarToolStripButton, imprimirToolStripButton, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(904, 25);
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
            novaToolStripButton.Text = "&Nova";
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
            salvarToolStripButton.Click += salvarToolStripButton_Click;
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
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(23, 22);
            ajudaToolStripButton.Text = "Aju&da";
            // 
            // Frm_CadastroEntidades_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(toolStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_CadastroEntidades_UC";
            Size = new Size(904, 581);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox TxtCPNJ;
        private TextBox TxtLogradouro;
        private Label label1;
        private GroupBox groupBox2;
        private ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private TextBox TxtNome;
        private Label label2;
        private RadioButton RbConcessionaria;
        private RadioButton RbEmpresa;
        private MaskedTextBox TxtIE;
        private Label label4;
        private Label label3;
        private Button button1;
        private MaskedTextBox TxtCep;
        private Label label5;
        private TextBox TxtNumero;
        private Label label10;
        private TextBox TxtUF;
        private Label label9;
        private TextBox TxtLocalidade;
        private Label label8;
        private TextBox TxtBairro;
        private Label label7;
        private TextBox TxtComplemento;
        private Label label6;
        private TextBox TxtID;
        private Label label11;
    }
}
