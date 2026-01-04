using HelpDeskPro.OpenCall.Data;
using HelpDeskPro.OpenCall.Utility;
using HelpDeskPro.OpenCall.View.Chamado;

namespace HelpDeskPro.OpenCall.View.Menus
{
    public partial class frmMenuPrincipal : Form
    {
        private readonly AppDbContext _db;
        public frmMenuPrincipal(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            Sessao.TrocarConta = false;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            frmCriar frmCriar = new frmCriar(_db);
            frmCriar.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmExibir frmExibir = new frmExibir(_db);
            frmExibir.Show();
            this.Close();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Breve", "Proxima Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
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

    }
}
