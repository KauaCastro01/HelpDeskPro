using HelpDeskPro.Support.Data;

namespace HelpDeskPro.Support.Services
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

        public string RetornarNomeCliente(string id)
        {
            try
            {
                if (int.TryParse(id, out int ID))
                {
                    var usuarioClient = _db.UsuarioClient.FirstOrDefault(u => u.Id == ID);

                    if (usuarioClient == null)
                        return "";

                    return usuarioClient.Nome;
                }

                return "";
            }
            catch (Exception ex)
            {
                MensagemErro(ex.Message);
                return "";
            }   
        }
    }
}
