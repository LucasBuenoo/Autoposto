using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAutoPosto.ControleDeUsuario
{
    public partial class ControleDeUsuarioPesquisa : UserControl
    {
        public ControleDeUsuarioPesquisa()
        {
            InitializeComponent();
        }

        Classes.clPesquisa clPesquisa = new Classes.clPesquisa();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rbFuncionario.Checked)
            {
                Classes.clFuncionário funcionário = new Classes.clFuncionário();

                //Mapeia a origen dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
                funcionário.Nome = txtPesquisa.Text;
                dgvPesquisaGeral.DataSource = funcionário.PesquisaPorNome();
                //dgCliente.Columns[6].Visible = false;
                dgvPesquisaGeral.AutoResizeColumns();

            }

            if (rbCliente.Checked)
            {
                Classes.clCliente cliente = new Classes.clCliente();

                //Mapeia a origen dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
                cliente.Nome = txtPesquisa.Text;
                dgvPesquisaGeral.DataSource = cliente.PesquisaPorNome();
                //dgCliente.Columns[6].Visible = false;
                dgvPesquisaGeral.AutoResizeColumns();

            }

            if (rbFornecedor.Checked)
            {
                Classes.clFornecedor fornecedor = new Classes.clFornecedor();

                //Mapeia a origen dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
                fornecedor.Fantasia = txtPesquisa.Text;
                dgvPesquisaGeral.DataSource = fornecedor.PesquisaPorNome();
                //dgCliente.Columns[6].Visible = false;
                dgvPesquisaGeral.AutoResizeColumns();

            }

            if (rbProduto.Checked)
            {
                Classes.clProduto produto = new Classes.clProduto();

                //Mapeia a origen dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
                produto.Nome = txtPesquisa.Text;
                dgvPesquisaGeral.DataSource = produto.PesquisaPorNome();
                //dgCliente.Columns[6].Visible = false;
                dgvPesquisaGeral.AutoResizeColumns();

            }

            if (rbUsuario.Checked)
            {
                Classes.clUsuario usuario = new Classes.clUsuario();

                //Mapeia a origen dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
                usuario.Nome = txtPesquisa.Text;
                dgvPesquisaGeral.DataSource = usuario.PesquisaPorNome();
                //dgCliente.Columns[6].Visible = false;
                dgvPesquisaGeral.AutoResizeColumns();

            }

        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbFuncionario_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbFornecedor_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbProduto_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbUsuario_CheckedChanged(object sender, EventArgs e)
        {
        }


    }
}
