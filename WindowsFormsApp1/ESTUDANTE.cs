using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ESTUDANTE
    {
        MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

        
       public bool inserirEstudante(string nome, string sobrenome, DateTime nascimento, string telefone, string genero, string endereco, MemoryStream foto)
        {
         MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`(`id`, `Nome`, `sobrenome`, `Nascimento`, `Genero`,  `Telefone`, `Endereco`, `foto`) VALUES(@Nome,@sobrenome,@Nascimento,@Genero,@Telefone,@Endereco,@foto,@id)");

            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@Nascimento", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@Genero", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@Endereco", MySqlDbType.Text).Value = endereco;
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto;

            meuBancoDeDados.abrirconexao();

            if (comando.ExecuteNonQuery() == 1)
            {
                meuBancoDeDados.fecharconexao();
                return true;
            }
            else 
            {
                meuBancoDeDados.fecharconexao();
                return false;
            }
        }
    }
}
