namespace HelpDeskPro
{
    partial class frmEditar
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditar));
            dgv = new DataGridView();
            btnSelecionar = new Button();
            btnApagar = new Button();
            btnVoltar = new Button();
            txtPesquisar = new TextBox();
            btnDetalhes = new Button();
            btnRelatorio = new Button();
            cmbResponsavel = new ComboBox();
            Notificacao = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
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
            dgv.Location = new Point(0, 0);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1020, 858);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dgv_CellContentClick;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            // 
            // btnSelecionar
            // 
            btnSelecionar.BackColor = Color.FromArgb(76, 175, 80);
            btnSelecionar.FlatAppearance.BorderSize = 0;
            btnSelecionar.FlatStyle = FlatStyle.Flat;
            btnSelecionar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelecionar.Image = (Image)resources.GetObject("btnSelecionar.Image");
            btnSelecionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelecionar.Location = new Point(1026, 90);
            btnSelecionar.Margin = new Padding(3, 4, 3, 4);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(200, 55);
            btnSelecionar.TabIndex = 11;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = false;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.FromArgb(255, 152, 0);
            btnApagar.FlatAppearance.BorderSize = 0;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagar.Image = (Image)resources.GetObject("btnApagar.Image");
            btnApagar.ImageAlign = ContentAlignment.MiddleLeft;
            btnApagar.Location = new Point(1026, 150);
            btnApagar.Margin = new Padding(3, 4, 3, 4);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(200, 55);
            btnApagar.TabIndex = 12;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(1026, 330);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(200, 55);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisar.Location = new Point(1026, 12);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Pesquisar Chamado...";
            txtPesquisar.Size = new Size(200, 34);
            txtPesquisar.TabIndex = 14;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnDetalhes
            // 
            btnDetalhes.BackColor = Color.FromArgb(0, 119, 204);
            btnDetalhes.FlatAppearance.BorderSize = 0;
            btnDetalhes.FlatStyle = FlatStyle.Flat;
            btnDetalhes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetalhes.Image = (Image)resources.GetObject("btnDetalhes.Image");
            btnDetalhes.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetalhes.Location = new Point(1026, 210);
            btnDetalhes.Margin = new Padding(3, 4, 3, 4);
            btnDetalhes.Name = "btnDetalhes";
            btnDetalhes.Size = new Size(200, 55);
            btnDetalhes.TabIndex = 21;
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
            btnRelatorio.Location = new Point(1026, 270);
            btnRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(200, 55);
            btnRelatorio.TabIndex = 22;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // cmbResponsavel
            // 
            cmbResponsavel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbResponsavel.FlatStyle = FlatStyle.Flat;
            cmbResponsavel.FormattingEnabled = true;
            cmbResponsavel.Items.AddRange(new object[] { "Todos" });
            cmbResponsavel.Location = new Point(1026, 50);
            cmbResponsavel.Name = "cmbResponsavel";
            cmbResponsavel.Size = new Size(200, 28);
            cmbResponsavel.TabIndex = 27;
            cmbResponsavel.SelectedIndexChanged += cmbResponsavel_SelectedIndexChanged;
            // 
            // Notificacao
            // 
            Notificacao.Icon = (Icon)resources.GetObject("Notificacao.Icon");
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(1238, 853);
            Controls.Add(cmbResponsavel);
            Controls.Add(btnRelatorio);
            Controls.Add(btnDetalhes);
            Controls.Add(txtPesquisar);
            Controls.Add(btnVoltar);
            Controls.Add(btnApagar);
            Controls.Add(btnSelecionar);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - Support";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Button btnSelecionar;
        private Button btnApagar;
        private Button btnVoltar;
        private TextBox txtPesquisar;
        private Button btnDetalhes;
        private Button btnRelatorio;
        private ComboBox cmbResponsavel;
        private NotifyIcon Notificacao;
    }
}