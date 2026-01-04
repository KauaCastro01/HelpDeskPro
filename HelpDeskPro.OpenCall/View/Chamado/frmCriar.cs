using HelpDeskPro.OpenCall.Data;
using HelpDeskPro.OpenCall.Model;
using HelpDeskPro.OpenCall.Properties;
using HelpDeskPro.OpenCall.Service;
using HelpDeskPro.OpenCall.View.Menus;
using HelpDeskPro.OpenCall.View.Chamado;

namespace HelpDeskPro.OpenCall.View.Chamado
{
    public partial class frmCriar : Form
    {
        private readonly AppDbContext _db;
        private readonly ChamadoModel _chamadoModel;
        private readonly ChamadoService _chamadoService;

        #region Eventos
        public frmCriar(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _chamadoService = new ChamadoService(_db);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ValidaCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AbrirFormsMenuPrincipal();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
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

        private void ValidaCampos()
        {
            if (string.IsNullOrEmpty(txtTitulo.Text))
                ExibirMensagemErro("O título está vazio.");
            else if (string.IsNullOrEmpty(txtDescricao.Text))
                ExibirMensagemErro("A descrição está vazia.");
            else
                CriarChamado();
        }

        private void AbrirFormsMenuPrincipal()
        {
            frmMenuPrincipal frmMenu = new frmMenuPrincipal(_db);
            frmMenu.Show();
            this.Close();
        }

        private ChamadoModel PopularClasseChamado()
        {
            return new ChamadoModel()
            {
                Titulo = txtTitulo.Text,
                Descricao = txtDescricao.Text,
                DataAbertura = DateTime.Now,
                Prioridade = "Média",
                UsuarioClientId = Settings.Default.ID
            };
        }

        private void CriarChamado()
        {
            ChamadoModel chamadoModel = PopularClasseChamado();

            if (_chamadoService.CriarChamado(chamadoModel))
            {
                ExibirMensagemSucesso("Chamado criado com sucesso!");
                AbrirFormsMenuPrincipal();
            }
            else
                ExibirMensagemErro("Erro ao criar chamado.");
        }
        private void LimparCampos()
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            txtTitulo.Focus();
        }

        #endregion

    }
}
