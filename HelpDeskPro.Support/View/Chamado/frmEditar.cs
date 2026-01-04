
using HelpDeskPro.Support.Data;
using HelpDeskPro.Support.Models;
using HelpDeskPro.Support.Properties;
using HelpDeskPro.Support.Relatorio;
using HelpDeskPro.Support.Services;
using HelpDeskPro.Support.View.Chamado;

namespace HelpDeskPro
{
    public partial class frmEditar : Form
    {
        private readonly AppDbContext _db;
        private readonly ChamadoService _chamadoService;
        private readonly UsuarioAdminService _usuarioAdminService;

        #region Eventos
        public frmEditar(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            _chamadoService = new ChamadoService(_db);
            _usuarioAdminService = new UsuarioAdminService(_db);
            PopularComboResponsavel();
            PopularDGV();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ValidarExclusao();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            ValidarSelecao();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (cmbResponsavel.SelectedIndex == 0)
                dgv.DataSource = _chamadoService.ObterTodosChamadosPorPesquisa(txtPesquisar.Text);
            else if (cmbResponsavel.SelectedIndex == 1)
                dgv.DataSource = _chamadoService.ObterTodosChamadosPorPesquisaID(txtPesquisar.Text, Settings.Default.ID);
            ColunasDGV();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ChamadoModel chamado = (ChamadoModel)dgv.SelectedRows[0].DataBoundItem;
                frmDetalhes frmDetalhes = new frmDetalhes(_db, chamado);
                frmDetalhes.Show();
                this.Close();
            }
            else
                ExibirMensagemErro("Selecione uma linha!");
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioTotal rel = new RelatorioTotal();
            rel.GerarPDF(dgv);
        }

        private void cmbResponsavel_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopularDGV();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ValidarSelecao();
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

        public void PopularDGV()
        {
            try
            {
                if (cmbResponsavel.SelectedIndex == 0)
                    dgv.DataSource = _chamadoService.ObterTodosChamados();
                else if (cmbResponsavel.SelectedIndex == 1)
                    dgv.DataSource = _chamadoService.ObterTodosChamadosID(Settings.Default.ID);

                ColunasDGV();
            }
            catch (Exception ex)
            {
                ExibirMensagemErro("Erro ao carregar chamados: " + ex.Message);
            }
        }

        public void ColunasDGV()
        {
            dgv.Columns["Titulo"].HeaderText = "Título";
            dgv.Columns["Descricao"].HeaderText = "Descrição";
            dgv.Columns["Status"].HeaderText = "Status";
            dgv.Columns["DataAbertura"].HeaderText = "Abertura";
            dgv.Columns["DataFechamento"].HeaderText = "Fechamento";
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["Prioridade"].HeaderText = "Prioridade";
            dgv.Columns["UsuarioAdminId"].Visible = false;
            dgv.Columns["UsuarioClientId"].Visible = false;
        }

        private void ValidarSelecao()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ChamadoModel chamado = (ChamadoModel)dgv.SelectedRows[0].DataBoundItem;
                frmCriar frmCriar = new frmCriar(_db, chamado);
                frmCriar.Show();
                this.Close();
            }
            else
                ExibirMensagemErro("Selecione uma linha!");
        }

        private void ValidarExclusao()
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
                    var confirm = MessageBox.Show("Deseja realmente excluir o chamado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                        _chamadoService.ExcluirChamado(id);
                }
                else
                    ExibirMensagemErro("Selecione uma linha!");

                PopularDGV();

            }
            catch (Exception ex)
            {
                ExibirMensagemErro("Erro ao excluir chamado: " + ex.Message);
            }
        }

        private void PopularComboResponsavel()
        {
            cmbResponsavel.Items.Clear();
            cmbResponsavel.Items.Add("Todos");
            cmbResponsavel.Items.Add(_usuarioAdminService.RetornarNomeAdmin(Settings.Default.ID));
            cmbResponsavel.SelectedIndex = 1;
        }

        #endregion
    }
}
