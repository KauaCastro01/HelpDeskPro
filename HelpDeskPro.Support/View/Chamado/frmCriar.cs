using HelpDeskPro.Support.Data;
using HelpDeskPro.Support.Models;
using HelpDeskPro.Support.Properties;
using HelpDeskPro.Support.Services;
using System.Security.Cryptography;


namespace HelpDeskPro
{
    public partial class frmCriar : Form
    {
        private readonly AppDbContext _db;
        private readonly ChamadoModel _chamadoModel;
        private readonly ChamadoService _chamadoService;
        private readonly UsuarioAdminService _usuarioAdminService;
        private string caminho = string.Empty;

        #region Eventos
        public frmCriar(AppDbContext db = null, ChamadoModel chamadoModel = null)
        {
            InitializeComponent();
            _db = db;
            _chamadoModel = chamadoModel;
            _chamadoService = new ChamadoService(_db);
            _usuarioAdminService = new UsuarioAdminService(_db);
            PopularValores(_chamadoModel);
            PopularComboResponsavel();
            SelecionarAdminResponsavel();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ValidaCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (_chamadoModel != null)
                AbrirFormsEditar();
            else
                AbrirFormsMenuPrincipal();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            _chamadoService.FinalizarChamado(_chamadoModel.Id);
            BtnConcluirEnabled(_chamadoModel);
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            OFD.Filter = "Imagens (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string caminho = OFD.FileName;
            }
        }

        #endregion

        #region Metodos
        private void PopularValores(ChamadoModel chamadoModel)
        {
            if (chamadoModel != null)
            {
                txtTitulo.Text = chamadoModel.Titulo;
                txtDescricao.Text = chamadoModel.Descricao;
                cmbStatus.SelectedItem = chamadoModel.Status;
                cmbPrioridade.SelectedItem = chamadoModel.Prioridade;
                btnConcluir.Visible = true;
                BtnConcluirEnabled(chamadoModel);
            }
            else
            {
                cmbStatus.SelectedIndex = 0;
                cmbPrioridade.SelectedIndex = 1;
                btnConcluir.Visible = false;
            }
        }

        private void BtnConcluirEnabled(ChamadoModel chamadoModel)
        {
            if (chamadoModel.DataFechamento != null)
                btnConcluir.Enabled = false;
            else
                btnConcluir.Enabled = true;
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


        private void ValidaCampos()
        {
            if (string.IsNullOrEmpty(txtTitulo.Text))
                ExibirMensagemErro("O título está vazio.");
            else if (string.IsNullOrEmpty(txtDescricao.Text))
                ExibirMensagemErro("A descrição está vazio.");
            else if (cmbStatus.SelectedIndex <= -1)
                ExibirMensagemErro("Selecione o status do chamado.");
            else if (cmbPrioridade.SelectedIndex <= -1)
                ExibirMensagemErro("Selecione a prioridade do chamado.");
            else
            {
                if (_chamadoModel != null)
                    AlterarChamado();
                else
                    CriarChamado();
            }
        }

        private void AbrirFormsMenuPrincipal()
        {
            frmMenuPrincipal frmMenu = new frmMenuPrincipal(_db);
            frmMenu.Show();
            this.Close();
        }

        private void AbrirFormsEditar()
        {
            frmEditar frmEditar = new frmEditar(_db);
            frmEditar.Show();
            this.Close();
        }

        private ChamadoModel PopularClasseChamado()
        {
            return new ChamadoModel()
            {
                Titulo = txtTitulo.Text,
                Descricao = txtDescricao.Text,
                DataAbertura = DateTime.Now,
                Status = cmbStatus.SelectedItem.ToString(),
                Prioridade = cmbPrioridade.SelectedItem.ToString(),
                UsuarioClientId = Settings.Default.ID,
                UsuarioAdminId = Convert.ToInt32(cmbResponsavel.SelectedValue)
            };
        }

        private void CriarChamado()
        {
            ChamadoModel chamadoModel = PopularClasseChamado();

            if (_chamadoService.CriarChamado(chamadoModel))
            {
                ExibirMensagemSucesso("Chamado criado com sucesso!");
                AbrirFormsMenuPrincipal();
            }
            else
                ExibirMensagemErro("Erro ao criar chamado.");
        }

        private void AlterarChamado()
        {
            ChamadoModel chamadoModel = PopularClasseChamado();

            if (_chamadoService.AtualizarChamado(_chamadoModel.Id, chamadoModel))
            {
                ExibirMensagemSucesso("Chamado atualizado com sucesso!");
                AbrirFormsMenuPrincipal();
            }
            else
                ExibirMensagemErro("Erro ao atualizar chamado.");
        }

        private void LimparCampos()
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            txtTitulo.Focus();
            cmbStatus.SelectedIndex = 0;
        }

        private void PopularComboResponsavel()
        {
            var lista = _usuarioAdminService.RetornarTodosOsAdmin();

            cmbResponsavel.DataSource = lista;
            cmbResponsavel.DisplayMember = "Nome";
            cmbResponsavel.ValueMember = "Id";
        }

        private void SelecionarAdminResponsavel()
        {
            if (_chamadoModel == null)
                cmbResponsavel.SelectedValue = Settings.Default.ID;
            else
                cmbResponsavel.SelectedValue = _chamadoModel.UsuarioAdminId;

        }



        #endregion
    }
}
