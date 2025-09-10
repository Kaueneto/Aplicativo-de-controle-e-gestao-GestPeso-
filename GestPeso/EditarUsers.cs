using DotNetEnv;
using GestPeso.model;
using Npgsql;
using Supabase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPeso
{
    public partial class EditarUsers : Form
    {
        public EditarUsers(string codigo, string nome, string empresa)
        {
            InitializeComponent();
            CarregarComboEmpresas();
            // Preenche os campos do formulário
            txtcod.Text = codigo;
            txtnome.Text = nome;

            // Seleciona a empresa no ComboBox
            cboxEmpresa.SelectedItem = empresa;
        }


        public EditarUsers(string? codigo)
        {
            // this.codigo = codigo;
        }




        private void btconfirma_Click(object sender, EventArgs e)
        {
            ConfirmarEdicao();

        }

        private void CarregarComboEmpresas()
        {
            try
            {
                const string sql = @"
            SELECT codigo, nome
              FROM empresas
          ORDER BY codigo;";

                using var da = new NpgsqlDataAdapter(sql, Db.Conexao);
                da.SelectCommand.CommandTimeout = 60;

                var tabela = new DataTable();
                da.Fill(tabela);

                // Adiciona coluna "display" com código + nome
                tabela.Columns.Add("display", typeof(string));
                foreach (DataRow row in tabela.Rows)
                {
                    row["display"] = $"{row["codigo"]} - {row["nome"]}";
                }

                cboxEmpresa.SelectedIndexChanged -= cboxEmpresa_SelectedIndexChanged;

                cboxEmpresa.DataSource = tabela;
                cboxEmpresa.DisplayMember = "display";   // Mostra "EMP01 - Empresa A"
                cboxEmpresa.ValueMember = "codigo";      // vai usar o codigo da empresa como valor
                cboxEmpresa.SelectedIndex = -1;

                cboxEmpresa.SelectedIndexChanged += cboxEmpresa_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar empresas:\n{ex}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ConfirmarEdicao()
        {
            if (string.IsNullOrWhiteSpace(txtcod.Text) || string.IsNullOrWhiteSpace(txtnome.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

    
            if (cboxEmpresa.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma empresa.");
                return;
            }
            try
            {
                string codigoUsuario = txtcod.Text.Trim();
                string nomeUsuario = txtnome.Text.Trim();
                string codigoEmpresa = cboxEmpresa.SelectedValue.ToString();

                const string sql = @"
            UPDATE usuarios
               SET nome = @nome,
                   id_empresa = (SELECT id FROM empresas WHERE codigo = @codigoEmpresa)
             WHERE codigo_usuario = @codigoUsuario;
        ";

                using var cmd = new NpgsqlCommand(sql, Db.Conexao);
                cmd.Parameters.AddWithValue("nome", nomeUsuario);
                cmd.Parameters.AddWithValue("codigoEmpresa", Convert.ToInt32(codigoEmpresa)); // se no banco for int ou smallint
                cmd.Parameters.AddWithValue("codigoUsuario", codigoUsuario);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Usuário atualizado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nenhum usuário foi atualizado. Verifique o código.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar usuário:\n{ex}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
      

        private void cboxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
