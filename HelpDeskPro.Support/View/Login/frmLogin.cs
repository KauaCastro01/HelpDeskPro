using HelpDeskPro.Support.Data;
using HelpDeskPro.Support.Services;
using HelpDeskPro.Support.Utility;

namespace HelpDeskPro
{
    public partial class frmLogin : Form
    {
        private readonly LembrarDeMim lembrar = new LembrarDeMim();
        private readonly HashSenha hash = new HashSenha();
        private readonly AppDbContext _db;
        private UsuarioAdminService _usuarioService;

        #region Eventos
        public frmLogin(AppDbContext db)
        {
            InitializeComponent();
            CarregarLembrarDeMim();
            _db = db;
            _usuarioService = new UsuarioAdminService(_db);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (!Sessao.TrocarConta)
                LoginAutomatico();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ValidarLogin();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(_db);
            form1.Show();
            this.Close();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void cBoxLembrarDeMim_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLembrarDeMim.Checked)
                lembrar.Salvar(txtBoxUsuario.Text, txtBoxSenha.Text, cBoxLembrarDeMim.Checked);
            else
                lembrar.Apagar();
        }

        #endregion

        #region Metodos
        public void CarregarLembrarDeMim()
        {
            lembrar.Carregar();
            var (usuario, senha, lembrarDeMim) = lembrar.Carregar();
            txtBoxUsuario.Text = usuario;
            txtBoxSenha.Text = senha;
            cBoxLembrarDeMim.Checked = lembrarDeMim;
        }

        private void ExibirMensagemErro(string mensagem)
        {
            Notificacao.BalloonTipTitle = "Erro";
            Notificacao.BalloonTipText = mensagem;
            Notificacao.BalloonTipIcon = ToolTipIcon.Error;

            Notificacao.ShowBalloonTip(3000);
        }

        private void ValidarLogin()
        {
            if (_usuarioService.Login(txtBoxUsuario.Text, hash.GerarHash(txtBoxSenha.Text)))
                AbrirForms();
            else
                ExibirMensagemErro("Usuário ou senha incorretos.");
        }

        private void LoginAutomatico()
        {
            if (_usuarioService.Login(txtBoxUsuario.Text, hash.GerarHash(txtBoxSenha.Text)))
                AbrirForms();
        }

        private void AbrirForms()
        {
            ObterIdDoUsuario();
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }

        public void ObterIdDoUsuario()
        {
            lembrar.IdUsuario(_usuarioService.ObterIdDoUsuario(txtBoxUsuario.Text, hash.GerarHash(txtBoxSenha.Text)));
        }
        #endregion

        
    }
}