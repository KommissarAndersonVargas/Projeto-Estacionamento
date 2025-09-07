using Newtonsoft.Json;
using System.ComponentModel;

namespace Projeto_Estacionamento.Classes.Controls.FilesActions
{
    public static class FilesManipulatingCommands
    {
        public static void SaveJasonFile()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = Properties.Resources.AllJsonFilters;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string jsonString = System.Text.Json.JsonSerializer.Serialize(Infocar.infocarsList);
                        File.WriteAllText(saveFileDialog.FileName, jsonString);

                        MessageBox.Show(Properties.Resources.FileSaved,
                            Properties.Resources.MessageBoxInfo, 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.UnExcpectedError, 
                    Properties.Resources.MessageBoxError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void SaveFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = Properties.Resources.AllJsonFilters;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jsonString = System.Text.Json.JsonSerializer.Serialize(Infocar.infocarsList);
                    File.WriteAllText(saveFileDialog.FileName, jsonString);

                    MessageBox.Show(Properties.Resources.FileSaved,
                        Properties.Resources.MessageBoxInfo,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(Properties.Resources.UnExcpectedError,
                    Properties.Resources.MessageBoxError,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static BindingList<Infocar> Desserialization()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = Properties.Resources.JsonFilters;

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
