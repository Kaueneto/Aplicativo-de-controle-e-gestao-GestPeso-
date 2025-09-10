using DotNetEnv;
using GestPeso.model;
using Npgsql;
using Supabase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPeso
{
    public partial class EditarUsers : Form
    {
        public EditarUsers(string codigo, string nome, string empresa)
        {
            InitializeComponent();

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

        }

      


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
      

        private void cboxEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
