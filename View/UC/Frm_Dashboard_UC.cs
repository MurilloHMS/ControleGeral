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
    public partial class Frm_Dashboard_Uc : UserControl
    {
        public Frm_Dashboard_Uc()
        {
            InitializeComponent();
        }

        public void MostrarDadosVeiculo()
        {
            Veiculo veiculo = new Veiculo();
            var dados = veiculo.GetAll();
            DgvVeiculos.DataSource = dados;
            TxtQuantVeiculo.Text = dados.Count().ToString();
        }

        private void Frm_Dashboard_Uc_Load(object sender, EventArgs e)
        {
            MostrarDadosVeiculo();
        }
    }
}
