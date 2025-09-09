using Npgsql;
using DotNetEnv;
using System;
using System.Windows.Forms;

namespace GestPeso
{
    public static class Db
    {
        public static NpgsqlConnection Conexao { get; private set; }

        /// <summary>Cria a connection string a partir do .env</summary>
        private static string BuildConnStr()
        {
            // Carrega o .env
            Env.Load(@"C:\dev\GestPeso\GestPeso\.env");

            string host = Environment.GetEnvironmentVariable("DB_HOST");
            string port = Environment.GetEnvironmentVariable("DB_PORT") ?? "5432";
            string db = Environment.GetEnvironmentVariable("DB_NAME");
            string user = Environment.GetEnvironmentVariable("DB_USER");
            string password = Environment.GetEnvironmentVariable("DB_PASS");

            if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(db) ||
                string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Alguma variável de ambiente do banco não foi definida.");
            }

            // Monta a connection string com SSL
            string connStr = $"Host={host};Port={port};Database={db};Username={user};Password={password};SSL Mode=Require;Trust Server Certificate=true;";

            // Mostra no MessageBox para conferir
            MessageBox.Show("Connection String:\n" + connStr);

            return connStr;
        }

        /// <summary>Abre a conexão se não estiver aberta</summary>
        public static void Abrir()
        {
            if (Conexao == null || Conexao.State != System.Data.ConnectionState.Open)
            {
                Conexao = new NpgsqlConnection(BuildConnStr());
                Conexao.Open();
                MessageBox.Show("Conexão aberta com sucesso!");
            }
        }

        /// <summary>Fecha a conexão se estiver aberta</summary>
        public static void Fechar()
        {
            if (Conexao != null && Conexao.State != System.Data.ConnectionState.Closed)
            {
                Conexao.Close();
                Conexao.Dispose();
                MessageBox.Show("Conexão fechada.");
            }
        }
    }
}
