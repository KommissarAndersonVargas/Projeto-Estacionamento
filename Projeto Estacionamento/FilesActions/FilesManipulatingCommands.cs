using Projeto_Estacionamento.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estacionamento.FilesActions
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
    }
}
