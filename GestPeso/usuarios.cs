using DotNetEnv;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPeso
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxGerarSenhaPadrao.Checked)
            {
                txtsenhaCadastro.Text = "123456";
                txtsenhaCadastro.BackColor = Color.LightGray;

            }
            else
            {
                txtsenhaCadastro.Text = "";
                txtsenhaCadastro.BackColor = Color.White;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtsenhaCadastro.Text = "";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Env.Load(@"C:\dev\PastaGestPeso\GestPeso\.env");

            try
            {

                if (string.IsNullOrWhiteSpace(txtnomeCadastro.Text))
                {
                    MessageBox.Show("Informe o nome do usuário!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtcodigoCadastro.Text))
                {
                    MessageBox.Show("Informe o código do usuário!");
                    return;
                }

    

           
                string codigoUsuario = txtcodigoCadastro.Text.Trim();
                string nome = txtnomeCadastro.Text.Trim();
                string senha;

                if (cboxGerarSenhaPadrao.Checked)
                {
                    senha = "123456"; // senha padrão
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtsenhaCadastro.Text))
                    {
                        MessageBox.Show("Informe a senha ou marque para gerar a padrão.");
                        return;
                    }
                    senha = txtsenhaCadastro.Text.Trim();
                }

      
                string senhaHash = BCrypt.Net.BCrypt.HashPassword(senha);

                int idEmpresa = Convert.ToInt32(cboxempresaCadastro.SelectedValue);

                // Abre conexão
           Db.Abrir();

                string sql = @"
                    INSERT INTO usuarios 
                        (codigo_usuario, nome, senha_hash, id_empresa, dt_cadastro_usuario)
                    VALUES 
                        (@codigo, @nome, @senha, @id_empresa, NOW())
                ";

                using (var cmd = new NpgsqlCommand(sql, Db.Conexao))
                {
                    cmd.Parameters.AddWithValue("codigo", codigoUsuario);
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("senha", senhaHash);
                    cmd.Parameters.AddWithValue("id_empresa", idEmpresa);

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar usuário.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
            Db.Fechar();
            }
        }

        private void LimparCampos()
        {
            txtcodigoCadastro.Clear();
            txtnomeCadastro.Clear();
            txtsenhaCadastro.Clear();
            cboxempresaCadastro.SelectedIndex = -1;
            cboxGerarSenhaPadrao.Checked = false;
        }
    

        private void txtnomeCadastro_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
