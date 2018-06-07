using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAutoPosto.Cadastros
{
    public partial class rbFunc : UserControl
    {
        public rbFunc()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Classes.clUsuario clUsuario = new Classes.clUsuario();

            clUsuario.Senha = txtSenha.Text;
            clUsuario.Conf_Senha = txtConf_Senha.Text;
            clUsuario.Nome = txtUsername.Text;

         
        }
    }
}
