using KhoraControl.Model;
using KhoraControl.Model.Import;
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
    public partial class Frm_BuscaNotaFiscal : Form
    {

        List<ItemBox> NFeBusca = new List<ItemBox>();
        public int idSelect { get; set; }
        public string NomeSelect { get; set; }
        public string NumeroSelect { get; set; }

        DadosNFe notasFiscais = new DadosNFe();
        public Frm_BuscaNotaFiscal()
        {
            InitializeComponent();
            PreencherLista();
            ListNotasFiscais.Sorted = true;
            textBox1.Focus();
        }

        private class ItemBox()
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Numero { get; set; }
            public string NaturezaOpe { get; set; }
            public int ID_Veiculo { get; set; }

            public override string ToString()
            {
                return Nome + " - ID Veiculo: "+ ID_Veiculo + " - " + Numero + " - " + NaturezaOpe;
            }

        }

        private void PreencherLista()
        {
            ListNotasFiscais.Items.Clear();
            NFeBusca.Clear();

            var returnVeiculo = notasFiscais.ReturnAll();
            foreach (var item in returnVeiculo)
            {
                ItemBox x = new ItemBox();
                x.ID = item.ID;
                x.Nome = item.RazaoSocialRemetente;
                x.Numero = item.NumNFe;
                x.NaturezaOpe = item.NaturezaOperacao;
                x.ID_Veiculo = item.ID_Veiculo;
                NFeBusca.Add(x);
                ListNotasFiscais.Items.Add(x);
            }
        }

        private void SelecionarItem()
        {
            try
            {
                ItemBox itemSelected = (ItemBox)ListNotasFiscais.Items[ListNotasFiscais.SelectedIndex];
                DialogResult = DialogResult.OK;
                NomeSelect = itemSelected.Nome;
                idSelect = itemSelected.ID;
                NumeroSelect = itemSelected.Numero;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção selecione uma Nota Fiscal válida!", "NFe Selecionada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox1.Text.ToLower();
            List<ItemBox> itemFilter = NFeBusca.Where(x => x.Numero.ToLower().Contains(filtro)).ToList();

            ListNotasFiscais.Items.Clear();
            foreach (var item in itemFilter)
            {
                ListNotasFiscais.Items.Add(item);
            }
        }

        private void ListNotasFiscais_DoubleClick(object sender, EventArgs e)
        {
            SelecionarItem();
        }

        private void ListNotasFiscais_KeyDown(object sender, KeyEventArgs e)
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
