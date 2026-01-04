using HelpDeskPro.Support.Data;
using HelpDeskPro.Support.Model;
using HelpDeskPro.Support.Properties;
using HelpDeskPro.Support.Services;
using HelpDeskPro.Support.Utility;
using System.Globalization;

namespace HelpDeskPro
{
    public partial class frmMenuPrincipal : Form
    {
        private readonly AppDbContext _db;
        private readonly ChamadoService _chamadoService;
        private readonly UsuarioAdminService _usuarioAdminService;

        #region Eventos
        public frmMenuPrincipal(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _chamadoService = new ChamadoService(_db);
            _usuarioAdminService = new UsuarioAdminService(_db);
            Sessao.TrocarConta = false;
            PopularComboResponsavel();
            PopularValores();
            cmbResponsavel.SelectedIndex = 1;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            frmCriar frmCriar = new frmCriar(_db, null);
            frmCriar.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditar frmEditar = new frmEditar(_db);
            frmEditar.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Breve", "Proxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig(_db);
            frmConfig.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void cBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistribuirValor();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Breve", "Proxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Breve", "Proxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmbResponsavel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistribuirValor();
        }

        #endregion

        #region Metodos

        private void PopularValores()
        {
            Data();
            cBoxFiltro.SelectedIndex = 0;
            DistribuirValor();
        }

        private void ExibirMensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Data()
        {
            var data = DateTime.Now;
            lblData.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(data.ToString("MMMM"));
        }

        public ChamadoTotalModel VerificarFiltro()
        {
            var tipo = cBoxFiltro.Text;

            if (cmbResponsavel.SelectedIndex == 0)
            {
                switch (tipo)
                {
                    case "Todos":
                        return _chamadoService.RetonarTodosChamados();
                    case "Diário":
                        return _chamadoService.RetonarChamadosDiario();
                    case "Semanal":
                        return _chamadoService.RetonarChamadosSemanal();
                    case "Mensal":
                        return _chamadoService.RetonarChamadosMensal();
                    default:
                        return _chamadoService.RetornoParaErro();
                }
            }
            else if (cmbResponsavel.SelectedIndex == 1)
            {
                switch (tipo)
                {
                    case "Todos":
                        return _chamadoService.RetonarTodosChamadosID(Settings.Default.ID);
                    case "Diário":
                        return _chamadoService.RetonarChamadosDiarioID(Settings.Default.ID);
                    case "Semanal":
                        return _chamadoService.RetornarChamadosSemanalID(Settings.Default.ID);
                    case "Mensal":
                        return _chamadoService.RetonarChamadosMensalID(Settings.Default.ID);
                    default:
                        return _chamadoService.RetornoParaErro();
                }
            }
            else
                return _chamadoService.RetornoParaErro();
        }

        public void DistribuirValor()
        {
            var tipo = cBoxFiltro.Text;
            ChamadoTotalModel chamadoTotalModel = VerificarFiltro();
            lblTotal.Text = chamadoTotalModel.TotalChamados.ToString();
            lblAberto.Text = chamadoTotalModel.ChamadosAbertos.ToString();
            lblAndamento.Text = chamadoTotalModel.ChamadosEmAndamento.ToString();
            lblResolvidos.Text = chamadoTotalModel.ChamadosFechados.ToString();
        }

        private void PopularComboResponsavel()
        {
            cmbResponsavel.Items.Clear();
            cmbResponsavel.Items.Add("Todos");
            cmbResponsavel.Items.Add(_usuarioAdminService.RetornarNomeAdmin(Settings.Default.ID));
        }

        #endregion
    }
}
