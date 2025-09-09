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
            if (checkBox1.Checked)
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
            if (txtsenhaCadastro != null || txtnomeCadastro != null || txtcodigoCadastro != null)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            else
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }






        }

        private void txtnomeCadastro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
