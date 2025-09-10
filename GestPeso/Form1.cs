using Supabase;
using Supabase.Postgrest;
using Supabase.Postgrest.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;
using Supabase.Postgrest.Attributes;
using GestPeso.model;
using BCrypt.Net;


namespace GestPeso
{




    public partial class LoginPage : Form
    {

        public Supabase.Client client;

        public LoginPage()
        {

            InitializeComponent();
            txtsenha.PasswordChar = '●';


            // Inicializa: senha escondida

            picOlhoAberto.Visible = false;
            picOlhoFechado.Visible = true;


            // Evento do botão
            btentrar.Click += async (s, e) => await LoginAsync();
        }

        private async Task LoginAsync()
        {
            //try
            //{
            //    progressBarLogin.Visible = true;
            //    progressBarLogin.Value = 0;
            //    progressBarLogin.Value = 5;

            //    progressBarLogin.Value = 20;
            //    progressBarLogin.Value = 25;

            //    // Simula progresso inicial
            //    progressBarLogin.Value = 30;

            //    // Carrega o .env
                Env.Load(@"C:\dev\PastaGestPeso\GestPeso\.env");

                string url = Environment.GetEnvironmentVariable("SUPABASE_URL");
                string key = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            //    if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(key))
            //    {
            //        MessageBox.Show("Variáveis de ambiente SUPABASE_URL ou SUPABASE_KEY não definidas.");
            //        return;
            //    }

           
               client = new Supabase.Client(url, key);
              await client.InitializeAsync();

            //    string codigoUsuario = txtuser.Text.Trim();
            //    string senhaDigitada = txtsenha.Text;

            //    if (string.IsNullOrEmpty(codigoUsuario) || string.IsNullOrEmpty(senhaDigitada))
            //    {
            //        MessageBox.Show("Preencha usuário e senha.");
            //        return;
            //    }

            //    // Busca o usuário na tabela 'usuarios'
            //    var usuarios = await client
            //        .From<Usuario>()
            //        .Where(u => u.codigo_usuario == codigoUsuario)
            //        .Get();
            //    progressBarLogin.Value = 80;

            //    if (usuarios.Models.Count == 0)
            //    {
            //        MessageBox.Show("Usuário não encontrado.");
            //        return;
            //    }

            //    var usuario = usuarios.Models[0];

            //    // Validação da senha usando BCrypt
            //    if (BCrypt.Net.BCrypt.Verify(senhaDigitada, usuario.senha_hash))
            //    {
            //        progressBarLogin.Value = 100;
            //        progressBarLogin.Visible = false;
            //        MessageBox.Show($"Login realizado! Bem-vindo(a) {usuario.nome}");
            var menuForm = new menu();
            menuForm.Show();
            //    }
            //    else  
            //    {
            //        progressBarLogin.Value = 1;
            //        progressBarLogin.Visible = false;
            //        MessageBox.Show("Senha incorreta.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro ao acessar O banco de dados: " + ex.Message);
            //}
            Db.Abrir();
        }



        private bool senhaVisivel = false;
    
        private void btentrar_Click(object sender, EventArgs e)
        {

        }

        private void btclose_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void progressBarLogin_Click(object sender, EventArgs e)
        {

        }



        private void picOlhoFechado_Click_1(object sender, EventArgs e)
        {
            // Esconder a senha
            txtsenha.PasswordChar = '●';
            picOlhoAberto.Visible = true;
            picOlhoFechado.Visible = false;
        }

        private void picOlhoAberto_Click_1(object sender, EventArgs e)
        {
            // Mostrar a senha
            txtsenha.PasswordChar = '\0';
            picOlhoAberto.Visible = false;
            picOlhoFechado.Visible = true;
        }
    }


}
