namespace HelpDeskPro
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxUsuario = new TextBox();
            txtBoxSenha = new TextBox();
            cBoxMostrarSenha = new CheckBox();
            cBoxLembrarDeMim = new CheckBox();
            btnVoltar = new Button();
            btnEntrar = new Button();
            Notificacao = new NotifyIcon(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(84, 10);
            label1.Name = "label1";
            label1.Size = new Size(232, 37);
            label1.TabIndex = 0;
            label1.Text = "Acesse sua conta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.Location = new Point(100, 70);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 1;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.Location = new Point(100, 140);
            label3.Name = "label3";
            label3.Size = new Size(79, 30);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxUsuario.Location = new Point(100, 100);
            txtBoxUsuario.MaxLength = 60;
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "Digite seu usuário";
            txtBoxUsuario.Size = new Size(200, 34);
            txtBoxUsuario.TabIndex = 3;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Font = new Font("Segoe UI", 12F);
            txtBoxSenha.Location = new Point(100, 170);
            txtBoxSenha.MaxLength = 60;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Digite sua senha";
            txtBoxSenha.Size = new Size(200, 34);
            txtBoxSenha.TabIndex = 4;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBoxMostrarSenha.Location = new Point(122, 210);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(155, 29);
            cBoxMostrarSenha.TabIndex = 5;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // cBoxLembrarDeMim
            // 
            cBoxLembrarDeMim.AutoSize = true;
            cBoxLembrarDeMim.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            cBoxLembrarDeMim.Location = new Point(101, 240);
            cBoxLembrarDeMim.Name = "cBoxLembrarDeMim";
            cBoxLembrarDeMim.Size = new Size(198, 29);
            cBoxLembrarDeMim.TabIndex = 6;
            cBoxLembrarDeMim.Text = "Manter sessão ativa";
            cBoxLembrarDeMim.UseVisualStyleBackColor = true;
            cBoxLembrarDeMim.CheckedChanged += cBoxLembrarDeMim_CheckedChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(112, 325);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(175, 50);
            btnVoltar.TabIndex = 8;
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
            btnEntrar.Location = new Point(112, 270);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(175, 50);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // Notificacao
            // 
            Notificacao.Icon = (Icon)resources.GetObject("Notificacao.Icon");
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(400, 398);
            Controls.Add(btnVoltar);
            Controls.Add(btnEntrar);
            Controls.Add(cBoxLembrarDeMim);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - Support";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxSenha;
        private CheckBox cBoxMostrarSenha;
        private CheckBox cBoxLembrarDeMim;
        private Button btnVoltar;
        private Button btnEntrar;
        private NotifyIcon Notificacao;
    }
}