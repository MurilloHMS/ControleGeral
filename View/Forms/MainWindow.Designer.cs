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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            btnVeiculos = new Button();
            panelVeiculos = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelImagem = new Panel();
            btnMenu = new Button();
            panelMenu = new Panel();
            tbcHome = new TabControl();
            panelVeiculos.SuspendLayout();
            panelImagem.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnVeiculos
            // 
            btnVeiculos.AutoSize = true;
            btnVeiculos.BackgroundImageLayout = ImageLayout.None;
            btnVeiculos.Cursor = Cursors.Hand;
            btnVeiculos.FlatAppearance.BorderSize = 0;
            btnVeiculos.FlatStyle = FlatStyle.Flat;
            btnVeiculos.Font = new Font("MesloLGLDZ Nerd Font", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVeiculos.ForeColor = Color.FromArgb(144, 148, 155);
            btnVeiculos.Image = (Image)resources.GetObject("btnVeiculos.Image");
            btnVeiculos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVeiculos.Location = new Point(0, 106);
            btnVeiculos.Margin = new Padding(0);
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Size = new Size(192, 38);
            btnVeiculos.TabIndex = 0;
            btnVeiculos.Text = "     Cadastros";
            btnVeiculos.TextAlign = ContentAlignment.MiddleLeft;
            btnVeiculos.UseVisualStyleBackColor = true;
            btnVeiculos.Click += btnVeiculos_Click;
            // 
            // panelVeiculos
            // 
            panelVeiculos.BackColor = Color.FromArgb(53, 56, 83);
            panelVeiculos.Controls.Add(button3);
            panelVeiculos.Controls.Add(button2);
            panelVeiculos.Controls.Add(button1);
            panelVeiculos.Location = new Point(0, 145);
            panelVeiculos.Name = "panelVeiculos";
            panelVeiculos.Size = new Size(189, 116);
            panelVeiculos.TabIndex = 1;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(144, 148, 155);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 76);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(189, 38);
            button3.TabIndex = 2;
            button3.Text = "                    Cadastro Check List";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(144, 148, 155);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 38);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(189, 38);
            button2.TabIndex = 1;
            button2.Text = "                    Cadastro Entidades";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(144, 148, 155);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(189, 38);
            button1.TabIndex = 0;
            button1.Text = "                    Cadastro Veiculos";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelImagem
            // 
            panelImagem.BackColor = Color.FromArgb(32, 36, 62);
            panelImagem.Controls.Add(btnMenu);
            panelImagem.Dock = DockStyle.Top;
            panelImagem.Location = new Point(0, 0);
            panelImagem.Name = "panelImagem";
            panelImagem.Size = new Size(192, 104);
            panelImagem.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMenu.BackgroundImage = Properties.Resources.Menu1;
            btnMenu.BackgroundImageLayout = ImageLayout.Zoom;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(156, 1);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(30, 30);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(32, 36, 62);
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
            // tbcHome
            // 
            tbcHome.Dock = DockStyle.Fill;
            tbcHome.Location = new Point(192, 0);
            tbcHome.Name = "tbcHome";
            tbcHome.SelectedIndex = 0;
            tbcHome.Size = new Size(608, 450);
            tbcHome.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbcHome);
            Controls.Add(panelMenu);
            Name = "MainWindow";
            Text = "Form1";
            panelVeiculos.ResumeLayout(false);
            panelImagem.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
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
        private TabControl tbcHome;
    }
}
