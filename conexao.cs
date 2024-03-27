using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzariaLeVelmont
{
    public static class conexao
    {

        //string de conexão com o banco de dados
        //public static string db = "SERVER=localhost;USER=root;DATABASE=dbpizza";
        
        public static string db = "SERVER=195.179.239.0;USER=u283879542_levelmont;PASSWORD=SenacLeVelmont01;DATABASE=u283879542_levelmont;SSL MODE=None";

        //reconhecer a biblioteca do Mysql
        public static MySqlConnection conn;

        //método para conectar o banco de dados
        public static void Conectar()
        {
            try
            {
                conn = new MySqlConnection(db);
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o banco de dados", "ERRO");
            }

        }

        //Método para fechar o banco de dados
        public static void Desconectar()
        {
            try
            {
                conn = new MySqlConnection(db);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao desconectar com o banco de dados", "ERRO");
            }
        }


    }
}
