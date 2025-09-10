namespace GestPeso
{
    partial class usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            txtnomeCadastro = new TextBox();
            label1 = new Label();
            txtsenhaCadastro = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btFechar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            btLimparCadastro = new Button();
            cboxGerarSenhaPadrao = new CheckBox();
            btpesquisaempresa = new Button();
            label5 = new Label();
            label4 = new Label();
            txtcodigoCadastro = new TextBox();
            label3 = new Label();
            cboxempresaCadastro = new ComboBox();
            btCadastrarUsuario = new Button();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            btReset = new Button();
            BtExcluir = new Button();
            btEditar = new Button();
            dataGridUsuariosCadastrados = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridPermissoesUsuarios = new DataGridView();
            btconfirmaAlteracoes = new Button();
            btPesquisa = new Button();
            cboxEmpresa = new ComboBox();
            label7 = new Label();
            txtNomeUserPesquisa = new TextBox();
            button4 = new Button();
            label6 = new Label();
            txtcoduserPesquisa = new TextBox();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuariosCadastrados).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPermissoesUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtnomeCadastro
            // 
            txtnomeCadastro.BorderStyle = BorderStyle.FixedSingle;
            txtnomeCadastro.CharacterCasing = CharacterCasing.Upper;
            txtnomeCadastro.Font = new Font("Segoe UI", 9.75F);
            txtnomeCadastro.Location = new Point(22, 84);
            txtnomeCadastro.Name = "txtnomeCadastro";
            txtnomeCadastro.Size = new Size(369, 25);
            txtnomeCadastro.TabIndex = 1;
            txtnomeCadastro.TextChanged += txtnomeCadastro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(22, 64);
            label1.Name = "label1";
            label1.Size = new Size(91, 17);
            label1.TabIndex = 2;
            label1.Text = "Nome usuário";
            // 
            // txtsenhaCadastro
            // 
            txtsenhaCadastro.BorderStyle = BorderStyle.FixedSingle;
            txtsenhaCadastro.Font = new Font("Segoe UI", 9.75F);
            txtsenhaCadastro.Location = new Point(22, 132);
            txtsenhaCadastro.Name = "txtsenhaCadastro";
            txtsenhaCadastro.Size = new Size(282, 25);
            txtsenhaCadastro.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(22, 112);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btFechar);
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 473);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btFechar
            // 
            btFechar.Location = new Point(10, 436);
            btFechar.Name = "btFechar";
            btFechar.Size = new Size(92, 31);
            btFechar.TabIndex = 8;
            btFechar.Text = "Fechar";
            btFechar.UseVisualStyleBackColor = true;
            btFechar.Click += btFechar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(808, 418);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btLimparCadastro);
            tabPage1.Controls.Add(cboxGerarSenhaPadrao);
            tabPage1.Controls.Add(btpesquisaempresa);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtcodigoCadastro);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cboxempresaCadastro);
            tabPage1.Controls.Add(btCadastrarUsuario);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtsenhaCadastro);
            tabPage1.Controls.Add(txtnomeCadastro);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(800, 390);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 250);
            button1.Name = "button1";
            button1.Size = new Size(124, 28);
            button1.TabIndex = 14;
            button1.Text = "Confirmar Edição";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // btLimparCadastro
            // 
            btLimparCadastro.Location = new Point(270, 250);
            btLimparCadastro.Name = "btLimparCadastro";
            btLimparCadastro.Size = new Size(92, 28);
            btLimparCadastro.TabIndex = 13;
            btLimparCadastro.Text = "Limpar";
            btLimparCadastro.UseVisualStyleBackColor = true;
            btLimparCadastro.Click += button9_Click;
            // 
            // cboxGerarSenhaPadrao
            // 
            cboxGerarSenhaPadrao.AutoSize = true;
            cboxGerarSenhaPadrao.Location = new Point(318, 136);
            cboxGerarSenhaPadrao.Name = "cboxGerarSenhaPadrao";
            cboxGerarSenhaPadrao.Size = new Size(129, 19);
            cboxGerarSenhaPadrao.TabIndex = 12;
            cboxGerarSenhaPadrao.Text = "Gerar Senha padrão";
            cboxGerarSenhaPadrao.UseVisualStyleBackColor = true;
            cboxGerarSenhaPadrao.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btpesquisaempresa
            // 
            btpesquisaempresa.Location = new Point(310, 180);
            btpesquisaempresa.Name = "btpesquisaempresa";
            btpesquisaempresa.Size = new Size(39, 23);
            btpesquisaempresa.TabIndex = 11;
            btpesquisaempresa.Text = "...";
            btpesquisaempresa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(172, 41);
            label5.Name = "label5";
            label5.Size = new Size(287, 13);
            label5.TabIndex = 10;
            label5.Text = "Ultilizar prefixo de cada filial para código dos usuários";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(22, 16);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 9;
            label4.Text = "Código";
            // 
            // txtcodigoCadastro
            // 
            txtcodigoCadastro.BorderStyle = BorderStyle.FixedSingle;
            txtcodigoCadastro.Font = new Font("Segoe UI", 9.75F);
            txtcodigoCadastro.Location = new Point(22, 36);
            txtcodigoCadastro.Name = "txtcodigoCadastro";
            txtcodigoCadastro.Size = new Size(144, 25);
            txtcodigoCadastro.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(22, 160);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 7;
            label3.Text = "Empresa";
            // 
            // cboxempresaCadastro
            // 
            cboxempresaCadastro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxempresaCadastro.FormattingEnabled = true;
            cboxempresaCadastro.Items.AddRange(new object[] { "1-STORE", "2-PROEZA" });
            cboxempresaCadastro.Location = new Point(22, 180);
            cboxempresaCadastro.Name = "cboxempresaCadastro";
            cboxempresaCadastro.Size = new Size(282, 23);
            cboxempresaCadastro.TabIndex = 3;
            // 
            // btCadastrarUsuario
            // 
            btCadastrarUsuario.Location = new Point(368, 250);
            btCadastrarUsuario.Name = "btCadastrarUsuario";
            btCadastrarUsuario.Size = new Size(92, 28);
            btCadastrarUsuario.TabIndex = 4;
            btCadastrarUsuario.Text = "Cadastrar";
            btCadastrarUsuario.UseVisualStyleBackColor = true;
            btCadastrarUsuario.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(btPesquisa);
            tabPage2.Controls.Add(cboxEmpresa);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtNomeUserPesquisa);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtcoduserPesquisa);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(800, 390);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Controle de usuários";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btReset);
            groupBox3.Controls.Add(BtExcluir);
            groupBox3.Controls.Add(btEditar);
            groupBox3.Controls.Add(dataGridUsuariosCadastrados);
            groupBox3.Location = new Point(19, 73);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(416, 311);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Usuários Cadastrados";
            // 
            // btReset
            // 
            btReset.Location = new Point(200, 268);
            btReset.Name = "btReset";
            btReset.Size = new Size(110, 26);
            btReset.TabIndex = 20;
            btReset.Text = "Resetar senha ";
            btReset.UseVisualStyleBackColor = true;
            // 
            // BtExcluir
            // 
            BtExcluir.Location = new Point(6, 268);
            BtExcluir.Name = "BtExcluir";
            BtExcluir.Size = new Size(90, 28);
            BtExcluir.TabIndex = 9;
            BtExcluir.Text = "Excluir";
            BtExcluir.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            btEditar.Location = new Point(104, 268);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(90, 28);
            btEditar.TabIndex = 19;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // dataGridUsuariosCadastrados
            // 
            dataGridUsuariosCadastrados.AllowUserToAddRows = false;
            dataGridUsuariosCadastrados.AllowUserToOrderColumns = true;
            dataGridUsuariosCadastrados.AllowUserToResizeColumns = false;
            dataGridUsuariosCadastrados.AllowUserToResizeRows = false;
            dataGridUsuariosCadastrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridUsuariosCadastrados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridUsuariosCadastrados.BackgroundColor = Color.White;
            dataGridUsuariosCadastrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuariosCadastrados.Location = new Point(6, 22);
            dataGridUsuariosCadastrados.Name = "dataGridUsuariosCadastrados";
            dataGridUsuariosCadastrados.Size = new Size(404, 231);
            dataGridUsuariosCadastrados.TabIndex = 18;
            dataGridUsuariosCadastrados.CellContentClick += dataGridUsuariosCadastrados_CellContentClick;
            dataGridUsuariosCadastrados.CellContentDoubleClick += dataGridUsuariosCadastrados_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridPermissoesUsuarios);
            groupBox2.Controls.Add(btconfirmaAlteracoes);
            groupBox2.Location = new Point(444, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 311);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Permissões por Usuário";
            // 
            // dataGridPermissoesUsuarios
            // 
            dataGridPermissoesUsuarios.BackgroundColor = Color.White;
            dataGridPermissoesUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPermissoesUsuarios.Location = new Point(6, 22);
            dataGridPermissoesUsuarios.Name = "dataGridPermissoesUsuarios";
            dataGridPermissoesUsuarios.Size = new Size(330, 231);
            dataGridPermissoesUsuarios.TabIndex = 20;
            // 
            // btconfirmaAlteracoes
            // 
            btconfirmaAlteracoes.Location = new Point(194, 268);
            btconfirmaAlteracoes.Name = "btconfirmaAlteracoes";
            btconfirmaAlteracoes.Size = new Size(142, 28);
            btconfirmaAlteracoes.TabIndex = 23;
            btconfirmaAlteracoes.Text = "Confirmar alterações";
            btconfirmaAlteracoes.UseVisualStyleBackColor = true;
            // 
            // btPesquisa
            // 
            btPesquisa.Image = (Image)resources.GetObject("btPesquisa.Image");
            btPesquisa.ImageAlign = ContentAlignment.MiddleRight;
            btPesquisa.Location = new Point(587, 30);
            btPesquisa.Name = "btPesquisa";
            btPesquisa.Size = new Size(105, 31);
            btPesquisa.TabIndex = 17;
            btPesquisa.Text = "Pesquisar";
            btPesquisa.TextAlign = ContentAlignment.MiddleRight;
            btPesquisa.TextImageRelation = TextImageRelation.TextBeforeImage;
            btPesquisa.UseVisualStyleBackColor = true;
            btPesquisa.Click += button5_Click;
            // 
            // cboxEmpresa
            // 
            cboxEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxEmpresa.FormattingEnabled = true;
            cboxEmpresa.Location = new Point(441, 35);
            cboxEmpresa.Name = "cboxEmpresa";
            cboxEmpresa.Size = new Size(127, 23);
            cboxEmpresa.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(441, 14);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 15;
            label7.Text = "Empresa";
            // 
            // txtNomeUserPesquisa
            // 
            txtNomeUserPesquisa.BackColor = SystemColors.InactiveCaption;
            txtNomeUserPesquisa.BorderStyle = BorderStyle.FixedSingle;
            txtNomeUserPesquisa.Font = new Font("Segoe UI", 9.75F);
            txtNomeUserPesquisa.Location = new Point(143, 34);
            txtNomeUserPesquisa.Name = "txtNomeUserPesquisa";
            txtNomeUserPesquisa.Size = new Size(292, 25);
            txtNomeUserPesquisa.TabIndex = 13;
            // 
            // button4
            // 
            button4.Location = new Point(98, 34);
            button4.Name = "button4";
            button4.Size = new Size(39, 23);
            button4.TabIndex = 12;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(19, 14);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 11;
            label6.Text = "Usuário";
            // 
            // txtcoduserPesquisa
            // 
            txtcoduserPesquisa.BorderStyle = BorderStyle.FixedSingle;
            txtcoduserPesquisa.Font = new Font("Segoe UI", 9.75F);
            txtcoduserPesquisa.Location = new Point(19, 34);
            txtcoduserPesquisa.Name = "txtcoduserPesquisa";
            txtcoduserPesquisa.Size = new Size(78, 25);
            txtcoduserPesquisa.TabIndex = 10;
            // 
            // usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 475);
            Controls.Add(groupBox1);
            Name = "usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar usuários";
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUsuariosCadastrados).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPermissoesUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtnomeCadastro;
        private Label label1;
        private TextBox txtsenhaCadastro;
        private Label label2;
        private GroupBox groupBox1;
        private Button btFechar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private ComboBox cboxempresaCadastro;
        private Button btCadastrarUsuario;
        private TabPage tabPage2;
        private Button btpesquisaempresa;
        private Label label5;
        private Label label4;
        private TextBox txtcodigoCadastro;
        private Label label6;
        private TextBox txtcoduserPesquisa;
        private Button button4;
        private Button btEditar;
        private Button BtExcluir;
        private DataGridView dataGridUsuariosCadastrados;
        private Button btPesquisa;
        private ComboBox cboxEmpresa;
        private Label label7;
        private TextBox txtNomeUserPesquisa;
        private DataGridView dataGridPermissoesUsuarios;
        private Button btconfirmaAlteracoes;
        private CheckBox cboxGerarSenhaPadrao;
        private Button btLimparCadastro;
        private Button button1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btReset;
    }
}