namespace HelpDeskPro
{
    partial class frmAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvaliacao));
            btnSalvar = new Button();
            btnVoltar = new Button();
            txtDescricao = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtNota = new TextBox();
            label2 = new Label();
            Notificacao = new NotifyIcon(components);
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(76, 175, 80);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(122, 330);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(155, 55);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "Enviar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(122, 390);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(155, 55);
            btnVoltar.TabIndex = 18;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 12F);
            txtDescricao.Location = new Point(75, 170);
            txtDescricao.MaxLength = 600;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Insira uma descrição...";
            txtDescricao.Size = new Size(250, 150);
            txtDescricao.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.Location = new Point(75, 140);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 16;
            label3.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(38, 10);
            label1.Name = "label1";
            label1.Size = new Size(323, 35);
            label1.TabIndex = 15;
            label1.Text = "Como foi sua experiência?";
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Segoe UI", 12F);
            txtNota.Location = new Point(75, 100);
            txtNota.MaxLength = 1;
            txtNota.Name = "txtNota";
            txtNota.PlaceholderText = "Digite uma nota de 0 a 5";
            txtNota.Size = new Size(250, 34);
            txtNota.TabIndex = 14;
            txtNota.KeyPress += txtNota_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.Location = new Point(75, 70);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 13;
            label2.Text = "Nota: (0 - 5)";
            // 
            // Notificacao
            // 
            Notificacao.Icon = (Icon)resources.GetObject("Notificacao.Icon");
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmAvaliacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 247);
            ClientSize = new Size(400, 473);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(txtDescricao);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtNota);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAvaliacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HelpDesk Pro - Support";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalvar;
        private Button btnVoltar;
        private TextBox txtDescricao;
        private Label label3;
        private Label label1;
        private TextBox txtNota;
        private Label label2;
        private NotifyIcon Notificacao;
    }
}