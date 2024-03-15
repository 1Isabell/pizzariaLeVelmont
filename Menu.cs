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
            lblTurno.Text = variaveis.turnoFuncionario;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

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
            new frmClientelistar ().Show();
            Hide();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            new Estoque_Listar().Show();
            Hide();
        }
    }
}
