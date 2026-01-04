namespace HelpDeskPro.OpenCall.View.Chamado
{
    partial class frmCriar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriar));
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnVoltar = new Button();
            txtDescricao = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtTitulo = new TextBox();
            label2 = new Label();
            Notificacao = new NotifyIcon(components);
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 152, 0);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.Location = new Point(275, 400);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(55, 55);
            btnLimpar.TabIndex = 21;
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(76, 175, 80);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(80, 460);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(250, 50);
            btnSalvar.TabIndex = 20;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(80, 400);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(190, 55);
            btnVoltar.TabIndex = 19;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(80, 170);
            txtDescricao.MaxLength = 1000;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição do problema";
            txtDescricao.Size = new Size(250, 220);
            txtDescricao.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(82, 140);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 17;
            label3.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(94, 10);
            label1.Name = "label1";
            label1.Size = new Size(212, 37);
            label1.TabIndex = 16;
            label1.Text = "Novo chamado";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 12F);
            txtTitulo.Location = new Point(80, 100);
            txtTitulo.MaxLength = 60;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Resumo do problema";
            txtTitulo.Size = new Size(250, 34);
            txtTitulo.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(82, 70);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 14;
            label2.Text = "Título:";
            // 
            // Notificacao
            // 
            Notificacao.Icon = (Icon)resources.GetObject("Notificacao.Icon");
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmCriar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(400, 553);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(txtDescricao);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCriar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - OpenCall";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnVoltar;
        private TextBox txtDescricao;
        private Label label3;
        private Label label1;
        private TextBox txtTitulo;
        private Label label2;
        private NotifyIcon Notificacao;
    }
}