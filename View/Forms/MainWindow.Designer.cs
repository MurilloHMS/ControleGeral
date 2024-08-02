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
            panelImportacoes = new Panel();
            button6 = new Button();
            button7 = new Button();
            btnPanelImportacoes = new Button();
            tbcHome = new TabControl();
            panelVeiculos.SuspendLayout();
            panelImagem.SuspendLayout();
            panelMenu.SuspendLayout();
            panelImportacoes.SuspendLayout();
            SuspendLayout();
            // 
            // btnVeiculos
            // 
            btnVeiculos.AutoSize = true;
            btnVeiculos.BackgroundImageLayout = ImageLayout.None;
            btnVeiculos.Cursor = Cursors.Hand;
            btnVeiculos.Dock = DockStyle.Top;
            btnVeiculos.FlatAppearance.BorderSize = 0;
            btnVeiculos.FlatStyle = FlatStyle.Flat;
            btnVeiculos.Font = new Font("MesloLGLDZ Nerd Font", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVeiculos.ForeColor = Color.FromArgb(144, 148, 155);
            btnVeiculos.Image = (Image)resources.GetObject("btnVeiculos.Image");
            btnVeiculos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVeiculos.Location = new Point(0, 104);
            btnVeiculos.Margin = new Padding(0);
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Size = new Size(380, 38);
            btnVeiculos.TabIndex = 2;
            btnVeiculos.Text = "     Cadastros";
            btnVeiculos.TextAlign = ContentAlignment.MiddleLeft;
            btnVeiculos.UseVisualStyleBackColor = true;
            btnVeiculos.Click += btnVeiculos_Click;
            // 
            // panelVeiculos
            // 
            panelVeiculos.BackColor = Color.FromArgb(53, 56, 83);
            panelVeiculos.Controls.Add(button3);
            panelVeiculos.Controls.Add(button1);
            panelVeiculos.Controls.Add(button2);
            panelVeiculos.Dock = DockStyle.Top;
            panelVeiculos.Location = new Point(0, 142);
            panelVeiculos.Margin = new Padding(0);
            panelVeiculos.Name = "panelVeiculos";
            panelVeiculos.Size = new Size(380, 116);
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
            button3.Size = new Size(380, 38);
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
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(380, 38);
            button2.TabIndex = 1;
            button2.Text = "                    Cadastro Entidades";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
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
            button1.Location = new Point(0, 38);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(380, 38);
            button1.TabIndex = 0;
            button1.Text = "                    Cadastro Veiculos";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // panelImagem
            // 
            panelImagem.BackColor = Color.FromArgb(32, 36, 62);
            panelImagem.Controls.Add(btnMenu);
            panelImagem.Dock = DockStyle.Top;
            panelImagem.Location = new Point(0, 0);
            panelImagem.Name = "panelImagem";
            panelImagem.Size = new Size(380, 104);
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
            btnMenu.Location = new Point(344, 1);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(30, 30);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(32, 36, 62);
            panelMenu.Controls.Add(panelImportacoes);
            panelMenu.Controls.Add(btnPanelImportacoes);
            panelMenu.Controls.Add(panelVeiculos);
            panelMenu.Controls.Add(btnVeiculos);
            panelMenu.Controls.Add(panelImagem);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(380, 630);
            panelMenu.TabIndex = 0;
            // 
            // panelImportacoes
            // 
            panelImportacoes.BackColor = Color.FromArgb(53, 56, 83);
            panelImportacoes.Controls.Add(button6);
            panelImportacoes.Controls.Add(button7);
            panelImportacoes.Dock = DockStyle.Top;
            panelImportacoes.Location = new Point(0, 296);
            panelImportacoes.Name = "panelImportacoes";
            panelImportacoes.Size = new Size(380, 116);
            panelImportacoes.TabIndex = 2;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.FromArgb(144, 148, 155);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 38);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(380, 38);
            button6.TabIndex = 1;
            button6.Text = "                    Importar Excel";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.FromArgb(144, 148, 155);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 0);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(380, 38);
            button7.TabIndex = 0;
            button7.Text = "                    Importar XML";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            // 
            // btnPanelImportacoes
            // 
            btnPanelImportacoes.AutoSize = true;
            btnPanelImportacoes.BackgroundImageLayout = ImageLayout.None;
            btnPanelImportacoes.Cursor = Cursors.Hand;
            btnPanelImportacoes.Dock = DockStyle.Top;
            btnPanelImportacoes.FlatAppearance.BorderSize = 0;
            btnPanelImportacoes.FlatStyle = FlatStyle.Flat;
            btnPanelImportacoes.Font = new Font("MesloLGLDZ Nerd Font", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPanelImportacoes.ForeColor = Color.FromArgb(144, 148, 155);
            btnPanelImportacoes.Image = (Image)resources.GetObject("btnPanelImportacoes.Image");
            btnPanelImportacoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnPanelImportacoes.Location = new Point(0, 258);
            btnPanelImportacoes.Margin = new Padding(0);
            btnPanelImportacoes.Name = "btnPanelImportacoes";
            btnPanelImportacoes.Size = new Size(380, 38);
            btnPanelImportacoes.TabIndex = 3;
            btnPanelImportacoes.Text = "     Importações";
            btnPanelImportacoes.TextAlign = ContentAlignment.MiddleLeft;
            btnPanelImportacoes.UseVisualStyleBackColor = true;
            btnPanelImportacoes.Click += btnPanelImportacoes_Click;
            // 
            // tbcHome
            // 
            tbcHome.Dock = DockStyle.Fill;
            tbcHome.Location = new Point(380, 0);
            tbcHome.Name = "tbcHome";
            tbcHome.SelectedIndex = 0;
            tbcHome.Size = new Size(420, 630);
            tbcHome.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 630);
            Controls.Add(tbcHome);
            Controls.Add(panelMenu);
            Name = "MainWindow";
            Text = "Controle De Projetos";
            panelVeiculos.ResumeLayout(false);
            panelImagem.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelImportacoes.ResumeLayout(false);
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
        private Panel panelImportacoes;
        private Button button6;
        private Button button7;
        private Button btnPanelImportacoes;
    }
}
