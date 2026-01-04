namespace HelpDeskPro.Support.Utility
{
    public class LembrarDeMim
    {
        public void Salvar(string usuario, string senha, bool lembrar)
        {
            Properties.Settings.Default.Usuario = usuario;
            Properties.Settings.Default.Senha = senha;
            Properties.Settings.Default.LembrarDeMim = true;
            Properties.Settings.Default.Save();
        }

        public void Apagar()
        {
            Properties.Settings.Default.Usuario = string.Empty;
            Properties.Settings.Default.Senha = string.Empty;
            Properties.Settings.Default.LembrarDeMim = false;
            Properties.Settings.Default.Save();
        }

        public (string Usuario, string senha, bool Lembrar) Carregar()
        {
            if (Properties.Settings.Default.LembrarDeMim)
            {
                return (Properties.Settings.Default.Usuario,
                        Properties.Settings.Default.Senha,
                        Properties.Settings.Default.LembrarDeMim);
            }
            return ("", "", false);
        }

        public void IdUsuario(int idUsuario)
        {
            Properties.Settings.Default.ID = idUsuario;         
        }
    }
}
