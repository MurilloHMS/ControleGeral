namespace KhoraControl.View.UC
{
    partial class Frm_Configuracoes_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Configuracoes_UC));
            groupBox1 = new GroupBox();
            lblTipoBase = new Label();
            cbProvider = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            TxtConnectionString = new TextBox();
            toolStrip1 = new ToolStrip();
            salvarToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTipoBase);
            groupBox1.Controls.Add(cbProvider);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TxtConnectionString);
            groupBox1.Location = new Point(13, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 439);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurações";
            // 
            // lblTipoBase
            // 
            lblTipoBase.AutoSize = true;
            lblTipoBase.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoBase.ForeColor = Color.Black;
            lblTipoBase.Location = new Point(35, 30);
            lblTipoBase.Name = "lblTipoBase";
            lblTipoBase.Size = new Size(65, 25);
            lblTipoBase.TabIndex = 3;
            lblTipoBase.Text = "label3";
            // 
            // cbProvider
            // 
            cbProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProvider.FormattingEnabled = true;
            cbProvider.Items.AddRange(new object[] { "SQLite", "PostgreSQL" });
            cbProvider.Location = new Point(35, 83);
            cbProvider.Name = "cbProvider";
            cbProvider.Size = new Size(121, 23);
            cbProvider.TabIndex = 2;
            cbProvider.SelectedIndexChanged += cbProvider_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 65);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Provedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 65);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "String De Conexão";
            // 
            // TxtConnectionString
            // 
            TxtConnectionString.Location = new Point(211, 83);
            TxtConnectionString.Name = "TxtConnectionString";
            TxtConnectionString.Size = new Size(706, 23);
            TxtConnectionString.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { salvarToolStripButton, toolStripSeparator1, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(980, 25);
            toolStrip1.TabIndex = 1;
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
            // Frm_Configuracoes_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Name = "Frm_Configuracoes_UC";
            Size = new Size(980, 685);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox TxtConnectionString;
        private ComboBox cbProvider;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripButton salvarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ajudaToolStripButton;
        private Label lblTipoBase;
    }
}
