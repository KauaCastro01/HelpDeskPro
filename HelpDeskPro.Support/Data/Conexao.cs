namespace HelpDeskPro.Support.Data
{
    public class Conexao
    {
        public static string GetDatabasePath()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string dataFolder = Path.Combine(basePath, "Data");
            Directory.CreateDirectory(dataFolder);

            string dbPath = Path.Combine(dataFolder, "HelpDeskPro.db");

            string origem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "HelpDeskPro.db");

            if (!File.Exists(dbPath) && File.Exists(origem))
                File.Copy(origem, dbPath);

            return dbPath;
        }
    }
}
