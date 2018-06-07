using System;
using System.Collections.Generic;
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

        public void Adicionar()
        {
            throw new System.NotImplementedException();
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
                BD._sql = String.Format("DELETE FROM CLIENTE WHERE ID_CLIENTE = '{0}'", id_marca);

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
    }
}
