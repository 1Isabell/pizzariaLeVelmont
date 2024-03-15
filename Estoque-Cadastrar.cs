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
    public partial class Estoque_Cadastrar : Form
    {
        public Estoque_Cadastrar()
        {
            InitializeComponent();
        }

        private void Estoque_Cadastrar_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                lblEstoque.Text = "Alterar Informações do Estoque";
                banco.CarregarDadosEstoque();
                txtNomeEstoque.Text = variaveis.nomeEstoque;
                txtNomeFornecedor.Text = variaveis.fornecedorEstoque;
                mtbDataValidade.Text = variaveis.dataValidadeEstoque.ToString();
                txtValor.Text = variaveis.preçoEstoque.ToString();
                nudQuantidade.Text = variaveis.quantidadeEstoque.ToString();
                cmbCategoria.Text = variaveis.categoriaEstoque;
                cmbStatus.Text = variaveis.statusEstoque;
                btnAlterar.Text = "ALTERAR";


                txtNomeEstoque.Enabled = true;
                txtNomeFornecedor.Enabled = true;
                txtValor.Enabled = true;
                mtbDataValidade.Enabled = true;
                nudQuantidade.Enabled = true;
                cmbCategoria.Enabled = true;
                cmbStatus.Enabled = true;
                btnAlterar.Enabled = true;
                btnLimpar.Enabled = false;



            }
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new Estoque_Listar().Show();
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.FromArgb(75, 73, 73);
            lblNomeFornecedor.ForeColor = Color.FromArgb(75, 73, 73);
            lblQuantidade.ForeColor = Color.FromArgb(75, 73, 73);
            lblCategoria.ForeColor = Color.FromArgb(75, 73, 73);
            lblData.ForeColor = Color.FromArgb(75, 73, 73);
            lblValor.ForeColor = Color.FromArgb(75, 73, 73);
            lblStatus.ForeColor = Color.FromArgb(75, 73, 73);

            if (txtNomeEstoque.Text.Length <= 1) //Não aceita menos que 2 caracteres
            {
                MessageBox.Show("Favor colocar o nome");
                txtNomeEstoque.Clear();
                txtNomeEstoque.Focus();
                lblNome.ForeColor = Color.Red;
            } //Nome


            else if (txtNomeFornecedor.Text == "")//Não aceita Texto vazio
            {
                MessageBox.Show("Favor colocar o nome");
                txtNomeFornecedor.Clear();
                txtNomeFornecedor.Focus();
                lblNomeFornecedor.ForeColor = Color.Red;
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
            } //Data Nascimeto


            else if (mtbDataValidade.MaskCompleted == false)
            {
                MessageBox.Show("Favor colocar data válidade, caso o prduto não seja da categoria de alimento colocar a data de aquisição");
                mtbDataValidade.Clear();
                mtbDataValidade.Focus();
                lblData.ForeColor = Color.Red;
            } //Telefone




            else if (cmbStatus.Text == "")//Não aceita campo vazio
            {
                MessageBox.Show("Favor selecionar status");
                cmbStatus.SelectedIndex = -1;
                cmbStatus.Focus();
                lblStatus.ForeColor = Color.Red;
            } //Status


            else
            {
                variaveis.nomeEstoque = txtNomeEstoque.Text;
                variaveis.fornecedorEstoque = txtNomeFornecedor.Text;
                variaveis.dataValidadeEstoque = DateTime.Parse(mtbDataValidade.Text);
                variaveis.quantidadeEstoque = int.Parse(nudQuantidade.Text);
                variaveis.categoriaEstoque = cmbCategoria.Text;
                variaveis.preçoEstoque = int.Parse(txtValor.Text);
                variaveis.statusEstoque = cmbStatus.Text;


                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirProdutoEstoque();
                    btnAlterar.Enabled = false;
                    btnLimpar.PerformClick();
                    new Estoque_Listar().Show();
                    Close();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarEstoque();
                    new Estoque_Listar().Show();
                    Hide();

                }
                btnLimpar.Enabled = false;
            }   
        }
    }
}
