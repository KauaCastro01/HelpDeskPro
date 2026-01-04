using HelpDeskPro.Support.Model;
using HelpDeskPro.Support.Data;
using HelpDeskPro.Support.Models;
using HelpDeskPro.Support.Properties;

namespace HelpDeskPro.Support.Services
{
    public class ChamadoService
    {
        private readonly AppDbContext _db;
        public ChamadoService(AppDbContext db)
        {
            _db = db;
        }

        private void MensagemErro(string erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public ChamadoTotalModel RetornoParaErro()
        {
            return new ChamadoTotalModel()
            {
                TotalChamados = 0,
                ChamadosAbertos = 0,
                ChamadosEmAndamento = 0,
                ChamadosFechados = 0
            };
        }

        public ChamadoTotalModel RetonarTodosChamados()
        {
            try
            {
                return new ChamadoTotalModel()
                {
                    TotalChamados = _db.Chamado.Count(),
                    ChamadosAbertos = _db.Chamado.Where(c => c.Status == "Aberto").Count(),
                    ChamadosEmAndamento = _db.Chamado.Where(c => c.Status == "Em Andamento").Count(),
                    ChamadosFechados = _db.Chamado.Where(c => c.Status == "Resolvido").Count()
                };
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return RetornoParaErro();
            }
        }

        public ChamadoTotalModel RetonarChamadosDiario()
        {
            try
            {
                var hoje = DateTime.Today;
                return new ChamadoTotalModel()
                {
                    TotalChamados = _db.Chamado.Where(c => c.DataAbertura.Date == hoje).Count(),
                    ChamadosAbertos = _db.Chamado.Where(c => c.Status == "Aberto" && c.DataAbertura.Date == hoje).Count(),
                    ChamadosEmAndamento = _db.Chamado.Where(c => c.Status == "Em Andamento" && c.DataAbertura.Date == hoje).Count(),
                    ChamadosFechados = _db.Chamado.Where(c => c.Status == "Resolvido" && c.DataAbertura.Date == hoje).Count()
                };
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return RetornoParaErro();
            }
        }

        public ChamadoTotalModel RetonarChamadosSemanal()
        {
            try
            {
                DateTime dataInicial = DateTime.Today.AddDays(-7);

                return new ChamadoTotalModel
                {
                    TotalChamados = _db.Chamado
                        .Count(c => c.DataAbertura >= dataInicial),

                    ChamadosAbertos = _db.Chamado
                        .Count(c => c.Status == "Aberto" && c.DataAbertura >= dataInicial),

                    ChamadosEmAndamento = _db.Chamado
                        .Count(c => c.Status == "Em Andamento" && c.DataAbertura >= dataInicial),

                    ChamadosFechados = _db.Chamado
                        .Count(c => c.Status == "Resolvido" && c.DataAbertura >= dataInicial)
                };
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return RetornoParaErro();
            }
        }



        public ChamadoTotalModel RetonarChamadosMensal()
        {
            try
            {
                var mensal = DateTime.Today.AddDays(-30);

                return new ChamadoTotalModel()
                {
                    TotalChamados = _db.Chamado.Count(c => c.DataAbertura >= mensal),
                    ChamadosAbertos = _db.Chamado.Count(c => c.Status == "Aberto" && c.DataAbertura >= mensal),
                    ChamadosEmAndamento = _db.Chamado.Count(c => c.Status == "Em Andamento" && c.DataAbertura >= mensal),
                    ChamadosFechados = _db.Chamado.Count(c => c.Status == "Resolvido" && c.DataAbertura >= mensal)
                };
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return RetornoParaErro();
            }
        }

        public ChamadoTotalModel RetonarTodosChamadosID(int Id)
        {
            try
            {
                return new ChamadoTotalModel()
                {
                    TotalChamados = _db.Chamado.Where(u => u.UsuarioAdminId == Id).Count(),
                    ChamadosAbertos = _db.Chamado.Where(c => c.Status == "Aberto" && c.UsuarioAdminId == Id).Count(),
                    ChamadosEmAndamento = _db.Chamado.Where(c => c.Status == "Em Andamento" && c.UsuarioAdminId == Id).Count(),
                    ChamadosFechados = _db.Chamado.Where(c => c.Status == "Resolvido" && c.UsuarioAdminId == Id).Count()
                };
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return RetornoParaErro();
            }
        }

        public ChamadoTotalModel RetonarChamadosDiarioID(int Id)
        {
            try
            {
                var hoje = DateTime.Today;
                return new ChamadoTotalModel()
                {
                    TotalChamados = _db.Chamado.Where(c => c.DataAbertura.Date == hoje && c.UsuarioAdminId == Id).Count(),
                    ChamadosAbertos = _db.Chamado.Where(c => c.Status == "Aberto" && c.DataAbertura.Date == hoje && c.UsuarioAdminId == Id).Count(),
                    ChamadosEmAndamento = _db.Chamado.Where(c => c.Status == "Em Andamento" && c.DataAbertura.Date == hoje && c.UsuarioAdminId == Id).Count(),
                    ChamadosFechados = _db.Chamado.Where(c => c.Status == "Resolvido" && c.DataAbertura.Date == hoje && c.UsuarioAdminId == Id).Count()
                };
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return RetornoParaErro();
            }
        }

        public ChamadoTotalModel RetornarChamadosSemanalID(int Id)
        {
            try
            {
                DateTime dataInicial = DateTime.Today.AddDays(-7);

                return new ChamadoTotalModel
                {
                    TotalChamados = _db.Chamado.Where(c=> c.UsuarioAdminId == Id).Count(c => c.DataAbertura >= dataInicial),
                    ChamadosAbertos = _db.Chamado.Where(c => c.UsuarioAdminId == Id).Count(c => c.Status == "Aberto" && c.DataAbertura >= dataInicial),
                    ChamadosEmAndamento = _db.Chamado.Where(c => c.UsuarioAdminId == Id).Count(c => c.Status == "Em Andamento" && c.DataAbertura >= dataInicial),
                    ChamadosFechados = _db.Chamado.Where(c => c.UsuarioAdminId == Id).Count(c => c.Status == "Resolvido" && c.DataAbertura >= dataInicial)
                };
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return RetornoParaErro();
            }
        }

        public ChamadoTotalModel RetonarChamadosMensalID(int Id)
        {
            try
            {
                var mensal = DateTime.Today.AddDays(-30);

                return new ChamadoTotalModel()
                {
                    TotalChamados = _db.Chamado.Where(c => c.UsuarioAdminId == Id).Count(c => c.DataAbertura >= mensal),
                    ChamadosAbertos = _db.Chamado.Where(c => c.UsuarioAdminId == Id).Count(c => c.Status == "Aberto" && c.DataAbertura >= mensal),
                    ChamadosEmAndamento = _db.Chamado.Where(c => c.UsuarioAdminId == Id).Count(c => c.Status == "Em Andamento" && c.DataAbertura >= mensal),
                    ChamadosFechados = _db.Chamado.Where(c => c.UsuarioAdminId == Id).Count(c => c.Status == "Resolvido" && c.DataAbertura >= mensal)
                };
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return RetornoParaErro();
            }
        }


        public bool CriarChamado(ChamadoModel chamadoModel)
        {
            try
            {
                if (chamadoModel == null)
                    return false;

                _db.Chamado.Add(chamadoModel);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return false;
            }
        }

        public List<ChamadoModel> ObterTodosChamados()
        {
            try
            {
                return _db.Chamado.ToList();
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return new List<ChamadoModel>();
            }
        }

        public List<ChamadoModel> ObterTodosChamadosPorPesquisa(string pesquisa)
        {
            try
            {
                return _db.Chamado.Where(c => c.Titulo.Contains(pesquisa)).OrderByDescending(c => c.DataAbertura).ToList();
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return new List<ChamadoModel>();
            }
        }

        public List<ChamadoModel> ObterTodosChamadosID(int Id)
        {
            try
            {
                return _db.Chamado.Where(u => u.UsuarioAdminId == Id).OrderByDescending(c => c.DataAbertura).ToList();
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return new List<ChamadoModel>();
            }
        }

        public List<ChamadoModel> ObterTodosChamadosPorPesquisaID(string pesquisa, int Id)
        {
            try
            {
                return _db.Chamado.Where(c => c.Titulo.Contains(pesquisa) && c.UsuarioAdminId == Id).OrderByDescending(c => c.DataAbertura).ToList();
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return new List<ChamadoModel>();
            }
        }

        public bool ExcluirChamado(int id)
        {
            try
            {
                ChamadoModel chamado = _db.Chamado.FirstOrDefault(c => c.Id == id);
                if (chamado == null)
                    return false;

                _db.Chamado.Remove(chamado);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return false;
            }
        }

        public bool AtualizarChamado(int Id, ChamadoModel chamadoModelNovo)
        {
            try
            {
                ChamadoModel chamadoExistente = _db.Chamado.FirstOrDefault(c => c.Id == Id);
                if (chamadoExistente == null)
                    return false;

                chamadoExistente.Titulo = chamadoModelNovo.Titulo;
                chamadoExistente.Descricao = chamadoModelNovo.Descricao;
                chamadoExistente.Status = chamadoModelNovo.Status;
                chamadoExistente.Prioridade = chamadoModelNovo.Prioridade;
                chamadoExistente.UsuarioAdminId = chamadoModelNovo.UsuarioAdminId;
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return false;
            }
        }

        public void FinalizarChamado(int chamadoID)
        {
            try
            {
                ChamadoModel chamadoExistente = _db.Chamado.FirstOrDefault(c => c.Id == chamadoID);
                if (chamadoExistente == null)
                    return;

                chamadoExistente.DataFechamento = DateTime.Now;
                chamadoExistente.UsuarioAdminId = Settings.Default.ID;
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
            }
        }

    }
}
