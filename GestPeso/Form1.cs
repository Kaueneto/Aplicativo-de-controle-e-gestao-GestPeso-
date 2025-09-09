using Supabase;
using Supabase.Postgrest;
using Supabase.Postgrest.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;
using Supabase.Postgrest.Attributes;

namespace GestPeso
{
    public partial class LoginPage : Form
    {

        private Supabase.Client client;

        public LoginPage()
        {
            
            InitializeComponent();

            // Evento do bot�o
            btentrar.Click += async (s, e) => await LoginAsync();
        }

        private async Task LoginAsync()
        {
            try
            {
                // Carrega o .env
                Env.Load(@"C:\dev\GestPeso\GestPeso\.env");

                string url = Environment.GetEnvironmentVariable("SUPABASE_URL");
                string key = Environment.GetEnvironmentVariable("SUPABASE_KEY");

                if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Vari�veis de ambiente SUPABASE_URL ou SUPABASE_KEY n�o definidas.");
                    return;
                }

                // Cria o client e inicializa
                client = new Supabase.Client(url, key);
                await client.InitializeAsync();

                string codigoUsuario = txtuser.Text.Trim();
                string senhaDigitada = txtsenha.Text;

                if (string.IsNullOrEmpty(codigoUsuario) || string.IsNullOrEmpty(senhaDigitada))
                {
                    MessageBox.Show("Preencha usu�rio e senha.");
                    return;
                }

                // Busca o usu�rio na tabela 'usuarios'
                var usuarios = await client
                    .From<Usuario>()
                    .Where(u => u.codigo_usuario == codigoUsuario)
                    .Get();

                if (usuarios.Models.Count == 0)
                {
                    MessageBox.Show("Usu�rio n�o encontrado.");
                    return;
                }

                var usuario = usuarios.Models[0];

                // Valida��o simples de senha (texto puro)
                if (usuario.senha_hash == senhaDigitada)
                {
                    MessageBox.Show($"Login realizado! Bem-vindo(a) {usuario.nome}");
                }
                else
                {
                    MessageBox.Show("Senha incorreta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar Supabase: " + ex.Message);
            }
        }
    }

  
}
