namespace pizzariaLeVelmont
{
    partial class frmPagamentoListar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFundoFuncionario = new System.Windows.Forms.Panel();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.cbStatusDesativo = new System.Windows.Forms.CheckBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lblListarPagamento = new System.Windows.Forms.Label();
            this.lblStatusPagamento = new System.Windows.Forms.Label();
            this.txtNomePagamento = new System.Windows.Forms.TextBox();
            this.lblNomePagamento = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvPagamento = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlFundoFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFundoFuncionario
            // 
            this.pnlFundoFuncionario.BackColor = System.Drawing.Color.White;
            this.pnlFundoFuncionario.Controls.Add(this.pctSair);
            this.pnlFundoFuncionario.Controls.Add(this.cbStatusDesativo);
            this.pnlFundoFuncionario.Controls.Add(this.chkAtivo);
            this.pnlFundoFuncionario.Controls.Add(this.lblListarPagamento);
            this.pnlFundoFuncionario.Controls.Add(this.lblStatusPagamento);
            this.pnlFundoFuncionario.Controls.Add(this.txtNomePagamento);
            this.pnlFundoFuncionario.Controls.Add(this.lblNomePagamento);
            this.pnlFundoFuncionario.Controls.Add(this.btnAlterar);
            this.pnlFundoFuncionario.Controls.Add(this.btnExcluir);
            this.pnlFundoFuncionario.Controls.Add(this.btnCadastrar);
            this.pnlFundoFuncionario.Controls.Add(this.dgvPagamento);
            this.pnlFundoFuncionario.Controls.Add(this.panel1);
            this.pnlFundoFuncionario.Controls.Add(this.pictureBox2);
            this.pnlFundoFuncionario.Location = new System.Drawing.Point(5, 5);
            this.pnlFundoFuncionario.Name = "pnlFundoFuncionario";
            this.pnlFundoFuncionario.Size = new System.Drawing.Size(1220, 655);
            this.pnlFundoFuncionario.TabIndex = 2;
            // 
            // pctSair
            // 
            this.pctSair.Image = global::pizzariaLeVelmont.Properties.Resources.fechar;
            this.pctSair.Location = new System.Drawing.Point(1163, 0);
            this.pctSair.Name = "pctSair";
            this.pctSair.Size = new System.Drawing.Size(55, 55);
            this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSair.TabIndex = 55;
            this.pctSair.TabStop = false;
            this.pctSair.Click += new System.EventHandler(this.pctSair_Click);
            // 
            // cbStatusDesativo
            // 
            this.cbStatusDesativo.AutoSize = true;
            this.cbStatusDesativo.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusDesativo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.cbStatusDesativo.Location = new System.Drawing.Point(1029, 75);
            this.cbStatusDesativo.Name = "cbStatusDesativo";
            this.cbStatusDesativo.Size = new System.Drawing.Size(141, 34);
            this.cbStatusDesativo.TabIndex = 54;
            this.cbStatusDesativo.Text = "Pendente";
            this.cbStatusDesativo.UseVisualStyleBackColor = true;
            this.cbStatusDesativo.CheckedChanged += new System.EventHandler(this.cbStatusDesativo_CheckedChanged);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.chkAtivo.Location = new System.Drawing.Point(885, 75);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(91, 34);
            this.chkAtivo.TabIndex = 53;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // lblListarPagamento
            // 
            this.lblListarPagamento.BackColor = System.Drawing.Color.White;
            this.lblListarPagamento.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblListarPagamento.Location = new System.Drawing.Point(5, 5);
            this.lblListarPagamento.Name = "lblListarPagamento";
            this.lblListarPagamento.Size = new System.Drawing.Size(1215, 50);
            this.lblListarPagamento.TabIndex = 2;
            this.lblListarPagamento.Text = "Listar Pagamento";
            this.lblListarPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblListarPagamento.UseMnemonic = false;
            // 
            // lblStatusPagamento
            // 
            this.lblStatusPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(108)))), ((int)(((byte)(97)))));
            this.lblStatusPagamento.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblStatusPagamento.Location = new System.Drawing.Point(729, 72);
            this.lblStatusPagamento.Name = "lblStatusPagamento";
            this.lblStatusPagamento.Size = new System.Drawing.Size(465, 42);
            this.lblStatusPagamento.TabIndex = 49;
            this.lblStatusPagamento.Text = "Status:";
            this.lblStatusPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomePagamento
            // 
            this.txtNomePagamento.BackColor = System.Drawing.Color.White;
            this.txtNomePagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtNomePagamento.Location = new System.Drawing.Point(106, 77);
            this.txtNomePagamento.Multiline = true;
            this.txtNomePagamento.Name = "txtNomePagamento";
            this.txtNomePagamento.Size = new System.Drawing.Size(505, 32);
            this.txtNomePagamento.TabIndex = 45;
            this.txtNomePagamento.TextChanged += new System.EventHandler(this.txtNomePagamento_TextChanged);
            // 
            // lblNomePagamento
            // 
            this.lblNomePagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(108)))), ((int)(((byte)(97)))));
            this.lblNomePagamento.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblNomePagamento.Location = new System.Drawing.Point(25, 72);
            this.lblNomePagamento.Name = "lblNomePagamento";
            this.lblNomePagamento.Size = new System.Drawing.Size(664, 42);
            this.lblNomePagamento.TabIndex = 46;
            this.lblNomePagamento.Text = "Nome:";
            this.lblNomePagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(108)))), ((int)(((byte)(97)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnAlterar.Location = new System.Drawing.Point(537, 588);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(185, 45);
            this.btnAlterar.TabIndex = 43;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(108)))), ((int)(((byte)(97)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnExcluir.Location = new System.Drawing.Point(807, 588);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(185, 45);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(108)))), ((int)(((byte)(97)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnCadastrar.Location = new System.Drawing.Point(234, 588);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 45);
            this.btnCadastrar.TabIndex = 42;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // dgvPagamento
            // 
            this.dgvPagamento.AllowUserToAddRows = false;
            this.dgvPagamento.AllowUserToDeleteRows = false;
            this.dgvPagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPagamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPagamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(112)))));
            this.dgvPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Yu Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagamento.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPagamento.EnableHeadersVisualStyles = false;
            this.dgvPagamento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.dgvPagamento.Location = new System.Drawing.Point(25, 115);
            this.dgvPagamento.Name = "dgvPagamento";
            this.dgvPagamento.RowHeadersVisible = false;
            this.dgvPagamento.RowTemplate.Height = 25;
            this.dgvPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamento.Size = new System.Drawing.Size(1170, 450);
            this.dgvPagamento.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(678, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pizzariaLeVelmont.Properties.Resources.btnCliente;
            this.pictureBox2.Location = new System.Drawing.Point(868, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // frmPagamentoListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(55)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pnlFundoFuncionario);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPagamentoListar";
            this.Text = "formulario_pagamento_listar";
            this.Load += new System.EventHandler(this.frmPagamentoListar_Load);
            this.pnlFundoFuncionario.ResumeLayout(false);
            this.pnlFundoFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundoFuncionario;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.CheckBox cbStatusDesativo;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label lblListarPagamento;
        private System.Windows.Forms.Label lblStatusPagamento;
        private System.Windows.Forms.TextBox txtNomePagamento;
        private System.Windows.Forms.Label lblNomePagamento;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvPagamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}