using System;
using System.Windows.Forms;


namespace KhoraControl
{
    public partial class MainWindow : Form
    {
        private Boolean showPanelMenu = false;
        private Boolean showPanelVeiculos = false;
        private Boolean showPanelImportacoes = false;
        private System.Windows.Forms.Timer animationTimer;
        private int targetHeightVeiculos;
        private int targetWidthMenu;
        private int targetHeightImportacoes;
        private int step = 10; // Ajuste a velocidade da animação

        public MainWindow()
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

            // Parar o Timer se todas as animações estiverem concluídas
            if (panelVeiculos.Height == targetHeightVeiculos &&
                panelMenu.Width == targetWidthMenu &&
                panelImportacoes.Height == targetHeightImportacoes)
            {
                animationTimer.Stop();
            }
        }

        private void TogglePanel()
        {
            targetHeightVeiculos = showPanelVeiculos ? 115 : 0;
            targetWidthMenu = showPanelMenu ? 192 : 40;
            targetHeightImportacoes = showPanelImportacoes ? 115 : 0;

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
    }
}
