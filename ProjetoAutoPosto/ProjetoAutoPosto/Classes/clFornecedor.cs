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
    class clFornecedor
    {
        private string bairro;
        private string cep;
        private int id_cidade;
        private string cnpj;
        private string complemento;
        private string email_p;
        private string email_s;
        private int id_estado;
        private string fantasia;
        private string telefone_fax;
        private int id_fornecedor;
        private string inscricao_estadual;
        private string logradouro;
        private string telefone_cel;
        private string telefone_com;
        private string telefone_whats;
        private string razao_social;

        conectaBD BD = new conectaBD();

        public string Fantasia
        {
            get { return fantasia; }
            set { fantasia = value; }
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Inscricao_Estadual
        {
            get { return inscricao_estadual; }
            set { inscricao_estadual = value; }
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

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public int Id_Estado
        {
            get { return id_estado; }
            set { id_estado = value; }
        }

        public int Id_Cidade
        {
            get { return id_cidade; }
            set { id_cidade = value; }
        }

        public string Telefone_Cel
        {
            get { return telefone_cel; }
            set { telefone_cel = value; }
        }

        public string Telefone_com
        {
            get { return telefone_com; }
            set { telefone_com = value; }
        }

        public string Telefone_Fax
        {
            get { return telefone_fax; }
            set { telefone_fax = value; }
        }

        public string Telefone_Whats
        {
            get { return telefone_whats; }
            set { telefone_whats = value; }
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

        public int Id_Fornecedor
        {
            get { return id_fornecedor; }
            set { id_fornecedor = value; }

        }

        public string Razao_Social
        {
            get { return razao_social; }
            set { razao_social = value; }
        }


        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO FORNECEDOR (id_cidade,bairro,cep,complemento,fantasia,razao_social,email_p,email_s,logradouro,cnpj," +
                                                                 "inscricao_estadual,telefone_fax,telefone_cel,telefone_com,telefone_whats) " +
                                       " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')", id_cidade, bairro, cep, complemento, fantasia, razao_social, email_p, email_s, logradouro, cnpj, inscricao_estadual,telefone_fax,telefone_cel,telefone_com,telefone_whats) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Fornecedor cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;

        }

        public void Atualizar()
        {
            throw new System.NotImplementedException();
        }

        public void Deletar()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM FORNECEDOR WHERE ID_FORNECEDOR = '{0}'", id_fornecedor);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fornecedor deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }


        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT C.id_fornecedor as 'Id', C.fantasia as 'Nome', C.cnpj as 'CNPJ', " +
                                 " C.razao_social as 'SOCIAL'" +
                "  FROM FORNECEDOR C " +
                "  WHERE C.fantasia LIKE '%" + fantasia + "%'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
