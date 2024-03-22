namespace pizzariaLeVelmont
{
    partial class frmClienteCadastrar
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
            this.pnlClienteCad = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.pnlCadastroCliente = new System.Windows.Forms.Panel();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.mkbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mkbDataNascCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.pnlClienteCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.pnlCadastroCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClienteCad
            // 
            this.pnlClienteCad.BackColor = System.Drawing.Color.White;
            this.pnlClienteCad.Controls.Add(this.btnLimpar);
            this.pnlClienteCad.Controls.Add(this.btnCadastrar);
            this.pnlClienteCad.Controls.Add(this.pctSair);
            this.pnlClienteCad.Controls.Add(this.lblFuncionario);
            this.pnlClienteCad.Controls.Add(this.pnlCadastroCliente);
            this.pnlClienteCad.Location = new System.Drawing.Point(5, 5);
            this.pnlClienteCad.Name = "pnlClienteCad";
            this.pnlClienteCad.Size = new System.Drawing.Size(1220, 655);
            this.pnlClienteCad.TabIndex = 3;
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
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            // lblFuncionario
            // 
            this.lblFuncionario.BackColor = System.Drawing.Color.White;
            this.lblFuncionario.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblFuncionario.Location = new System.Drawing.Point(0, 0);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(1220, 55);
            this.lblFuncionario.TabIndex = 78;
            this.lblFuncionario.Text = "Cadastro de Cliente";
            this.lblFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFuncionario.UseMnemonic = false;
            // 
            // pnlCadastroCliente
            // 
            this.pnlCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(112)))));
            this.pnlCadastroCliente.Controls.Add(this.lblEndereco);
            this.pnlCadastroCliente.Controls.Add(this.lblStatus);
            this.pnlCadastroCliente.Controls.Add(this.cmbStatus);
            this.pnlCadastroCliente.Controls.Add(this.mkbTelefone);
            this.pnlCadastroCliente.Controls.Add(this.mkbDataNascCliente);
            this.pnlCadastroCliente.Controls.Add(this.lblDataNasc);
            this.pnlCadastroCliente.Controls.Add(this.lblTelefone);
            this.pnlCadastroCliente.Controls.Add(this.lblNome);
            this.pnlCadastroCliente.Controls.Add(this.txtNomeCliente);
            this.pnlCadastroCliente.Controls.Add(this.txtEndereco);
            this.pnlCadastroCliente.Location = new System.Drawing.Point(72, 109);
            this.pnlCadastroCliente.Name = "pnlCadastroCliente";
            this.pnlCadastroCliente.Size = new System.Drawing.Size(1091, 403);
            this.pnlCadastroCliente.TabIndex = 11;
            // 
            // lblEndereco
            // 
            this.lblEndereco.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblEndereco.Location = new System.Drawing.Point(80, 256);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(157, 32);
            this.lblEndereco.TabIndex = 62;
            this.lblEndereco.Text = "Endereço:";
            this.lblEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblStatus.Location = new System.Drawing.Point(789, 152);
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
            this.cmbStatus.Location = new System.Drawing.Point(715, 187);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(237, 31);
            this.cmbStatus.TabIndex = 76;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // mkbTelefone
            // 
            this.mkbTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mkbTelefone.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbTelefone.Location = new System.Drawing.Point(386, 187);
            this.mkbTelefone.Mask = "(99)0000-00000";
            this.mkbTelefone.Name = "mkbTelefone";
            this.mkbTelefone.Size = new System.Drawing.Size(272, 31);
            this.mkbTelefone.TabIndex = 77;
            this.mkbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mkbDataNascCliente
            // 
            this.mkbDataNascCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mkbDataNascCliente.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbDataNascCliente.Location = new System.Drawing.Point(86, 187);
            this.mkbDataNascCliente.Mask = "00/00/0000";
            this.mkbDataNascCliente.Name = "mkbDataNascCliente";
            this.mkbDataNascCliente.Size = new System.Drawing.Size(225, 31);
            this.mkbDataNascCliente.TabIndex = 72;
            this.mkbDataNascCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkbDataNascCliente.ValidatingType = typeof(System.DateTime);
            this.mkbDataNascCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mkbDataNasc_KeyPress);
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblDataNasc.Location = new System.Drawing.Point(118, 152);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(144, 32);
            this.lblDataNasc.TabIndex = 42;
            this.lblDataNasc.Text = "Data Nasc:";
            this.lblDataNasc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblTelefone.Location = new System.Drawing.Point(452, 152);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(137, 32);
            this.lblTelefone.TabIndex = 58;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblNome.Location = new System.Drawing.Point(80, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(157, 32);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome :";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.White;
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtNomeCliente.Location = new System.Drawing.Point(85, 93);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(867, 31);
            this.txtNomeCliente.TabIndex = 0;
            this.txtNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCliente_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtEndereco.Location = new System.Drawing.Point(85, 291);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(867, 31);
            this.txtEndereco.TabIndex = 63;
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            // 
            // frmClienteCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(55)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pnlClienteCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClienteCadastrar";
            this.Text = "Cliente_Cadastrar";
            this.Load += new System.EventHandler(this.frmClienteCadastrar_Load);
            this.pnlClienteCad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.pnlCadastroCliente.ResumeLayout(false);
            this.pnlCadastroCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClienteCad;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Panel pnlCadastroCliente;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.MaskedTextBox mkbTelefone;
        private System.Windows.Forms.MaskedTextBox mkbDataNascCliente;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtEndereco;
    }
}