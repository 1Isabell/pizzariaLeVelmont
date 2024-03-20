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
    public partial class frmClientelistar : Form
    {
        public frmClientelistar()
        {
            InitializeComponent();
        }

        private void frmClientelistar_Load(object sender, EventArgs e)
        {
            banco.dgCliente = dgvCliente;
            banco.CarregarCliente();
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

            variaveis.nomeCliente = txtNomeCliente.Text;

            banco.CarregarCliente(); // CARREGAR O NOME DO CLIENTE

            if (txtNomeCliente.Text == "")
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
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());

            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codCliente = Convert.ToInt32(dgvCliente[0, variaveis.linhaSelecionada].Value);
            }
        }

        private void dgvCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCliente.Sort(dgvCliente.Columns[1], ListSortDirection.Ascending);
            dgvCliente.ClearSelection();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
          new frmClienteCadastrar().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new frmClienteCadastrar().Show();
            Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0) //Verifica se uma linha válida foi selecionada
            {
                var resposta = MessageBox.Show("Deseja realmente exclluir? Essa ação não poderá ser desfeita", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    banco.DesativarCliente();
                    banco.CarregarCliente();
                    dgvCliente.ClearSelection();
                }
                else
                {
                    dgvCliente.ClearSelection();

                }
            }
        }

       

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked == true)
            {
                banco.CarregarStatusCliente();
                txtNomeCliente.Enabled = false;
                chkPendente.Enabled = false;
            }
            else
            {
                banco.CarregarCliente();
                txtNomeCliente.Enabled = true;
                chkPendente.Enabled = true;
            }
        }

        private void chkPendente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPendente.Checked == true)
            {
                banco.CarregarStatusPendente();
                txtNomeCliente.Enabled = false;
                chkAtivo.Enabled = false;
            }
            else
            {
                banco.CarregarCliente();
                txtNomeCliente.Enabled = true;
                chkAtivo.Enabled = true;
            }
        }

      
    }
}
