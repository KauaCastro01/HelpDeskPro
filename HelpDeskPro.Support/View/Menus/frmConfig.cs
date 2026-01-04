
using HelpDeskPro.Support.Data;
using HelpDeskPro.Support.Utility;

namespace HelpDeskPro
{
    public partial class frmConfig : Form
    {
        private readonly AppDbContext _db;
        public frmConfig(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            frmMudarSenha frmMudarSenha = new frmMudarSenha(_db);
            frmMudarSenha.Show();
            this.Close();
        }

        private void btnTrocarConta_Click(object sender, EventArgs e)
        {
            Sessao.TrocarConta = true;
            Form1 form1 = new Form1(_db);
            form1.Show();
            this.Close();
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            frmAvaliacao frmAvaliacao = new frmAvaliacao(_db);
            frmAvaliacao.Show();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenu = new frmMenuPrincipal(_db);
            frmMenu.Show();
            this.Close();
        }
    }
}
