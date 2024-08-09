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
    public partial class Frm_BuscaConcessionaria : Form
    {

        List<ItemBox> ConcessionariaBusca = new List<ItemBox>();

        public int idSelect { get; set; }
        public string NomeSelect { get; set; }

        Concessionaria concessionaria = new Concessionaria();


        public Frm_BuscaConcessionaria()
        {
            InitializeComponent();
            PreencherLista();
            ListConcessionaria.Sorted = true;
            textBox1.Focus();
        }
        private class ItemBox()
        {
            public int ID { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return Nome;
            }

        }

        private void PreencherLista()
        {
            ListConcessionaria.Items.Clear();
            ConcessionariaBusca.Clear();

            var returnVeiculo = concessionaria.ReturnAll();
            foreach (var item in returnVeiculo)
            {
                ItemBox x = new ItemBox();
                x.ID = item.ID;
                x.Nome = item.Nome;
                ConcessionariaBusca.Add(x);
                ListConcessionaria.Items.Add(x);
            }
        }

        private void SelecionarItem()
        {
            try
            {
                ItemBox itemSelected = (ItemBox)ListConcessionaria.Items[ListConcessionaria.SelectedIndex];
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
            List<ItemBox> itemFilter = ConcessionariaBusca.Where(b => b.Nome.ToLower().Contains(filtro)).ToList();

            ListConcessionaria.Items.Clear();
            foreach( var item in itemFilter)
            {
                ListConcessionaria.Items.Add(item);
            }
        }

        private void ListConcessionaria_KeyDown(object sender, KeyEventArgs e)
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

        private void ListConcessionaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarItem();
        }
    }
}
