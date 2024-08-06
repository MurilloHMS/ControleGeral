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
            button1 = new Button();
            button2 = new Button();
            panelImagem = new Panel();
            btnMenu = new Button();
            panelMenu = new Panel();
            button4 = new Button();
            panelAnalises = new Panel();
            button5 = new Button();
            BtnDashBoard = new Button();
            BtnPanelAnalises = new Button();
            panelImportacoes = new Panel();
            button6 = new Button();
            button7 = new Button();
            btnPanelImportacoes = new Button();
            tbcHome = new TabControl();
            panelVeiculos.SuspendLayout();
            panelImagem.SuspendLayout();
            panelMenu.SuspendLayout();
            panelAnalises.SuspendLayout();
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
            btnVeiculos.Size = new Size(199, 38);
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
            panelVeiculos.Size = new Size(199, 116);
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
            button3.Size = new Size(199, 38);
            button3.TabIndex = 2;
            button3.Text = "                    Cadastro Check List";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            button1.Size = new Size(199, 38);
            button1.TabIndex = 0;
            button1.Text = "                    Cadastro Veiculos";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            button2.Size = new Size(199, 38);
            button2.TabIndex = 1;
            button2.Text = "                    Cadastro Entidades";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelImagem
            // 
            panelImagem.BackColor = Color.FromArgb(32, 36, 62);
            panelImagem.Controls.Add(btnMenu);
            panelImagem.Dock = DockStyle.Top;
            panelImagem.Location = new Point(0, 0);
            panelImagem.Name = "panelImagem";
            panelImagem.Size = new Size(199, 104);
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
            btnMenu.Location = new Point(163, 1);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(30, 30);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(32, 36, 62);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(panelAnalises);
            panelMenu.Controls.Add(BtnPanelAnalises);
            panelMenu.Controls.Add(panelImportacoes);
            panelMenu.Controls.Add(btnPanelImportacoes);
            panelMenu.Controls.Add(panelVeiculos);
            panelMenu.Controls.Add(btnVeiculos);
            panelMenu.Controls.Add(panelImagem);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(199, 671);
            panelMenu.TabIndex = 0;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Bottom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 634);
            button4.Name = "button4";
            button4.Size = new Size(199, 37);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            // 
            // panelAnalises
            // 
            panelAnalises.BackColor = Color.FromArgb(53, 56, 83);
            panelAnalises.Controls.Add(button5);
            panelAnalises.Controls.Add(BtnDashBoard);
            panelAnalises.Dock = DockStyle.Top;
            panelAnalises.Location = new Point(0, 450);
            panelAnalises.Name = "panelAnalises";
            panelAnalises.Size = new Size(199, 116);
            panelAnalises.TabIndex = 5;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(144, 148, 155);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 38);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(199, 38);
            button5.TabIndex = 1;
            button5.Text = "                    Exportar Excel";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // BtnDashBoard
            // 
            BtnDashBoard.Cursor = Cursors.Hand;
            BtnDashBoard.Dock = DockStyle.Top;
            BtnDashBoard.FlatAppearance.BorderSize = 0;
            BtnDashBoard.FlatStyle = FlatStyle.Flat;
            BtnDashBoard.ForeColor = Color.FromArgb(144, 148, 155);
            BtnDashBoard.Image = (Image)resources.GetObject("BtnDashBoard.Image");
            BtnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDashBoard.Location = new Point(0, 0);
            BtnDashBoard.Margin = new Padding(0);
            BtnDashBoard.Name = "BtnDashBoard";
            BtnDashBoard.Size = new Size(199, 38);
            BtnDashBoard.TabIndex = 0;
            BtnDashBoard.Text = "                    DashBoard";
            BtnDashBoard.TextAlign = ContentAlignment.MiddleLeft;
            BtnDashBoard.UseVisualStyleBackColor = true;
            BtnDashBoard.Click += BtnDashBoard_Click;
            // 
            // BtnPanelAnalises
            // 
            BtnPanelAnalises.AutoSize = true;
            BtnPanelAnalises.BackgroundImageLayout = ImageLayout.None;
            BtnPanelAnalises.Cursor = Cursors.Hand;
            BtnPanelAnalises.Dock = DockStyle.Top;
            BtnPanelAnalises.FlatAppearance.BorderSize = 0;
            BtnPanelAnalises.FlatStyle = FlatStyle.Flat;
            BtnPanelAnalises.Font = new Font("MesloLGLDZ Nerd Font", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnPanelAnalises.ForeColor = Color.FromArgb(144, 148, 155);
            BtnPanelAnalises.Image = (Image)resources.GetObject("BtnPanelAnalises.Image");
            BtnPanelAnalises.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPanelAnalises.Location = new Point(0, 412);
            BtnPanelAnalises.Margin = new Padding(0);
            BtnPanelAnalises.Name = "BtnPanelAnalises";
            BtnPanelAnalises.Size = new Size(199, 38);
            BtnPanelAnalises.TabIndex = 4;
            BtnPanelAnalises.Text = "      Analises";
            BtnPanelAnalises.TextAlign = ContentAlignment.MiddleLeft;
            BtnPanelAnalises.UseVisualStyleBackColor = true;
            BtnPanelAnalises.Click += BtnPanelAnalises_Click;
            // 
            // panelImportacoes
            // 
            panelImportacoes.BackColor = Color.FromArgb(53, 56, 83);
            panelImportacoes.Controls.Add(button6);
            panelImportacoes.Controls.Add(button7);
            panelImportacoes.Dock = DockStyle.Top;
            panelImportacoes.Location = new Point(0, 296);
            panelImportacoes.Name = "panelImportacoes";
            panelImportacoes.Size = new Size(199, 116);
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
            button6.Size = new Size(199, 38);
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
            button7.Size = new Size(199, 38);
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
            btnPanelImportacoes.Size = new Size(199, 38);
            btnPanelImportacoes.TabIndex = 3;
            btnPanelImportacoes.Text = "     Importações";
            btnPanelImportacoes.TextAlign = ContentAlignment.MiddleLeft;
            btnPanelImportacoes.UseVisualStyleBackColor = true;
            btnPanelImportacoes.Click += btnPanelImportacoes_Click;
            // 
            // tbcHome
            // 
            tbcHome.Dock = DockStyle.Fill;
            tbcHome.Location = new Point(199, 0);
            tbcHome.Name = "tbcHome";
            tbcHome.SelectedIndex = 0;
            tbcHome.Size = new Size(977, 671);
            tbcHome.TabIndex = 1;
            tbcHome.MouseDown += tbcHome_MouseDown;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 671);
            Controls.Add(tbcHome);
            Controls.Add(panelMenu);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khora Control";
            panelVeiculos.ResumeLayout(false);
            panelImagem.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelAnalises.ResumeLayout(false);
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
        private Panel panelAnalises;
        private Button button5;
        private Button BtnDashBoard;
        private Button BtnPanelAnalises;
        private Button button4;
    }
}
