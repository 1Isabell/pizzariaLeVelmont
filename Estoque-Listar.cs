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
    public partial class Estoque_Listar : Form
    {
        public Estoque_Listar()
        {
            InitializeComponent();
        }

        private void Estoque_Listar_Load(object sender, EventArgs e)
        {
            banco.dgEstoque = dgvEstoque;
            banco.CarregarEstoque();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeEstoque = txtNome.Text;
            banco.CarregarEstoqueNome();

            if (txtNome.Text == "")
            {
                cbStatusAtivo.Enabled = true;
                cbStatusDesativo.Enabled = true;

            }
            else
            {
                cbStatusAtivo.Enabled = false;
                cbStatusDesativo.Enabled = false;
            }
        }

        private void cbStatusAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatusAtivo.Checked == true)
            {
                banco.CarregarEstoqueStatusAtivo();
                txtNome.Enabled = false;
                cbStatusDesativo.Enabled = false;
            }
            else
            {
                banco.CarregarEstoque();
                txtNome.Enabled = true;
                cbStatusDesativo.Enabled = true;
            }
        }

        private void cbStatusDesativo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatusDesativo.Checked == true)
            {
                banco.CarregarEstoqueStatusDesativo();
                txtNome.Enabled = false;
                cbStatusAtivo.Enabled = false;
            }
            else
            {
                banco.CarregarEstoque();
                txtNome.Enabled = true;
                cbStatusAtivo.Enabled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new Estoque_Cadastrar().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new Estoque_Cadastrar().Show();
            Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja realmente excluir? Essa ação não poderá ser desfeita", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    banco.DesativarEstoque();
                    banco.CarregarEstoque();
                    dgvEstoque.ClearSelection();

                }
                else
                {
                    dgvEstoque.ClearSelection();
                }
            }
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codEstoque = Convert.ToInt32(dgvEstoque[0, variaveis.linhaSelecionada].Value);
                MessageBox.Show(variaveis.codEstoque.ToString());
            }
        }

        private void dgvEstoque_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEstoque.Sort(dgvEstoque.Columns[1], ListSortDirection.Ascending);
            dgvEstoque.ClearSelection();
        }
    }
}
