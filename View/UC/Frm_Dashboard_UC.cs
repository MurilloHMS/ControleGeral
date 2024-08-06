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
using System.Windows.Forms.DataVisualization.Charting;

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

            int veiculosAtivos = dados.Count(v => v.StatusVeiculo.Equals('T'));
            int veiculosInativos = dados.Count(v => v.StatusVeiculo.Equals('F')); 
            ConfigureChartVeiculosAtivosEInativos(veiculosAtivos, veiculosInativos);
        }

        public void ConfigureChartVeiculosAtivosEInativos(int vAtivos, int vInativos)
        {
            
            Chart pieChart = chart1;

            pieChart.ChartAreas.Clear();
            pieChart.Series.Clear();
            pieChart.Titles.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.BackColor = Color.Lavender;
            pieChart.ChartAreas.Add(chartArea);

            
            Series series = new Series("Veiculos");
            series.LabelBackColor = Color.Transparent;
            series.LabelForeColor = Color.Transparent;
            series.ChartType = SeriesChartType.Pie;

            
            series.Points.AddXY("Veiculos Ativos", vAtivos);
            series.Points.AddXY("Veiculos Inativos", vInativos);

            pieChart.Series.Add(series);

        }

        private void Frm_Dashboard_Uc_Load(object sender, EventArgs e)
        {
            MostrarDadosVeiculo();
        }
    }
}
