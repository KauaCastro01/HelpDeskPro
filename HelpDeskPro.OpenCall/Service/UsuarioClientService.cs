using HelpDeskPro.OpenCall.Data;
using HelpDeskPro.OpenCall.Model;

namespace HelpDeskPro.OpenCall.Service
{
    public class UsuarioClientService
    {
        private readonly AppDbContext _db;
        public UsuarioClientService(AppDbContext db)
        {
            _db = db;
        }

        private void MensagemErro(string erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool Login(string usuario, string senha)
        {
            try
            {
                return _db.UsuarioClient.Any(u => u.Usuario == usuario && u.Senha == senha);
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return false;
            }
        }

        public int ObterIdDoUsuario(string usuario, string senha)
        {
            try
            {
                UsuarioClientModel usuarioClient = _db.UsuarioClient.FirstOrDefault(u => u.Usuario == usuario && u.Senha == senha);
                return usuarioClient != null ? usuarioClient.Id : 0;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return 0;
            }
        }

        public bool Cadastrar(UsuarioClientModel usuarioClientModel)
        {
            try
            {
                if (usuarioClientModel == null)
                    return false;

                if (_db.UsuarioClient.Any(u => u.Nome == usuarioClientModel.Nome))
                    return false;

                _db.UsuarioClient.Add(usuarioClientModel);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return false;
            }
        }

        public bool AlterarSenha(int id, string novaSenha)
        {
            try
            {
                UsuarioClientModel usuarioClient = _db.UsuarioClient.FirstOrDefault(u => u.Id == id);
                if (usuarioClient == null)
                    return false;

                usuarioClient.Senha = novaSenha;
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return false;
            }
        }

        public string RetornarSenhaDoUsuario(int id)
        {
            try
            {
                var usuarioAdmin = _db.UsuarioClient.FirstOrDefault(u => u.Id == id);
                return usuarioAdmin.Senha;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return "";
            }
        }
    }
}
