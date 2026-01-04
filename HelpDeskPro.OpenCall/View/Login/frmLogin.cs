using HelpDeskPro.OpenCall.Data;
using HelpDeskPro.OpenCall.View.Menus;
using HelpDeskPro.OpenCall.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelpDeskPro.OpenCall.Service;

namespace HelpDeskPro.OpenCall.View.Login
{
    public partial class frmLogin : Form
    {
        private readonly LembrarDeMim lembrar = new LembrarDeMim();
        private readonly Hash hash = new Hash();
        private readonly AppDbContext _db;
        private UsuarioClientService _usuarioClientService;

        #region Eventos
        public frmLogin(AppDbContext db)
        {
            InitializeComponent();
            CarregarLembrarDeMim();
            _db = db;
            _usuarioClientService = new UsuarioClientService(_db);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(!Sessao.TrocarConta)
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

        private void ExibirMensagemSucesso(string mensagem)
        {
            Notificacao.BalloonTipTitle = "Sucesso";
            Notificacao.BalloonTipText = mensagem;
            Notificacao.BalloonTipIcon = ToolTipIcon.Info;

            Notificacao.ShowBalloonTip(3000);
        }

        private void ValidarLogin()
        {
            if (_usuarioClientService.Login(txtBoxUsuario.Text, hash.GerarHash(txtBoxSenha.Text)))
                AbrirFormsPrincipal();
            else
                ExibirMensagemErro("Usuário ou senha incorretos.");
        }

        private void LoginAutomatico()
        {
            if (_usuarioClientService.Login(txtBoxUsuario.Text, hash.GerarHash(txtBoxSenha.Text)))
                AbrirFormsPrincipal();
        }

        public void ObterIdDoUsuario()
        {
            lembrar.IdUsuario(_usuarioClientService.ObterIdDoUsuario(txtBoxUsuario.Text, hash.GerarHash(txtBoxSenha.Text)));
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
