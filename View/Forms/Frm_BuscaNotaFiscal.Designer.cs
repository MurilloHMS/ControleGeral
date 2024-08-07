namespace KhoraControl.View.Forms
{
    partial class Frm_BuscaNotaFiscal
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
            groupBox2 = new GroupBox();
            ListNotasFiscais = new ListBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ListNotasFiscais);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 379);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busca";
            // 
            // ListNotasFiscais
            // 
            ListNotasFiscais.Dock = DockStyle.Fill;
            ListNotasFiscais.FormattingEnabled = true;
            ListNotasFiscais.ItemHeight = 15;
            ListNotasFiscais.Location = new Point(3, 19);
            ListNotasFiscais.Name = "ListNotasFiscais";
            ListNotasFiscais.Size = new Size(774, 357);
            ListNotasFiscais.TabIndex = 0;
            ListNotasFiscais.DoubleClick += ListNotasFiscais_DoubleClick;
            ListNotasFiscais.KeyDown += ListNotasFiscais_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 71);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Busca ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 30);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite a Nota Fiscal para buscar";
            textBox1.Size = new Size(735, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Frm_BuscaNotaFiscal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_BuscaNotaFiscal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Buscar Veiculo";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ListBox ListNotasFiscais;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}