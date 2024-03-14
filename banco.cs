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
            dgFuncionario,//Formulario Funcionario
            dgPagamento, //FORMULARIO PAGAMENTO/LISTAR
            dgProduto, //Formulario Produto
            dgEstoque, //Formulario Estoque
            dgCliente;






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
                string alterar = "UPDATE tblfuncionario SET nomeFuncionario=@nome,dataNascFuncionario=@dataNas,cpfFuncionario=@cpf,turnoFuncionario=@turno,emailFuncionario=@email,funcaoFuncionario=@funcao,acessoFuncionario=@nivel,telefoneFuncionario=@telefone,statusFuncionario=@status WHERE idFuncionario=@codigo;";
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
                cmd.Parameters.AddWithValue("@codigo", variaveis.codFuncionario);

                //cmd parametros

                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario alterado com sucesso!", "ALTERAÇÃO DO FUNCIONÁRIO");
                conexao.Desconectar();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar funcionario!\n\n" + erro.Message, "ERRO");
            }
        } //Alterar






        //SEÇÃO PAGAMENTO //

        //CARREGAR PAGAMENTO 

        public static void CarregarPagamento()
        {
            try
            {
                conexao.Conectar();
                //ONDE MUDAMOS SOMENTE O CODIGO SELECTE
                string selecionar = "SELECT tblpagamento.* ,tblcliente.nomeCliente\r\nFROM tblpagamento\r\nINNER JOIN tblcliente ON tblpagamento.idCliente = tblcliente.idCliente\r\n\r\nWHERE tblcliente.nomeCliente LIKE '%\"+variaveis.nomeCliente+\"%'\r\nORDER BY tblcliente.nomeCliente\r\n";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgPagamento.DataSource = dt;

                dgPagamento.Columns[0].HeaderText = "ID Pagamento";
                dgPagamento.Columns[1].HeaderText = "Status";
                dgPagamento.Columns[2].HeaderText = "Tipo de Pagamento";
                dgPagamento.Columns[3].HeaderText = "Preço do Pagamento";
                dgPagamento.Columns[4].HeaderText = "ID Cliente";
                dgPagamento.Columns[5].HeaderText = "Nome Cliente";

                dgPagamento.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Pagamentos!\n\n" + erro);
            }

        }

        //RESPONSAVEL DE LISTAR OS ID 
        public static void CarregarPagamentoNome()
        {
            try
            {
                conexao.Conectar();

                //ONDE MUDAMOS SOMENTE O CODIGO SELECTE
                //COMO TRAZER O NOME DO CLIENTE NO LUGAR DO IR
                string selecionar = "SELECT tblpagamento.* ,tblcliente.nomeCliente FROM tblpagamento INNER JOIN tblcliente ON tblpagamento.idCliente = tblcliente.idCliente WHERE tblcliente.nomeCliente LIKE '%\"+variaveis.nomeCliente+\"%' ORDER BY tblcliente.nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgPagamento.DataSource = dt;

                dgPagamento.Columns[0].HeaderText = "ID Pagamento";
                dgPagamento.Columns[1].HeaderText = "Status";
                dgPagamento.Columns[2].HeaderText = "Tipo de Pagamento";
                dgPagamento.Columns[3].HeaderText = "Preço do Pagamento";
                dgPagamento.Columns[4].HeaderText = "ID Cliente";
                dgPagamento.Columns[5].HeaderText = "Nome Cliente";

                dgPagamento.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Pagamentos!\n\n" + erro);
            }

        }

        //RESPONSAVEL DE LISTAR OS PAGAMENTOS ATIVOS
        public static void CarregarPagamentoStatus()
        {
            try
            {
                conexao.Conectar();

                //ONDE MUDAMOS SOMENTE O CODIGO SELECTE
                string selecionar = "SELECT tblpagamento.* ,tblcliente.nomeCliente FROM tblpagamento INNER JOIN tblcliente ON tblpagamento.idCliente = tblcliente.idCliente WHERE statusPagamento = 'ATIVO' ORDER BY tblcliente.nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgPagamento.DataSource = dt;


                dgPagamento.Columns[0].HeaderText = "ID Pagamento";
                dgPagamento.Columns[1].HeaderText = "Status";
                dgPagamento.Columns[2].HeaderText = "Tipo de Pagamento";
                dgPagamento.Columns[3].HeaderText = "Preço do Pagamento";
                dgPagamento.Columns[4].HeaderText = "ID Cliente";
                dgPagamento.Columns[5].HeaderText = "Nome Cliente";

                dgPagamento.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Pagamentos!\n\n" + erro);
            }
        }

        //STATUS PENDENTE
        public static void CarregarPagamentoStatusPendente()
        {
            try
            {
                conexao.Conectar();

                //ONDE MUDAMOS SOMENTE O CODIGO SELECTE
                string selecionar = "SELECT tblpagamento.* ,tblcliente.nomeCliente FROM tblpagamento INNER JOIN tblcliente ON tblpagamento.idCliente = tblcliente.idCliente WHERE statusPagamento = 'PENDENTE' ORDER BY tblcliente.nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgPagamento.DataSource = dt;


                dgPagamento.Columns[0].HeaderText = "ID Pagamento";
                dgPagamento.Columns[1].HeaderText = "Status";
                dgPagamento.Columns[2].HeaderText = "Tipo de Pagamento";
                dgPagamento.Columns[3].HeaderText = "Preço do Pagamento";
                dgPagamento.Columns[4].HeaderText = "ID Cliente";
                dgPagamento.Columns[5].HeaderText = "Nome Cliente";

                dgPagamento.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os Pagamentos!\n\n" + erro);
            }
        }

        //INSERIR PAGAMENTOS
         public static void InserirPagamento()
        {
            conexao.Conectar();
            string inserir = "INSERT INTO `tblpagamento`( statusPagamento, tipoPagamento, preçoPagamento, idCliente) VALUES (@statusPagamento,@tipoPagamento,@precoPagamento,@codCliente);";
            MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);
            //PARÁMETROS
            cmd.Parameters.AddWithValue("@statusPagamento", variaveis.statusPagamento); //ADICIONAR OS VALORES DO PARÁMETROS NA VAR
            cmd.Parameters.AddWithValue("@tipoPagamento", variaveis.tipoPagamento);
            cmd.Parameters.AddWithValue("@precoPagamento", variaveis.precoPagamento);
            cmd.Parameters.AddWithValue("@codCliente", variaveis.codCliente);
         
         
            
            //FIM PARÁMETROS    
            cmd.ExecuteNonQuery();
            MessageBox.Show("Pagamento cadastrado com sucesso!", "CADASTRO DO PAGAMENTO");
            conexao.Desconectar();

        }

        //CARREGAR PAGAMENTO 

        public static void CarregarDadosPagamento()
        {
           try
            {
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblpagamento WHERE idPagamento = @codPagamento;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("@codPagamento", variaveis.CodPagamento);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.statusPagamento = reader.GetString(1);
                    variaveis.tipoPagamento = reader.GetString(2);
                    variaveis.precoPagamento = reader.GetString(3);
                    variaveis.nomeCliente = reader.GetString(4);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os dados do funcionario!\n\n" + erro);
            }

        }

        //ALTERAR PAGAMENTO
        public static void AlterarPagamento()
        {
            try
            {
                conexao.Conectar();
                string alterar = "UPDATE tblpagamento SET statusPagamento = @statusPagamento, tipoPagamento = @tipoPagamento, preçoPagamento = precoPagamento, idCliente = codCliente WHERE idPagamento = codPadamento;";

                MySqlCommand cmd = new MySqlCommand(alterar, conexao.conn);
                //PARÁMETROS
                cmd.Parameters.AddWithValue("@statusPagamento", variaveis.statusPagamento); //ADICIONAR OS VALORES DO PARÁMETROS NA VAR
                cmd.Parameters.AddWithValue("@tipoPagamento", variaveis.tipoPagamento);
                cmd.Parameters.AddWithValue("@precoPagamento", variaveis.precoPagamento);
                cmd.Parameters.AddWithValue("@nomeCliente", variaveis.nomeCliente);

                //FIM PARÁMETROS    
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pagamento alterado com sucesso!", "CADASTRO ALTERARADO");
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar o Pagamento!\n\n." + erro.Message, "ERRO!");
            }
        }


        //SEÇÃO CLIENTE//

        //LISTAR CLIENTE

        public static void CarregarCliente()
        {
            try
            { 

                conexao.Conectar();
                //ONDE MUDAMOS SOMENTE O CODIGO SELECTE
                string selecionar = "SELECT * FROM tblcliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgCliente.DataSource = dt;

                dgCliente.Columns[0].Visible = false;
                dgCliente.Columns[1].HeaderText = "Nome";
                dgCliente.Columns[2].HeaderText = "Data de Nascimento";
                dgCliente.Columns[3].HeaderText = "Telefone";
                dgCliente.Columns[4].HeaderText = "Endereço/Bairro";
                dgCliente.Columns[5].HeaderText = "Pagamentos Pendente";
                dgCliente.Columns[6].HeaderText = "Status";

                dgCliente.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro) 
            {
                MessageBox.Show("Erro ao carregar o Cliente!\n\n" + erro);
            }
        }


        public static void CarregarClienteNome()
        { 
            try
            {
                conexao.Conectar();
                //ONDE MUDAMOS SOMENTE O CODIGO SELECTE
                string selecionar = "SELECT * FROM tblcliente WHERE nomeCliente LIKE '%\"+variaveis.nomeInstrutor+\"%' ORDER BY nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgCliente.DataSource= dt;

                dgCliente.Columns[0].Visible = false;
                dgCliente.Columns[1].HeaderText = "Nome";
                dgCliente.Columns[2].HeaderText = "Data de Nascimento";
                dgCliente.Columns[3].HeaderText = "Telefone";
                dgCliente.Columns[4].HeaderText = "Endereço/Bairro";
                dgCliente.Columns[5].HeaderText = "Pagamentos Pendente";
                dgCliente.Columns[6].HeaderText = "Status";

                dgCliente.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar o Cliente!\n\n" + erro);
            }
        }

        //STATUS ATIVO 
        public static void CarregarStatusCliente()
        {
            try
            {
                conexao.Conectar();
                //ONDE MUDAMOS SOMENTE O CODIGO SELECTE
                string selecionar = "SELECT nomeCliente, statusCliente FROM tblcliente WHERE statusCliente = 'ATIVO' ORDER BY nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgCliente.DataSource = dt; //objeto não encontrado

                dgCliente.Columns[0].Visible = false;
                dgCliente.Columns[1].HeaderText = "Nome";
                dgCliente.Columns[2].HeaderText = "Data de Nascimento";
                dgCliente.Columns[3].HeaderText = "Telefone";
                dgCliente.Columns[4].HeaderText = "Endereço/Bairro";
                dgCliente.Columns[5].HeaderText = "Pagamentos Pendente";
                dgCliente.Columns[6].HeaderText = "Status";

                dgCliente.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar o Cliente!\n\n" + erro);
            }
        }


        //STATUS CLIENTE ONDE MOSTRAR O VALOR DO PAGAMENTO PENDENTE



        public static void CarregarStatusPendente()
        {
            try
            {
                conexao.Conectar();
                //ONDE MUDAMOS SOMENTE O CODIGO SELECTE
                string selecionar = "SELECT nomeCliente, statusCliente, pagamentosPendentes FROM tblcliente WHERE statusCliente = 'ATIVO' ORDER BY nomeCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgCliente.DataSource = dt;

                dgCliente.Columns[0].Visible = false;
                dgCliente.Columns[1].HeaderText = "Nome";
                dgCliente.Columns[2].HeaderText = "Data de Nascimento";
                dgCliente.Columns[3].HeaderText = "Telefone";
                dgCliente.Columns[4].HeaderText = "Endereço/Bairro";
                dgCliente.Columns[5].HeaderText = "Pagamentos Pendente";
                dgCliente.Columns[6].HeaderText = "Status";

                dgCliente.ClearSelection();

                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar o Cliente!\n\n" + erro);
            }
        }


        //INSERIR CLIENTE

        public static void InserirCliente()

        {
            try
            {
                conexao.Conectar();
                string inserir = "INSERT INTO `tblcliente`( `nomeCliente`, `dataNascCliente`, `telefoneCliente`, `enderecoCliente`, `pagamentosPendentes`, `statusCliente`) \r\nVALUES (@nomeCliente, @dataNascimentoC,@telefoneCliente,@enderecoCliente,@pagamentoPendCliente,@statusCliente);";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);

                cmd.Parameters.AddWithValue("@nomeCliente", variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@dataNascimentoC", variaveis.dataNascimentoC);
                cmd.Parameters.AddWithValue("@telefoneCliente", variaveis.telefoneClinte);
                cmd.Parameters.AddWithValue("@enderecoCliente", variaveis.enderecoCliente);
                cmd.Parameters.AddWithValue("@pagamentoPendCliente", variaveis.pagamentoPendCliente);
                cmd.Parameters.AddWithValue("@statusCliente", variaveis.statusCliente);

                //FIM PARÁMETROS    
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!", "CADASTRO CLIENTE");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o Cliente!\n\n" + erro.Message, "ERRO");
            }
        }

        public static void CarregarDadosCliente()
        {
            try
            {
                conexao.Conectar();
                conexao.Conectar();
                string selecionar = "SELECT * FROM tblcliente WHERE idCliente = codCliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
                cmd.Parameters.AddWithValue("@codigo", variaveis.codCliente);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    variaveis.nomeCliente = reader.GetString(1);
                    variaveis.dataNascimentoC = reader.GetDateTime(2);
                    variaveis.telefoneClinte = reader.GetString(3);
                    variaveis.enderecoCliente = reader.GetString(4);
                    variaveis.pagamentoPendCliente = reader.GetString(5);
                    variaveis.statusCliente = reader.GetString(6);
                }
                conexao.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os dados do cliente!\n\n" + erro);
            }
        }
        

    public static void AlterarCliente()
    {
        try
        {  conexao.Conectar();
           
            string selecionar = "UPDATE `tblcliente` SET nomeCliente = @nomeCliente, dataNascCliente = @dataNascimentoC, telefoneCliente = @telefoneCliente,enderecoCliente= @enderecoCliente, pagamentosPendentes= @pagamentoPendCliente, statusCliente = @statusCliente WHERE idCliente = codCliente;";
            MySqlCommand cmd = new MySqlCommand(selecionar, conexao.conn);
            cmd.Parameters.AddWithValue("@codigo", variaveis.codCliente);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                variaveis.nomeCliente = reader.GetString(1);
                variaveis.dataNascimentoC = reader.GetDateTime(2);
                variaveis.telefoneClinte = reader.GetString(3);
                variaveis.enderecoCliente = reader.GetString(4);
                variaveis.pagamentoPendCliente = reader.GetString(5);
                variaveis.statusCliente = reader.GetString(6);
            }
            conexao.Desconectar();
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro ao carregar os dados do cliente!\n\n" + erro);
        }
    }
    
        //DESATIVAR 

        public static void DesativarCliente()
        {
            try
            {
               
                conexao.Conectar();
                string inserir = "UPDATE tblcliente SET statusCliente = @statusCliente WHERE idCliente= @codCliente;";
                MySqlCommand cmd = new MySqlCommand(inserir, conexao.conn);

                //parametros
                cmd.Parameters.AddWithValue("@statusCliente", variaveis.statusCliente);
                cmd.Parameters.AddWithValue("@codCliente", variaveis.codCliente);
                // fim parametros

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente desativado com sucesso!", "EXCLUIR CLIENTE");
                conexao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao desativar o cliente!\n\n" + erro.Message, "ERRO");
            }
        }
        
    }


















    



























}





