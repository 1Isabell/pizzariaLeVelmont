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
            new frmMenuPrincipal().Show();
            Close();
        }

        private void frmPagamentoListar_Load(object sender, EventArgs e)
        {
            banco.dgPagamento = dgvPagamento; 
            banco.CarregarPagamento();
        }

        //TRAS O ID DOS CLIENTES
        private void txtNomePagamento_TextChanged(object sender, EventArgs e)
        {
            variaveis.pagamentoPendCliente = txtNomePagamento.Text; 
            
            banco.CarregarPagamentoNome(); // CARREGAR O NOME DO CLIENTE

            if (txtNomePagamento.Text == "")
            {
                chkAtivo.Enabled = true;
                chkPendente.Enabled = true;

            }
            else
            {
                chkAtivo.Enabled = false;
                chkPendente.Enabled = false;
            }
        }

        //STATUS ATIVOS
        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked == true)
            {
                banco.CarregarPagamentoStatus();
                txtNomePagamento.Enabled = false;
                chkPendente.Enabled = false;
            }
            else
            {
                banco.CarregarPagamento();
                txtNomePagamento.Enabled = true;
                chkPendente.Enabled = true;
            }
        }

        //STATUS PENDENTE
        private void chkPendente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPendente.Checked == true)
            {
                banco.CarregarPagamentoStatusPendente();
                txtNomePagamento.Enabled = false;
                chkAtivo.Enabled = false;
            }
            else
            {
                banco.CarregarPagamento();
                txtNomePagamento.Enabled = true;
                chkAtivo.Enabled = true;
            }
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new frmCadastrarPagamento().Show();
            Hide();
        }

        private void dgvPagamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if(variaveis.linhaSelecionada >= 0)
            {
                variaveis.CodPagamento = Convert.ToInt32(dgvPagamento[0,
                    variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvPagamento_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvPagamento.Sort(dgvPagamento.Columns[1], ListSortDirection.Ascending);
            dgvPagamento.ClearSelection();
        }
    }
}
