using KhoraControl.Model;
using KhoraControl.Model.Requests;
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
    public partial class Frm_CadastroEntidades_UC : UserControl
    {
        public Frm_CadastroEntidades_UC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cep = TxtCep.Text;
            if (cep.Length == 9)
            {
                var vjson = CepRequests.GeraJsonCEP(cep);
                CEP.Unit uCep = new CEP.Unit();
                uCep = CEP.DesSeializedClassUnit(vjson);

                TxtLogradouro.Text = uCep.Logradouro;
                TxtLocalidade.Text = uCep.Localidade;
                TxtBairro.Text = uCep.Bairro;
                TxtComplemento.Text = uCep.Complemento;
                TxtUF.Text = uCep.Uf;
            }
        }

        private Concessionaria CollectConceData()
        {
            Concessionaria con = new Concessionaria();
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                con.ID = int.Parse(TxtID.Text);
            }
            con.Nome = TxtNome.Text;
            con.CNPJ = TxtCPNJ.Text;
            con.IE = TxtIE.Text;
            con.Cep = TxtCep.Text;
            con.Localidade = TxtLocalidade.Text;
            con.Logradouro = TxtLogradouro.Text;
            con.Bairro = TxtBairro.Text;
            con.Complemento = TxtComplemento.Text;
            con.Uf = TxtUF.Text;
            con.Numero = TxtNumero.Text;

            return con;
        }

        private Empresa CollectEmpreData()
        {
            Empresa con = new Empresa();
            if (!string.IsNullOrEmpty(TxtID.Text))
            {
                con.ID = int.Parse(TxtID.Text);
            }
            con.Nome = TxtNome.Text;
            con.CNPJ = TxtCPNJ.Text;
            con.IE = TxtIE.Text;
            con.Cep = TxtCep.Text;
            con.Localidade = TxtLocalidade.Text;
            con.Logradouro = TxtLogradouro.Text;
            con.Bairro = TxtBairro.Text;
            con.Complemento = TxtComplemento.Text;
            con.Uf = TxtUF.Text;
            con.Numero = TxtNumero.Text;

            return con;
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (RbConcessionaria.Checked) 
            {
                try
                {
                    Concessionaria con = new Concessionaria();
                    con = CollectConceData();
                    if (!string.IsNullOrEmpty(TxtID.Text))
                    {
                        con.Update();
                        MessageBox.Show("Concessionária atualizada com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        con.Insert();
                        MessageBox.Show("Concessionária inserida com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (RbEmpresa.Checked)
            {
                try
                {
                    Empresa empresa = new Empresa();
                    empresa = CollectEmpreData();
                    if (!string.IsNullOrEmpty(TxtID.Text))
                    {
                        empresa.Update();
                        MessageBox.Show("Empresa atualizada com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        empresa.Insert();
                        MessageBox.Show("Empresa inserida com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
