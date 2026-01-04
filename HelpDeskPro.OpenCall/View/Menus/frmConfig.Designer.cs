namespace HelpDeskPro.OpenCall.View.Menus
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            btnAvaliacao = new Button();
            btnMudarSenha = new Button();
            label1 = new Label();
            btnVoltar = new Button();
            btnTrocarConta = new Button();
            SuspendLayout();
            // 
            // btnAvaliacao
            // 
            btnAvaliacao.BackColor = Color.FromArgb(0, 119, 204);
            btnAvaliacao.FlatAppearance.BorderSize = 0;
            btnAvaliacao.FlatStyle = FlatStyle.Flat;
            btnAvaliacao.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnAvaliacao.Image = (Image)resources.GetObject("btnAvaliacao.Image");
            btnAvaliacao.ImageAlign = ContentAlignment.MiddleLeft;
            btnAvaliacao.Location = new Point(65, 190);
            btnAvaliacao.Margin = new Padding(3, 4, 3, 4);
            btnAvaliacao.Name = "btnAvaliacao";
            btnAvaliacao.Size = new Size(230, 55);
            btnAvaliacao.TabIndex = 18;
            btnAvaliacao.Text = "Avaliação";
            btnAvaliacao.UseVisualStyleBackColor = false;
            btnAvaliacao.Click += btnAvaliacao_Click;
            // 
            // btnMudarSenha
            // 
            btnMudarSenha.BackColor = Color.FromArgb(0, 119, 204);
            btnMudarSenha.FlatAppearance.BorderSize = 0;
            btnMudarSenha.FlatStyle = FlatStyle.Flat;
            btnMudarSenha.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnMudarSenha.Image = (Image)resources.GetObject("btnMudarSenha.Image");
            btnMudarSenha.ImageAlign = ContentAlignment.MiddleLeft;
            btnMudarSenha.Location = new Point(65, 70);
            btnMudarSenha.Margin = new Padding(3, 4, 3, 4);
            btnMudarSenha.Name = "btnMudarSenha";
            btnMudarSenha.Size = new Size(230, 55);
            btnMudarSenha.TabIndex = 17;
            btnMudarSenha.Text = "Alterar Senha";
            btnMudarSenha.UseVisualStyleBackColor = false;
            btnMudarSenha.Click += btnMudarSenha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(79, 10);
            label1.Name = "label1";
            label1.Size = new Size(201, 37);
            label1.TabIndex = 16;
            label1.Text = "Configurações";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(65, 250);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(230, 55);
            btnVoltar.TabIndex = 15;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnTrocarConta
            // 
            btnTrocarConta.BackColor = Color.FromArgb(0, 119, 204);
            btnTrocarConta.FlatAppearance.BorderSize = 0;
            btnTrocarConta.FlatStyle = FlatStyle.Flat;
            btnTrocarConta.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnTrocarConta.Image = (Image)resources.GetObject("btnTrocarConta.Image");
            btnTrocarConta.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrocarConta.Location = new Point(65, 130);
            btnTrocarConta.Margin = new Padding(3, 4, 3, 4);
            btnTrocarConta.Name = "btnTrocarConta";
            btnTrocarConta.Size = new Size(230, 55);
            btnTrocarConta.TabIndex = 14;
            btnTrocarConta.Text = "Trocar Conta";
            btnTrocarConta.UseVisualStyleBackColor = false;
            btnTrocarConta.Click += btnTrocarConta_Click;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(360, 343);
            Controls.Add(btnAvaliacao);
            Controls.Add(btnMudarSenha);
            Controls.Add(label1);
            Controls.Add(btnVoltar);
            Controls.Add(btnTrocarConta);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - OpenCall";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAvaliacao;
        private Button btnMudarSenha;
        private Label label1;
        private Button btnVoltar;
        private Button btnTrocarConta;
    }
}