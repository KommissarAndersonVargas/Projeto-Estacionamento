using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System.Data;
using System.ComponentModel;
using Projeto_Estacionamento.Classes;
using Projeto_Estacionamento.Factory;
using Projeto_Estacionamento.AboutForm;
using Projeto_Estacionamento.Controls;

namespace Projeto_Estacionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addsMainInfo_Click(object sender, EventArgs e)
        {  
            ControlsOperations.AddsInputInformation(txtbArriveHour, txtbArriveMin, txtbrrivePlot, DateTimePicker, dataGridView1);
        }
       
        private void calculateHours_Click(object sender, EventArgs e)
        {
            ControlsOperations.CalculateHours(txtbLeftPlot, txtbLeftHour, txtbLeftMin, dataGridView1);
        }

        private void search_Click(object sender, EventArgs e)
        {
            Infocar.PrintOneTicket(txtBoxGenerateCupon.Text);
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
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

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Infocar.infocarsList = Desserialization();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Infocar.infocarsList;

                txtBoxGenerateCupon.Text = Infocar.infocarsList.Count().ToString();
                txtbArriveHour.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcao não aplicavel", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcao não aplicavel", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ajudaToolStripButton_Click(object sender, EventArgs e)
        {
            AboutFormParkingLot aboutForm = new AboutFormParkingLot();
            aboutForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtbArriveHour.Text = Infocar.infocarsList.Count().ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SearchInDataGrid(txtSearchText.Text);
        }


        private void SearchInDataGrid(string searchText)
        {
            try
            {
                dataGridView1.ClearSelection();
                bool found = false;

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    MessageBox.Show("Digite uma placa para pesquisar.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["Placa"].Value != null)
                    {
                        string placa = row.Cells["Placa"].Value.ToString().Trim();

                        // Comparação exata (case-insensitive)
                        if (placa.Equals(searchText, StringComparison.OrdinalIgnoreCase))
                        {
                            row.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                            found = true;
                            break;
                        }
                    }
                }

                if (!found)
                {
                    MessageBox.Show($"Placa '{searchText}' não encontrada.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro durante a busca: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            Infocar.PrintAllCarsInSystem();
        }

        static BindingList<Infocar> Desserialization()
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

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Equals("Tempo de Entrada: >"))
                {
                    if (GlobalVariables.filterValues.Count() != 0) { GlobalVariables.filterValues.Clear(); }
                    int selection = int.Parse(analise1.Text);
                    var result = Infocar.infocarsList.Where(info => info.Time.Hour > selection).Select(info => info.Placa);
                    foreach (var selectedInfo in result)
                    {
                        GlobalVariables.filterValues.Add($"Placa: {selectedInfo} \n");
                    }
                    Estati staticsForm = new Estati(GlobalVariables.filterValues, Infocar.infocarsList.Count());
                    staticsForm.ShowDialog();
                }
                if (comboBox1.Text.Equals("Tempo de Entrada: <"))
                {
                    if (GlobalVariables.filterValues.Count() != 0) { GlobalVariables.filterValues.Clear(); }
                    int selection = int.Parse(analise1.Text);
                    var result = Infocar.infocarsList
                        .Where(info => info.Time.Hour < selection)
                        .Select(info => info.Placa);

                    foreach (var selectedInfo in result)
                    {
                        GlobalVariables.filterValues.Add($"Placa: {selectedInfo} \n");
                    }
                    Estati staticsForm = new Estati(GlobalVariables.filterValues, Infocar.infocarsList.Count());
                    staticsForm.ShowDialog();
                }
                if (comboBox1.Text.Equals("Tempo de Entrada: ="))
                {
                    if (GlobalVariables.filterValues.Count() != 0) { GlobalVariables.filterValues.Clear(); }
                    int selection = int.Parse(analise1.Text);
                    var result = Infocar.infocarsList
                        .Where(info => info.Time.Hour.Equals(selection))
                        .Select(info => info.Placa);

                    foreach (var selectedInfo in result)
                    {
                        GlobalVariables.filterValues.Add($"Placa: {selectedInfo} \n");
                    }
                    Estati staticsForm = new Estati(GlobalVariables.filterValues, Infocar.infocarsList.Count());
                    staticsForm.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            txtbArriveHour.Text = Infocar.infocarsList.Count.ToString();
            //FUTURO
        }
    }
}