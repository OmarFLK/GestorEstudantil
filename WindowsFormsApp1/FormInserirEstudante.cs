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
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormInserirEstudante_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            //Abri o gerenciador de arquivos para selecionar uma imagem(foto ou seja .png etc) pelo pc do usuario
            OpenFileDialog procurarfoto = new OpenFileDialog();

            procurarfoto.Filter = "Selecionar a foto(*.jpg;*.png;*.jpge;*.gif)|*.jpg;*.png;*.jpge;*.gif";

            if(procurarfoto.ShowDialog() == DialogResult.OK) 
            {
                pictureBoxFotoAlunoNovo.Image = Image.FromFile(procurarfoto.FileName);       
            }
        }

        bool Verificar() 
        {
            if((textBoxNome.Text.Trim() == "")   ||
              (textBoxSobreNome.Text.Trim() == "") ||
              (textBoxTelefone.Text.Trim() == "")  ||
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

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            ESTUDANTE estudante = new ESTUDANTE();
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
                pictureBoxFotoAlunoNovo.Image.Save(foto, pictureBoxFotoAlunoNovo.Image.RawFormat );
                if (estudante.inserirEstudante(nome, sobrenome, nascimento, telefone, endereco, genero, foto))
                {
                    MessageBox.Show("Novo aluno cadastrado!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                
                {
                    MessageBox.Show("Aluno não cadastrado", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else

            {
                MessageBox.Show("A campos não preenxidos em seu formulário de inscrição.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
