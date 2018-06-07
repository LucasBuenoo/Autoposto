using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAutoPosto.Classes
{
    class CadastroGeral
    {
        private String nome;
        public String Nome
        {
            set
            {
                if (value.Length < 1 )
                    throw new ValidationException("A propriedade Nome não pode ser nula.");
                /*
                 * Regex rgx = new Regex(@"(\w+)");

                if (!rgx.IsMatch(value))
                {
                    throw new ValidationException("O campo Nome Não pode ser nulo e nao pode conter numeros.");
                }
                nome = value;
                 */
                nome = value;
            }
            get { return nome; }
        }

        private DateTime nascimento;
        public DateTime Nascimento
        {
            set
            {
                if (!(value < DateTime.Today))
                {
                    throw new ValidationException("A data de nascimento deve ser anterior a data hoje.");
                }
                nascimento = value;
            }
            get { return nascimento; }
        }

        private String marca;
        public String Marca
        {
            set
            {
                if (value.Length < 1)
                    throw new ValidationException("A propriedade Marca não pode ser nula.");
                nome = value;
            }
            get { return marca; }
        }

    }
}

