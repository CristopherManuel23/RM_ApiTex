using RM_APItex.Controler;
using RM_APItex.Model;

namespace RM_APItex
{
    public partial class Form1 : Form
    {
        private CharacterControler charactersControler;
        private Characteres Characteres;

        public Form1()
        {
            InitializeComponent();
            charactersControler = new CharacterControler();
            Characteres = new Characteres();
        }

        private async void GetCharacteresAsync()
        {
            Characteres = await charactersControler.GetCharactersAsync(); //Llamamos el metodo que obtiene los personajes de la API

            if (Characteres != null)
            {
                foreach(var character in Characteres?.results)
                {
                    DataGridViewRow row = new DataGridViewRow(); //Crea una nueva fila para el datagridview
                    row.CreateCells(dgvCharacters);

                    row.Cells[0].Value = character.name;
                    row.Cells[1].Value = character.gender;
                    row.Cells[2].Value = character.species;
                    row.Cells[3].Value = character.origin.name;

                    dgvCharacters.Rows.Add(row);
                }
                
            }
            else
            {
                MessageBox.Show("No se pudo obtener la peticion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCharacteresAsync();
        }
    }
}
