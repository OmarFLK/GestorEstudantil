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
    }
}
