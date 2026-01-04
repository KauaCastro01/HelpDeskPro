using HelpDeskPro.OpenCall.Data;
using HelpDeskPro.OpenCall.View.Menus;

namespace HelpDeskPro.OpenCall.View.Utils
{
    public partial class frmAvaliacao : Form
    {
        private readonly AppDbContext _db;
        #region Eventos
        public frmAvaliacao(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Verificacao();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtNota.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AbrirForms();
        }

        #endregion

        #region Metodos
        public void AbrirForms()
        {
            frmConfig frmConfig = new frmConfig(_db);
            frmConfig.Show();
            this.Close();
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

        public void Verificacao()
        {
            if (int.TryParse(txtNota.Text, out int nota))
            {
                if (nota >= 0 && nota <= 5)
                {
                    ExibirMensagemSucesso("Avaliação salva com sucesso!");
                    AbrirForms();
                }
                else
                    ExibirMensagemErro("Por favor, insira uma nota entre 0 e 5.");
            }
            else
                ExibirMensagemErro("Por favor, insira uma nota entre 0 e 5.");
        }

        #endregion

        private void txtNota_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
