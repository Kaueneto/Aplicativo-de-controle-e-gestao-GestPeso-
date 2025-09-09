namespace GestPeso
{
    partial class ChangePass
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
            label1 = new Label();
            txtuser = new TextBox();
            btentrar = new Button();
            label2 = new Label();
            picOlhoFechado = new PictureBox();
            txtsenha = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picOlhoFechado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(103, 53);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 7;
            label1.Text = "Usuário";
            // 
            // txtuser
            // 
            txtuser.Font = new Font("Segoe UI", 9.75F);
            txtuser.ForeColor = Color.Black;
            txtuser.Location = new Point(103, 73);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(219, 25);
            txtuser.TabIndex = 8;
            // 
            // btentrar
            // 
            btentrar.BackColor = Color.FromArgb(224, 224, 224);
            btentrar.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btentrar.Font = new Font("Segoe UI", 9.75F);
            btentrar.ForeColor = Color.Black;
            btentrar.Location = new Point(220, 220);
            btentrar.Name = "btentrar";
            btentrar.Size = new Size(102, 30);
            btentrar.TabIndex = 10;
            btentrar.Text = "Confirmar";
            btentrar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(103, 101);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 11;
            label2.Text = "Senha Atual";
            // 
            // picOlhoFechado
            // 
            picOlhoFechado.BackgroundImage = Properties.Resources.eye_closed;
            picOlhoFechado.BackgroundImageLayout = ImageLayout.Zoom;
            picOlhoFechado.Location = new Point(295, 123);
            picOlhoFechado.Name = "picOlhoFechado";
            picOlhoFechado.Size = new Size(25, 25);
            picOlhoFechado.TabIndex = 12;
            picOlhoFechado.TabStop = false;
            // 
            // txtsenha
            // 
            txtsenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsenha.ForeColor = Color.Black;
            txtsenha.Location = new Point(103, 121);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(219, 29);
            txtsenha.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(103, 156);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 14;
            label3.Text = "Nova senha";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(103, 176);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(219, 29);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.BorderColor = Color.LightSeaGreen;
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(103, 220);
            button1.Name = "button1";
            button1.Size = new Size(111, 30);
            button1.TabIndex = 15;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.eye_closed;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(295, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 325);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtuser);
            Controls.Add(btentrar);
            Controls.Add(label2);
            Controls.Add(picOlhoFechado);
            Controls.Add(txtsenha);
            Name = "ChangePass";
            Text = "Configurações da senha";
            ((System.ComponentModel.ISupportInitialize)picOlhoFechado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtuser;
        private Button btentrar;
        private Label label2;
        private PictureBox picOlhoFechado;
        private TextBox txtsenha;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}