using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAutoPosto.TelaPrincipal
{
    public partial class frmPrincipal : Form
    {
        Boolean fl_encerra = true;

        public frmPrincipal()
        {
            InitializeComponent();
            SidePainel.Height = btnHome.Height;
            SidePainel.Top = btnHome.Top;
            controleDeUsuarioHome1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePainel.Height = btnHome.Height;
            SidePainel.Top = btnHome.Top;
            controleDeUsuarioHome1.BringToFront();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            SidePainel.Height = btnCadastro.Height;
            SidePainel.Top = btnCadastro.Top;
            controleDeUsuarioCadastro1.BringToFront();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            SidePainel.Height = btnPesquisa.Height;
            SidePainel.Top = btnPesquisa.Top;
            controleDeUsuarioPesquisa1.BringToFront();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            SidePainel.Height = btnRelatorio.Height;
            SidePainel.Top = btnRelatorio.Top;
            controleDeUsuarioRelatorio1.BringToFront();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            SidePainel.Height = btnCaixa.Height;
            SidePainel.Top = btnCaixa.Top;
            
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            SidePainel.Height = btnSobre.Height;
            SidePainel.Top = btnSobre.Top;
           //cuSobre1.BringToFront();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            SidePainel.Height = btnLogoff.Height;
            SidePainel.Top = btnLogoff.Top;

            fl_encerra = false;

            DialogResult resp;

            resp = MessageBox.Show("Deseja Fazer Logoff?", "Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
            else
            {

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            SidePainel.Height = btnSair.Height;
            SidePainel.Top = btnSair.Top;

            this.Close();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fl_encerra)
            {
                Application.Exit();
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fl_encerra)
            {
                DialogResult resp;
                resp = MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

