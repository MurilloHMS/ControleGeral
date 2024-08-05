
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
            Veiculo v = new Veiculo();
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                v.ID = int.Parse(TxtID.Text);
            }
            v.ID_Concessionaria = int.Parse(TxtIDConcessionaria.Text);
            v.ID_Empresa = int.Parse(TxtIDEmpresa.Text);
            v.Marca = TxtMarca.Text;
            v.Placa = TxtPlaca.Text;
            v.Ano = TxtAno.Text;
            v.Modelo = TxtModelo.Text;
            v.DataDaCompra = DtpDataDaCompra.Value;
            v.KmQuandoComprado = int.Parse(TxtKmQuandoComprado.Text);
            v.DataUltimaRevisao = DtpDataUltimaRevisao.Value;
            v.KmUltimaRevisao = int.Parse(TxtKmUltimaRevisao.Text);
            v.DataProximaRevisao = DtpDataProximaRevisao.Value;
            v.KmRodados = int.Parse(TxtKmRodados.Text);
            v.SugestaoConcessionaria = TxtSugestaoConcessionaria.Text;
            v.Observacoes = TxtObs.Text;
            v.LocalSalvamentoDeDados = TxtLocalSalvamento.Text;





            return v;
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo = new Veiculo();
                veiculo = CollectData();
                veiculo.ValidaClasse();
                if (string.IsNullOrEmpty(TxtID.Text))
                {
                    veiculo.Update();
                    MessageBox.Show("Veiculo Atualizado com sucesso!", "Atualização Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    veiculo.Insert();
                    MessageBox.Show("Veiculo Cadastrado com sucesso!", "Cadastro Veiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            string nome = cbConcessionária.Text;
            var retorno = emp.ReturnForName(nome);
            if (retorno != null)
            {
                TxtIDEmpresa.Text = retorno.ID.ToString();
            }
        }
    }
}
