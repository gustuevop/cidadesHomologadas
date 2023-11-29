using System;
using System.Configuration;
using System.Drawing;

namespace verificadorDeCidadesHomologadas.Uteis
{
    public static class ConfigManager
    {
        public static string BuscarToken()
        {
            var config = ConfigurationManager.AppSettings;
            return config.Get("x-api-chave");
        }
        public static void AdicionaOuAlteraToken(string token)
        {
            try
            {
                var manager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var config = manager.AppSettings.Settings;
                if (config["x-api-chave"] == null)
                {
                    config.Add("x-api-chave", token);
                }
                else
                {
                    config["x-api-chave"].Value = token;
                }
                manager.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(manager.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Erro ao salvar configurações");
            }
        }
    }
}