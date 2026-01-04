namespace HelpDeskPro.Support.View.Chamado
{
    partial class frmDetalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalhes));
            panel1 = new Panel();
            btnVoltar = new Button();
            btnGerarRelatorio = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label10 = new Label();
            txtPriporidade = new TextBox();
            label3 = new Label();
            label9 = new Label();
            txtDataAbertura = new TextBox();
            txtStatus = new TextBox();
            label6 = new Label();
            label8 = new Label();
            txtDataResolvido = new TextBox();
            txtAdmin = new TextBox();
            label7 = new Label();
            label4 = new Label();
            txtCliente = new TextBox();
            panel4 = new Panel();
            btnAnexar = new Button();
            txtTitulo = new TextBox();
            label5 = new Label();
            txtDescricao = new TextBox();
            label2 = new Label();
            Notificacao = new NotifyIcon(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnGerarRelatorio);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 647);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 106);
            panel1.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(400, 20);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(200, 55);
            btnVoltar.TabIndex = 69;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.BackColor = Color.FromArgb(0, 119, 204);
            btnGerarRelatorio.FlatAppearance.BorderSize = 0;
            btnGerarRelatorio.FlatStyle = FlatStyle.Flat;
            btnGerarRelatorio.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnGerarRelatorio.Image = (Image)resources.GetObject("btnGerarRelatorio.Image");
            btnGerarRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerarRelatorio.Location = new Point(195, 20);
            btnGerarRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(200, 55);
            btnGerarRelatorio.TabIndex = 68;
            btnGerarRelatorio.Text = "Gerar PDF";
            btnGerarRelatorio.UseVisualStyleBackColor = false;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 59);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(250, 10);
            label1.Name = "label1";
            label1.Size = new Size(299, 37);
            label1.TabIndex = 64;
            label1.Text = "Detalhes do Chamado";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtPriporidade);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtDataAbertura);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtDataResolvido);
            panel3.Controls.Add(txtAdmin);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtCliente);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(400, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 588);
            panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(75, 325);
            textBox1.MaxLength = 60;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Selecione uma categoria";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 84;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label10.Location = new Point(75, 290);
            label10.Name = "label10";
            label10.Size = new Size(126, 32);
            label10.TabIndex = 83;
            label10.Text = "Categoria:";
            // 
            // txtPriporidade
            // 
            txtPriporidade.Enabled = false;
            txtPriporidade.Font = new Font("Segoe UI", 12F);
            txtPriporidade.Location = new Point(75, 395);
            txtPriporidade.MaxLength = 60;
            txtPriporidade.Name = "txtPriporidade";
            txtPriporidade.PlaceholderText = "Defina a prioridade";
            txtPriporidade.ReadOnly = true;
            txtPriporidade.Size = new Size(250, 34);
            txtPriporidade.TabIndex = 82;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(75, 10);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 66;
            label3.Text = "Criado em:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label9.Location = new Point(75, 360);
            label9.Name = "label9";
            label9.Size = new Size(132, 32);
            label9.TabIndex = 81;
            label9.Text = "Prioridade:";
            // 
            // txtDataAbertura
            // 
            txtDataAbertura.Enabled = false;
            txtDataAbertura.Font = new Font("Segoe UI", 12F);
            txtDataAbertura.Location = new Point(75, 45);
            txtDataAbertura.MaxLength = 60;
            txtDataAbertura.Name = "txtDataAbertura";
            txtDataAbertura.PlaceholderText = "Data de criação do chamado";
            txtDataAbertura.ReadOnly = true;
            txtDataAbertura.Size = new Size(250, 34);
            txtDataAbertura.TabIndex = 72;
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Segoe UI", 12F);
            txtStatus.Location = new Point(75, 465);
            txtStatus.MaxLength = 60;
            txtStatus.Name = "txtStatus";
            txtStatus.PlaceholderText = "Situação atual do chamado";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(250, 34);
            txtStatus.TabIndex = 80;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label6.Location = new Point(75, 80);
            label6.Name = "label6";
            label6.Size = new Size(170, 32);
            label6.TabIndex = 73;
            label6.Text = "Finalizado em:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label8.Location = new Point(75, 430);
            label8.Name = "label8";
            label8.Size = new Size(87, 32);
            label8.TabIndex = 79;
            label8.Text = "Status:";
            // 
            // txtDataResolvido
            // 
            txtDataResolvido.Enabled = false;
            txtDataResolvido.Font = new Font("Segoe UI", 12F);
            txtDataResolvido.Location = new Point(75, 115);
            txtDataResolvido.MaxLength = 60;
            txtDataResolvido.Name = "txtDataResolvido";
            txtDataResolvido.PlaceholderText = "Ainda não finalizado";
            txtDataResolvido.ReadOnly = true;
            txtDataResolvido.Size = new Size(250, 34);
            txtDataResolvido.TabIndex = 74;
            // 
            // txtAdmin
            // 
            txtAdmin.Enabled = false;
            txtAdmin.Font = new Font("Segoe UI", 12F);
            txtAdmin.Location = new Point(75, 255);
            txtAdmin.MaxLength = 60;
            txtAdmin.Name = "txtAdmin";
            txtAdmin.PlaceholderText = "Técnico responsável";
            txtAdmin.ReadOnly = true;
            txtAdmin.Size = new Size(250, 34);
            txtAdmin.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label7.Location = new Point(75, 150);
            label7.Name = "label7";
            label7.Size = new Size(136, 32);
            label7.TabIndex = 75;
            label7.Text = "Criado por:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.Location = new Point(75, 220);
            label4.Name = "label4";
            label4.Size = new Size(153, 32);
            label4.TabIndex = 77;
            label4.Text = "Responsável:";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Font = new Font("Segoe UI", 12F);
            txtCliente.Location = new Point(75, 185);
            txtCliente.MaxLength = 60;
            txtCliente.Name = "txtCliente";
            txtCliente.PlaceholderText = "Usuário solicitante";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(250, 34);
            txtCliente.TabIndex = 76;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnAnexar);
            panel4.Controls.Add(txtTitulo);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtDescricao);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 588);
            panel4.TabIndex = 3;
            // 
            // btnAnexar
            // 
            btnAnexar.BackColor = Color.Gray;
            btnAnexar.FlatAppearance.BorderSize = 0;
            btnAnexar.FlatStyle = FlatStyle.Flat;
            btnAnexar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnAnexar.Image = (Image)resources.GetObject("btnAnexar.Image");
            btnAnexar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnexar.Location = new Point(75, 495);
            btnAnexar.Margin = new Padding(3, 4, 3, 4);
            btnAnexar.Name = "btnAnexar";
            btnAnexar.Size = new Size(250, 55);
            btnAnexar.TabIndex = 72;
            btnAnexar.Text = "Imagem anexada";
            btnAnexar.UseVisualStyleBackColor = false;
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Font = new Font("Segoe UI", 12F);
            txtTitulo.Location = new Point(75, 40);
            txtTitulo.MaxLength = 60;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Ex: Erro ao acessar o sistema";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(250, 34);
            txtTitulo.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.Location = new Point(75, 10);
            label5.Name = "label5";
            label5.Size = new Size(218, 32);
            label5.TabIndex = 70;
            label5.Text = "Título do chamado";
            // 
            // txtDescricao
            // 
            txtDescricao.Enabled = false;
            txtDescricao.Font = new Font("Segoe UI", 12F);
            txtDescricao.Location = new Point(75, 110);
            txtDescricao.MaxLength = 1000;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descreva o problema com o máximo de detalhes possível";
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new Size(250, 379);
            txtDescricao.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(75, 80);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 65;
            label2.Text = "Descrição";
            // 
            // Notificacao
            // 
            Notificacao.Icon = (Icon)resources.GetObject("Notificacao.Icon");
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmDetalhes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(800, 753);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmDetalhes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - Support";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVoltar;
        private Button btnGerarRelatorio;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox txtPriporidade;
        private Label label3;
        private Label label9;
        private TextBox txtDataAbertura;
        private TextBox txtStatus;
        private Label label6;
        private Label label8;
        private TextBox txtDataResolvido;
        private TextBox txtAdmin;
        private Label label7;
        private Label label4;
        private TextBox txtCliente;
        private Panel panel4;
        private TextBox txtTitulo;
        private Label label5;
        private TextBox txtDescricao;
        private Label label2;
        private Button btnAnexar;
        private TextBox textBox1;
        private Label label10;
        private NotifyIcon Notificacao;
    }
}