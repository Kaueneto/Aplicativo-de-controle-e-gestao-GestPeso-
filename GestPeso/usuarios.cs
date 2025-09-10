using DotNetEnv;
using GestPeso.model;
using Microsoft.VisualBasic;
using Npgsql;
using Supabase;
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
        private readonly Client client; // Client Supabase já inicializado no login
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
            txtcodigoCadastro.Text = "";
            txtnomeCadastro.Text = "";
            cboxempresaCadastro.SelectedIndex = -1;

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

        private void txtsenhaCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Db.Abrir();

                string sql = @"
                    SELECT id_usuario, codigo_usuario, nome, id_empresa, dt_cadastro_usuario
                    FROM usuarios
                    WHERE 1=1
                ";

                if (!string.IsNullOrWhiteSpace(txtcoduserPesquisa.Text))
                {
                    sql += " AND codigo_usuario ILIKE @codigo";
                }

                if (!string.IsNullOrWhiteSpace(txtNomeUserPesquisa.Text))
                {
                    sql += " AND nome ILIKE @nome";
                }

                using (var cmd = new NpgsqlCommand(sql, Db.Conexao))
                {
                    if (!string.IsNullOrWhiteSpace(txtcoduserPesquisa.Text))
                        cmd.Parameters.AddWithValue("codigo", "%" + txtcoduserPesquisa.Text.Trim() + "%");

                    if (!string.IsNullOrWhiteSpace(txtNomeUserPesquisa.Text))
                        cmd.Parameters.AddWithValue("nome", "%" + txtNomeUserPesquisa.Text.Trim() + "%");

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridUsuariosCadastrados.DataSource = dt;
                    }
                }


                dataGridUsuariosCadastrados.Columns["id_usuario"].HeaderText = "ID";
                dataGridUsuariosCadastrados.Columns["codigo_usuario"].HeaderText = "Código";
                dataGridUsuariosCadastrados.Columns["nome"].HeaderText = "Nome";
                dataGridUsuariosCadastrados.Columns["id_empresa"].HeaderText = "Empresa";
                dataGridUsuariosCadastrados.Columns["dt_cadastro_usuario"].HeaderText = "Data de Cadastro";




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
            finally
            {
                // Db.Fechar();
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dataGridUsuariosCadastrados.SelectedRows.Count > 0)
            {
                // Pega a linha selecionada
                var linha = dataGridUsuariosCadastrados.SelectedRows[0];

                // Pega os dados diretamente das células do DataGridView
                string codigo = linha.Cells["codigo_usuario"].Value.ToString();
                string nome = linha.Cells["nome"].Value.ToString();
                string empresa = linha.Cells["id_empresa"].Value.ToString();

                // Cria o formulário de edição passando os valores
                EditarUsers editarForm = new EditarUsers(codigo, nome, empresa);
                editarForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dataGridUsuariosCadastrados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          


        }




        private void dataGridUsuariosCadastrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }



    }

}
