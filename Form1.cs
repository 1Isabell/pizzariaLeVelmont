using MySql.Data.MySqlClient;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        int mostrar = 0;

        private void pctBtnFechar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Encerrar?", "ENCERRAR", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pctEscondeS_Click(object sender, EventArgs e)
        {
            if (mostrar == 0)
            {

                txtSenha.PasswordChar = '\0';
                pctEscondeS.Image = Properties.Resources.esconder; //escode o valor 
                mostrar = 1;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                pctEscondeS.Image = Properties.Resources.mostrar; //permite mostrar 
                mostrar = 0;
            }
        }

        

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            //  PEGA OS VALORES DA CAIXA DE EMAIL
            variaveis.usuario = txtEmail.Text;
            variaveis.senha = txtSenha.Text;

            if (variaveis.usuario == "" && variaveis.senha == "")
            {
                variaveis.nivel = "ADM";
                new frmMenuPrincipal().Show();
                Hide();
            }
            else
            {
                try
                {
                    conexao.Conectar();
                    string selecionar = "SELECT nomeFuncionario, emailFuncionario, senhaFuncionario, acessoFuncionario, turnoFuncionario FROM tblfuncionario WHERE emailFuncionario=@email AND senhaFuncionario=@senha AND statusFuncionario=@status";
                    MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                    cmd.Parameters.AddWithValue("@email", variaveis.usuario);
                    cmd.Parameters.AddWithValue("@senha", variaveis.senha);
                    cmd.Parameters.AddWithValue("@status", "ATIVO");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        variaveis.usuario = reader.GetString(0);
                        variaveis.nivel = reader.GetString(3);
                        variaveis.turno = reader.GetString(4); 
                        new frmMenuPrincipal().Show();
                        Hide();

                    }
                    else
                    {
                        MessageBox.Show("Acesso Negado");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtEmail.Focus();

                    }

                }
                catch (Exception err)

                {
                    MessageBox.Show("Erro ao logar" + err);

                }
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
