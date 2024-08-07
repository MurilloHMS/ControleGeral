using System;
using System.Configuration;


namespace KhoraControl.Model.Settings
{
    public class ConfigurationManagerHelper
    {

        // Método para obter o valor de uma configuração específica
        public static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        // Método para definir o valor de uma configuração específica
        public static void SetSetting(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Se a configuração não existir, adiciona-a
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }

            // Salva as mudanças
            config.Save(ConfigurationSaveMode.Modified);

            // Recarrega as configurações para que as mudanças sejam refletidas
            ConfigurationManager.RefreshSection("appSettings");
        }

        // Método para obter a string de conexão para um provider específico
        public static string GetConnectionString(string provider)
        {
            var connectionString = ConfigurationManager.ConnectionStrings[provider + "Connection"];
            return connectionString?.ConnectionString;
        }

        // Método para definir ou atualizar uma string de conexão
        public static void SetConnectionString(string provider, string connectionString)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.ConnectionStrings.ConnectionStrings[provider + "Connection"] == null)
            {
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings
                {
                    Name = provider + "Connection",
                    ConnectionString = connectionString,
                    ProviderName = provider == "SQLite" ? "Microsoft.Data.Sqlite" : "Npgsql"
                });
            }
            else
            {
                config.ConnectionStrings.ConnectionStrings[provider + "Connection"].ConnectionString = connectionString;
            }

            // Salva as mudanças
            config.Save(ConfigurationSaveMode.Modified);

            // Recarrega as configurações para que as mudanças sejam refletidas
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        // Método para definir o provider de banco de dados
        public static void SetDatabaseProvider(string provider)
        {
            SetSetting("DatabaseProvider", provider);
        }
    }
}
