namespace HelpDeskPro.OpenCall.View.Login
{
    partial class frmCadastro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            txtBoxNome = new TextBox();
            label5 = new Label();
            txtBoxSenhaNovamente = new TextBox();
            label4 = new Label();
            btnVoltar = new Button();
            btnEntrar = new Button();
            cBoxMostrarSenha = new CheckBox();
            txtBoxSenha = new TextBox();
            txtBoxUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Notificacao = new NotifyIcon(components);
            SuspendLayout();
            // 
            // txtBoxNome
            // 
            txtBoxNome.Font = new Font("Segoe UI", 12F);
            txtBoxNome.Location = new Point(95, 100);
            txtBoxNome.MaxLength = 60;
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.PlaceholderText = "Digite seu nome";
            txtBoxNome.Size = new Size(210, 34);
            txtBoxNome.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.Location = new Point(95, 70);
            label5.Name = "label5";
            label5.Size = new Size(195, 32);
            label5.TabIndex = 32;
            label5.Text = "Nome completo:";
            // 
            // txtBoxSenhaNovamente
            // 
            txtBoxSenhaNovamente.Font = new Font("Segoe UI", 12F);
            txtBoxSenhaNovamente.Location = new Point(95, 310);
            txtBoxSenhaNovamente.MaxLength = 60;
            txtBoxSenhaNovamente.Name = "txtBoxSenhaNovamente";
            txtBoxSenhaNovamente.PlaceholderText = "Repita a senha";
            txtBoxSenhaNovamente.Size = new Size(210, 34);
            txtBoxSenhaNovamente.TabIndex = 31;
            txtBoxSenhaNovamente.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.Location = new Point(95, 280);
            label4.Name = "label4";
            label4.Size = new Size(200, 32);
            label4.TabIndex = 30;
            label4.Text = "Confirmar senha:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(110, 440);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(180, 50);
            btnVoltar.TabIndex = 29;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(0, 119, 204);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnEntrar.Image = (Image)resources.GetObject("btnEntrar.Image");
            btnEntrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrar.Location = new Point(110, 380);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(180, 55);
            btnEntrar.TabIndex = 28;
            btnEntrar.Text = "Cadastrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            cBoxMostrarSenha.Location = new Point(122, 350);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(155, 29);
            cBoxMostrarSenha.TabIndex = 27;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Font = new Font("Segoe UI", 12F);
            txtBoxSenha.Location = new Point(95, 240);
            txtBoxSenha.MaxLength = 60;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Digite sua senha";
            txtBoxSenha.Size = new Size(210, 34);
            txtBoxSenha.TabIndex = 26;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Font = new Font("Segoe UI", 12F);
            txtBoxUsuario.Location = new Point(95, 170);
            txtBoxUsuario.MaxLength = 60;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Digite seu usuário";
            txtBoxUsuario.Size = new Size(210, 34);
            txtBoxUsuario.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(95, 210);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 24;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(95, 140);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 23;
            label2.Text = "Usuário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(121, 10);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 22;
            label1.Text = "Criar conta";
            // 
            // Notificacao
            // 
            Notificacao.Icon = (Icon)resources.GetObject("Notificacao.Icon");
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(400, 513);
            Controls.Add(txtBoxNome);
            Controls.Add(label5);
            Controls.Add(txtBoxSenhaNovamente);
            Controls.Add(label4);
            Controls.Add(btnVoltar);
            Controls.Add(btnEntrar);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - OpenCall";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxNome;
        private Label label5;
        private TextBox txtBoxSenhaNovamente;
        private Label label4;
        private Button btnVoltar;
        private Button btnEntrar;
        private CheckBox cBoxMostrarSenha;
        private TextBox txtBoxSenha;
        private TextBox txtBoxUsuario;
        private Label label3;
        private Label label2;
        private Label label1;
        private NotifyIcon Notificacao;
    }
}