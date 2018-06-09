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
    public partial class cuCadastroFuncionario : UserControl
    {
        CadastroGeral CadastroGeral = new CadastroGeral();
        Classes.clFuncionário clFuncionário = new clFuncionário();
        public cuCadastroFuncionario()
        {
            InitializeComponent();
        }

        Classes.ListaTudo ListaTudo = new ListaTudo();


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

            Classes.clFuncionário clFuncionário = new clFuncionário();
            clFuncionário.Nome = txtNome.Text;
            clFuncionário.Sobrenome = txtSobrenome.Text;
            clFuncionário.Dt_Nascimento = Convert.ToDateTime(dtpDataNascimento.Value.ToShortDateString());
            clFuncionário.Cpf = Convert.ToString(mskCPF.Text);
            clFuncionário.Rg = Convert.ToString(mskRG.Text);
            clFuncionário.Nacionalidade = txtNacionalidade.Text;
            clFuncionário.Naturalidade = txtNaturalidade.Text;
            clFuncionário.Salario = Convert.ToDouble(nudSalario.Text);
            clFuncionário.Logradouro = txtLogradouro.Text;
            clFuncionário.Bairro = txtBairro.Text;
            clFuncionário.Complemento = txtComplemento.Text;
            clFuncionário.Cep = Convert.ToString(mskCEP.Text);
            clFuncionário.Telefone_Res = Convert.ToString(mskFoneRes.Text);
            clFuncionário.Telefone_Cel = Convert.ToString(mskFoneCel.Text);
            clFuncionário.Telefone_Whats = Convert.ToString(mskFoneWhats.Text);
            clFuncionário.Telefone_3 = Convert.ToString(mskFone3.Text);
            clFuncionário.Email_P = txtEmailP.Text;
            clFuncionário.Email_S = txtEmailS.Text;
            clFuncionário.Id_Estado_Civil = Convert.ToInt16(cmbEstadoCivil.SelectedValue);
            clFuncionário.Id_Cidade = Convert.ToInt16(cmbCidade.SelectedValue);
            clFuncionário.Id_Sexo = Convert.ToInt16(cmbSexo.SelectedValue);

            txtID.Text = Convert.ToString(clFuncionário.Adicionar());
        }

        private void cuCadastroFuncionario_Load(object sender, EventArgs e)
        {
           
            cmbSexo.DataSource = ListaTudo.ListaSexo();
            cmbSexo.DisplayMember = "nome";
            cmbSexo.ValueMember = "id_sexo";
            cmbSexo.SelectedValue = -1;

            cmbEstadoCivil.DataSource = ListaTudo.ListaEstadoCivil();
            cmbEstadoCivil.DisplayMember = "nome";
            cmbEstadoCivil.ValueMember = "id_estado_civil";
            cmbEstadoCivil.SelectedValue = -1;

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
