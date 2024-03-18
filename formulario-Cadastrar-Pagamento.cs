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
    public partial class frmCadastrarPagamento : Form
    {
        public frmCadastrarPagamento()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmPagamentoListar().Show();
            Close();
        }

        private void frmCadastrarPagamento_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                lblCadastrarPagamento.Text = "Alterar Informações do Pagamento";
                banco.CarregarDadosPagamento();
                txtidPagamento.Text = variaveis.CodPagamento.ToString(); ;
                txtNomeCliente.Text = variaveis.nomeCliente;
                txtPagamento.Text = variaveis.precoPagamento.ToString();
                cmbTipoPagamento.Text = variaveis.tipoPagamento;
                cmbStatus.Text = variaveis.statusEstoque;
                btnAlterar.Text = "ALTERAR";


                txtidPagamento.Enabled = true;
                txtNomeCliente.Enabled = true;
                txtPagamento.Enabled = true;
                cmbTipoPagamento.Enabled = true;
                cmbStatus.Enabled = true;
                cmbStatus.Enabled = true;
                btnAlterar.Enabled = true;
                btnLimpar.Enabled = false;



            }
            else if (variaveis.funcao == "CADASTRAR")
            {
                lblidPagamento = 
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
    
}
