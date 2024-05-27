using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonadicionar_Click(object sender, EventArgs e)
        {
            //criando objetos poggers xd bruh stro try pog kkj UwU nog O-O ´-´
            MeuBancoDeDados meBbancoDeDados = new MeuBancoDeDados();

            MySqlDataAdapter mewaDaptadorSql = new MySqlDataAdapter();
            DataTable tabelaDeDados = new DataTable(); 
            MySqlCommand comandsql = new MySqlCommand("SELECT * FROM `usuários` WHERE `nome_de_usuario` =@usuario and `senha` =@senha", meBbancoDeDados.GetConnection);
            
            comandsql.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = textBoxusuario.Text ;
            comandsql.Parameters.Add("@senha", MySqlDbType.VarChar).Value = textBox2senha.Text;

            mewaDaptadorSql.SelectCommand = comandsql;

            mewaDaptadorSql.Fill(tabelaDeDados);

            if (tabelaDeDados.Rows.Count > 0)
            {
                this.DialogResult= DialogResult.OK; 
            }
            else 
            {
                MessageBox.Show("Usuário ou senha inválidos.","Erro de Login", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
