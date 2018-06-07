using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAutoPosto.Classes
{
    class clFuncionário
    {
        private string bairro;
        private string cep;
        private string complemento;
        private string cpf;
        private DateTime dt_nascimento;
        private string email_p;
        private string email_s;
        private int id_sexo;
        private int id_funcionario;
        private string logradouro;
        private string nacionalidade;
        private string nome;
        private string rg;
        private string sobrenome;
        private string telefone_3;
        private string telefone_cel;
        private string telefone_res;
        private string telefone_whats;
        private string naturalidade;
        private int id_cidade;
        private int id_estado;
        private Double salario;
        private int id_estado_civil;

        conectaBD BD = new conectaBD();

        public Double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public DateTime Dt_Nascimento
        {
            get { return dt_nascimento; }
            set { dt_nascimento = value; }
        }

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Telefone_Res
        {
            get { return telefone_res; }
            set { telefone_res = value; }
        }

        public string Telefone_Cel
        {
            get { return telefone_cel; }
            set { telefone_cel = value; }
        }

        public string Email_P
        {
            get { return email_p; }
            set { email_p = value; }
        }

        public string Email_S
        {
            get { return email_s; }
            set { email_s = value; }
        }

        public string Telefone_3
        {
            get { return telefone_3; }
            set { telefone_3 = value; }
        }

        public int Id_Sexo
        {
            get { return id_sexo; }
            set { id_sexo = value; }
        }

        public int Id_Funcionario
        {
            get { return id_funcionario; }
            set { id_funcionario = value; }
        }

        public string Telefone_Whats
        {
            get { return telefone_whats; }
            set { telefone_whats = value; }
        }

        public int Id_Cidade
        {
            get { return id_cidade; }
            set { id_cidade = value; }
        }

        public int Id_Estado
        {
            get { return id_estado; }
            set { id_estado = value; }
        }

        public string Naturalidade
        {
            get { return naturalidade; }
            set { naturalidade = value; }
        }


        public int Id_Estado_Civil
        {
            get { return id_estado_civil; }
            set { id_estado_civil = value; }
        }


        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO FUNCIONARIO (id_sexo,id_estado_civil,id_cidade,bairro,cep,complemento,cpf,dt_nascimento,email_p,email_s,logradouro,nacionalidade," +
                                                                 "nome,rg,sobrenome,telefone_3,telefone_cel,telefone_res,telefone_whats,naturalidade,salario) " +
                                       " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}')", id_sexo, id_estado_civil, id_cidade, bairro, cep, complemento, cpf, dt_nascimento.ToShortDateString(), email_p, email_s, logradouro, nacionalidade, nome, rg, sobrenome, telefone_3, telefone_cel, telefone_res, telefone_whats, naturalidade, salario) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;

        }

        public void Deletar()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM CLIENTE WHERE ID_CLIENTE = '{0}'", id_funcionario);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        public void Atualizar()
        {
            throw new System.NotImplementedException();
        }

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT C.id_funcionario as 'Id', C.nome as 'Nome', C.sobrenome as 'SOBRENOME', " +
                                 " C.dt_nascimento as 'Nascimento', C.cpf as 'CPF' " +
                "  FROM FUNCIONARIO C " +
                "  WHERE C.nome LIKE '%" + nome + "%'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }


        public void Excluir()
        {
            throw new System.NotImplementedException();
        }


    }
}
