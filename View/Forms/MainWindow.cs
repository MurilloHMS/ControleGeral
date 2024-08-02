using KhoraControl.View.UC;

namespace KhoraControl
{
    public partial class MainWindow : Form
    {
        private Boolean showPanelMenu = false;
        private Boolean showPanelVeiculos = false;
        private Boolean showPanelImportacoes = false;
        public MainWindow()
        {
            InitializeComponent();
            TogglePanel();
        }

        private void TogglePanel()
        {

            panelVeiculos.Height = showPanelVeiculos ? 115 : 0;
            panelMenu.Width = showPanelMenu ? 192 : 40;
            panelImportacoes.Height = showPanelImportacoes ? 115 : 0;
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            showPanelVeiculos = !showPanelVeiculos;
            TogglePanel();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            showPanelMenu = !showPanelMenu;
            TogglePanel();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_CadastroVeiculos_UC frm = new Frm_CadastroVeiculos_UC();
            frm.Dock = DockStyle.Fill;
            TabPage tp = new TabPage();
            tp.Name = frm.Name;
            tp.Text = "Cadastro Veiculos";
            tp.Controls.Add(frm);
            tbcHome.Controls.Add(tp);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_CadastroEntidades_UC frm = new Frm_CadastroEntidades_UC();
            frm.Dock = DockStyle.Fill;
            TabPage tp = new TabPage();
            tp.Name = frm.Name;
            tp.Text = "Cadastro Entidades";
            tp.Controls.Add(frm);
            tbcHome.Controls.Add(tp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_CadastroCheckList_UC frm = new Frm_CadastroCheckList_UC();
            frm.Dock = DockStyle.Fill;
            TabPage tp = new TabPage();
            tp.Name = frm.Name;
            tp.Text = "Cadastro Check Lists";
            tp.Controls.Add(frm);
            tbcHome.Controls.Add(tp);
        }

        private void btnPanelImportacoes_Click(object sender, EventArgs e)
        {
            showPanelImportacoes = !showPanelImportacoes;
            TogglePanel();
        }
    }
}
