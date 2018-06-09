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

namespace ProjetoAutoPosto.Cadastros
{
    public partial class cuCadastroProduto : UserControl
    {

        public cuCadastroProduto()
        {
            InitializeComponent();
        }

        Classes.ListaTudo ListaMarca = new ListaMarca();

        private void btnADD_Click(object sender, EventArgs e)
        {
            Forms.frmMarca Pesquisa = new Forms.frmMarca();
            Pesquisa.ShowDialog();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Classes.clProduto clProduto = new Classes.clProduto();
            clProduto.Nome = txtNome.Text;
            clProduto.Dt_Cadastro = Convert.ToDateTime(mskData_Cadastro.Text);
            clProduto.Preco_Custo = Convert.ToDouble(txtCusto.Text);
            clProduto.Preco_Venda = Convert.ToDouble(txtVenda.Text);
            clProduto.Codigo_Barra = txtCodigoBarra.Text;

            txtCodigo.Text = Convert.ToString(clProduto.Adicionar());
        }
       
    }
}
