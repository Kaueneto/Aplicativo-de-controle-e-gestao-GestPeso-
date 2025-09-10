namespace GestPeso
{
    partial class EditarUsers
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
            txtnome = new TextBox();
            txtcod = new TextBox();
            label7 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btclose = new Button();
            btconfirma = new Button();
            cboxEmpresa = new ComboBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtnome
            // 
            txtnome.BackColor = Color.White;
            txtnome.BorderStyle = BorderStyle.FixedSingle;
            txtnome.Font = new Font("Segoe UI", 9.75F);
            txtnome.Location = new Point(101, 39);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(241, 25);
            txtnome.TabIndex = 16;
            // 
            // txtcod
            // 
            txtcod.BorderStyle = BorderStyle.FixedSingle;
            txtcod.Font = new Font("Segoe UI", 9.75F);
            txtcod.Location = new Point(17, 39);
            txtcod.Name = "txtcod";
            txtcod.Size = new Size(78, 25);
            txtcod.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(17, 19);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 17;
            label7.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(101, 19);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 18;
            label1.Text = "Nome";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btclose);
            groupBox1.Controls.Add(btconfirma);
            groupBox1.Controls.Add(cboxEmpresa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtcod);
            groupBox1.Controls.Add(txtnome);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 197);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btclose
            // 
            btclose.Location = new Point(17, 151);
            btclose.Name = "btclose";
            btclose.Size = new Size(108, 26);
            btclose.TabIndex = 22;
            btclose.Text = "Fechar";
            btclose.UseVisualStyleBackColor = true;
            // 
            // btconfirma
            // 
            btconfirma.Location = new Point(234, 151);
            btconfirma.Name = "btconfirma";
            btconfirma.Size = new Size(108, 26);
            btconfirma.TabIndex = 21;
            btconfirma.Text = "Confirmar";
            btconfirma.UseVisualStyleBackColor = true;
            btconfirma.Click += btconfirma_Click;
            // 
            // cboxEmpresa
            // 
            cboxEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxEmpresa.FormattingEnabled = true;
            cboxEmpresa.Location = new Point(17, 87);
            cboxEmpresa.Name = "cboxEmpresa";
            cboxEmpresa.Size = new Size(325, 23);
            cboxEmpresa.TabIndex = 20;
            cboxEmpresa.SelectedIndexChanged += cboxEmpresa_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(17, 67);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 19;
            label2.Text = "Empresa";
            // 
            // EditarUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 210);
            Controls.Add(groupBox1);
            Name = "EditarUsers";
            Text = "Cadastrar Usuários - Editar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtnome;
        private TextBox txtcod;
        private Label label7;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cboxEmpresa;
        private Button btclose;
        private Button btconfirma;
    }
}