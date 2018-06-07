using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAutoPosto.Classes
{
    class clPesquisa
    {
        conectaBD BD = new conectaBD();

        private string tabela;
        private string clausula;
        private string valor;

        public string Tabela
        {
            get { return tabela; }
            set { tabela = value; }
        }

        public string Clausula
        {
            get { return clausula; }
            set { clausula = value; }
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public DataTable PesquisaGenerica(string clausula, string valor)
        {
            try
            {
                BD._sql = "SELECT  " +
                " * FROM " + tabela +
                "  WHERE C." + clausula + " LIKE '%" + valor + "%'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}
