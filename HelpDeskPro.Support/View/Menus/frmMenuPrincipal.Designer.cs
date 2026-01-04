namespace HelpDeskPro
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCriar = new Button();
            btnEditar = new Button();
            btnHistorico = new Button();
            btnRelatorio = new Button();
            btnConfig = new Button();
            btnSair = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            cmbResponsavel = new ComboBox();
            label3 = new Label();
            lblData = new Label();
            cBoxFiltro = new ComboBox();
            panel5 = new Panel();
            lblResolvidos = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblAndamento = new Label();
            label6 = new Label();
            panel3 = new Panel();
            lblAberto = new Label();
            label8 = new Label();
            panel6 = new Panel();
            lblTotal = new Label();
            label1 = new Label();
            Notificacao = new NotifyIcon(components);
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCriar);
            flowLayoutPanel1.Controls.Add(btnEditar);
            flowLayoutPanel1.Controls.Add(btnHistorico);
            flowLayoutPanel1.Controls.Add(btnRelatorio);
            flowLayoutPanel1.Controls.Add(btnConfig);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 403);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.FromArgb(10, 116, 201);
            btnCriar.FlatAppearance.BorderSize = 0;
            btnCriar.FlatStyle = FlatStyle.Flat;
            btnCriar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnCriar.Image = (Image)resources.GetObject("btnCriar.Image");
            btnCriar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCriar.Location = new Point(3, 4);
            btnCriar.Margin = new Padding(3, 4, 3, 4);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(250, 55);
            btnCriar.TabIndex = 9;
            btnCriar.Text = "Novo chamado";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 119, 204);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(3, 67);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(250, 55);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar chamados";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.FromArgb(0, 119, 204);
            btnHistorico.FlatAppearance.BorderSize = 0;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnHistorico.Image = (Image)resources.GetObject("btnHistorico.Image");
            btnHistorico.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorico.Location = new Point(3, 130);
            btnHistorico.Margin = new Padding(3, 4, 3, 4);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(250, 55);
            btnHistorico.TabIndex = 11;
            btnHistorico.Text = "Histórico";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.FromArgb(0, 119, 204);
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnRelatorio.Image = (Image)resources.GetObject("btnRelatorio.Image");
            btnRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorio.Location = new Point(3, 193);
            btnRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(250, 55);
            btnRelatorio.TabIndex = 14;
            btnRelatorio.Text = "Relatórios";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(0, 119, 204);
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(3, 256);
            btnConfig.Margin = new Padding(3, 4, 3, 4);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(250, 55);
            btnConfig.TabIndex = 12;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(181, 23, 30);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(3, 319);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(250, 55);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 403);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbResponsavel);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblData);
            panel2.Controls.Add(cBoxFiltro);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 403);
            panel2.TabIndex = 17;
            // 
            // cmbResponsavel
            // 
            cmbResponsavel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResponsavel.FlatStyle = FlatStyle.Flat;
            cmbResponsavel.FormattingEnabled = true;
            cmbResponsavel.Items.AddRange(new object[] { "Todos" });
            cmbResponsavel.Location = new Point(10, 46);
            cmbResponsavel.Name = "cmbResponsavel";
            cmbResponsavel.Size = new Size(150, 28);
            cmbResponsavel.TabIndex = 26;
            cmbResponsavel.SelectedIndexChanged += cmbResponsavel_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(198, 10);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 25;
            label3.Text = "Relatório de";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.ForeColor = Color.Black;
            lblData.Location = new Point(212, 40);
            lblData.Name = "lblData";
            lblData.Size = new Size(124, 31);
            lblData.TabIndex = 24;
            lblData.Text = "Dezembro";
            // 
            // cBoxFiltro
            // 
            cBoxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxFiltro.FlatStyle = FlatStyle.Flat;
            cBoxFiltro.FormattingEnabled = true;
            cBoxFiltro.Items.AddRange(new object[] { "Diário", "Semanal", "Mensal", "Todos" });
            cBoxFiltro.Location = new Point(10, 10);
            cBoxFiltro.Name = "cBoxFiltro";
            cBoxFiltro.Size = new Size(150, 28);
            cBoxFiltro.TabIndex = 23;
            cBoxFiltro.SelectedIndexChanged += cBoxFiltro_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(31, 31, 31);
            panel5.Controls.Add(lblResolvidos);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(280, 226);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 100);
            panel5.TabIndex = 22;
            // 
            // lblResolvidos
            // 
            lblResolvidos.AutoSize = true;
            lblResolvidos.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblResolvidos.ForeColor = Color.FromArgb(76, 175, 80);
            lblResolvidos.Location = new Point(98, 58);
            lblResolvidos.Name = "lblResolvidos";
            lblResolvidos.Size = new Size(33, 38);
            lblResolvidos.TabIndex = 13;
            lblResolvidos.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(76, 175, 80);
            label4.Location = new Point(39, 16);
            label4.Name = "label4";
            label4.Size = new Size(151, 38);
            label4.TabIndex = 12;
            label4.Text = "Resolvidos";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(31, 31, 31);
            panel4.Controls.Add(lblAndamento);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(40, 226);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 100);
            panel4.TabIndex = 21;
            // 
            // lblAndamento
            // 
            lblAndamento.AutoSize = true;
            lblAndamento.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblAndamento.ForeColor = Color.FromArgb(33, 150, 243);
            lblAndamento.Location = new Point(98, 54);
            lblAndamento.Name = "lblAndamento";
            lblAndamento.Size = new Size(33, 38);
            lblAndamento.TabIndex = 13;
            lblAndamento.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(33, 150, 243);
            label6.Location = new Point(7, 16);
            label6.Name = "label6";
            label6.Size = new Size(215, 38);
            label6.TabIndex = 12;
            label6.Text = "Em Andamento";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(31, 31, 31);
            panel3.Controls.Add(lblAberto);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(280, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 100);
            panel3.TabIndex = 20;
            // 
            // lblAberto
            // 
            lblAberto.AutoSize = true;
            lblAberto.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblAberto.ForeColor = Color.FromArgb(255, 152, 0);
            lblAberto.Location = new Point(98, 49);
            lblAberto.Name = "lblAberto";
            lblAberto.Size = new Size(33, 38);
            lblAberto.TabIndex = 13;
            lblAberto.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(255, 152, 0);
            label8.Location = new Point(62, 11);
            label8.Name = "label8";
            label8.Size = new Size(106, 38);
            label8.TabIndex = 12;
            label8.Text = "Aberto";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(31, 31, 31);
            panel6.Controls.Add(lblTotal);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(40, 120);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 100);
            panel6.TabIndex = 19;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(98, 49);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 38);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 11);
            label1.Name = "label1";
            label1.Size = new Size(78, 38);
            label1.TabIndex = 12;
            label1.Text = "Total";
            // 
            // Notificacao
            // 
            Notificacao.Icon = (Icon)resources.GetObject("Notificacao.Icon");
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(800, 403);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - Support";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCriar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnEditar;
        private Button btnHistorico;
        private Button btnConfig;
        private Button btnSair;
        private Panel panel1;
        private Button btnRelatorio;
        private Panel panel2;
        private Label label3;
        private Label lblData;
        private ComboBox cBoxFiltro;
        private Panel panel5;
        private Label lblResolvidos;
        private Label label4;
        private Panel panel4;
        private Label lblAndamento;
        private Label label6;
        private Panel panel3;
        private Label lblAberto;
        private Label label8;
        private Panel panel6;
        private Label lblTotal;
        private Label label1;
        private ComboBox cmbResponsavel;
        private NotifyIcon Notificacao;
    }
}