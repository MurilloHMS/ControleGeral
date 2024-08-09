namespace KhoraControl.View.Forms
{
    partial class Frm_BuscaConcessionaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscaConcessionaria));
            groupBox2 = new GroupBox();
            ListConcessionaria = new ListBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ListConcessionaria);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(454, 392);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busca";
            // 
            // ListConcessionaria
            // 
            ListConcessionaria.Dock = DockStyle.Fill;
            ListConcessionaria.FormattingEnabled = true;
            ListConcessionaria.ItemHeight = 15;
            ListConcessionaria.Location = new Point(3, 19);
            ListConcessionaria.Name = "ListConcessionaria";
            ListConcessionaria.Size = new Size(448, 370);
            ListConcessionaria.TabIndex = 0;
            ListConcessionaria.SelectedIndexChanged += ListConcessionaria_SelectedIndexChanged;
            ListConcessionaria.KeyDown += ListConcessionaria_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 71);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Busca ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 30);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite a Concessionaria para buscar";
            textBox1.Size = new Size(408, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Frm_BuscaConcessionaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 463);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_BuscaConcessionaria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Busca Concessionária";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ListBox ListConcessionaria;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}