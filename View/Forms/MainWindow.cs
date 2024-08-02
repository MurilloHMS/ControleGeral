using KhoraControl.View.UC;

namespace KhoraControl
{
    public partial class MainWindow : Form
    {
        private Boolean showPanelMenu = false;
        private Boolean showPanelVeiculos = false;
        public MainWindow()
        {
            InitializeComponent();
            TogglePanel();
        }

        private void TogglePanel()
        {
            if (showPanelVeiculos)
            {
                panelVeiculos.Height = 115;
            }
            else
            {
                panelVeiculos.Height = 0;
            }
            if (showPanelMenu)
            {
                panelMenu.Width = 192;
            }
            else
            {
                panelMenu.Width = 40;
            }
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
    }
}
