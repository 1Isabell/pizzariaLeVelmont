﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzariaLeVelmont
{
    public static class variaveis
    {

        //Geral
        public static int linhaSelecionada;
        public static string funcao;

        //Login
        public static string usuario, senha, nivel;




        //Funcionario - VANZELLI
        public static int codFuncionario;
        public static string nomeFuncionario, cpfFuncionario, telefoneFuncionario,emailFuncionario, turnoFuncionario, funcaoFuncionario, nivelFuncionario, statusFuncionario;
        public static DateTime dataNascFuncionario;


        //Estoque - VANZELLI
        public static int codEstoque, quantidadeEstoque, preçoEstoque;
        public static string nomeEstoque, fornecedorEstoque,categoriaEstoque, statusEstoque;
        public static DateTime dataValidadeEstoque;
        


        //PAGAMENTOS - ISABELLA
        public static int CodPagamento, precoPagamento;
        public static string   tipoPagamento, statusPagamento;

        //CLIENTE -ISABELLA

        public static int codCliente,pagamentoPendCliente;
        public static string nomeCliente, telefoneClinte, enderecoCliente, statusCliente;
        public static DateTime dataNascimentoC;


        // Produto Maycon
        public static int codProduto, precoProduto;
        public static string nomeProduto, tipoProduto, descricaoProduto, categoriaProduto, statusProduto;

    }


}
