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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // txtuser
            // 
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            txtuser.Font = new Font("Segoe UI", 9.75F);
            txtuser.Location = new Point(91, 27);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(231, 25);
            txtuser.TabIndex = 0;
            // 
            // btentrar
            // 
            btentrar.Font = new Font("Segoe UI", 9.75F);
            btentrar.Location = new Point(250, 106);
            btentrar.Name = "btentrar";
            btentrar.Size = new Size(82, 34);
            btentrar.TabIndex = 2;
            btentrar.Text = "Entrar";
            btentrar.UseVisualStyleBackColor = true;
          //  btentrar.Click += button1_ClickAsync;
            // 
            // txtsenha
            // 
            txtsenha.BorderStyle = BorderStyle.FixedSingle;
            txtsenha.Font = new Font("Segoe UI", 9.75F);
            txtsenha.Location = new Point(91, 58);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(231, 25);
            txtsenha.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(42, 60);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // btchangepass
            // 
            btchangepass.Font = new Font("Segoe UI", 9.75F);
            btchangepass.Location = new Point(42, 106);
            btchangepass.Name = "btchangepass";
            btchangepass.Size = new Size(109, 34);
            btchangepass.TabIndex = 3;
            btchangepass.Text = "Trocar Senha";
            btchangepass.UseVisualStyleBackColor = true;
            // 
            // btclose
            // 
            btclose.Font = new Font("Segoe UI", 9.75F);
            btclose.Location = new Point(157, 106);
            btclose.Name = "btclose";
            btclose.Size = new Size(87, 34);
            btclose.TabIndex = 4;
            btclose.Text = "Fechar";
            btclose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btclose);
            groupBox1.Controls.Add(txtuser);
            groupBox1.Controls.Add(btchangepass);
            groupBox1.Controls.Add(btentrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtsenha);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 174);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(379, 188);
            Controls.Add(groupBox1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}
