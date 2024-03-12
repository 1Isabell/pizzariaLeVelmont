using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzariaLeVelmont
{
    public partial class frmPagamentoListar : Form
    {
        public frmPagamentoListar()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Encerrar?", "ENCERRAR", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmPagamentoListar_Load(object sender, EventArgs e)
        {
            banco.dgPagamento = dgvPagamento;
            banco.CarregarPagamento();
        }

        //TRAS O ID DOS CLIENTES
        private void txtNomePagamento_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeCliente = txtNomePagamento.Text;
            banco.CarregarPagamento();

            if (txtNomePagamento.Text == "")
            {
                chkAtivo.Enabled = true;
            }
            else
            {
                chkAtivo.Enabled = false;
            }
        }

        //STATUS ATIVOS
        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked == true)
            {
                banco.CarregarPagamentoStatus();
                txtNomePagamento.Enabled = false;
            }
            else
            {
                banco.CarregarPagamentoStatus();
                txtNomePagamento.Enabled = true;
            }
        }

        //STATUS PENDENTE
        private void cbStatusDesativo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked == true)
            {
                banco.CarregarPagamentoStatusPendente();
                txtNomePagamento.Enabled = false;
            }
            else
            {
                banco.CarregarPagamentoStatusPendente();
                txtNomePagamento.Enabled = true;
            }
        }
    }
}
