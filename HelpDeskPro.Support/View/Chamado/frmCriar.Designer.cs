namespace HelpDeskPro
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
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btnAnexar = new Button();
            txtDescricao = new TextBox();
            label3 = new Label();
            txtTitulo = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            btnVoltar = new Button();
            btnConcluir = new Button();
            cmbResponsavel = new ComboBox();
            btnSalvar = new Button();
            label4 = new Label();
            btnLimpar = new Button();
            label6 = new Label();
            label7 = new Label();
            cmbCategoria = new ComboBox();
            label5 = new Label();
            cmbStatus = new ComboBox();
            cmbPrioridade = new ComboBox();
            OFD = new OpenFileDialog();
            Notificacao = new NotifyIcon(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(298, 10);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 24;
            label1.Text = "Criar chamado";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAnexar);
            panel3.Controls.Add(txtDescricao);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtTitulo);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 528);
            panel3.TabIndex = 2;
            // 
            // btnAnexar
            // 
            btnAnexar.BackColor = Color.Gray;
            btnAnexar.Enabled = false;
            btnAnexar.FlatAppearance.BorderSize = 0;
            btnAnexar.FlatStyle = FlatStyle.Flat;
            btnAnexar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnAnexar.Image = (Image)resources.GetObject("btnAnexar.Image");
            btnAnexar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnexar.Location = new Point(75, 410);
            btnAnexar.Margin = new Padding(3, 4, 3, 4);
            btnAnexar.Name = "btnAnexar";
            btnAnexar.Size = new Size(250, 55);
            btnAnexar.TabIndex = 34;
            btnAnexar.Text = "Anexar imagem";
            btnAnexar.UseVisualStyleBackColor = false;
            btnAnexar.Click += btnAnexar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(75, 110);
            txtDescricao.MaxLength = 1000;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descreva o problema com mais detalhes";
            txtDescricao.Size = new Size(250, 295);
            txtDescricao.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.Location = new Point(75, 80);
            label3.Name = "label3";
            label3.Size = new Size(246, 30);
            label3.TabIndex = 25;
            label3.Text = "Descrição do problema:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 12F);
            txtTitulo.Location = new Point(75, 40);
            txtTitulo.MaxLength = 60;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "Resumo do problema";
            txtTitulo.Size = new Size(250, 34);
            txtTitulo.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.Location = new Point(75, 10);
            label2.Name = "label2";
            label2.Size = new Size(204, 30);
            label2.TabIndex = 22;
            label2.Text = "Título do chamado:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnVoltar);
            panel4.Controls.Add(btnConcluir);
            panel4.Controls.Add(cmbResponsavel);
            panel4.Controls.Add(btnSalvar);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btnLimpar);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(cmbCategoria);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(cmbStatus);
            panel4.Controls.Add(cmbPrioridade);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(400, 55);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 528);
            panel4.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(75, 290);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(185, 55);
            btnVoltar.TabIndex = 27;
            btnVoltar.Text = "Cancelar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnConcluir
            // 
            btnConcluir.BackColor = Color.FromArgb(76, 175, 80);
            btnConcluir.FlatAppearance.BorderSize = 0;
            btnConcluir.FlatStyle = FlatStyle.Flat;
            btnConcluir.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnConcluir.Image = (Image)resources.GetObject("btnConcluir.Image");
            btnConcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnConcluir.Location = new Point(75, 410);
            btnConcluir.Margin = new Padding(3, 4, 3, 4);
            btnConcluir.Name = "btnConcluir";
            btnConcluir.Size = new Size(250, 55);
            btnConcluir.TabIndex = 31;
            btnConcluir.Text = "Concluir";
            btnConcluir.UseVisualStyleBackColor = false;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // cmbResponsavel
            // 
            cmbResponsavel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResponsavel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbResponsavel.FormattingEnabled = true;
            cmbResponsavel.Location = new Point(75, 250);
            cmbResponsavel.Name = "cmbResponsavel";
            cmbResponsavel.Size = new Size(250, 31);
            cmbResponsavel.TabIndex = 39;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(76, 175, 80);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(75, 350);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(250, 55);
            btnSalvar.TabIndex = 28;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label4.Location = new Point(75, 10);
            label4.Name = "label4";
            label4.Size = new Size(114, 30);
            label4.TabIndex = 35;
            label4.Text = "Categoria:";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(255, 152, 0);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.Location = new Point(264, 290);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(60, 55);
            btnLimpar.TabIndex = 29;
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label6.Location = new Point(75, 150);
            label6.Name = "label6";
            label6.Size = new Size(78, 30);
            label6.TabIndex = 37;
            label6.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label7.Location = new Point(75, 220);
            label7.Name = "label7";
            label7.Size = new Size(140, 30);
            label7.TabIndex = 38;
            label7.Text = "Responsável:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Adicionar no futuro..." });
            cmbCategoria.Location = new Point(75, 40);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(250, 31);
            cmbCategoria.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label5.Location = new Point(75, 80);
            label5.Name = "label5";
            label5.Size = new Size(121, 30);
            label5.TabIndex = 36;
            label5.Text = "Prioridade:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Aberto", "Em Andamento", "Resolvido" });
            cmbStatus.Location = new Point(75, 180);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 31);
            cmbStatus.TabIndex = 30;
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridade.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Items.AddRange(new object[] { "Baixo", "Médio", "Alto", "Urgente" });
            cmbPrioridade.Location = new Point(75, 110);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(250, 31);
            cmbPrioridade.TabIndex = 33;
            // 
            // OFD
            // 
            OFD.Multiselect = true;
            OFD.RestoreDirectory = true;
            OFD.Title = "Selecionar imagem";
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
            ClientSize = new Size(800, 583);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCriar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - Support";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private ComboBox cmbResponsavel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnAnexar;
        private Label label7;
        private ComboBox cmbPrioridade;
        private ComboBox cmbCategoria;
        private Button btnConcluir;
        private ComboBox cmbStatus;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnVoltar;
        private TextBox txtDescricao;
        private Label label3;
        private TextBox txtTitulo;
        private Label label2;
        private OpenFileDialog OFD;
        private NotifyIcon Notificacao;
    }
}