using KhoraControl.Model.Settings;
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
    public partial class Frm_Configuracoes_UC : UserControl
    {
        public Frm_Configuracoes_UC()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Carregar o provider de banco de dados
            string currentProvider = ConfigurationManagerHelper.GetSetting("DatabaseProvider");
            cbProvider.SelectedItem = currentProvider ?? "SQLite";

            // Carregar a string de conexão do provider selecionado
            string connectionString = ConfigurationManagerHelper.GetConnectionString(cbProvider.SelectedItem.ToString());
            TxtConnectionString.Text = connectionString;
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            string selectedProvider = cbProvider.SelectedItem.ToString();
            string newConnectionString = TxtConnectionString.Text;

            ConfigurationManagerHelper.SetConnectionString(selectedProvider, newConnectionString);
            ConfigurationManagerHelper.SetDatabaseProvider(selectedProvider);

            MessageBox.Show("Configurações salvas com sucesso!");
        }

        private void cbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Atualizar a string de conexão quando o provider for alterado
            string selectedProvider = cbProvider.SelectedItem.ToString();
            string connectionString = ConfigurationManagerHelper.GetConnectionString(selectedProvider);
            TxtConnectionString.Text = connectionString;
            lblTipoBase.Text = cbProvider.SelectedItem.ToString() == "SQLite" ? "BASE DE TESTE" : "BASE PRODUÇÃO";
            lblTipoBase.ForeColor = cbProvider.SelectedItem.ToString() == "SQLite" ? Color.Red : Color.Green;
        }
    }
}
