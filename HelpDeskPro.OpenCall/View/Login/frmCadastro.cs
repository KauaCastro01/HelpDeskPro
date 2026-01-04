using HelpDeskPro.OpenCall.Data;
using HelpDeskPro.OpenCall.Model;
using HelpDeskPro.OpenCall.Service;
using HelpDeskPro.OpenCall.Utility;
using HelpDeskPro.OpenCall.View.Menus;


namespace HelpDeskPro.OpenCall.View.Login
{
    public partial class frmCadastro : Form
    {
        Hash hash = new Hash();
        private readonly AppDbContext _db;
        private readonly UsuarioClientService _usuarioClientService;
        private LembrarDeMim LembrarDeMim = new LembrarDeMim();

        #region Eventos
        public frmCadastro(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _usuarioClientService = new UsuarioClientService(_db);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ValidaCampos();
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
            txtBoxSenhaNovamente.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
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
            if (txtBoxNome.Text.Length < 4)
                ExibirMensagemErro("O nome deve ter pelo menos 4 caracteres.");
            else if (txtBoxUsuario.Text.Length < 4)
                ExibirMensagemErro("O usuário deve ter pelo menos 4 caracteres.");
            else if (txtBoxSenha.Text.Length < 6)
                ExibirMensagemErro("A senha deve ter pelo menos 6 caracteres.");
            else if (txtBoxSenha.Text != txtBoxSenhaNovamente.Text)
                ExibirMensagemErro("As senhas não coincidem.");
            else
                CadastrarUsuario();
        }

        private UsuarioClientModel PopularClasseUsuario()
        {
            return new UsuarioClientModel
            {
                Nome = txtBoxNome.Text,
                Usuario = txtBoxUsuario.Text,
                Senha = hash.GerarHash(txtBoxSenha.Text)
            };
        }

        private void CadastrarUsuario()
        {
            var usuarioClientModel = PopularClasseUsuario();

            if (_usuarioClientService.Cadastrar(usuarioClientModel))
                AbrirFormsPrincipal();
            else
                ExibirMensagemErro("Usuário já existe.");
        }

        public void ObterIdDoUsuario()
        {
            LembrarDeMim.IdUsuario(_usuarioClientService.ObterIdDoUsuario(txtBoxUsuario.Text, hash.GerarHash(txtBoxSenha.Text)));
        }

        private void AbrirFormsPrincipal()
        {
            ObterIdDoUsuario();
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }
        #endregion
    }
}
