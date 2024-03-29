﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzariaLeVelmont
{
    public partial class Funcionario_Cadastrar : Form
    {
        public Funcionario_Cadastrar()
        {
            InitializeComponent();
        }

        private void Funcionario_Cadastrar_Load(object sender, EventArgs e)
        {
            if (variaveis.funcao == "ALTERAR")
            {
                lblFuncionario.Text = "Alterar Informações do Funcionário";
                btnCadastrar.Text = "ALTERAR";
                banco.CarregarDadosFuncionario();
                txtNome.Text = variaveis.nomeFuncionario;
                txtEmail.Text = variaveis.emailFuncionario;
                txtCPF.Text = variaveis.cpfFuncionario;
                txtSenha.Text = variaveis.senhaFuncionario;
                mtbDataNasc.Text = variaveis.dataNascFuncionario.ToString();
                mkbTelefone.Text = variaveis.telefoneFuncionario;
                cmbTurno.Text = variaveis.turnoFuncionario;
                cmbFuncao.Text = variaveis.funcaoFuncionario;
                cmbNivel.Text = variaveis.nivelFuncionario;
                cmbStatus.Text = variaveis.statusFuncionario;
               

                txtNome.Enabled = true;
                txtEmail.Enabled = true;
                txtCPF.Enabled = true;
                txtSenha.Enabled = true;
                mtbDataNasc.Enabled = true;
                mkbTelefone.Enabled = true;
                cmbTurno.Enabled = true;
                cmbFuncao.Enabled = true;
                cmbNivel.Enabled = true;
                cmbStatus.Enabled = true;
                btnCadastrar.Enabled = true;
                btnLimpar.Enabled = false;



            }
        } //Alterar Informações

        private void pctSair_Click(object sender, EventArgs e)
        {
            new Funcionario_Listar().Show();
            Close();
        } //SAIR

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.FromArgb(75, 73, 73);
            lblEmail.ForeColor = Color.FromArgb(75, 73, 73);
            lblCPF.ForeColor = Color.FromArgb(75, 73, 73);
            lblDataNasc.ForeColor = Color.FromArgb(75, 73, 73);
            lblTelefone.ForeColor = Color.FromArgb(75, 73, 73);
            lblTurno.ForeColor = Color.FromArgb(75, 73, 73);
            lblFuncao.ForeColor = Color.FromArgb(75, 73, 73 );
            lblNivel.ForeColor = Color.FromArgb(75, 73, 73);
            lblStatus.ForeColor = Color.FromArgb(75, 73, 73);

            if (txtNome.Text.Length <= 3) //Não aceita menos que 4 caracteres
            {
                MessageBox.Show("Favor colocar o nome completo");
                txtNome.Clear();
                txtNome.Focus();
                lblNome.ForeColor = Color.Red;
            } //Nome


            else if (txtEmail.Text == "")//Não aceita Texto vazio
            {
                MessageBox.Show("Favor colocar o cargo");
                txtEmail.Clear();
                txtEmail.Focus();
                lblEmail.ForeColor = Color.Red;
            } //Email


            else if (txtCPF.Text == "")//Não aceita Texto vazio
            {
                MessageBox.Show("Favor colocar email");
                txtCPF.Clear();
                txtCPF.Focus();
                lblCPF.ForeColor = Color.Red;
            } //CPF

            else if (txtSenha.Text == "")//Não aceita Texto vazio
            {
                MessageBox.Show("Favor colocar senha");
                txtSenha.Clear();
                txtSenha.Focus();
                lblSenha.ForeColor = Color.Red;
            }//Senha


            else if (mtbDataNasc.MaskCompleted == false)//Não aceita data incompleta
            {
                MessageBox.Show("Favor colocar data de nascimento completa ");
                mtbDataNasc.Clear();
                mtbDataNasc.Focus();
                lblDataNasc.ForeColor = Color.Red;
            } //Data Nascimeto


            else if (mkbTelefone.MaskCompleted == false)//Não aceita telefone vazio
            {
                MessageBox.Show("Favor colocar telefone completa ");
                mkbTelefone.Clear();
                mkbTelefone.Focus();
                lblTelefone.ForeColor = Color.Red;
            } //Telefone


            else if (cmbTurno.Text == "")//Não aceita campo vazio
            {
                MessageBox.Show("Favor selecionar especialidade");
                cmbTurno.SelectedIndex = -1;
                cmbTurno.Focus();
                lblTurno.ForeColor = Color.Red;
            } //Turno


            else if (cmbFuncao.Text == "")//Não aceita campo vazio
            {
                MessageBox.Show("Favor selecionar status");
                cmbFuncao.SelectedIndex = -1;
                cmbFuncao.Focus();
                lblFuncao.ForeColor = Color.Red;
            } //Função


            else if (cmbNivel.Text == "") //Não aceita campo vazio
            {
                MessageBox.Show("Favor selecionar nível");
                cmbNivel.SelectedIndex = -1;
                cmbNivel.Focus();
                lblNivel.ForeColor = Color.Red;
            } //Nível


            else if (cmbStatus.Text == "")//Não aceita campo vazio
            {
                MessageBox.Show("Favor selecionar status");
                cmbStatus.SelectedIndex = -1;
                cmbStatus.Focus();
                lblStatus.ForeColor = Color.Red;
            } //Status


            else
            {
                variaveis.nomeFuncionario = txtNome.Text;
                variaveis.emailFuncionario = txtEmail.Text;
                variaveis.cpfFuncionario = txtCPF.Text;
                variaveis.senhaFuncionario = txtSenha.Text;
                variaveis.dataNascFuncionario = DateTime.Parse(mtbDataNasc.Text);
                variaveis.telefoneFuncionario = mkbTelefone.Text;
                variaveis.turnoFuncionario = cmbTurno.Text;
                variaveis.funcaoFuncionario = cmbFuncao.Text;
                variaveis.nivelFuncionario = cmbNivel.Text;
                variaveis.statusFuncionario = cmbStatus.Text;


                if (variaveis.funcao == "CADASTRAR")
                {
                    banco.InserirFuncionario();
                    btnCadastrar.Enabled = false;
                    btnLimpar.PerformClick();
                    new Funcionario_Listar().Show();
                    Close();
                }
                else if (variaveis.funcao == "ALTERAR")
                {
                    banco.AlterarFuncionario();
                    new Funcionario_Listar().Show();
                    Hide();

                }
                btnLimpar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
