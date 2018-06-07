using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAutoPosto.Classes;

namespace ProjetoAutoPosto.ControleDeUsuario
{
    public partial class ControleDeUsuarioCadastro : UserControl
    {
        public ControleDeUsuarioCadastro()
        {
            InitializeComponent();
            cuCadastroCliente1.Visible = false;
            cuCadastroFornecedor1.Visible = false;
            cuCadastroFuncionario1.Visible = false;
            cuCadastroProduto1.Visible = false;
            cuCadastroUsuario1.Visible = false;
        }

        private void btnAbrirCliente_Click(object sender, EventArgs e)
        {
            SidePainel.Visible = true;
            SidePainel.Height = btnAbrirCliente.Height;
            SidePainel.Top = btnAbrirCliente.Top;
            cuCadastroCliente1.Visible = true;
            cuCadastroCliente1.BringToFront();
        }

        private void btnAbrirFornecedor_Click(object sender, EventArgs e)
        {
            SidePainel.Visible = true;
            SidePainel.Height = btnAbrirFornecedor.Height;
            SidePainel.Top = btnAbrirFornecedor.Top;
            cuCadastroFornecedor1.Visible = true;
            cuCadastroFornecedor1.BringToFront();
        }

        private void btnAbrirFuncionario_Click(object sender, EventArgs e)
        {
             SidePainel.Visible = true;
             SidePainel.Height = btnAbrirFuncionario.Height;
             SidePainel.Top = btnAbrirFuncionario.Top;
             cuCadastroFuncionario1.Visible = true;
             cuCadastroFuncionario1.BringToFront();
        }

        private void btnAbrirProduto_Click(object sender, EventArgs e)
        {
            SidePainel.Visible = true;
            SidePainel.Height = btnAbrirProduto.Height;
            SidePainel.Top = btnAbrirProduto.Top;
            cuCadastroProduto1.Visible = true;
            cuCadastroProduto1.BringToFront();
        }

        private void btnAbrirUsuario_Click(object sender, EventArgs e)
        {
            SidePainel.Visible = true;
            SidePainel.Height = btnAbrirUsuario.Height;
            SidePainel.Top = btnAbrirUsuario.Top;
            cuCadastroUsuario1.Visible = true;
            cuCadastroUsuario1.BringToFront();
        }
    }
}
