using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System.Data;
using System.ComponentModel;
using Projeto_Estacionamento.Classes;
using Projeto_Estacionamento.Factory;
using Projeto_Estacionamento.AboutForm;

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
            try
            {
                GlobalVariables.arriveHour = int.Parse(txtbArriveHour.Text);
                GlobalVariables.arriveMin = int.Parse(txtbArriveMin.Text);
                GlobalVariables.plot = txtbrrivePlot.Text.ToString();
                string data = DateTimePicker.Text;

                GlobalVariables.arriveTime
                    =
                new DateTime(GlobalVariables.TimeNow.Year, GlobalVariables.TimeNow.Month, GlobalVariables.TimeNow.Day, GlobalVariables.arriveHour, GlobalVariables.arriveMin, 0);
                DateTime HoraEntrada = GlobalVariables.arriveTime;

                GlobalVariables.car = InfocarSimpleFactory.CreateCar(GlobalVariables.plot, HoraEntrada, data, "ainda não calculado");

                Infocar.infocarsList.Add((Infocar)GlobalVariables.car);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Infocar.infocarsList;

                this.PrepareArriveInputControls();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrepareArriveInputControls()
        {
            txtbArriveHour.Clear();
            txtbArriveMin.Clear();
            txtbrrivePlot.Clear();
            txtbArriveHour.Focus();
            txtbArriveMin.Focus();
            txtbrrivePlot.Focus();
        }

        private void calculateHours_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var cars in Infocar.infocarsList)
                {
                    if (txtbLeftPlot.Text.Equals(cars.Placa))
                    {
                        GlobalVariables.leftTimeHour = int.Parse(txtbLeftHour.Text);
                        GlobalVariables.leftMin = int.Parse(txtbLeftMin.Text);
                        GlobalVariables.leftHour
                            =
                        new DateTime(GlobalVariables.TimeNow.Year, GlobalVariables.TimeNow.Month, GlobalVariables.TimeNow.Day, GlobalVariables.leftTimeHour, GlobalVariables.leftMin, 0);
                        GlobalVariables.difference = GlobalVariables.leftHour.Subtract(cars.Time);

                        cars.Tempo_Permanenica = GlobalVariables.difference.ToString();

                        Infocar.PaymentLogic(cars);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Infocar.infocarsList;
                    }
                }

                this.PrepareExitInputControls();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrepareExitInputControls()
        {
            txtbLeftHour.Clear();
            txtbLeftMin.Clear();
            txtbLeftPlot.Clear();
            txtbLeftHour.Focus();
            txtbLeftMin.Focus();
            txtbLeftPlot.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVariables.difference = GlobalVariables.leftHour.Subtract(GlobalVariables.arriveTime);
                GlobalVariables.timeSpanList.Add(GlobalVariables.difference);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Registro_de_Veiculos registro_De_Veiculos = new Registro_de_Veiculos();
                registro_De_Veiculos.ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro: \n\n" + er.ToString());
            }
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
            catch(Exception)
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
                if (GlobalVariables.filterValues.Count() != 0) {GlobalVariables.filterValues.Clear();}
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

        private void button7_Click_1(object sender, EventArgs e)
        {
            txtbArriveHour.Text = Infocar.infocarsList.Count.ToString();
            //FUTURO
        }
    }
}