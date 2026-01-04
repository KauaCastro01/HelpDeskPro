namespace HelpDeskPro.OpenCall.View.Chamado
{
    partial class frmExibir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExibir));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txtPesquisar = new TextBox();
            btnVoltar = new Button();
            dgv = new DataGridView();
            btnDetalhes = new Button();
            btnRelatorio = new Button();
            Notificacao = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisar.Location = new Point(800, 10);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar Chamado...";
            txtPesquisar.Size = new Size(200, 34);
            txtPesquisar.TabIndex = 19;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(800, 160);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(200, 50);
            btnVoltar.TabIndex = 18;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(250, 251, 252);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(45, 52, 64);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(25, 25, 28);
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(252, 253, 254);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(45, 52, 64);
            dataGridViewCellStyle5.Padding = new Padding(12, 0, 12, 0);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(45, 52, 64);
            dataGridViewCellStyle6.Padding = new Padding(12, 0, 12, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(25, 25, 28);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle6;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromArgb(234, 236, 239);
            dgv.Location = new Point(6, -4);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(788, 660);
            dgv.TabIndex = 15;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // btnDetalhes
            // 
            btnDetalhes.BackColor = Color.FromArgb(0, 119, 204);
            btnDetalhes.FlatAppearance.BorderSize = 0;
            btnDetalhes.FlatStyle = FlatStyle.Flat;
            btnDetalhes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetalhes.Image = (Image)resources.GetObject("btnDetalhes.Image");
            btnDetalhes.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetalhes.Location = new Point(800, 50);
            btnDetalhes.Margin = new Padding(3, 4, 3, 4);
            btnDetalhes.Name = "btnDetalhes";
            btnDetalhes.Size = new Size(200, 50);
            btnDetalhes.TabIndex = 20;
            btnDetalhes.Text = "Detalhes";
            btnDetalhes.UseVisualStyleBackColor = false;
            btnDetalhes.Click += btnDetalhes_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.FromArgb(0, 119, 204);
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorio.Image = (Image)resources.GetObject("btnRelatorio.Image");
            btnRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorio.Location = new Point(800, 105);
            btnRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(200, 50);
            btnRelatorio.TabIndex = 21;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // Notificacao
            // 
            Notificacao.Icon = (Icon)resources.GetObject("Notificacao.Icon");
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmExibir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(1006, 653);
            Controls.Add(btnRelatorio);
            Controls.Add(btnDetalhes);
            Controls.Add(txtPesquisar);
            Controls.Add(btnVoltar);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmExibir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - OpenCall";
            Load += frmExibir_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisar;
        private Button btnVoltar;
        private DataGridView dgv;
        private Button btnDetalhes;
        private Button btnRelatorio;
        private NotifyIcon Notificacao;
    }
}