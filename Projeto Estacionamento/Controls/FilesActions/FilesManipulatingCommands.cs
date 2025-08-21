using Newtonsoft.Json;
using Projeto_Estacionamento.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estacionamento.Controls.FilesActions
{
    public static class FilesManipulatingCommands
    {
        public static void SaveJasonFile()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Arquivos JSON (*.json)|*.json|Todos os arquivos (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string jsonString = System.Text.Json.JsonSerializer.Serialize(Infocar.infocarsList);
                        File.WriteAllText(saveFileDialog.FileName, jsonString);

                        MessageBox.Show("Arquivo salvo com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivos JSON (*.json)|*.json|Todos os arquivos (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jsonString = System.Text.Json.JsonSerializer.Serialize(Infocar.infocarsList);
                    File.WriteAllText(saveFileDialog.FileName, jsonString);

                    MessageBox.Show("Arquivo salvo com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public static void OpenFile(DataGridView dataGridView1)
        {
            try
            {
                Infocar.infocarsList = Desserialization();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Infocar.infocarsList;

            }
            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static BindingList<Infocar> Desserialization()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos JSON (*.json)|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var car = JsonConvert.DeserializeObject<BindingList<Infocar>>(File.ReadAllText(openFileDialog.FileName));
                return car;
            }
            else
            {
                return null;
            }
        }
    }
}
