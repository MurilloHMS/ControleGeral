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
            groupBox2 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            toolStrip1 = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            imprimirToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            label2 = new Label();
            textBox2 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            maskedTextBox3 = new MaskedTextBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox8 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox2);
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
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(17, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(864, 254);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações endereço";
            groupBox2.Enter += groupBox2_Enter;
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
            // textBox1
            // 
            textBox1.Location = new Point(19, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 23);
            textBox1.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(413, 44);
            maskedTextBox1.Mask = "00.000.000/0000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(140, 23);
            maskedTextBox1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, salvarToolStripButton, imprimirToolStripButton, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 26);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 1;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(559, 44);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(140, 23);
            maskedTextBox2.TabIndex = 2;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(559, 26);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 0;
            label4.Text = "IE";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(731, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Empresa";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(731, 44);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(105, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Concessionária";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(19, 56);
            maskedTextBox3.Mask = "00000-000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(72, 23);
            maskedTextBox3.TabIndex = 2;
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
            // button1
            // 
            button1.Location = new Point(97, 56);
            button1.Name = "button1";
            button1.Size = new Size(27, 23);
            button1.TabIndex = 3;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
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
            // textBox3
            // 
            textBox3.Location = new Point(356, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 23);
            textBox3.TabIndex = 1;
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
            // textBox4
            // 
            textBox4.Location = new Point(14, 172);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(336, 23);
            textBox4.TabIndex = 1;
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
            // textBox5
            // 
            textBox5.Location = new Point(356, 172);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(103, 23);
            textBox5.TabIndex = 1;
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
            // textBox6
            // 
            textBox6.Location = new Point(465, 172);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(41, 23);
            textBox6.TabIndex = 1;
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
            // textBox7
            // 
            textBox7.Location = new Point(512, 172);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(115, 23);
            textBox7.TabIndex = 1;
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
            // textBox8
            // 
            textBox8.Location = new Point(14, 44);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(54, 23);
            textBox8.TabIndex = 1;
            // 
            // Frm_CadastroEntidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_CadastroEntidades";
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
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private TextBox textBox2;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private MaskedTextBox maskedTextBox2;
        private Label label4;
        private Label label3;
        private Button button1;
        private MaskedTextBox maskedTextBox3;
        private Label label5;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox8;
        private Label label11;
    }
}
