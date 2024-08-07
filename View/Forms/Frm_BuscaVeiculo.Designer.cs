namespace KhoraControl.View.Forms
{
    partial class Frm_BuscaVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscaVeiculo));
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            ListVeiculos = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 71);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Busca ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 30);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite o Veiculo para buscar";
            textBox1.Size = new Size(408, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ListVeiculos);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(454, 392);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busca";
            // 
            // ListVeiculos
            // 
            ListVeiculos.Dock = DockStyle.Fill;
            ListVeiculos.FormattingEnabled = true;
            ListVeiculos.ItemHeight = 15;
            ListVeiculos.Location = new Point(3, 19);
            ListVeiculos.Name = "ListVeiculos";
            ListVeiculos.Size = new Size(448, 370);
            ListVeiculos.TabIndex = 0;
            ListVeiculos.DoubleClick += ListVeiculos_DoubleClick;
            ListVeiculos.KeyDown += ListVeiculos_KeyDown;
            // 
            // Frm_BuscaVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 463);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_BuscaVeiculo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Busca Veiculos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private ListBox ListVeiculos;
    }
}