using KhoraControl.Model;
using System.Data;
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
            LbQuantVeiculo.Text = dados.Count().ToString();

            int veiculosAtivos = dados.Count(v => v.StatusVeiculo.Equals('T'));
            int veiculosInativos = dados.Count(v => v.StatusVeiculo.Equals('F'));

            ConfigureChartVeiculosPorMarca(dados);
            ConfigureChartVeiculosAtivosEInativos(veiculosAtivos, veiculosInativos);
            configureDataGrideViewColumns();

            DadosCheckList check = new DadosCheckList();
            var dadosCheck = check.ReturnAll();
            LbTotalRevisoes.Text = dadosCheck.Count().ToString();

            DadosNFe dadosN = new DadosNFe();
            var dadosNfe = dadosN.ReturnAll();
            lbTotalNotas.Text = dadosNfe.Count().ToString();

            Produtos produtos = new Produtos();
            var produtosCount = produtos.ReturnAll();
            lbTotalItens.Text = produtosCount.Count().ToString();
        }

        public void configureDataGrideViewColumns()
        {
            string[] colunasParaEsconder = { "DataDaCompra", "KmQuandoComprado", "DataUltimaRevisao", "KmUltimaRevisao", "DataProximaRevisao", 
                "KmProximaRevisao", "ID_Concessionaria", "LocalSalvamentoDeDados", "NotaFiscalDeCompra","ID_Empresa", "TipoVeiculo", "StatusVeiculo"};
            foreach (string nomeColuna in colunasParaEsconder)
            {
                if (DgvVeiculos.Columns.Contains(nomeColuna))
                {
                    DgvVeiculos.Columns[nomeColuna].Visible = false;
                }
            }

        }
        public void ConfigureChartVeiculosPorMarca(IEnumerable<Veiculo> dados)
        {
                var dadosPorMarca = dados
                .GroupBy(v => v.Marca)
                .Select(g => new { Marca = g.Key, Quantidade = g.Count() })
                .ToList();

            
            Chart pieChart = chartVeiculosPorMarca;
            pieChart.BackColor = Color.Lavender;
            pieChart.ChartAreas.Clear();
            pieChart.Series.Clear();
            pieChart.Titles.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.BackColor = Color.Lavender;
            pieChart.ChartAreas.Add(chartArea);

            Series series = new Series("Marcas");
            series.LabelBackColor = Color.Transparent;
            series.LabelForeColor = Color.Transparent;
            series.ChartType = SeriesChartType.Pie;

            foreach (var item in dadosPorMarca)
            {
                series.Points.AddXY(item.Marca, item.Quantidade);
            }

            pieChart.Series.Add(series);
        }
        public void ConfigureChartVeiculosAtivosEInativos(int vAtivos, int vInativos)
        {
            
            Chart pieChart = chartVeiculosAtIn;

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
