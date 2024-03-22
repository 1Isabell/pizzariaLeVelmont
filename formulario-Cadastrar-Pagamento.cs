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
                cmbNomeCliente.Text = variaveis.nomeCliente;
                txtPagamento.Text = variaveis.precoPagamento.ToString();
                cmbStatus.Text = variaveis.statusPagamento;
                btnAlterar.Text = "ALTERAR";


                txtidPagamento.Enabled = true;
                cmbNomeCliente.Enabled = true;
                txtPagamento.Enabled = true;
               
                cmbStatus.Enabled = true;
                cmbStatus.Enabled = true;
                btnAlterar.Enabled = true;
                btnLimpar.Enabled = false;



            }
            else if (variaveis.funcao == "CADASTRAR")
            {
                txtidPagamento.Enabled= false;
            }
        }

        private void cmbNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            banco.cmbNomeCliente = cmbNomeCliente;
            banco.CarregarClienteCombo();

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            lblidPagamento.ForeColor = Color.FromArgb(75, 73, 73);
            lblidCliente.ForeColor = Color.FromArgb(75, 73, 73);
            lblPreçoPagamento.ForeColor = Color.FromArgb(75, 73, 73);
           
            lblStatus.ForeColor = Color.FromArgb(75, 73, 73);

            

             if (txtPagamento.Text == "")//Não aceita Texto vazio
            {
                MessageBox.Show("Favor colocar o valor");
                txtPagamento.Clear();
                txtPagamento.Focus();
                lblPreçoPagamento.ForeColor = Color.Red;
            } //Email



            else if (cmbNomeCliente.Text == "")
            {
                MessageBox.Show("Favor colocar nome");
                cmbNomeCliente.SelectedIndex = -1;
                cmbNomeCliente.Focus();
                lblidCliente.ForeColor = Color.Red;
            } //Data Nascimeto




            else if (cmbStatus.Text == "")//Não aceita campo vazio
            {
                MessageBox.Show("Favor selecionar status");
                cmbStatus.SelectedIndex = -1;
                cmbStatus.Focus();
                lblStatus.ForeColor = Color.Red;
            } //Status


            else
            {
                variaveis.nomeCliente = cmbNomeCliente.Text;
                variaveis.precoPagamento = int.Parse(txtPagamento.Text);
                variaveis.statusPagamento = cmbStatus.Text;


                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirPagamento();
                    btnAlterar.Enabled = false;
                    btnLimpar.PerformClick();
                    new frmPagamentoListar().Show();
                    Close();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarPagamento();
                    new frmPagamentoListar().Show();
                    Hide();

                }
                btnLimpar.Enabled = false;
            }
        }

        


        
    }
    
}
