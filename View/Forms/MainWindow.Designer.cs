namespace KhoraControl
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVeiculos = new Button();
            panelVeiculos = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelImagem = new Panel();
            btnMenu = new Button();
            panelMenu = new Panel();
            panelVeiculos.SuspendLayout();
            panelImagem.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnVeiculos
            // 
            btnVeiculos.FlatStyle = FlatStyle.Flat;
            btnVeiculos.Location = new Point(0, 106);
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Size = new Size(189, 33);
            btnVeiculos.TabIndex = 0;
            btnVeiculos.Text = "Veiculos";
            btnVeiculos.UseVisualStyleBackColor = true;
            btnVeiculos.Click += btnVeiculos_Click;
            // 
            // panelVeiculos
            // 
            panelVeiculos.Controls.Add(button3);
            panelVeiculos.Controls.Add(button2);
            panelVeiculos.Controls.Add(button1);
            panelVeiculos.Location = new Point(0, 145);
            panelVeiculos.Name = "panelVeiculos";
            panelVeiculos.Size = new Size(189, 101);
            panelVeiculos.TabIndex = 1;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 66);
            button3.Name = "button3";
            button3.Size = new Size(189, 33);
            button3.TabIndex = 2;
            button3.Text = "Configurações Veiculos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 33);
            button2.Name = "button2";
            button2.Size = new Size(189, 33);
            button2.TabIndex = 1;
            button2.Text = "Consulta Veiculos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(189, 33);
            button1.TabIndex = 0;
            button1.Text = "Cadastro Veiculos";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelImagem
            // 
            panelImagem.Controls.Add(btnMenu);
            panelImagem.Dock = DockStyle.Top;
            panelImagem.Location = new Point(0, 0);
            panelImagem.Name = "panelImagem";
            panelImagem.Size = new Size(192, 104);
            panelImagem.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(47, 48);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "button4";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveCaption;
            panelMenu.Controls.Add(panelImagem);
            panelMenu.Controls.Add(panelVeiculos);
            panelMenu.Controls.Add(btnVeiculos);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(192, 450);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Name = "MainWindow";
            Text = "Form1";
            panelVeiculos.ResumeLayout(false);
            panelImagem.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnVeiculos;
        private Panel panelVeiculos;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panelImagem;
        private Panel panelMenu;
        private Button btnMenu;
    }
}
