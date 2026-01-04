namespace HelpDeskPro
{
    partial class frmMudarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMudarSenha));
            txtBoxSenhaNovamente = new TextBox();
            label4 = new Label();
            btnVoltar = new Button();
            btnAlterar = new Button();
            cBoxMostrarSenha = new CheckBox();
            txtBoxSenha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSenhaAtual = new TextBox();
            Notificacao = new NotifyIcon(components);
            SuspendLayout();
            // 
            // txtBoxSenhaNovamente
            // 
            txtBoxSenhaNovamente.Font = new Font("Segoe UI", 12F);
            txtBoxSenhaNovamente.Location = new Point(100, 240);
            txtBoxSenhaNovamente.MaxLength = 60;
            txtBoxSenhaNovamente.Name = "txtBoxSenhaNovamente";
            txtBoxSenhaNovamente.PlaceholderText = "Repita a nova senha";
            txtBoxSenhaNovamente.Size = new Size(200, 34);
            txtBoxSenhaNovamente.TabIndex = 29;
            txtBoxSenhaNovamente.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label4.Location = new Point(100, 210);
            label4.Name = "label4";
            label4.Size = new Size(178, 30);
            label4.TabIndex = 28;
            label4.Text = "Confirme Senha:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(112, 380);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(175, 55);
            btnVoltar.TabIndex = 27;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(0, 119, 204);
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(112, 320);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(175, 55);
            btnAlterar.TabIndex = 26;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cBoxMostrarSenha.Location = new Point(120, 280);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(159, 29);
            cBoxMostrarSenha.TabIndex = 25;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Font = new Font("Segoe UI", 12F);
            txtBoxSenha.Location = new Point(100, 170);
            txtBoxSenha.MaxLength = 60;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Crie uma nova senha";
            txtBoxSenha.Size = new Size(200, 34);
            txtBoxSenha.TabIndex = 24;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.Location = new Point(100, 140);
            label3.Name = "label3";
            label3.Size = new Size(133, 30);
            label3.TabIndex = 22;
            label3.Text = "Senha nova:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.Location = new Point(100, 70);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 21;
            label2.Text = "Senha atual:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(106, 10);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 20;
            label1.Text = "Alterar senha";
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaAtual.Location = new Point(100, 100);
            txtSenhaAtual.MaxLength = 60;
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.PlaceholderText = "Digite sua senha atual";
            txtSenhaAtual.Size = new Size(200, 34);
            txtSenhaAtual.TabIndex = 30;
            txtSenhaAtual.UseSystemPasswordChar = true;
            // 
            // Notificacao
            // 
            Notificacao.Icon = (Icon)resources.GetObject("Notificacao.Icon");
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmMudarSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(400, 473);
            Controls.Add(txtSenhaAtual);
            Controls.Add(txtBoxSenhaNovamente);
            Controls.Add(label4);
            Controls.Add(btnVoltar);
            Controls.Add(btnAlterar);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(txtBoxSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMudarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - Support";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxSenhaNovamente;
        private Label label4;
        private Button btnVoltar;
        private Button btnAlterar;
        private CheckBox cBoxMostrarSenha;
        private TextBox txtBoxSenha;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSenhaAtual;
        private NotifyIcon Notificacao;
    }
}