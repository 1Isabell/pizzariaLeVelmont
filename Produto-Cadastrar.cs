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
    public partial class Produto_Cadastrar : Form
    {
        public Produto_Cadastrar()
        {
            InitializeComponent();
        }

        private void Produto_Cadastrar_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                lblProduto.Text = "Alterar Informações do Produto";
                btnAlterar.Text = "ALTERAR";
                banco.CarregarDadosProduto();
                txtNomeProduto.Text = variaveis.nomeProduto;
                txtDescricao.Text = variaveis.descricaoProduto;
                txtValor.Text = variaveis.precoProduto.ToString();
                cmbCategoria.Text = variaveis.categoriaProduto;
                cmbTipo.Text = variaveis.tipoProduto;
                cmbStatus.Text = variaveis.statusProduto;


                txtNomeProduto.Enabled = true;
                txtDescricao.Enabled = true;
                txtValor.Enabled = true;
                cmbCategoria.Enabled = true;
                cmbTipo.Enabled = true;
                cmbStatus.Enabled = true;
                btnAlterar.Enabled = true;
                btnLimpar.Enabled = false;
            }
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new Produto_Listar().Show();
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.FromArgb(75, 73, 73);
            lblDescricao.ForeColor = Color.FromArgb(75, 73, 73);
            lblCategoria.ForeColor = Color.FromArgb(75, 73, 73);
            lblTipo.ForeColor = Color.FromArgb(75, 73, 73);
            lblValor.ForeColor = Color.FromArgb(75, 73, 73);
            lblStatus.ForeColor = Color.FromArgb(75, 73, 73);

            if (txtNomeProduto.Text.Length <= 1) //Não aceita menos que 2 caracteres
            {
                MessageBox.Show("Favor colocar o nome");
                txtNomeProduto.Clear();
                txtNomeProduto.Focus();
                lblNome.ForeColor = Color.Red;
            } //Nome


            else if (txtDescricao.Text == "")//Não aceita Texto vazio
            {
                MessageBox.Show("Favor colocar descrição");
                txtDescricao.Clear();
                txtDescricao.Focus();
                lblDescricao.ForeColor = Color.Red;
            } //Email

            else if (txtValor.Text == "")//Não aceita Texto vazio
            {
                MessageBox.Show("Favor colocar o valor");
                txtValor.Clear();
                txtValor.Focus();
                lblValor.ForeColor = Color.Red;
            } //Email



            else if (cmbCategoria.Text == "")
            {
                MessageBox.Show("Favor colocar categoria");
                cmbCategoria.SelectedIndex = -1;
                cmbCategoria.Focus();
                lblCategoria.ForeColor = Color.Red;
            } 


            else if (cmbTipo.Text == "")
            {
                MessageBox.Show("Favor colocar tipo");
                cmbTipo.SelectedIndex = -1;
                cmbTipo.Focus();
                lblTipo.ForeColor = Color.Red;
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
                variaveis.nomeProduto = txtNomeProduto.Text;
                variaveis.descricaoProduto = txtDescricao.Text;
                variaveis.tipoProduto = cmbTipo.Text;
                variaveis.categoriaProduto = cmbCategoria.Text;
                variaveis.precoProduto = int.Parse(txtValor.Text);
                variaveis.statusProduto = cmbStatus.Text;


                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirProduto();
                    btnAlterar.Enabled = false;
                    btnLimpar.PerformClick();
                    new Produto_Listar().Show();
                    Close();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarProduto();
                    new Produto_Listar().Show();
                    Hide();

                }
                btnLimpar.Enabled = false;
            }
        }
    }

}
