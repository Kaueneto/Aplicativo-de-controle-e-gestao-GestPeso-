namespace GestPeso
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtuser = new TextBox();
            btentrar = new Button();
            txtsenha = new TextBox();
            label2 = new Label();
            btchangepass = new Button();
            btclose = new Button();
            groupBox1 = new GroupBox();
            picOlhoAberto = new PictureBox();
            picOlhoFechado = new PictureBox();
            progressBarLogin = new ProgressBar();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOlhoAberto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOlhoFechado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(39, 19);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // txtuser
            // 
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            txtuser.Font = new Font("Segoe UI", 9.75F);
            txtuser.ForeColor = Color.Black;
            txtuser.Location = new Point(39, 39);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(219, 25);
            txtuser.TabIndex = 0;
            // 
            // btentrar
            // 
            btentrar.BackColor = Color.FromArgb(224, 224, 224);
            btentrar.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btentrar.Font = new Font("Segoe UI", 9.75F);
            btentrar.ForeColor = Color.Black;
            btentrar.Location = new Point(39, 130);
            btentrar.Name = "btentrar";
            btentrar.Size = new Size(219, 30);
            btentrar.TabIndex = 2;
            btentrar.Text = "Entrar";
            btentrar.UseVisualStyleBackColor = false;
            btentrar.Click += btentrar_Click;
            // 
            // txtsenha
            // 
            txtsenha.BorderStyle = BorderStyle.FixedSingle;
            txtsenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsenha.ForeColor = Color.Black;
            txtsenha.Location = new Point(39, 87);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(219, 29);
            txtsenha.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(39, 67);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // btchangepass
            // 
            btchangepass.Font = new Font("Segoe UI", 9.75F);
            btchangepass.Location = new Point(39, 170);
            btchangepass.Name = "btchangepass";
            btchangepass.Size = new Size(108, 30);
            btchangepass.TabIndex = 3;
            btchangepass.Text = "Trocar Senha";
            btchangepass.UseVisualStyleBackColor = true;
            // 
            // btclose
            // 
            btclose.Font = new Font("Segoe UI", 9.75F);
            btclose.Location = new Point(153, 170);
            btclose.Name = "btclose";
            btclose.Size = new Size(105, 30);
            btclose.TabIndex = 4;
            btclose.Text = "Fechar";
            btclose.UseVisualStyleBackColor = true;
            btclose.Click += btclose_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(picOlhoAberto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btclose);
            groupBox1.Controls.Add(txtuser);
            groupBox1.Controls.Add(btchangepass);
            groupBox1.Controls.Add(btentrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(picOlhoFechado);
            groupBox1.Controls.Add(txtsenha);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 215);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // picOlhoAberto
            // 
            picOlhoAberto.BackgroundImage = Properties.Resources.eye_opened;
            picOlhoAberto.BackgroundImageLayout = ImageLayout.Zoom;
            picOlhoAberto.Location = new Point(231, 89);
            picOlhoAberto.Name = "picOlhoAberto";
            picOlhoAberto.Size = new Size(25, 25);
            picOlhoAberto.TabIndex = 6;
            picOlhoAberto.TabStop = false;
            picOlhoAberto.Click += picOlhoAberto_Click_1;
            // 
            // picOlhoFechado
            // 
            picOlhoFechado.BackgroundImage = Properties.Resources.eye_closed;
            picOlhoFechado.BackgroundImageLayout = ImageLayout.Zoom;
            picOlhoFechado.Location = new Point(231, 89);
            picOlhoFechado.Name = "picOlhoFechado";
            picOlhoFechado.Size = new Size(25, 25);
            picOlhoFechado.TabIndex = 5;
            picOlhoFechado.TabStop = false;
            picOlhoFechado.Click += picOlhoFechado_Click_1;
            // 
            // progressBarLogin
            // 
            progressBarLogin.Location = new Point(-1, 223);
            progressBarLogin.Maximum = 140;
            progressBarLogin.Name = "progressBarLogin";
            progressBarLogin.Size = new Size(332, 23);
            progressBarLogin.TabIndex = 5;
            progressBarLogin.Visible = false;
            progressBarLogin.Click += progressBarLogin_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(325, 247);
            Controls.Add(progressBarLogin);
            Controls.Add(groupBox1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOlhoAberto).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOlhoFechado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtuser;
        private Button btentrar;
        private TextBox txtsenha;
        private Label label2;
        private Button btchangepass;
        private Button btclose;
        private GroupBox groupBox1;
        private ProgressBar progressBarLogin;
        private PictureBox picOlhoAberto;
        private PictureBox picOlhoFechado;
    }
}
