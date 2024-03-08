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
    public partial class Funcionario_Listar : Form
    {
        public Funcionario_Listar()
        {
            InitializeComponent();
        }
        private void Funcionario_Listar_Load(object sender, EventArgs e)
        {
            banco.dgFuncionario = dgvFuncionario;
            banco.CarregarFuncionario();
        }  //Formulário 

        private void pctSair_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }  //Fechar

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            variaveis.nomeFuncionario = txtNome.Text;
            banco.CarregarFuncionarioNome();

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
        }  // Pesquisar Nome

        private void cbStatusAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatusAtivo.Checked == true)
            {
                banco.CarregarFuncionarioStatusAtivo();
                txtNome.Enabled = false;
                cbStatusDesativo.Enabled= false;
            }
            else
            {
                banco.CarregarFuncionario();
                txtNome.Enabled = true;
                cbStatusDesativo.Enabled = true;
            }


        }  //Status Ativo

        private void cbStatusDesativo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatusDesativo.Checked == true)
            {
                banco.CarregarFuncionarioStatusDesativo();
                txtNome.Enabled = false;
                cbStatusAtivo.Enabled = false;
            }
            else
            {
                banco.CarregarFuncionario();
                txtNome.Enabled = true;
                cbStatusAtivo.Enabled = true;
            }
        } //Status Desativo

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "CADASTRAR";
            new Funcionario_Cadastrar().Show();
            Hide();
        }  //Cadastrar

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (variaveis.linhaSelecionada >= 0)
            {
                variaveis.codFuncionario = Convert.ToInt32(dgvFuncionario[0, variaveis.linhaSelecionada].Value);
                MessageBox.Show(variaveis.codFuncionario.ToString());
            }
        } //Tabela Funcionario (dataGrid)

        private void dgvFuncionario_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFuncionario.Sort(dgvFuncionario.Columns[1], ListSortDirection.Ascending);
            dgvFuncionario.ClearSelection();
        }  //Tabela Funcionario (dataGrid)

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            variaveis.funcao = "ALTERAR";
            new Funcionario_Cadastrar().Show();
            Hide();
        } //Alterar

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (variaveis.linhaSelecionada >= 0)
            {
                var resposta = MessageBox.Show("Deseja realmente excluir? Essa ação não poderá ser desfeita", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    banco.DesativarFuncionario();
                    banco.CarregarFuncionario();
                    dgvFuncionario.ClearSelection();

                }
                else
                {
                    dgvFuncionario.ClearSelection();
                }
            }
        } //Desativar

    
    }
}
