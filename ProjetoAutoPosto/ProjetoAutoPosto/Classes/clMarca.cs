using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAutoPosto.Classes
{
    class clMarca
    {
        private int id_marca;
        private string nome;

        conectaBD BD = new conectaBD();

        public int Id_Marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO MARCA (nome) " +
                                       " values ('{0}')", nome) + "; SELECT SCOPE_IDENTITY();";

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

        public void Pesquisar()
        {
            throw new System.NotImplementedException();
        }

        public void Deletar()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM MARCA WHERE ID_MARCA = '{0}'", id_marca);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Marca", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Marca deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }
    }
}
