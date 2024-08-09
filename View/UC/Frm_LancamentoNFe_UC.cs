using KhoraControl.Model.Enums;
using KhoraControl.Model;
using KhoraControl.Model.Import;
using KhoraControl.View.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace KhoraControl.View.UC
{
    public partial class Frm_LancamentoNFe_UC : UserControl
    {

        private Boolean showPanelLancamentoPedido = false;

        private System.Windows.Forms.Timer animationTimer;
        private int targetLancamentoPedido;
        private int step = 13;

        private string path;
        public Frm_LancamentoNFe_UC()
        {
            InitializeComponent();
            PreencheComboBox();
            InitializeAnimationTimer();
            TogglePanel();
            
        }

        private void BtnBuscaVeiculo_Click(object sender, EventArgs e)
        {
            Frm_BuscaVeiculo busca = new Frm_BuscaVeiculo();
            busca.ShowDialog();

            if (busca.DialogResult == DialogResult.OK)
            {
                TxtID_Veiculo.Text = busca.idSelect.ToString();
                TxtVeiculo.Text = busca.NomeSelect;
            }
        }

        #region Animação

        private void InitializeAnimationTimer()
        {
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if(panelLancamentoPedido.Height != targetLancamentoPedido)
            {
                if (Math.Abs(panelLancamentoPedido.Height - targetLancamentoPedido) <= step)
                {
                    panelLancamentoPedido.Height = targetLancamentoPedido;
                }
                else 
                {
                    panelLancamentoPedido.Height += targetLancamentoPedido > panelLancamentoPedido.Height ? step : -step;
                }

            }

            if (panelLancamentoPedido.Height == targetLancamentoPedido)
            {
                animationTimer.Stop();
            }
        }

        private void TogglePanel()
        {
            targetLancamentoPedido = showPanelLancamentoPedido ? 375 : 250;
            animationTimer.Start();
        }
        #endregion

        private void PreencheComboBox()
        {
            CbNaturezaOpe.DataSource = Enum.GetValues(typeof(TipoNaturezaOperacao_e));
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Arquivos XML (*.xml)|*.xml|Todos os Arquivos (*.*)|*.*";
                    ofd.Title = "Selecione um arquivo XML";
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        path = ofd.FileName;
                        NFeData data = new NFeData();
                        var dados = data.ReturnDados(path);

                        TxtChave.Text = data.ChaveNFe;
                        TxtNumNFe.Text = data.NumeroNFe;
                        DtpDataEmissao.Value = data.DataEmissao;
                        TxtRzSocialRem.Text = data.Fornecedor;
                        mTxtCnpjRem.Text = data.CNPJ;
                        TxtRzSocialDest.Text = data.Destinatario;
                        mTxtCnpjDes.Text = data.CNPJDestinatario;
                        TxtSerie.Text = data.Serie;
                        TxtTotNFe.Text = data.ValorNFe;
                        TxtTotProd.Text = data.ValorProd;

                        DgvDadosNFe.DataSource = dados;
                        AjustarColunasDataGridView();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AjustarColunasDataGridView()
        {
            DgvDadosNFe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvDadosNFe.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvDadosNFe.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DgvDadosNFe.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ocultar colunas , 4, 5, 6, 7, 8, 9, 10, 11
            int[] colunasOcultar = new int[] { 0, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            foreach (int i in colunasOcultar)
            {
                DgvDadosNFe.Columns[i].Visible = false;
            }
        }

        private void SaveData()
        {
            DadosNFe dados = new DadosNFe()
            {
                NaturezaOperacao = CbNaturezaOpe.Text,
                ID_Veiculo = int.Parse(TxtID_Veiculo.Text),
                NumNFe = TxtNumNFe.Text ?? null,
                Serie = TxtSerie.Text ?? null,
                ChaveDeAcesso = TxtChave.Text ?? null,
                RazaoSocialDestinatario = TxtRzSocialDest.Text,
                RazaoSocialRemetente = TxtRzSocialRem.Text,
                CNPJDestinatario = mTxtCnpjDes.Text ?? null,
                CNPJRemetente = mTxtCnpjRem.Text ?? null,
                DataEmissao = DtpDataEmissao.Value.ToUniversalTime(),
                DataRevisao = DtpDataRevisao.Value.ToUniversalTime(),
                ValorTotalNotaFiscal = double.Parse(TxtTotNFe.Text),
                ValorTotalProdutos = double.Parse(TxtTotProd.Text)
            };

            dados.Insert();
            TxtID.Text = dados.ID.ToString();



            List<Produtos> produtosParaIncluir = new List<Produtos>();

            foreach (DataGridViewRow row in DgvDadosNFe.Rows)
            {
                Produtos produto = new Produtos
                {
                    CodigoProduto = row.Cells["Referência"].Value.ToString(),
                    DescricaoProduto = row.Cells["Descrição"].Value.ToString(),
                    Quantidade = int.Parse(row.Cells["Quantidade"].Value.ToString()),
                    ValorUnitario = double.Parse(row.Cells["ValorUnitario"].Value.ToString()),
                    ValorTotal = double.Parse(row.Cells["ValorTotal"].Value.ToString()),
                    ID_Veiculo = int.Parse(TxtID_Veiculo.Text),
                    NumeroNFe = TxtNumNFe.Text,
                    ID_NFe = int.Parse(TxtID.Text)

                };

                produtosParaIncluir.Add(produto);
            }

            Veiculo veiculo = new Veiculo();
            var retorno = veiculo.GetForID(int.Parse(TxtID_Veiculo.Text));
            if (!Directory.Exists($@"{retorno.LocalSalvamentoDeDados}\{retorno.Placa}\XML"))
            {
                Directory.CreateDirectory($@"{retorno.LocalSalvamentoDeDados}\{retorno.Placa}\XML");
            }
            if (!string.IsNullOrEmpty(TxtChave.Text))
            {
                File.Copy(path, $@"{retorno.LocalSalvamentoDeDados}\{retorno.Placa}\XML\{TxtChave.Text}.xml");
            }

            try
            {
                foreach (Produtos i in produtosParaIncluir)
                {
                    i.Insert();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao incluir os produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Dados incluídos com sucesso!", "Inclusão de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void CbNaturezaOpe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((TipoNaturezaOperacao_e)CbNaturezaOpe.SelectedItem == TipoNaturezaOperacao_e.PedidoServiço ||
                (TipoNaturezaOperacao_e)CbNaturezaOpe.SelectedItem == TipoNaturezaOperacao_e.PedidoRevisao)
            {
                DtpDataEmissao.Enabled = true;
                showPanelLancamentoPedido = true;
                TogglePanel();
            }
            else
            {
                showPanelLancamentoPedido = false;
                TogglePanel();
                DtpDataEmissao.Enabled = false;
            }
        }
    }
}
