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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            lblUser.Text = variaveis.usuario;
            lblData.Text = DateTime.Now.ToString();
            lblTurno.Text = variaveis.turno;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        


       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Encerrar?", "ENCERRAR", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            new Funcionario_Listar().Show();
            Hide();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            new frmPagamentoListar().Show();
            Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            new frmClientelistar().Show();
            Hide();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            new Estoque_Listar().Show();
            Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            new Produto_Listar().Show();
            Hide();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            banco.CarregarQtdeCliente();
            lblCliente.Text = variaveis.qtdeCliente.ToString();

            banco.CarregarQtdeFuncionario();
            lblFuncinario.Text = variaveis.qtdeFuncionario.ToString();

            banco.CarregarQtdeProduto();
            lblProdutos.Text = variaveis.qtdeProduto.ToString();

            btnRelatorio.Enabled = false;
            btnPagamento.Enabled = false;
            btnAjuda.Enabled = false; 
            btnEmail.Enabled = false;
            btnVendas.Enabled = false; 
        }

        
    }
}
