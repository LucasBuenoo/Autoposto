using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoAutoPosto.Classes
{
    internal class clUsuario
    {
        conectaBD BD = new conectaBD();

        private int id_usuario;
        private int id_funcionario;
        private string nome;
        private string senha;
        private string conf_senha;

        public string Conf_Senha
        {
            get { return conf_senha; }
            set { conf_senha = value; }
        }

        public int Id_Usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public int Id_Funcionario
        {
            get { return id_funcionario; }
            set { id_funcionario = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public int Atualizar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO USUARIO (senha,conf_senha,nome) " +
                                       " values ('{0}','{1}','{2}')", senha, conf_senha, nome) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;

        }

        public void Pesquisar()
        {
            throw new System.NotImplementedException();
        }

        public void Adicionar()
        {
            throw new System.NotImplementedException();
        }

        public void Deletar()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM USUARIO WHERE ID_USUARIO = '{0}'", id_usuario);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuário deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                BD._sql = "SELECT U.id_funcionario as 'Id', u.nome as nome_usuario, f.nome as nome_funcionario, f.sobrenome" +
                "  FROM USUARIO U LEFT JOIN FUNCIONARIO f on u.id_funcionario = f.id_funcionario " +
                "  where u.nome like " + "'" + nome + "'" + " or f.nome like " + "'" + nome + "'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}