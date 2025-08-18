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
            ControlsOperations.SaveFile();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            ControlsOperations.OpenFile(dataGridView1);
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
            ControlsOperations.SearchInDataGrid(txtSearchText.Text, dataGridView1);
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            Infocar.PrintAllCarsInSystem();
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
            //FUTURO BOTAO DE EXCLUIR
        }
    }
}