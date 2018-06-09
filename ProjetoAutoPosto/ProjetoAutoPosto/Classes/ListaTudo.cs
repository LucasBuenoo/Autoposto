using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAutoPosto.Classes
{
    class ListaTudo
    {
        conectaBD BD = new conectaBD();

        public DataTable ListaSexo()
        {
            try
            {
                BD._sql = "SELECT id_sexo, nome FROM SEXO";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataTable ListaEstadoCivil()
        {
            try
            {
                BD._sql = "SELECT id_estado_civil, nome FROM ESTADO_CIVIL";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataTable ListaEstado()
        {
            try
            {
                BD._sql = "SELECT id_estado, uf FROM ESTADO ORDER BY UF";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataTable ListaCidade()
        {
            try
            {
                BD._sql = "SELECT id_cidade, nome FROM CIDADE  ORDER BY NOME";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataTable ListaCidadePorUf(Int16 uf)
        {
            try
            {
                BD._sql = "SELECT id_cidade, nome FROM CIDADE where id_estado = " + "'" + uf.ToString() + "' ORDER BY NOME";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;
        }
    }
}
