using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    internal class MeuBancoDeDados
    {
        // A conexão com o Banco de dados.

        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sga_estudantes_bd_t7");

        //acessar a variavel "conexão"
        public MySqlConnection GetConnection
        {
            get
            {
                return conexao;
            }
        }
        //função para abrir a conexão
        public void abrirconexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        //função para fehcar o canexao com o banco de daddos
        public void fecharconexao()
        {
            if (conexao.State == ConnectionState.Open)
                {
                     conexao.Close();
                }
        }

    }
}
