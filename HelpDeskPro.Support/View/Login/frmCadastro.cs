using HelpDeskPro.Support.Data;
using HelpDeskPro.Support.Models;
using HelpDeskPro.Support.Services;
using HelpDeskPro.Support.Utility;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelpDeskPro
{
    public partial class frmCadastro : Form
    {
        HashSenha hash = new HashSenha();
        private readonly AppDbContext _db;
        private readonly UsuarioAdminService _usuarioAdminService;
        private LembrarDeMim LembrarDeMim = new LembrarDeMim();

        #region Eventos
        public frmCadastro(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _usuarioAdminService = new UsuarioAdminService(_db);
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
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ValidaCampos();
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

        private UsuarioAdminModel PopularClasseUsuario()
        {
            return new UsuarioAdminModel
            {
                Nome = txtBoxNome.Text,
                Usuario = txtBoxUsuario.Text,
                Senha = hash.GerarHash(txtBoxSenha.Text)
            };
        }

        private void CadastrarUsuario()
        {
            var usuarioAdminModel = PopularClasseUsuario();

            if (_usuarioAdminService.Cadastrar(usuarioAdminModel))
                AbriForms();
            else
                ExibirMensagemErro("Usuário já existe.");
        }

        private void AbriForms()
        {
            ObterIdDoUsuario();
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }

        public void ObterIdDoUsuario()
        {
            LembrarDeMim.IdUsuario(_usuarioAdminService.ObterIdDoUsuario(txtBoxUsuario.Text, hash.GerarHash(txtBoxSenha.Text)));
        }
        #endregion
    }
}
