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
    class clProduto
    {
        conectaBD BD = new conectaBD();

        private string nome;
        private DateTime dt_cadastro;
        private Double preco_custo;
        private Double preco_venda;
        private string unidade_medida;
        private string codigo_barra;
        private int id_produto;
        private int id_fornecedor;
        private int id_marca;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime Dt_Cadastro
        {
            get { return dt_cadastro; }
            set { dt_cadastro = value; }
        }

        public Double Preco_Custo
        {
            get { return preco_custo; }
            set { preco_custo = value; }
        }

        public Double Preco_Venda
        {
            get { return preco_venda; }
            set { preco_venda = value; }
        }

        public string Unidade_Medida
        {
            get { return unidade_medida; }
            set { unidade_medida = value; }
        }

        public string Codigo_Barra
        {
            get { return codigo_barra; }
            set { codigo_barra = value; }
        }

        public int Id_Produto
        {
            get { return id_produto; }
            set { id_produto = value; }
        }

        public int Id_Fornecedor
        {
            get { return id_fornecedor; }
            set { id_fornecedor = value; }
        }

        public int Id_Marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }

        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO PRODUTO (preco_custo,preco_venda,codigo_barra,dt_cadastro,nome) " +
                                       " values ('{0}','{1}','{2}','{3}','{4}')", preco_custo, preco_venda, codigo_barra, dt_cadastro.ToShortDateString(), nome) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT C.id_produto as 'Id', C.nome as 'Nome'," +
                                 " C.dt_cadastro as 'CADASTRO', C.codigo_barra as 'COD.BARRA' " +
                "  FROM PRODUTO C " +
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
