namespace HelpDeskPro.OpenCall.View.Chamado
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
            panel2 = new Panel();
            label1 = new Label();
            btnVoltar = new Button();
            btnGerarRelatorio = new Button();
            panel4 = new Panel();
            txtTitulo = new TextBox();
            label5 = new Label();
            txtDescricao = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            txtDataAbertura = new TextBox();
            txtStatus = new TextBox();
            label6 = new Label();
            label8 = new Label();
            txtDataResolvido = new TextBox();
            Notificacao = new NotifyIcon(components);
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 59);
            panel2.TabIndex = 2;
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
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(75, 280);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(250, 55);
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
            btnGerarRelatorio.Location = new Point(75, 220);
            btnGerarRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(250, 55);
            btnGerarRelatorio.TabIndex = 68;
            btnGerarRelatorio.Text = "Gerar Relatório";
            btnGerarRelatorio.UseVisualStyleBackColor = false;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtTitulo);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtDescricao);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 494);
            panel4.TabIndex = 4;
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Font = new Font("Segoe UI", 12F);
            txtTitulo.Location = new Point(75, 40);
            txtTitulo.MaxLength = 60;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Título do chamado";
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
            label5.Size = new Size(76, 32);
            label5.TabIndex = 70;
            label5.Text = "Título";
            // 
            // txtDescricao
            // 
            txtDescricao.Enabled = false;
            txtDescricao.Font = new Font("Segoe UI", 12F);
            txtDescricao.Location = new Point(75, 110);
            txtDescricao.MaxLength = 1000;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new Size(250, 350);
            txtDescricao.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(75, 80);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 65;
            label2.Text = "Descrição:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnVoltar);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnGerarRelatorio);
            panel3.Controls.Add(txtDataAbertura);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtDataResolvido);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(400, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 494);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(75, 10);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 66;
            label3.Text = "Criado em";
            // 
            // txtDataAbertura
            // 
            txtDataAbertura.Enabled = false;
            txtDataAbertura.Font = new Font("Segoe UI", 12F);
            txtDataAbertura.Location = new Point(75, 40);
            txtDataAbertura.MaxLength = 60;
            txtDataAbertura.Name = "txtDataAbertura";
            txtDataAbertura.PlaceholderText = "Criado em";
            txtDataAbertura.ReadOnly = true;
            txtDataAbertura.Size = new Size(250, 34);
            txtDataAbertura.TabIndex = 72;
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Font = new Font("Segoe UI", 12F);
            txtStatus.Location = new Point(75, 180);
            txtStatus.MaxLength = 60;
            txtStatus.Name = "txtStatus";
            txtStatus.PlaceholderText = "Situação";
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
            label6.Size = new Size(164, 32);
            label6.TabIndex = 73;
            label6.Text = "Finalizado em";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label8.Location = new Point(75, 150);
            label8.Name = "label8";
            label8.Size = new Size(107, 32);
            label8.TabIndex = 79;
            label8.Text = "Situação";
            // 
            // txtDataResolvido
            // 
            txtDataResolvido.Enabled = false;
            txtDataResolvido.Font = new Font("Segoe UI", 12F);
            txtDataResolvido.Location = new Point(75, 110);
            txtDataResolvido.MaxLength = 60;
            txtDataResolvido.Name = "txtDataResolvido";
            txtDataResolvido.PlaceholderText = "Não Resolvido";
            txtDataResolvido.ReadOnly = true;
            txtDataResolvido.Size = new Size(250, 34);
            txtDataResolvido.TabIndex = 74;
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
            ClientSize = new Size(800, 553);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmDetalhes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - OpenCall";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button btnVoltar;
        private Button btnGerarRelatorio;
        private Panel panel4;
        private TextBox txtTitulo;
        private Label label5;
        private TextBox txtDescricao;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private TextBox txtDataAbertura;
        private TextBox txtStatus;
        private Label label6;
        private Label label8;
        private TextBox txtDataResolvido;
        private NotifyIcon Notificacao;
    }
}