using KhoraControl.Model;
using KhoraControl.Model.Enums;
using KhoraControl.View.Forms;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            PreencheComboBox();
        }

        private void PreencheComboBox()
        {
            Concessionaria con = new Concessionaria();
            var itens = con.ReturnAll();
            CbConcessionaria.Items.Add(string.Empty);
            foreach (var it in itens)
            {
                CbConcessionaria.Items.Add(it.Nome);
            }

        }

        private DadosCheckList CollectData()
        {
            DadosCheckList dados = new DadosCheckList();
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                dados.ID = int.Parse(TxtID.Text);
            }
            dados.ID_NotaFiscal = int.Parse(TxtId_NotaFiscal.Text);
            dados.Data = DtpDataLancamento.Value.ToUniversalTime();
            dados.ID_Veiculo = int.Parse(TxtID_Veiculo.Text);
            dados.ID_Concessionaria = int.Parse(TxtID_Concessionaria.Text);
            dados.KmRodados = int.Parse(TxtKmRodados.Text);
            dados.ValorRevisao = double.Parse(TxtValorRevisao.Text);
            dados.ChecklistItems = checkedListBox1.CheckedItems.Cast<string>().ToList();

            return dados;
        }

        private void WriteData(DadosCheckList ck)
        {
            TxtID.Text = ck.ID.ToString();
            TxtId_NotaFiscal.Text = ck.ID_NotaFiscal.ToString();
            TxtID_Veiculo.Text = ck.ID_Veiculo.ToString();
            TxtID_Concessionaria.Text = ck.ID_Concessionaria.ToString();
            DtpDataLancamento.Text = ck.Data.ToString();
            TxtKmRodados.Text = ck.KmRodados.ToString();
            TxtValorRevisao.Text = ck.ValorRevisao.ToString();

            var item = JsonSerializer.Deserialize<List<String>>(ck.ChecklistJson) ?? new List<String>();

            foreach (var i in item)
            {
                int index = checkedListBox1.Items.IndexOf(i);
                if (index != -1)
                {
                    checkedListBox1.SetItemChecked(index, true);
                }
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_BuscaVeiculo busca = new Frm_BuscaVeiculo();
            busca.ShowDialog();

            if (busca.DialogResult == DialogResult.OK)
            {
                TxtID_Veiculo.Text = busca.idSelect.ToString();
                TxtVeiculo.Text = busca.NomeSelect;
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                DadosCheckList dados = new DadosCheckList();
                dados.ValidaClasse();
                dados = CollectData();
                if (string.IsNullOrEmpty(TxtID.Text))
                {
                    dados.Insert();
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                else
                {
                    dados.Update();
                    MessageBox.Show("Dados Atualizados com sucesso!");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscaNotaFiscal_Click(object sender, EventArgs e)
        {
            Frm_BuscaNotaFiscal busca = new Frm_BuscaNotaFiscal();
            busca.ShowDialog();

            if (busca.DialogResult == DialogResult.OK)
            {
                TxtNumNotaFiscal.Text = busca.NumeroSelect;
                TxtId_NotaFiscal.Text = busca.idSelect.ToString();

            }
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            CollectData();
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            if(TxtID.Text.Length > 0)
            {
                var dados = new DadosCheckList();
                var retorno = dados.ReturnForID(int.Parse(TxtID.Text));
                WriteData(retorno);
            }
        }
    }
}
