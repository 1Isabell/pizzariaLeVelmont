using Org.BouncyCastle.Crypto.Agreement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzariaLeVelmont
{
    public partial class frmClienteCadastrar : Form
    {
        public frmClienteCadastrar()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frm().Show();
            Close();
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // CÓDIGO RESPONSAVEL DE SÓ´PERMITIR IR PARA O PROXIMO CAMPOS SE DER ENTER
            {
                mkbDataNascCliente.Enabled = true;
                mkbDataNascCliente.Focus();
            }
        }

        private void mkbDataNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // CÓDIGO RESPONSAVEL DE SÓ´PERMITIR IR PARA O PROXIMO CAMPOS SE DER ENTER
            {
                mkbTelefone.Enabled = true;
                mkbTelefone.Focus();
            }
        }

        private void mkbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // CÓDIGO RESPONSAVEL DE SÓ´PERMITIR IR PARA O PROXIMO CAMPOS SE DER ENTER
            {
                txtPagamentoCliente.Enabled = true;
                txtPagamentoCliente.Focus();
            }
        }

        private void txtPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // CÓDIGO RESPONSAVEL DE SÓ´PERMITIR IR PARA O PROXIMO CAMPOS SE DER ENTER
            {
                txtEndereco.Enabled = true;
                txtEndereco.Focus();
            }

        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // CÓDIGO RESPONSAVEL DE SÓ´PERMITIR IR PARA O PROXIMO CAMPOS SE DER ENTER
            {
                cmbStatus.Enabled = true;
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)  // CÓDIGO RESPONSAVEL DE SÓ´PERMITIR IR PARA O PROXIMO CAMPOS SE DER ENTER
            {
                btnCadastrar.Enabled = true;
                btnCadastrar.Focus();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            lblNome.ForeColor = Color.FromArgb(242, 188, 5);
            mkbDataNascCliente.ForeColor = Color.FromArgb(242, 188, 5);
            lblTelefone.ForeColor = Color.FromArgb(242, 188, 5);
            mkbTelefone.ForeColor = Color.FromArgb(242, 188, 5);
            lblPagamentoPend.ForeColor = Color.FromArgb(242, 188, 5);
            lblEndereco.ForeColor = Color.FromArgb(242, 188, 5);
            cmbStatus.ForeColor = Color.FromArgb(242, 188, 5);

            if (txtNomeCliente.Text.Length <= 5)                //QUANTIDADE DE CARACTER IRA TER Não aceita menos q 6 caracteres
            {
                MessageBox.Show("Favor preencher o nome Completo");
                txtNomeCliente.Clear();
                txtNomeCliente.Focus();
                lblNome.ForeColor = Color.Red;
            }
            else if (mkbDataNascCliente.MaskCompleted == false) //NÃO ACEITA MASCARA VAZIA 
            {
                MessageBox.Show("Favor colocar a data de nascimento completa");
                mkbDataNascCliente.Clear();
                mkbDataNascCliente.Focus();
                lblDataNasc.ForeColor = Color.Red;
            }
            else if (mkbTelefone.MaskCompleted == false) //NÃO ACEITA MASCARA VAZIA 
            {
                MessageBox.Show("Favor colocar o numero de telefone completo");
                mkbTelefone.Clear();
                mkbTelefone.Focus();
                lblDataNasc.ForeColor = Color.Red;
            }
            else if (txtPagamentoCliente.Text == "") //NÃO ACEITA TEXTO VAZIO
            {
                MessageBox.Show("Favor colocar o valor pendente");
                txtPagamentoCliente.Clear();
                txtPagamentoCliente.Focus();
                lblPagamentoPend.ForeColor = Color.Red;
            }
            else if (txtEndereco.Text == "") //NÃO ACEITA TEXTO VAZIO
            {
                MessageBox.Show("Favor colocar o valor pendente");
                txtEndereco.Clear();
                txtEndereco.Focus();
                lblEndereco.ForeColor = Color.Red;
            }
            else if (cmbStatus.Text == "")//Não aceita campo vazio
            {
                MessageBox.Show("Favor selecionar status");
                cmbStatus.SelectedIndex = -1;
                cmbStatus.Focus();
                lblStatus.ForeColor = Color.Red;
            } //Status

            else
            {
                variaveis.nomeCliente = txtNomeCliente.Text;
                variaveis.dataNascimentoC = DateTime.Parse(mkbDataNascCliente.Text);
                variaveis.telefoneClinte = mkbTelefone.Text;
                txtPagamentoCliente.Text = variaveis.pagamentoPendCliente.ToString();
                variaveis.enderecoCliente = txtEndereco.Text;
                variaveis.statusCliente = cmbStatus.Text;


                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirCliente();
                    btnCadastrar.Enabled = false;
                    btnLimpar.PerformClick();
                     new frmClientelistar().Show();
                    Close();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarCliente();
                   new frmClientelistar().Show();
                    Hide();

                }
                btnLimpar.Enabled = false;
            }
        }
        // NÃO ESTA ATUALIZANDO O CADASTRO
        private void frmClienteCadastrar_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                btnCadastrar.Text = "ALTERAR";
                banco.CarregarDadosCliente();

                txtNomeCliente.Text = variaveis.nomeCliente;
                // Certifique-se de converter a data para o formato correto antes de atribuí-la ao componente.
                mkbDataNascCliente.Text = variaveis.dataNascimentoC.ToString("dd/MM/yyyy");
                mkbTelefone.Text = variaveis.telefoneClinte.ToString();
                txtPagamentoCliente.Text = variaveis.pagamentoPendCliente.ToString();
                txtEndereco.Text = variaveis.enderecoCliente;
                cmbStatus.Text = variaveis.statusCliente;

                txtNomeCliente.Enabled = true;
                mkbDataNascCliente.Enabled = true;
                mkbTelefone.Enabled = true;
                txtPagamentoCliente.Enabled = true;
                txtEndereco.Enabled = true;
                cmbStatus.Enabled = true;
            }
        }
       
    }
}
