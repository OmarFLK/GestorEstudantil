using MySql.Data.MySqlClient;
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
    public partial class FormListarEstudantes : Form
    {
        public FormListarEstudantes()
        {
            InitializeComponent();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void FormListarEstudantes_Load(object sender, EventArgs e)
        {

        }

        ESTUDANTE estudante = new ESTUDANTE();

        private void dataGridViewListadeAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //preenche o dataGridView com as informações dos estudantes.
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");

            dataGridViewListadeAlunos.ReadOnly = true;

            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();

            dataGridViewListadeAlunos.RowTemplate.Height = 80;

            dataGridViewListadeAlunos.DataSource = estudante.getEstdantes(comando);

            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListadeAlunos.Columns[7];

            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewListadeAlunos.AllowUserToAddRows = false;



        }

        private void dataGridViewListadeAlunos_DoubleClick(object sender, EventArgs e)
        {
            FormAtualizareApagarEstudantes formAtualizareApagarEstudantes = new FormAtualizareApagarEstudantes();


            formAtualizareApagarEstudantes.textBoxId.Text = dataGridViewListadeAlunos.CurrentRow.Cells[0].Value.ToString();
            formAtualizareApagarEstudantes.textBoxNome.Text = dataGridViewListadeAlunos.CurrentRow.Cells[1].Value.ToString();
            formAtualizareApagarEstudantes.textBoxSobreNome.Text = dataGridViewListadeAlunos.CurrentRow.Cells[2].Value.ToString();
            formAtualizareApagarEstudantes.textBoxTelefone.Text = dataGridViewListadeAlunos.CurrentRow.Cells[3].Value.ToString();
            formAtualizareApagarEstudantes.textBoxEndenreco.Text = dataGridViewListadeAlunos.CurrentRow.Cells[4].Value.ToString();
            formAtualizareApagarEstudantes.dateTimePickerNascimento.Value = (DateTime)dataGridViewListadeAlunos.CurrentRow.Cells[5].Value;

            if (dataGridViewListadeAlunos.CurrentRow.Cells[6].Value.ToString() == "Femnino")

            {
                formAtualizareApagarEstudantes.radioButtonFeminino.Checked = true;
            }
            else
                    {
                formAtualizareApagarEstudantes.radioButtonMasculino.Checked = true;

                byte[] foto;
                foto = (byte[])dataGridViewListadeAlunos.CurrentRow.Cells[7].Value;
                MemoryStream fotoDoAluno = new MemoryStream(foto);
                formAtualizareApagarEstudantes.pictureBoxFotoAlunoNovo.Image = Image.FromStream(fotoDoAluno);
                formAtualizareApagarEstudantes.Show();
            }
        }
    }
}
