using HelpDeskPro.OpenCall.Data;
using HelpDeskPro.OpenCall.Model;
using HelpDeskPro.OpenCall.Properties;

namespace HelpDeskPro.OpenCall.Service
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

        public List<ChamadoModel> ObterTodosChamados(int id)
        {
            try
            {
                return _db.Chamado.Where(c => c.UsuarioClientId == id).OrderByDescending(c => c.DataAbertura).ToList();
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return new List<ChamadoModel>();
            }
        }

        public List<ChamadoModel> ObterTodosChamadosPorPesquisa(string pesquisa, int id)
        {
            try
            {
                return _db.Chamado.Where(c => c.Titulo.Contains(pesquisa) && c.Id == id).OrderByDescending(c => c.DataAbertura).ToList();
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

    }
}
