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
    public partial class Produto_Listar : Form
    {
        public Produto_Listar()
        {
            InitializeComponent();
        }

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new Produto_Cadastrar().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new Produto_Cadastrar().Show();
            Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja realmente excluir? Essa ação não poderá ser desfeita", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    banco.DesativarProduto();
                    banco.CarregarProduto();
                    dgvProduto.ClearSelection();

                }
                else
                {
                    dgvProduto.ClearSelection();
                }
            }
        }

        private void Produto_Listar_Load(object sender, EventArgs e)
        {
            banco.dgProduto = dgvProduto;
            banco.CarregarProduto();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeProduto = txtNome.Text;
            banco.CarregarProdutoNome();

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
                banco.CarregarProdutoStatusAtivo();
                txtNome.Enabled = false;
                cbStatusDesativo.Enabled = false;
            }
            else
            {
                banco.CarregarProduto();
                txtNome.Enabled = true;
                cbStatusDesativo.Enabled = true;
            }
        }

        private void cbStatusDesativo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatusDesativo.Checked == true)
            {
                banco.CarregarProdutoStatusDesativo();
                txtNome.Enabled = false;
                cbStatusAtivo.Enabled = false;
            }
            else
            {
                banco.CarregarProduto();
                txtNome.Enabled = true;
                cbStatusAtivo.Enabled = true;
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codProduto = Convert.ToInt32(dgvProduto[0, variaveis.linhaSelecionada].Value);
                MessageBox.Show(variaveis.codProduto.ToString());
            }
        }

        private void dgvProduto_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvProduto.Sort(dgvProduto.Columns[1], ListSortDirection.Ascending);
            dgvProduto.ClearSelection();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            variaveis.tipoProduto = cmbTipo.Text;
            banco.CarregarProdutoTipo();
        }
    }
}
