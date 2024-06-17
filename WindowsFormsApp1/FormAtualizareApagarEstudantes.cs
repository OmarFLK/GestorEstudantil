using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAtualizareApagarEstudantes : Form
    {
        public FormAtualizareApagarEstudantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            //Abri o gerenciador de arquivos para selecionar uma imagem(foto ou seja .png etc) pelo pc do usuario
            OpenFileDialog procurarfoto = new OpenFileDialog();

            procurarfoto.Filter = "Selecionar a foto(*.jpg;*.png;*.jpge;*.gif)|*.jpg;*.png;*.jpge;*.gif";

            if (procurarfoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFotoAlunoNovo.Image = Image.FromFile(procurarfoto.FileName);
            }
        }

        bool Verificar()
        {
            if ((textBoxNome.Text.Trim() == "") ||
              (textBoxSobreNome.Text.Trim() == "") ||
              (textBoxTelefone.Text.Trim() == "") ||
              (textBoxEndenreco.Text.Trim() == "") ||

              (pictureBoxFotoAlunoNovo.Image == null)
              )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            ESTUDANTE estudante = new ESTUDANTE();
            int id = Convert.ToInt32(textBoxId.Text);
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobreNome.Text;
            DateTime nascimento = dateTimePickerNascimento.Value;
            string telefone = textBoxTelefone.Text;
            string endereco = textBoxEndenreco.Text;
            string genero = "feminino";

            if (radioButtonMasculino.Checked == true)

            {
                genero = "Masculino";
            }

            MemoryStream foto = new MemoryStream();

            //verificar se tem entre 10 e 100 anos

            int anoDeNascimento = dateTimePickerNascimento.Value.Year;
            int anoAtual = DateTime.Now.Year;

            if ((anoAtual - anoDeNascimento) > 10 || (anoAtual - anoDeNascimento) > 100)

            {
                MessageBox.Show("O aluno precisa ter entre 10 e 100 anos",
                    "Ano de nascimento Inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (Verificar())
            {
                pictureBoxFotoAlunoNovo.Image.Save(foto, pictureBoxFotoAlunoNovo.Image.RawFormat);
                if (estudante.atualizarestudantes(nome, sobrenome, nascimento, telefone, endereco, genero, foto))
                {
                    MessageBox.Show("DADOS ATUALIZADOS", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else

                {
                    MessageBox.Show("NÃO FOI POSSIVEL ATUALIZAR", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else

            {
                MessageBox.Show("A campos não preenxidos em seu formulário de atualização.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


    }
}
