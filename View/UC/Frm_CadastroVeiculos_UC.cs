
using KhoraControl.Model;
using KhoraControl.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace KhoraControl.View.UC
{
    public partial class Frm_CadastroVeiculos_UC : UserControl
    {
        public Frm_CadastroVeiculos_UC()
        {
            InitializeComponent();
            PreencheComboBox();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void PreencheComboBox()
        {
            Concessionaria con = new Concessionaria();
            var itens = con.ReturnAll();
            cbConcessionária.Items.Add(string.Empty);
            foreach (var it in itens)
            {
                cbConcessionária.Items.Add(it.Nome);
            }

            cbTipoVeiculo.DataSource = Enum.GetValues(typeof(TipoVeiculo_e));

            Empresa emp = new Empresa();
            var item = emp.ReturnAll();
            cbEmpresa.Items.Add(string.Empty);
            foreach (var it in item)
            {
                cbEmpresa.Items.Add(it.Nome);
            }
        }
        private Veiculo CollectData()
        {
            TipoVeiculo_e tipo;
            Veiculo v = new Veiculo();
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                v.ID = int.Parse(TxtID.Text);
            }
            v.ID_Concessionaria = ParseNullable(TxtIDConcessionaria.Text);
            v.ID_Empresa = ParseNullable(TxtIDEmpresa.Text);
            v.Marca = TxtMarca.Text.Trim();
            v.Placa = TxtPlaca.Text;
            v.Ano = TxtAno.Text;
            v.Modelo = TxtModelo.Text;
            v.DataDaCompra = DtpDataDaCompra.Checked ? DtpDataDaCompra.Value : null;
            v.KmQuandoComprado = ParseNullable(TxtKmQuandoComprado.Text);
            v.DataUltimaRevisao = DtpDataUltimaRevisao.Checked ? DtpDataUltimaRevisao.Value : null;
            v.KmUltimaRevisao = ParseNullable(TxtKmUltimaRevisao.Text);
            v.DataProximaRevisao = DtpDataProximaRevisao.Checked ? DtpDataProximaRevisao.Value : null;
            v.KmRodados = ParseNullable(TxtKmRodados.Text);
            v.SugestaoConcessionaria = TxtSugestaoConcessionaria.Text;
            v.Observacoes = TxtObs.Text;
            v.LocalSalvamentoDeDados = TxtLocalSalvamento.Text;
            bool parseSuccess = Enum.TryParse<TipoVeiculo_e>(cbTipoVeiculo.SelectedValue.ToString(), out tipo);
            v.TipoVeiculo = parseSuccess ? tipo.ToString() : null;
            v.NotaFiscalDeCompra = TxtNotaFiscalDeCompra.Text;
            v.StatusVeiculo = ckbAtivo.Checked ? (char)StatusEstoque_e.Ativo : (char)StatusEstoque_e.Inativo;

            return v;
        }

        private void WriteData(Veiculo V)
        {
            TxtID.Text = V.ID.ToString();
            TxtAno.Text = V.Ano;
            TxtIDConcessionaria.Text = V.ID_Concessionaria.ToString();
            TxtIDEmpresa.Text = V.ID_Empresa.ToString();
            TxtKmProximaRevisao.Text = V.KmProximaRevisao.ToString();
            TxtKmQuandoComprado.Text = V.KmQuandoComprado.ToString();
            TxtKmRodados.Text = V.KmRodados.ToString();
            TxtKmUltimaRevisao.Text = V.KmUltimaRevisao.ToString();
            TxtLocalSalvamento.Text = V.LocalSalvamentoDeDados;
            TxtModelo.Text = V.Modelo;
            TxtObs.Text = V.Observacoes;
            TxtPlaca.Text = V.Placa;
            TxtSugestaoConcessionaria.Text = V.SugestaoConcessionaria;
            TxtMarca.Text = V.Marca;
            TxtNotaFiscalDeCompra.Text = V.NotaFiscalDeCompra;
            DtpDataDaCompra.Text = V.DataDaCompra.ToString();
            cbTipoVeiculo.SelectedItem = V.TipoVeiculo;
            ckbAtivo.Checked = V.StatusVeiculo == 'T' ? true : false;

        }

        private void ClearData()
        {
            TxtID.Clear();
            TxtAno.Clear();
            TxtIDConcessionaria.Clear();
            TxtIDEmpresa.Clear();
            TxtKmProximaRevisao.Clear();
            TxtKmQuandoComprado.Clear();
            TxtKmRodados.Clear();
            TxtKmUltimaRevisao.Clear();
            TxtLocalSalvamento.Clear();
            TxtModelo.Clear();
            TxtObs.Clear();
            TxtPlaca.Clear();
            TxtSugestaoConcessionaria.Clear();
            TxtMarca.Clear();
            TxtNotaFiscalDeCompra.Clear();
            cbConcessionária.SelectedIndex = 0;
            cbEmpresa.SelectedIndex = 0;
            cbTipoVeiculo.SelectedIndex = 0;
        }

        private int? ParseNullable(string text)
        {
            return int.TryParse(text, out var result) ? (int)result : null;
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo = new Veiculo();
                veiculo = CollectData();
                veiculo.ValidaClasse();

                string localSalvamento = $@"{veiculo.LocalSalvamentoDeDados}\{veiculo.Placa}";
                if (!Directory.Exists(localSalvamento))
                {
                    Directory.CreateDirectory(localSalvamento);
                }

                if (!Directory.Exists($@"{localSalvamento}\PDF"))
                {
                    Directory.CreateDirectory($@"{localSalvamento}\PDF");
                }
                if (TxtNotaFiscalDeCompra.Text.Length > 0)
                {
                    File.Copy(veiculo.NotaFiscalDeCompra, $@"{localSalvamento}\PDF\NotaFiscalDeCompra.pdf");
                }


                if (!string.IsNullOrEmpty(TxtID.Text))
                {
                    veiculo.Update();
                    MessageBox.Show("Veiculo Atualizado com sucesso!", "Atualização Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
                else
                {
                    veiculo.Insert();
                    MessageBox.Show("Veiculo Cadastrado com sucesso!", "Cadastro Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }

                
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Erro ao validar Classe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Arquivos PDF (*.pdf)|*.xml|Todos os arquivos(*.*)|*.*";
                    ofd.Title = "Selecione o PDF de Compra do Veiculo";
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        TxtNotaFiscalDeCompra.Text = ofd.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    TxtLocalSalvamento.Text = fbd.SelectedPath;
                }
            }
        }

        private void cbConcessionária_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtIDConcessionaria.Text = string.Empty;
            Concessionaria con = new Concessionaria();
            string nome = cbConcessionária.Text;
            var retorno = con.ReturnForName(nome);
            if (retorno != null)
            {
                TxtIDConcessionaria.Text = retorno.ID.ToString();
            }
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtIDEmpresa.Text = string.Empty;
            Empresa emp = new Empresa();
            string nome = cbEmpresa.Text;
            var retorno = emp.ReturnForName(nome);
            if (retorno != null)
            {
                TxtIDEmpresa.Text = retorno.ID.ToString();
            }
        }

        private void LimpartoolStripButton_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            if (TxtID.Text.Length > 0)
            {
                Veiculo veiculo = new Veiculo();
                WriteData(veiculo.GetForID(int.Parse(TxtID.Text)));
            }
            else
            {
                ClearData();
            }
        }
    }
}
