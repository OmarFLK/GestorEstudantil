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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void estudantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudante formInserirEstudante = new FormInserirEstudante();
            formInserirEstudante.ShowDialog();
        }

        private void estatísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarRemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pontosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
