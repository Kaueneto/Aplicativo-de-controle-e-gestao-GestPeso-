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

            // Evento do botão
            btentrar.Click += async (s, e) => await LoginAsync();
        }

        private async Task LoginAsync()
        {
            try
            {
                progressBarLogin.Visible = true;
                progressBarLogin.Value = 0;

                // Simula progresso inicial
                progressBarLogin.Value = 30;

                // Carrega o .env
                Env.Load(@"C:\dev\GestPeso\GestPeso\.env");

                string url = Environment.GetEnvironmentVariable("SUPABASE_URL");
                string key = Environment.GetEnvironmentVariable("SUPABASE_KEY");

                if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Variáveis de ambiente SUPABASE_URL ou SUPABASE_KEY não definidas.");
                    return;
                }

                // Cria o client e inicializa
                client = new Supabase.Client(url, key);
                await client.InitializeAsync();

                string codigoUsuario = txtuser.Text.Trim();
                string senhaDigitada = txtsenha.Text;

                if (string.IsNullOrEmpty(codigoUsuario) || string.IsNullOrEmpty(senhaDigitada))
                {
                    MessageBox.Show("Preencha usuário e senha.");
                    return;
                }

                // Busca o usuário na tabela 'usuarios'
                var usuarios = await client
                    .From<Usuario>()
                    .Where(u => u.codigo_usuario == codigoUsuario)
                    .Get();
                progressBarLogin.Value = 80;

                if (usuarios.Models.Count == 0)
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }

                var usuario = usuarios.Models[0];

                // Validação simples de senha (texto puro)
                if (usuario.senha_hash == senhaDigitada)
                {
                    progressBarLogin.Value = 100;
                    progressBarLogin.Visible = false;
                    MessageBox.Show($"Login realizado! Bem-vindo(a) {usuario.nome}");
                    var menuForm = new menu();
                    menuForm.Show();
                }
                else
                {
                    progressBarLogin.Value = 1;
                    progressBarLogin.Visible = false;
                    MessageBox.Show("Senha incorreta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar Supabase: " + ex.Message);
            }
        }

        private void btentrar_Click(object sender, EventArgs e)
        {

        }

        private void btclose_Click(object sender, EventArgs e)
        {

        }
    }


}
