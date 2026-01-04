using HelpDeskPro.OpenCall.Data;
using HelpDeskPro.OpenCall.Utility;
using HelpDeskPro.OpenCall.View.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDeskPro.OpenCall.View.Menus
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
            frmAlterarSenha frmAlterarSenha = new frmAlterarSenha(_db);
            frmAlterarSenha.Show();
            this.Close();
        }

        private void btnTrocarConta_Click(object sender, EventArgs e)
        {
            Sessao.TrocarConta = true;
            Form1 frmLogin = new Form1(_db);
            frmLogin.Show();
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
