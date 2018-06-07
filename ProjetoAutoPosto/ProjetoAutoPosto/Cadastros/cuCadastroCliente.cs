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
    public partial class cuCadastroCliente : UserControl
    {
        CadastroGeral CadastroGeral = new CadastroGeral();
        public cuCadastroCliente()
        {
            InitializeComponent();
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                CadastroGeral.Nome = txtNome.Text;
            }
            catch (ValidationException ve)
            {
                e.Cancel = true;
                txtNome.Select(0, txtNome.Text.Length);
                this.errorProvider1.SetError(txtNome, ve.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                CadastroGeral.Nome = txtNome.Text;
            }
            catch (ValidationException ve)
            {
                MessageBox.Show("Houve um erro no processo de cadastro: " + ve.Message);
            }


            Classes.clCliente clCliente = new Classes.clCliente();


            clCliente.Nome = txtNome.Text;
            clCliente.Sobrenome = txtSobrenome.Text;
            clCliente.Cpf = Convert.ToString(mskCPF.Text);
            clCliente.Rg = Convert.ToString(mskRG.Text);
            clCliente.Cnpj = Convert.ToString(mskCNPJ);
            clCliente.Dt_Nascimento = Convert.ToDateTime(dtpDataNascimento.Value.ToShortDateString());
            clCliente.Logradouro = txtLogradouro.Text;
            clCliente.Bairro = txtBairro.Text;
            clCliente.Complemento = txtComplemento.Text;
            clCliente.Cep = Convert.ToString(mskCEP);
            clCliente.Telefone_Res = Convert.ToString(mskFoneRes.Text);
            clCliente.Telefone_Cel = Convert.ToString(mskFoneCel.Text);
            clCliente.Telefone_3 = Convert.ToString(mskFone3.Text);
            clCliente.Telefone_4 = Convert.ToString(mskFone4.Text);
            clCliente.Email_P = txtEmailP.Text;
            clCliente.Email_S = txtEmailS.Text;
            clCliente.Id_Cidade = Convert.ToInt16(cmbCidade.SelectedValue);
            clCliente.Id_Sexo = Convert.ToInt16(cmbSexo.SelectedValue);



        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if(rbJuridica.Checked == true)
            {
                mskCNPJ.Enabled = true;
            }
            else
            {
                mskCNPJ.Enabled = false;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space)) e.Handled = true;
        }

        private void cuCadastroCliente_Load(object sender, EventArgs e)
        {
            Classes.ListaTudo ListaTudo = new ListaTudo();

            cmbSexo.DataSource = ListaTudo.ListaSexos();
            cmbSexo.DisplayMember = "nome";
            cmbSexo.ValueMember = "id_sexo";
            cmbSexo.SelectedValue = -1;

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
