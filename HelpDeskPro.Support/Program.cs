using HelpDeskPro.Support.Data;

namespace HelpDeskPro.SupportAdmin
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SQLitePCL.Batteries.Init();
            ApplicationConfiguration.Initialize();

            string dbPath = Conexao.GetDatabasePath();
            var db = new AppDbContext(dbPath);

            Application.Run(new Form1(db));
        }
    }
}