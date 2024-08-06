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

namespace KhoraControl.View.Forms
{
    public partial class Frm_Busca : Form
    {

        List<ItemBox> VeiculosBusca = new List<ItemBox>();
        public int idSelect { get; set; }
        public string NomeSelect { get; set; }
        Veiculo veiculos = new Veiculo();
        public Frm_Busca()
        {
            InitializeComponent();
            PreencherLista();
            ListVeiculos.Sorted = true;
            textBox1.Focus();
        }

        private class ItemBox()
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Placa { get; set; }
            public string Marca { get; set; }

            public override string ToString()
            {
                return Marca + " - " + Nome + " - " + Placa;
            }

        }

        private void PreencherLista()
        {
            ListVeiculos.Items.Clear();
            VeiculosBusca.Clear();

            var returnVeiculo = veiculos.GetAll();
            foreach (var item in returnVeiculo)
            {
                ItemBox x = new ItemBox();
                x.ID = item.ID;
                x.Nome = item.Modelo;
                x.Placa = item.Placa;
                x.Marca = item.Marca;
                VeiculosBusca.Add(x);
                ListVeiculos.Items.Add(x);
            }
        }

        private void SelecionarItem()
        {
            try
            {
                ItemBox itemSelected = (ItemBox)ListVeiculos.Items[ListVeiculos.SelectedIndex];
                DialogResult = DialogResult.OK;
                NomeSelect = itemSelected.Nome;
                idSelect = itemSelected.ID;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção selecione um Veiculo válido!", "Veiculo Selecionado inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox1.Text.ToLower();
            List<ItemBox> itemFilter = VeiculosBusca.Where(x => x.Nome.ToLower().Contains(filtro)).ToList();

            ListVeiculos.Items.Clear();
            foreach (var item in itemFilter)
            {
                ListVeiculos.Items.Add(item);
            }
        }

        private void ListVeiculos_DoubleClick(object sender, EventArgs e)
        {
            SelecionarItem();
        }

        private void ListVeiculos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SelecionarItem();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
