using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhoraControl.View.Forms;
using KhoraControl.Model;
using Microsoft.Extensions.Options;
using KhoraControl.Model.Import;

namespace KhoraControl.View.UC
{
    public partial class Frm_ConsultaVeiculos_UC : UserControl
    {
        public Frm_ConsultaVeiculos_UC()
        {
            InitializeComponent();
        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            Frm_BuscaVeiculo frm = new Frm_BuscaVeiculo();
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Veiculo veiculo = new Veiculo();
                var veiculoEncontrado = veiculo.GetForID(frm.idSelect);

                txtID.Text = veiculoEncontrado.ID.ToString();
                txtAno.Text = veiculoEncontrado.Ano;
                txtMarca.Text = veiculoEncontrado.Marca;
                txtModelo.Text = veiculoEncontrado.Modelo;
                txtPlaca.Text = veiculoEncontrado.Placa;

                DadosCheckList ck = new DadosCheckList();
                var dados = ck.ReturnForIDVeiculo(veiculoEncontrado.ID);

                dgvRevisoes.DataSource = dados;
                txtQuantRevisoes.Text = dados.Count().ToString();

                DadosNFe nfe = new DadosNFe();
                var notas = nfe.ReturnForIDVeiculo(veiculoEncontrado.ID);
                
                dgvNFe.DataSource = notas;
                txtQuantNFe.Text = notas.Count().ToString();
            }
        }
    }
}
