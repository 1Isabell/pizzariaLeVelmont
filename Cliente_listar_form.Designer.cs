namespace pizzariaLeVelmont
{
    partial class frmClientelistar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFundoCliente = new System.Windows.Forms.Panel();
            this.chkPendente = new System.Windows.Forms.CheckBox();
            this.pctSair = new System.Windows.Forms.PictureBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.lblListarCliente = new System.Windows.Forms.Label();
            this.lblStatusCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlFundoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFundoCliente
            // 
            this.pnlFundoCliente.BackColor = System.Drawing.Color.White;
            this.pnlFundoCliente.Controls.Add(this.chkPendente);
            this.pnlFundoCliente.Controls.Add(this.pctSair);
            this.pnlFundoCliente.Controls.Add(this.chkAtivo);
            this.pnlFundoCliente.Controls.Add(this.lblListarCliente);
            this.pnlFundoCliente.Controls.Add(this.lblStatusCliente);
            this.pnlFundoCliente.Controls.Add(this.txtNomeCliente);
            this.pnlFundoCliente.Controls.Add(this.lblNomeCliente);
            this.pnlFundoCliente.Controls.Add(this.btnAlterar);
            this.pnlFundoCliente.Controls.Add(this.btnExcluir);
            this.pnlFundoCliente.Controls.Add(this.btnCadastrar);
            this.pnlFundoCliente.Controls.Add(this.dgvCliente);
            this.pnlFundoCliente.Controls.Add(this.panel1);
            this.pnlFundoCliente.Controls.Add(this.pictureBox2);
            this.pnlFundoCliente.Location = new System.Drawing.Point(5, 5);
            this.pnlFundoCliente.Name = "pnlFundoCliente";
            this.pnlFundoCliente.Size = new System.Drawing.Size(1222, 648);
            this.pnlFundoCliente.TabIndex = 3;
            // 
            // chkPendente
            // 
            this.chkPendente.AutoSize = true;
            this.chkPendente.Font = new System.Drawing.Font("Britannic Bold", 20.25F);
            this.chkPendente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chkPendente.Location = new System.Drawing.Point(1032, 75);
            this.chkPendente.Name = "chkPendente";
            this.chkPendente.Size = new System.Drawing.Size(141, 34);
            this.chkPendente.TabIndex = 56;
            this.chkPendente.Text = "Pendente";
            this.chkPendente.UseVisualStyleBackColor = true;
            this.chkPendente.CheckedChanged += new System.EventHandler(this.chkPendente_CheckedChanged);
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
            // lblListarCliente
            // 
            this.lblListarCliente.BackColor = System.Drawing.Color.White;
            this.lblListarCliente.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblListarCliente.Location = new System.Drawing.Point(5, 5);
            this.lblListarCliente.Name = "lblListarCliente";
            this.lblListarCliente.Size = new System.Drawing.Size(1215, 50);
            this.lblListarCliente.TabIndex = 2;
            this.lblListarCliente.Text = "Listar Cliente";
            this.lblListarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblListarCliente.UseMnemonic = false;
            // 
            // lblStatusCliente
            // 
            this.lblStatusCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(108)))), ((int)(((byte)(97)))));
            this.lblStatusCliente.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblStatusCliente.Location = new System.Drawing.Point(729, 72);
            this.lblStatusCliente.Name = "lblStatusCliente";
            this.lblStatusCliente.Size = new System.Drawing.Size(465, 42);
            this.lblStatusCliente.TabIndex = 49;
            this.lblStatusCliente.Text = "Status:";
            this.lblStatusCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.White;
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(68)))), ((int)(((byte)(89)))));
            this.txtNomeCliente.Location = new System.Drawing.Point(106, 77);
            this.txtNomeCliente.Multiline = true;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(505, 32);
            this.txtNomeCliente.TabIndex = 45;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(108)))), ((int)(((byte)(97)))));
            this.lblNomeCliente.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lblNomeCliente.Location = new System.Drawing.Point(25, 72);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(664, 42);
            this.lblNomeCliente.TabIndex = 46;
            this.lblNomeCliente.Text = "Nome:";
            this.lblNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(112)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.dgvCliente.Location = new System.Drawing.Point(25, 115);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowTemplate.Height = 25;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(1170, 450);
            this.dgvCliente.TabIndex = 41;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            this.dgvCliente.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCliente_ColumnHeaderMouseClick);
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
            // frmClientelistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(55)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.pnlFundoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientelistar";
            this.Text = "Cliente_listar_form";
            this.Load += new System.EventHandler(this.frmClientelistar_Load);
            this.pnlFundoCliente.ResumeLayout(false);
            this.pnlFundoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundoCliente;
        private System.Windows.Forms.CheckBox chkPendente;
        private System.Windows.Forms.PictureBox pctSair;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Label lblListarCliente;
        private System.Windows.Forms.Label lblStatusCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}