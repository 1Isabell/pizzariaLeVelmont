﻿namespace pizzariaLeVelmont
{
    partial class frmCadastrarPagamento
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
            this.pnlFuncionario = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.lblCadastrarPagamento = new System.Windows.Forms.Label();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.lblidCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTipoPagamento = new System.Windows.Forms.Label();
            this.lblidPagamento = new System.Windows.Forms.Label();
            this.txtidPagamento = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbTipoPagamento = new System.Windows.Forms.ComboBox();
            this.lblPreçoPagamento = new System.Windows.Forms.Label();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.pnlFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.pnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFuncionario
            // 
            this.pnlFuncionario.BackColor = System.Drawing.Color.White;
            this.pnlFuncionario.Controls.Add(this.btnLimpar);
            this.pnlFuncionario.Controls.Add(this.btnCadastrar);
            this.pnlFuncionario.Controls.Add(this.pctSair);
            this.pnlFuncionario.Controls.Add(this.lblCadastrarPagamento);
            this.pnlFuncionario.Controls.Add(this.pnlCadastro);
            this.pnlFuncionario.Location = new System.Drawing.Point(5, 5);
            this.pnlFuncionario.Name = "pnlFuncionario";
            this.pnlFuncionario.Size = new System.Drawing.Size(1220, 655);
            this.pnlFuncionario.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(108)))), ((int)(((byte)(97)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnLimpar.Location = new System.Drawing.Point(685, 558);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(185, 45);
            this.btnLimpar.TabIndex = 82;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(108)))), ((int)(((byte)(97)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnCadastrar.Location = new System.Drawing.Point(327, 558);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 45);
            this.btnCadastrar.TabIndex = 81;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // pctSair
            // 
            this.pctSair.BackColor = System.Drawing.Color.White;
            this.pctSair.Image = global::pizzariaLeVelmont.Properties.Resources.fechar;
            this.pctSair.Location = new System.Drawing.Point(1165, 0);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(55, 55);
            this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSair.TabIndex = 79;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click);
            // 
            // lblCadastrarPagamento
            // 
            this.lblCadastrarPagamento.BackColor = System.Drawing.Color.White;
            this.lblCadastrarPagamento.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblCadastrarPagamento.Location = new System.Drawing.Point(0, 0);
            this.lblCadastrarPagamento.Name = "lblCadastrarPagamento";
            this.lblCadastrarPagamento.Size = new System.Drawing.Size(1220, 55);
            this.lblCadastrarPagamento.TabIndex = 78;
            this.lblCadastrarPagamento.Text = "Cadastrar Pagamentos";
            this.lblCadastrarPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadastrarPagamento.UseMnemonic = false;
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(112)))));
            this.pnlCadastro.Controls.Add(this.txtPagamento);
            this.pnlCadastro.Controls.Add(this.lblPreçoPagamento);
            this.pnlCadastro.Controls.Add(this.cmbTipoPagamento);
            this.pnlCadastro.Controls.Add(this.lblidCliente);
            this.pnlCadastro.Controls.Add(this.textBox1);
            this.pnlCadastro.Controls.Add(this.lblTipoPagamento);
            this.pnlCadastro.Controls.Add(this.lblidPagamento);
            this.pnlCadastro.Controls.Add(this.txtidPagamento);
            this.pnlCadastro.Controls.Add(this.lblStatus);
            this.pnlCadastro.Controls.Add(this.cmbStatus);
            this.pnlCadastro.Location = new System.Drawing.Point(72, 109);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(1091, 403);
            this.pnlCadastro.TabIndex = 11;
            // 
            // lblidCliente
            // 
            this.lblidCliente.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblidCliente.Location = new System.Drawing.Point(76, 126);
            this.lblidCliente.Name = "lblidCliente";
            this.lblidCliente.Size = new System.Drawing.Size(113, 32);
            this.lblidCliente.TabIndex = 3;
            this.lblidCliente.Text = " Cliente:";
            this.lblidCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.textBox1.Location = new System.Drawing.Point(350, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 24);
            this.textBox1.TabIndex = 4;
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblTipoPagamento.Location = new System.Drawing.Point(71, 260);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(268, 32);
            this.lblTipoPagamento.TabIndex = 5;
            this.lblTipoPagamento.Text = "Tipo de Pagamento:";
            this.lblTipoPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblidPagamento
            // 
            this.lblidPagamento.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblidPagamento.Location = new System.Drawing.Point(71, 63);
            this.lblidPagamento.Name = "lblidPagamento";
            this.lblidPagamento.Size = new System.Drawing.Size(196, 32);
            this.lblidPagamento.TabIndex = 1;
            this.lblidPagamento.Text = "ID Pagamento:";
            this.lblidPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtidPagamento
            // 
            this.txtidPagamento.BackColor = System.Drawing.Color.White;
            this.txtidPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtidPagamento.Location = new System.Drawing.Point(350, 71);
            this.txtidPagamento.Name = "txtidPagamento";
            this.txtidPagamento.Size = new System.Drawing.Size(179, 24);
            this.txtidPagamento.TabIndex = 2;
            this.txtidPagamento.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblStatus.Location = new System.Drawing.Point(589, 66);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(88, 32);
            this.lblStatus.TabIndex = 54;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 23;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVADO"});
            this.cmbStatus.Location = new System.Drawing.Point(701, 66);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(202, 31);
            this.cmbStatus.TabIndex = 76;
            // 
            // cmbTipoPagamento
            // 
            this.cmbTipoPagamento.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPagamento.FormattingEnabled = true;
            this.cmbTipoPagamento.ItemHeight = 23;
            this.cmbTipoPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Pix",
            "Cartão de Crédito",
            "Cartão de Débito",
            "Cartão Vale-alimentação",
            "Cartão Refeição"});
            this.cmbTipoPagamento.Location = new System.Drawing.Point(350, 260);
            this.cmbTipoPagamento.Name = "cmbTipoPagamento";
            this.cmbTipoPagamento.Size = new System.Drawing.Size(553, 31);
            this.cmbTipoPagamento.TabIndex = 6;
            // 
            // lblPreçoPagamento
            // 
            this.lblPreçoPagamento.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreçoPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblPreçoPagamento.Location = new System.Drawing.Point(76, 196);
            this.lblPreçoPagamento.Name = "lblPreçoPagamento";
            this.lblPreçoPagamento.Size = new System.Drawing.Size(263, 32);
            this.lblPreçoPagamento.TabIndex = 7;
            this.lblPreçoPagamento.Text = "Peço do Pagamento:";
            this.lblPreçoPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPagamento
            // 
            this.txtPagamento.BackColor = System.Drawing.Color.White;
            this.txtPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtPagamento.Location = new System.Drawing.Point(350, 204);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(553, 24);
            this.txtPagamento.TabIndex = 8;
            // 
            // frmCadastrarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(55)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pnlFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarPagamento";
            this.Text = "formulario_Cadastrar_Pagamento";
            this.pnlFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFuncionario;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.Label lblCadastrarPagamento;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblTipoPagamento;
        private System.Windows.Forms.Label lblidPagamento;
        private System.Windows.Forms.TextBox txtidPagamento;
        private System.Windows.Forms.Label lblidCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbTipoPagamento;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.Label lblPreçoPagamento;
    }
}