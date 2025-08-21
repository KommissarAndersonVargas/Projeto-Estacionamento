using Projeto_Estacionamento.Classes;
using Projeto_Estacionamento.AboutForm;
using Projeto_Estacionamento.Controls;
using Projeto_Estacionamento.Controls.FilesActions;

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
            FilesManipulatingCommands.SaveFile();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            FilesManipulatingCommands.OpenFile(dataGridView1);
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
            ControlsOperations.ApplyFilter(comboBoxFilter, analise);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //FUTURO BOTAO DE EXCLUIR
        }
    }
}