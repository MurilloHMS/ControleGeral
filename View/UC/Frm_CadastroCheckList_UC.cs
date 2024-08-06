using KhoraControl.Model;
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
            targetHeightCadastroCheckList = ShowPanelCadastroCheckList ? 240 : 150;
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

        private void Frm_CadastroCheckList_UC_Load(object sender, EventArgs e)
        {
            WriteCheckListData();
        }

        private void WriteCheckListData()
        {
            try
            {
                checkedListBox1.Items.Clear();
                CheckList checkList = new CheckList();
                var dados = checkList.ReturnAll();
                foreach (var check in dados)
                {
                    checkedListBox1.Items.Add(check.Descricao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao inserir os dados\n\n{ex.Message}\n\n{ex.Data}", "Erro ao Importar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CheckList ck = new CheckList();
                if (!string.IsNullOrEmpty(TxtID_CheckList.Text))
                {
                    ck.Id = int.Parse(TxtID_CheckList.Text);
                    ck.Descricao = TxtDescritivoCheckList.Text.Trim();
                    ck.ValidaClasse();
                    ck.Update();
                }
                else
                {
                    ck.Descricao = TxtDescritivoCheckList.Text;
                    ck.ValidaClasse();
                    ck.Insert();
                }

                //MessageBox.Show("Dados inseridos com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WriteCheckListData();
                TxtDescritivoCheckList.Clear();
                TxtID_CheckList.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao inserir os dados\n\n{ex.Message}\n\n{ex.Data}", "Erro ao Importar dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtDescritivoCheckList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }

    }
}
