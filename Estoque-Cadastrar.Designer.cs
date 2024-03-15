namespace pizzariaLeVelmont
{
    partial class Estoque_Cadastrar
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
            this.pnlEstoque = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.mtbDataValidade = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeEstoque = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.pnlEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEstoque
            // 
            this.pnlEstoque.BackColor = System.Drawing.Color.White;
            this.pnlEstoque.Controls.Add(this.btnLimpar);
            this.pnlEstoque.Controls.Add(this.btnAlterar);
            this.pnlEstoque.Controls.Add(this.pctSair);
            this.pnlEstoque.Controls.Add(this.lblEstoque);
            this.pnlEstoque.Controls.Add(this.pnlCadastro);
            this.pnlEstoque.Location = new System.Drawing.Point(5, 5);
            this.pnlEstoque.Name = "pnlEstoque";
            this.pnlEstoque.Size = new System.Drawing.Size(1220, 655);
            this.pnlEstoque.TabIndex = 3;
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
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(108)))), ((int)(((byte)(97)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnAlterar.Location = new System.Drawing.Point(327, 558);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(185, 45);
            this.btnAlterar.TabIndex = 81;
            this.btnAlterar.Text = "CADASTRAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            // lblEstoque
            // 
            this.lblEstoque.BackColor = System.Drawing.Color.White;
            this.lblEstoque.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblEstoque.Location = new System.Drawing.Point(0, 0);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(1220, 55);
            this.lblEstoque.TabIndex = 78;
            this.lblEstoque.Text = "Cadastro de Estoque";
            this.lblEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstoque.UseMnemonic = false;
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(112)))));
            this.pnlCadastro.Controls.Add(this.nudQuantidade);
            this.pnlCadastro.Controls.Add(this.lblQuantidade);
            this.pnlCadastro.Controls.Add(this.lblNomeFornecedor);
            this.pnlCadastro.Controls.Add(this.lblStatus);
            this.pnlCadastro.Controls.Add(this.lblCategoria);
            this.pnlCadastro.Controls.Add(this.cmbStatus);
            this.pnlCadastro.Controls.Add(this.cmbCategoria);
            this.pnlCadastro.Controls.Add(this.mtbDataValidade);
            this.pnlCadastro.Controls.Add(this.lblValor);
            this.pnlCadastro.Controls.Add(this.lblData);
            this.pnlCadastro.Controls.Add(this.txtValor);
            this.pnlCadastro.Controls.Add(this.lblNome);
            this.pnlCadastro.Controls.Add(this.txtNomeEstoque);
            this.pnlCadastro.Controls.Add(this.txtNomeFornecedor);
            this.pnlCadastro.Location = new System.Drawing.Point(72, 109);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(1091, 403);
            this.pnlCadastro.TabIndex = 11;
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblNomeFornecedor.Location = new System.Drawing.Point(108, 85);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(277, 32);
            this.lblNomeFornecedor.TabIndex = 62;
            this.lblNomeFornecedor.Text = "Nome do Fornecedor:";
            this.lblNomeFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblStatus.Location = new System.Drawing.Point(425, 264);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(88, 27);
            this.lblStatus.TabIndex = 54;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblCategoria.Location = new System.Drawing.Point(425, 173);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(138, 32);
            this.lblCategoria.TabIndex = 48;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 23;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "DESATIVADO"});
            this.cmbStatus.Location = new System.Drawing.Point(430, 294);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(252, 31);
            this.cmbStatus.TabIndex = 76;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.ItemHeight = 23;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Bebidas",
            "Ingredientes para Massa",
            "Sabores de Pizza",
            "Ingredientes Gerais",
            "Materiais de Embalagem",
            "Materiais de Serviço",
            "Materiais de Higiene"});
            this.cmbCategoria.Location = new System.Drawing.Point(430, 208);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(252, 31);
            this.cmbCategoria.TabIndex = 66;
            // 
            // mtbDataValidade
            // 
            this.mtbDataValidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtbDataValidade.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataValidade.Location = new System.Drawing.Point(783, 208);
            this.mtbDataValidade.Mask = "00/00/0000";
            this.mtbDataValidade.Name = "mtbDataValidade";
            this.mtbDataValidade.Size = new System.Drawing.Size(197, 31);
            this.mtbDataValidade.TabIndex = 72;
            this.mtbDataValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbDataValidade.ValidatingType = typeof(System.DateTime);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblValor.Location = new System.Drawing.Point(108, 264);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(192, 32);
            this.lblValor.TabIndex = 44;
            this.lblValor.Text = "Valor Unitário:";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblData.Location = new System.Drawing.Point(763, 173);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(217, 32);
            this.lblData.TabIndex = 42;
            this.lblData.Text = "Data Válidade:";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtValor.Location = new System.Drawing.Point(113, 299);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(226, 31);
            this.txtValor.TabIndex = 43;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblNome.Location = new System.Drawing.Point(89, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(277, 32);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Produto:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeEstoque
            // 
            this.txtNomeEstoque.BackColor = System.Drawing.Color.White;
            this.txtNomeEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtNomeEstoque.Location = new System.Drawing.Point(113, 48);
            this.txtNomeEstoque.Name = "txtNomeEstoque";
            this.txtNomeEstoque.Size = new System.Drawing.Size(867, 31);
            this.txtNomeEstoque.TabIndex = 0;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.BackColor = System.Drawing.Color.White;
            this.txtNomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtNomeFornecedor.Location = new System.Drawing.Point(113, 120);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(867, 31);
            this.txtNomeFornecedor.TabIndex = 63;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblQuantidade.Location = new System.Drawing.Point(89, 173);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(192, 32);
            this.lblQuantidade.TabIndex = 82;
            this.lblQuantidade.Text = "Quantidade:";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantidade.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.Location = new System.Drawing.Point(113, 208);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(226, 29);
            this.nudQuantidade.TabIndex = 83;
            // 
            // Estoque_Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(55)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pnlEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque_Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque_Cadastrar";
            this.Load += new System.EventHandler(this.Estoque_Cadastrar_Load);
            this.pnlEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEstoque;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.MaskedTextBox mtbDataValidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeEstoque;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
    }
}