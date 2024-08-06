using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhoraControl.View.UC
{
    public partial class Frm_CadastroCheckList_UC : UserControl
    {
        private Boolean ShowPanelCadastroCheckList = false;

        private System.Windows.Forms.Timer animationTimer;
        private int targetHeightCadastroCheckList;
        private int step = 13;
        public Frm_CadastroCheckList_UC()
        {
            InitializeComponent();
            InitializeAnimationTimer();
            TogglePanel();
        }

        private void InitializeAnimationTimer()
        {
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Animar painel Cadastro CheckList
            if (panelCadastroCheckList.Height != targetHeightCadastroCheckList)
            {
                if (Math.Abs(panelCadastroCheckList.Height - targetHeightCadastroCheckList) <= step)
                {
                    panelCadastroCheckList.Height = targetHeightCadastroCheckList;
                }
                else
                {
                    panelCadastroCheckList.Height += targetHeightCadastroCheckList > panelCadastroCheckList.Height ? step : -step;
                }
            }

            // Parar o Timer se todas as animações estiverem concluídas
            if (panelCadastroCheckList.Height == targetHeightCadastroCheckList)
            {
                animationTimer.Stop();
            }
        }

        private void TogglePanel()
        {
            targetHeightCadastroCheckList = ShowPanelCadastroCheckList ? 248 : 171;
            animationTimer.Start();
        }

        private void BtnShowPanel_Click(object sender, EventArgs e)
        {
            ShowPanelCadastroCheckList = !ShowPanelCadastroCheckList;
            if (ShowPanelCadastroCheckList)
            {
                BtnShowPanel.ImageIndex = 0;
            }
            else
            {
                BtnShowPanel.ImageIndex = 1;
            }
            TogglePanel();
        }
    }
}
