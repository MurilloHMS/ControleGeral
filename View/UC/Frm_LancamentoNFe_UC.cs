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

namespace KhoraControl.View.UC
{
    public partial class Frm_LancamentoNFe_UC : UserControl
    {
        public Frm_LancamentoNFe_UC()
        {
            InitializeComponent();
        }

        private void BtnBuscaVeiculo_Click(object sender, EventArgs e)
        {
            Frm_Busca busca = new Frm_Busca();
            busca.ShowDialog();

            if (busca.DialogResult == DialogResult.OK)
            {
                TxtID_Veiculo.Text = busca.idSelect.ToString();
                TxtVeiculo.Text = busca.NomeSelect;
            }
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
                        string path = ofd.FileName;
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
                        TxtTotNFe.Text = data.ValorNFe.ToString();
                        TxtTotProd.Text = data.ValorProd.ToString();

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

            // Ocultar colunas
            int[] colunasOcultar = new int[] { 0, 4, 5, 6, 7, 8, 9, 10, 11 };
            foreach(int i in colunasOcultar)
            {
                DgvDadosNFe.Columns[i].Visible = false;
            }
        }
    }
}
