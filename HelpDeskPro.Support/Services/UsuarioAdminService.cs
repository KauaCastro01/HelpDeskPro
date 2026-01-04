using HelpDeskPro.Support.Data;
using HelpDeskPro.Support.Model;
using HelpDeskPro.Support.Models;

namespace HelpDeskPro.Support.Services
{
    public class UsuarioAdminService
    {
        private readonly AppDbContext _db;
        public UsuarioAdminService(AppDbContext db)
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
                return _db.UsuarioAdmin.Any(u => u.Usuario == usuario && u.Senha == senha);
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
                UsuarioAdminModel usuarioAdmin = _db.UsuarioAdmin.FirstOrDefault(u => u.Usuario == usuario && u.Senha == senha);
                return usuarioAdmin != null ? usuarioAdmin.Id : 0;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return 0;
            }
        }

        public bool Cadastrar(UsuarioAdminModel usuarioAdminModel)
        {
            try
            {
                if (usuarioAdminModel == null)
                    return false;

                if (_db.UsuarioAdmin.Any(u => u.Nome == usuarioAdminModel.Nome))
                    return false;

                _db.UsuarioAdmin.Add(usuarioAdminModel);
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
                UsuarioAdminModel usuarioAdmin = _db.UsuarioAdmin.FirstOrDefault(u => u.Id == id);
                if (usuarioAdmin == null)
                    return false;

                usuarioAdmin.Senha = novaSenha;
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
                var usuarioAdmin = _db.UsuarioAdmin.FirstOrDefault(u => u.Id == id);
                return usuarioAdmin.Senha;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return "";
            }
        }

        public string RetornarNomeAdmin(int id)
        {
            try
            {
                    var usuarioAdmin = _db.UsuarioAdmin.FirstOrDefault(u => u.Id == id);

                    if (usuarioAdmin == null)
                        return "";

                    return usuarioAdmin.Nome;
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return "";
            }
        }

        public List<UsuarioAdminModel> RetornarTodosOsAdmin()
        {
            try
            {
                return _db.UsuarioAdmin.ToList();
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return null;
            }
        }



    }
}
