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
    public partial class cuCadastroFornecedor : UserControl
    {
        public cuCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Classes.clFornecedor clFornecedor = new Classes.clFornecedor();

            clFornecedor.Fantasia = txtFantasia.Text;
            clFornecedor.Razao_Social = txtRazaoSocial.Text;
            clFornecedor.Cnpj = Convert.ToString(mskCNPJ.Text);
            clFornecedor.Inscricao_Estadual = Convert.ToString(mskInscricaoEstadual.Text);
            clFornecedor.Logradouro = txtLougadouro.Text;
            clFornecedor.Bairro = txtBairro.Text;
            clFornecedor.Cep = Convert.ToString(mskCEP.Text);
            clFornecedor.Complemento = txtComplemento.Text;
            clFornecedor.Telefone_Res = Convert.ToString(mskFoneRes.Text);
            clFornecedor.Telefone_Cel = Convert.ToString(mskFoneCel.Text);
            clFornecedor.Telefone_Fax = Convert.ToString(mskFoneFax.Text);
            clFornecedor.Telefone_Whats = Convert.ToString(mskFoneWhats.Text);
            clFornecedor.Email_P = txtEmailP.Text;
            clFornecedor.Email_S = txtEmailS.Text;
        }

        private void cuCadastroFornecedor_Load(object sender, EventArgs e)
        {
            Classes.ListaTudo ListaTudo = new Classes.ListaTudo();

            cmbEstado.DataSource = ListaTudo.ListaEstado();
            cmbEstado.DisplayMember = "uf";
            cmbEstado.ValueMember = "id_estado";
            cmbEstado.SelectedValue = -1;

            cmbCidade.DataSource = ListaTudo.ListaCidade();
            cmbCidade.DisplayMember = "nome";
            cmbCidade.ValueMember = "id_cidade";
            cmbCidade.SelectedValue = -1;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classes.ListaTudo ListaTudo = new Classes.ListaTudo();

            if (cmbEstado.SelectedIndex != 0)
            {
                Int16 uf = Convert.ToInt16(cmbEstado.SelectedValue);
                cmbCidade.DataSource = ListaTudo.ListaCidadePorUf(uf);
                cmbCidade.DisplayMember = "nome";
                cmbCidade.ValueMember = "id_cidade";
                cmbCidade.SelectedValue = -1;
            }
        }
    }
}
