using HelpDeskPro.Support.Data;
using HelpDeskPro.Support.Services;
using HelpDeskPro.Support.Utility;
using HelpDeskPro.Support.Properties;

namespace HelpDeskPro
{
    public partial class frmMudarSenha : Form
    {
        HashSenha hashSenha = new HashSenha();        
        private readonly AppDbContext _db;
        private readonly UsuarioAdminService _usuarioAdminService;

        #region Eventos
        public frmMudarSenha(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _usuarioAdminService = new UsuarioAdminService(_db);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig(_db);
            frmConfig.Show();
            this.Close();
        }
        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtBoxSenhaNovamente.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtSenhaAtual.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
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
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ValidarCampos()
        {
            string senhaAtual = _usuarioAdminService.RetornarSenhaDoUsuario(Settings.Default.ID);
            if (txtBoxSenha.Text.Length < 6 || string.IsNullOrEmpty(txtBoxSenha.Text))
                ExibirMensagemErro("A senha deve ter no mínimo 6 caracteres.");
            else if (hashSenha.GerarHash(txtSenhaAtual.Text) != senhaAtual)
                ExibirMensagemErro("Senha atual incorreta!");
            else if (txtBoxSenha.Text != txtBoxSenhaNovamente.Text)
                ExibirMensagemErro("As senhas não coincidem!");
            else if (txtSenhaAtual.Text == txtBoxSenha.Text)
                ExibirMensagemErro("A sua nova senha não pode ser igual, a sua antiga senha!");
            else
                AlterarSenha();
        }

        private void AlterarSenha()
        {
            string novaSenha = hashSenha.GerarHash(txtBoxSenhaNovamente.Text);

            if(_usuarioAdminService.AlterarSenha(Settings.Default.ID, novaSenha))
            {
                ExibirMensagemSucesso("Senha alterada com sucesso!");
                AbrirForms();
            }
            else
                ExibirMensagemErro("Erro ao alterar a senha. Tente novamente.");
        }

        private void AbrirForms()
        {
            frmConfig frmConfig = new frmConfig(_db);
            frmConfig.Show();
            this.Close();
        }
        #endregion
    }
}
