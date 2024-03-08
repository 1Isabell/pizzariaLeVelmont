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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //  PEGA OS VALORES DA CAIXA DE EMAIL
            variaveis.usuario = txtEmail.Text;

            new frmMenuPrincipal().Show();
            Hide();
        }
    }
}
