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
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btLimpar = new Button();
            checkBox1 = new CheckBox();
            button3 = new Button();
            label5 = new Label();
            label4 = new Label();
            txtcodigoCadastro = new TextBox();
            label3 = new Label();
            cboxempresa = new ComboBox();
            btCadastrar = new Button();
            tabPage2 = new TabPage();
            button8 = new Button();
            label9 = new Label();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            button7 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            comboBox2 = new ComboBox();
            label7 = new Label();
            textBox5 = new TextBox();
            button4 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtnomeCadastro
            // 
            txtnomeCadastro.BorderStyle = BorderStyle.FixedSingle;
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
            txtsenhaCadastro.TabIndex = 3;
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
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 473);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(10, 436);
            button2.Name = "button2";
            button2.Size = new Size(92, 31);
            button2.TabIndex = 8;
            button2.Text = "Fechar";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(798, 418);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btLimpar);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtcodigoCadastro);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cboxempresa);
            tabPage1.Controls.Add(btCadastrar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtsenhaCadastro);
            tabPage1.Controls.Add(txtnomeCadastro);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(790, 390);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(270, 250);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(92, 28);
            btLimpar.TabIndex = 13;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += button9_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(318, 136);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Gerar Senha padrão";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button3
            // 
            button3.Location = new Point(310, 180);
            button3.Name = "button3";
            button3.Size = new Size(39, 23);
            button3.TabIndex = 11;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
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
            txtcodigoCadastro.TabIndex = 8;
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
            // cboxempresa
            // 
            cboxempresa.FormattingEnabled = true;
            cboxempresa.Location = new Point(22, 180);
            cboxempresa.Name = "cboxempresa";
            cboxempresa.Size = new Size(282, 23);
            cboxempresa.TabIndex = 6;
            // 
            // btCadastrar
            // 
            btCadastrar.Location = new Point(368, 250);
            btCadastrar.Name = "btCadastrar";
            btCadastrar.Size = new Size(92, 28);
            btCadastrar.TabIndex = 5;
            btCadastrar.Text = "Cadastrar";
            btCadastrar.UseVisualStyleBackColor = true;
            btCadastrar.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(790, 390);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Controle de usuários";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // button8
            // 
            button8.Location = new Point(642, 332);
            button8.Name = "button8";
            button8.Size = new Size(142, 28);
            button8.TabIndex = 23;
            button8.Text = "Confirmar alterações";
            button8.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(19, 73);
            label9.Name = "label9";
            label9.Size = new Size(118, 15);
            label9.TabIndex = 22;
            label9.Text = "Usuários cadastrados";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(454, 73);
            label8.Name = "label8";
            label8.Size = new Size(129, 15);
            label8.TabIndex = 21;
            label8.Text = "Permissões por usuário";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(454, 93);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(330, 233);
            dataGridView2.TabIndex = 20;
            // 
            // button7
            // 
            button7.Location = new Point(117, 332);
            button7.Name = "button7";
            button7.Size = new Size(90, 28);
            button7.TabIndex = 19;
            button7.Text = "Editar";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(19, 332);
            button6.Name = "button6";
            button6.Size = new Size(90, 28);
            button6.TabIndex = 9;
            button6.Text = "Excluir";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(416, 233);
            dataGridView1.TabIndex = 18;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(587, 30);
            button5.Name = "button5";
            button5.Size = new Size(105, 31);
            button5.TabIndex = 17;
            button5.Text = "Pesquisar";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.TextImageRelation = TextImageRelation.TextBeforeImage;
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(441, 35);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(127, 23);
            comboBox2.TabIndex = 16;
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
            // textBox5
            // 
            textBox5.BackColor = SystemColors.InactiveCaption;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 9.75F);
            textBox5.Location = new Point(143, 34);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(292, 25);
            textBox5.TabIndex = 13;
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
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 9.75F);
            textBox4.Location = new Point(19, 34);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(78, 25);
            textBox4.TabIndex = 10;
            // 
            // usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 475);
            Controls.Add(groupBox1);
            Name = "usuarios";
            Text = "Cadastrar usuários";
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtnomeCadastro;
        private Label label1;
        private TextBox txtsenhaCadastro;
        private Label label2;
        private GroupBox groupBox1;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private ComboBox cboxempresa;
        private Button btCadastrar;
        private TabPage tabPage2;
        private Button button3;
        private Label label5;
        private Label label4;
        private TextBox txtcodigoCadastro;
        private Label label6;
        private TextBox textBox4;
        private Button button4;
        private Button button7;
        private Button button6;
        private DataGridView dataGridView1;
        private Button button5;
        private ComboBox comboBox2;
        private Label label7;
        private TextBox textBox5;
        private Label label9;
        private Label label8;
        private DataGridView dataGridView2;
        private Button button8;
        private CheckBox checkBox1;
        private Button btLimpar;
    }
}