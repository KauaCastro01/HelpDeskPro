using HelpDeskPro.Support.Data;
using HelpDeskPro.Support.Models;
using HelpDeskPro.Support.Relatorio.HelpDeskPro.Relatorios;
using HelpDeskPro.Support.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDeskPro.Support.View.Chamado
{
    public partial class frmDetalhes : Form
    {
        private readonly AppDbContext _db;
        private readonly ChamadoService _chamadoService;
        private readonly ChamadoModel _chamadoModel;
        private readonly UsuarioAdminService _usuarioAdminService;
        private readonly UsuarioClientService _usuarioClientService;

        public frmDetalhes(AppDbContext db, ChamadoModel chamadoModel = null)
        {
            InitializeComponent();
            _db = db;
            _chamadoService = new ChamadoService(_db);
            _chamadoModel = chamadoModel;
            _usuarioAdminService = new UsuarioAdminService(_db);
            _usuarioClientService = new UsuarioClientService(_db);
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
                txtCliente.Text,
                txtAdmin.Text,
                txtStatus.Text,
                txtPriporidade.Text
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
            txtPriporidade.Text = _chamadoModel.Prioridade ?? "Não definida";
            txtAdmin.Text = _usuarioAdminService.RetornarNomeAdmin(int.Parse(_chamadoModel.UsuarioAdminId.ToString()));
            txtCliente.Text = _usuarioClientService.RetornarNomeCliente(_chamadoModel.UsuarioClientId.ToString());
        }

    }
}
