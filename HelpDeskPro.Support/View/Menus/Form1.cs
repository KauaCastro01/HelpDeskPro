using HelpDeskPro.Support.Data;

namespace HelpDeskPro
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _db;

        #region Eventos
        public Form1(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin(_db);
            frmlogin.Show();
            this.Hide();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro(_db);
            frmCadastro.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        #endregion
    }
}
