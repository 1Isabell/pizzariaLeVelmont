using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.WebRequestMethods;
using System.IO;

namespace pizzariaLeVelmont
{
    public static class banco
    {

        public static DataGridView 
            dgSomaPlanos, 
            dgContato, 
            dgFuncionario;//Formulario Funcionario






        //Funcionário
        public static void CarregarFuncionario()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionario ORDER BY nomeFuncionario AND statusFuncionario = 'ATIVO';";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgFuncionario.DataSource = dt;
                dgFuncionario.Columns[0].Visible = false; //ID
                dgFuncionario.Columns[1].HeaderText = "Nome";
                dgFuncionario.Columns[2].HeaderText = "Data Nascimento";
                dgFuncionario.Columns[3].HeaderText = "CPF Funcionário";
                dgFuncionario.Columns[4].HeaderText = "Telefone";
                dgFuncionario.Columns[5].HeaderText = "E-mail";
                dgFuncionario.Columns[6].HeaderText = "Turno";
                dgFuncionario.Columns[7].HeaderText = "Funçao";
                dgFuncionario.Columns[8].HeaderText = "Nível";
                dgFuncionario.Columns[9].HeaderText = "Status";


                dgFuncionario.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Funcionários!\n\n" + erro);
            }
        } //Carregar Informações

        public static void CarregarFuncionarioNome()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionario WHERE nomeFuncionario Like '%" + variaveis.nomeFuncionario + "%' ORDER BY nomeFuncionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgFuncionario.DataSource = dt;
                dgFuncionario.Columns[0].Visible = false; //ID
                dgFuncionario.Columns[1].HeaderText = "Nome";
                dgFuncionario.Columns[2].HeaderText = "Data Nascimento";
                dgFuncionario.Columns[3].HeaderText = "CPF Funcionário";
                dgFuncionario.Columns[4].HeaderText = "Telefone";
                dgFuncionario.Columns[5].HeaderText = "E-mail";
                dgFuncionario.Columns[6].HeaderText = "Turno";
                dgFuncionario.Columns[7].HeaderText = "Funçao";
                dgFuncionario.Columns[8].HeaderText = "Nível";
                dgFuncionario.Columns[9].HeaderText = "Status";


                dgFuncionario.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Funcionários!\n\n" + erro);
            }
        }  //Carregar Informações Focada no Nome

        public static void CarregarFuncionarioStatusAtivo()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM `tblfuncionario`  WHERE statusFuncionario = 'ATIVO' ORDER BY nomeFuncionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgFuncionario.DataSource = dt;
                dgFuncionario.Columns[0].Visible = false; //ID
                dgFuncionario.Columns[1].HeaderText = "Nome";
                dgFuncionario.Columns[2].HeaderText = "Data Nascimento";
                dgFuncionario.Columns[3].HeaderText = "CPF Funcionário";
                dgFuncionario.Columns[4].HeaderText = "Telefone";
                dgFuncionario.Columns[5].HeaderText = "E-mail";
                dgFuncionario.Columns[6].HeaderText = "Turno";
                dgFuncionario.Columns[7].HeaderText = "Funçao";
                dgFuncionario.Columns[8].HeaderText = "Nível";
                dgFuncionario.Columns[9].HeaderText = "Status";


                dgFuncionario.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Funcionários!\n\n" + erro);
            }
        } //Status Ativo

        public static void CarregarFuncionarioStatusDesativo()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM `tblfuncionario`  WHERE statusFuncionario = 'DESATIVADO' ORDER BY nomeFuncionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgFuncionario.DataSource = dt;
                dgFuncionario.Columns[0].Visible = false; //ID
                dgFuncionario.Columns[1].HeaderText = "Nome";
                dgFuncionario.Columns[2].HeaderText = "Data Nascimento";
                dgFuncionario.Columns[3].HeaderText = "CPF Funcionário";
                dgFuncionario.Columns[4].HeaderText = "Telefone";
                dgFuncionario.Columns[5].HeaderText = "E-mail";
                dgFuncionario.Columns[6].HeaderText = "Turno";
                dgFuncionario.Columns[7].HeaderText = "Funçao";
                dgFuncionario.Columns[8].HeaderText = "Nível";
                dgFuncionario.Columns[9].HeaderText = "Status";


                dgFuncionario.ClearSelection();
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Funcionários!\n\n" + erro);
            }
        } //Status Desativo

        public static void DesativarFuncionario()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblfuncionario SET statusFuncionario= 'DESATIVADO' WHERE idFuncionario=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFuncionario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario desativado com sucesso!", "EXCLUIR DO FUNCIONÁRIO");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao desativar funcionario!\n\n" + erro.Message, "ERRO");
            }
        } //Desativar

        public static void CarregarDadosFuncionario()
        {
            try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblfuncionario WHERE idFuncionario = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("codigo", variaveis.codFuncionario);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.nomeFuncionario = reader.GetString(1);
                    variaveis.dataNascFuncionario = reader.GetDateTime(2);
                    variaveis.cpfFuncionario = reader.GetString(3);
                    variaveis.telefoneFuncionario = reader.GetString(4);
                    variaveis.emailFuncionario = reader.GetString(5);
                    variaveis.turnoFuncionario = reader.GetString(6);
                    variaveis.funcaoFuncionario = reader.GetString(7);
                    variaveis.nivelFuncionario = reader.GetString(8);
                    variaveis.statusFuncionario = reader.GetString(9);
                    

                }
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Eroo ao carregar os dados do funcionários!\n\n" + erro);
            }
        }//Carregar

        public static void InserirFuncionario()
        {
            try
            {
                conexao.Conectar();
                string inserir = "INSERT INTO tblfuncionario(nomeFuncionario, dataNascFuncionario, cpfFuncionario, telefoneFuncionario, emailFuncionario, turnoFuncionario, funcaoFuncionario, acessoFuncionario, statusFuncionario) VALUES (@nome,@dataNas,@cpf,@telefone,@email,@turno,@funcao,@nivel,@status);";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
                //parametros
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@dataNas", variaveis.dataNascFuncionario);
                cmd.Parameters.AddWithValue("@cpf", variaveis.cpfFuncionario);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneFuncionario);
                cmd.Parameters.AddWithValue("@email", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@turno", variaveis.turnoFuncionario);
                cmd.Parameters.AddWithValue("@funcao", variaveis.funcaoFuncionario);
                cmd.Parameters.AddWithValue("@nivel", variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);


                //cmd parametros

                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario cadastro com sucesso!", "CADASTRO FUNCIONÁRIO");
                conexao.Desconectar();

               
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastra funcionario!\n\n" + erro.Message, "ERRO");
            }



        } //Cadastrar

        public static void AlterarFuncionario()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblfuncionario SET nomeFuncionario=@nomedataNascFuncionario=@dataNas,cpfFuncionario=@cpf,turnoFuncionario=@turno,emailFuncionario=@email,funcaoFuncionario=@funcao,acessoFuncionario=@nivel,telefoneFuncionario=@telefone,statusFuncionario=@status,WHERE idFuncionario=@codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //parametros
                cmd.Parameters.AddWithValue("@nome", variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@dataNas", variaveis.dataNascFuncionario);
                cmd.Parameters.AddWithValue("@cpf", variaveis.cpfFuncionario);
                cmd.Parameters.AddWithValue("@telefone", variaveis.telefoneFuncionario);
                cmd.Parameters.AddWithValue("@email", variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@turno", variaveis.turnoFuncionario);
                cmd.Parameters.AddWithValue("@funcao", variaveis.funcaoFuncionario);
                cmd.Parameters.AddWithValue("@nivel", variaveis.nivelFuncionario);
                cmd.Parameters.AddWithValue("@status", variaveis.statusFuncionario);

                //cmd parametros

                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario alterado com sucesso!", "ALTERAÇÃO DO FUNCIONÁRIO");
                conexao.Desconectar();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar funcionario!\n\n" + erro.Message, "ERRO");
            }
        }
    }
}
