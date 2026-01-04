using HelpDeskPro.OpenCall.Data;
using HelpDeskPro.OpenCall.Model;
using HelpDeskPro.OpenCall.Relatorio.HelpDeskPro.Relatorios;
using HelpDeskPro.OpenCall.Service;
using HelpDeskPro.OpenCall.View.Menus;


namespace HelpDeskPro.OpenCall.View.Chamado
{
    public partial class frmDetalhes : Form
    {
        private readonly AppDbContext _db;
        private readonly ChamadoModel _chamadoModel;


        public frmDetalhes(AppDbContext db, ChamadoModel chamadoModel = null)
        {
            InitializeComponent();
            _db = db;
            _chamadoModel = chamadoModel;
            PopularCampos();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioDetalhe rel = new RelatorioDetalhe();
            rel.GerarPDF(
                txtTitulo.Text,
                txtDescricao.Text,
                txtDataAbertura.Text,
                txtDataResolvido.Text,
                txtStatus.Text
            );
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal(_db);
            menuPrincipal.Show();
            this.Close();
        }

        private void PopularCampos()
        {
            txtTitulo.Text = _chamadoModel.Titulo;
            txtDescricao.Text = _chamadoModel.Descricao;
            txtDataAbertura.Text = _chamadoModel.DataAbertura.ToString("dd/MM/yyyy HH:mm");
            txtDataResolvido.Text = _chamadoModel.DataFechamento?.ToString("dd/MM/yyyy HH:mm") ?? "Em aberto";
            txtStatus.Text = _chamadoModel.Status;
        }

    }
}
