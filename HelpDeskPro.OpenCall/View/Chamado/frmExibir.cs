using HelpDeskPro.OpenCall.Data;
using HelpDeskPro.OpenCall.Model;
using HelpDeskPro.OpenCall.Properties;
using HelpDeskPro.OpenCall.Relatorio;
using HelpDeskPro.OpenCall.Service;
using HelpDeskPro.OpenCall.View.Menus;

namespace HelpDeskPro.OpenCall.View.Chamado
{
    public partial class frmExibir : Form
    {
        private readonly AppDbContext _db;
        private readonly ChamadoService _chamadoService;
        private RelatorioTotal rel = new RelatorioTotal();

        #region Eventos
        public frmExibir(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _chamadoService = new ChamadoService(_db);
            PopularDGV();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ChamadoModel chamado = (ChamadoModel)dgv.SelectedRows[0].DataBoundItem;
                frmDetalhes frmDetalhes = new frmDetalhes(_db, chamado);
                frmDetalhes.Show();
                this.Close();
            }
            else
                ExibirMensagemErro("Selecione uma linha!");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            int id = Settings.Default.ID;
            dgv.DataSource = _chamadoService.ObterTodosChamadosPorPesquisa(txtPesquisar.Text, id);
            ColunasDGV();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }
        #endregion

        #region Metodos
        private void ExibirMensagemErro(string mensagem)
        {
            Notificacao.BalloonTipTitle = "Erro";
            Notificacao.BalloonTipText = mensagem;
            Notificacao.BalloonTipIcon = ToolTipIcon.Error;

            Notificacao.ShowBalloonTip(3000);
        }

        private void ExibirMensagemSucesso(string mensagem)
        {
            Notificacao.BalloonTipTitle = "Sucesso";
            Notificacao.BalloonTipText = mensagem;
            Notificacao.BalloonTipIcon = ToolTipIcon.Info;

            Notificacao.ShowBalloonTip(3000);
        }
        
        public void PopularDGV()
        {
            try
            {
                int id = Settings.Default.ID;
                dgv.DataSource = _chamadoService.ObterTodosChamados(id);
                ColunasDGV();
            }
            catch (Exception ex)
            {
                ExibirMensagemErro("Erro ao carregar chamados: " + ex.Message);
            }
        }

        public void ColunasDGV()
        {
            dgv.Columns["Titulo"].HeaderText = "Título";
            dgv.Columns["Descricao"].HeaderText = "Descrição";
            dgv.Columns["Status"].HeaderText = "Status";
            dgv.Columns["DataAbertura"].HeaderText = "Data de Abertura";
            dgv.Columns["DataFechamento"].HeaderText = "Data de Fechamento";
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["Prioridade"].Visible = false;
            dgv.Columns["UsuarioAdminId"].Visible = false;
            dgv.Columns["UsuarioClientId"].Visible = false;
        }

        private void ValidarSelecao()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ChamadoModel chamado = (ChamadoModel)dgv.SelectedRows[0].DataBoundItem;
                frmCriar frmCriar = new frmCriar(_db);
                frmCriar.Show();
                this.Close();
            }
        }

        #endregion


        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            rel.GerarPDF(dgv);
        }

        private void frmExibir_Load(object sender, EventArgs e)
        {

        }
    }
}
