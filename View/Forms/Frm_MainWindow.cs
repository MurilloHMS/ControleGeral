using KhoraControl.View.UC;
using System;
using System.Windows.Forms;


namespace KhoraControl
{
    public partial class Frm_MainWindow : Form
    {
        private Boolean showPanelMenu = false;
        private Boolean showPanelVeiculos = false;
        private Boolean showPanelImportacoes = false;
        private Boolean showPanelAnalises = false;

        private System.Windows.Forms.Timer animationTimer;
        private int targetHeightVeiculos;
        private int targetWidthMenu;
        private int targetHeightImportacoes;
        private int targetHeightAnalises;
        private int step = 13; // Ajuste a velocidade da animação

        public Frm_MainWindow()
        {
            InitializeComponent();
            InitializeAnimationTimer();
            TogglePanel();
        }

        private void InitializeAnimationTimer()
        {
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10; // Tempo em milissegundos entre cada passo da animação
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Animar painel Veiculos
            if (panelVeiculos.Height != targetHeightVeiculos)
            {
                if (Math.Abs(panelVeiculos.Height - targetHeightVeiculos) <= step)
                {
                    panelVeiculos.Height = targetHeightVeiculos;
                }
                else
                {
                    panelVeiculos.Height += targetHeightVeiculos > panelVeiculos.Height ? step : -step;
                }
            }

            // Animar painel Menu
            if (panelMenu.Width != targetWidthMenu)
            {
                if (Math.Abs(panelMenu.Width - targetWidthMenu) <= step)
                {
                    panelMenu.Width = targetWidthMenu;
                }
                else
                {
                    panelMenu.Width += targetWidthMenu > panelMenu.Width ? step : -step;
                }
            }

            // Animar painel Importacoes
            if (panelImportacoes.Height != targetHeightImportacoes)
            {
                if (Math.Abs(panelImportacoes.Height - targetHeightImportacoes) <= step)
                {
                    panelImportacoes.Height = targetHeightImportacoes;
                }
                else
                {
                    panelImportacoes.Height += targetHeightImportacoes > panelImportacoes.Height ? step : -step;
                }
            }

            // Animar painel Analises
            if (panelAnalises.Height != targetHeightAnalises)
            {
                if (Math.Abs(panelAnalises.Height - targetHeightAnalises) <= step)
                {
                    panelAnalises.Height = targetHeightAnalises;
                }
                else
                {
                    panelAnalises.Height += targetHeightAnalises > panelAnalises.Height ? step : -step;
                }
            }

            // Parar o Timer se todas as animações estiverem concluídas
            if (panelVeiculos.Height == targetHeightVeiculos &&
                panelMenu.Width == targetWidthMenu &&
                panelImportacoes.Height == targetHeightImportacoes &&
                panelAnalises.Height == targetHeightAnalises)
            {
                animationTimer.Stop();
            }
        }

        private void TogglePanel()
        {
            targetHeightVeiculos = showPanelVeiculos ? 115 : 0;
            targetWidthMenu = showPanelMenu ? 192 : 40;
            targetHeightImportacoes = showPanelImportacoes ? 115 : 0;
            targetHeightAnalises = showPanelAnalises ? 115 : 0;

            // Inicia a animação
            animationTimer.Start();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            showPanelVeiculos = !showPanelVeiculos;
            TogglePanel();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            showPanelMenu = !showPanelMenu;
            TogglePanel();
        }

        private void btnPanelImportacoes_Click(object sender, EventArgs e)
        {
            showPanelImportacoes = !showPanelImportacoes;
            TogglePanel();
        }

        private void BtnPanelAnalises_Click(object sender, EventArgs e)
        {
            showPanelAnalises = !showPanelAnalises;
            TogglePanel();
        }

        private void tbcHome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = CriaItemMenu("Fechar Aba", "Close Tab");
                var vToolTip002 = CriaItemMenu("Fechar Todas as Abas", "Close All Tabs");
                var vToolTip003 = CriaItemMenu("Fechar Todas as Abas a Direita", "Close Pane");

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);

                ContextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);

            }
        }

        void vToolTip001_Click(object sender, EventArgs e)
        {
            //apaga a aba selecionada 
            if (!(tbcHome.SelectedTab == null))
            {
                tbcHome.TabPages.Remove(tbcHome.SelectedTab);
            }
        }
        void vToolTip002_Click(object sender, EventArgs e)
        {
            //apaga todas as abas
            tbcHome.TabPages.Clear();
        }
        void vToolTip003_Click(object sender, EventArgs e)
        {
            //apaga todas as abas a direita
            if (!(tbcHome.SelectedTab == null))
            {
                int ItemSelecionado = tbcHome.SelectedIndex;

                for (int i = tbcHome.TabCount - 1; i > ItemSelecionado; i += -1)
                {

                    tbcHome.TabPages.Remove(tbcHome.TabPages[i]);

                }
            }
        }

        private ToolStripMenuItem CriaItemMenu(String text, string nomeDoIcone)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;
            return vToolTip;

        }

        private void ShowTabPage(UserControl userControl, string tabPageName, string tabPageText)
        {
            TabPage existingTabPage = tbcHome.TabPages.Cast<TabPage>().FirstOrDefault(tab => tab.Name == tabPageName);
            if (existingTabPage == null)
            {
                var newTabPage = new TabPage
                {
                    Name = tabPageName,
                    Text = tabPageText
                };
                userControl.Dock = DockStyle.Fill;
                newTabPage.Controls.Add(userControl);
                tbcHome.TabPages.Add(newTabPage);
                tbcHome.SelectedTab = newTabPage;
            }
            else
            {
                tbcHome.SelectedTab = existingTabPage;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ShowTabPage(new Frm_CadastroVeiculos_UC(), "Frm_CadastroVeiculos_UC", "Cadastro de Veiculos");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ShowTabPage(new Frm_CadastroEntidades_UC(), "Frm_CadastroEntidades_UC", "Cadastro de Entidades");
        }

        private void BtnDashBoard_Click(object sender, EventArgs e)
        {

            ShowTabPage(new Frm_Dashboard_Uc(), "Frm_Dashboard_UC", "DashBoard Analise Veiculos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowTabPage(new Frm_CadastroCheckList_UC(), "Frm_CadastroCheckList", "Cadastro de Check List");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowTabPage(new Frm_LancamentoNFe_UC(), "Frm_LancamentoNFe_UC", "Lancamento NFe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowTabPage(new Frm_Configuracoes_UC(), "Frm_Configuracoes_UC", "Lancamento NFe");
        }
    }
}
