using Projeto_Estacionamento.Classes;
using Projeto_Estacionamento.AboutForm;
using Projeto_Estacionamento.Classes.Controls;
using Projeto_Estacionamento.Classes.Controls.FilesActions;

namespace Projeto_Estacionamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                Properties.Resources.SaveBeforeLeave,
                Properties.Resources.Confirmation,
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                FilesManipulatingCommands.SaveFile();
            }
            else if (result == DialogResult.No)
            {
                // This closes the program
            }
            else if (result == DialogResult.Cancel)
            {

                e.Cancel = true;
            }
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
            ControlsOperations.NewProject(dataGridView1);
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.NotFunctional,
                Properties.Resources.MessageBoxInfo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ajudaToolStripButton_Click(object sender, EventArgs e)
        {
            AboutFormParkingLot aboutForm = new AboutFormParkingLot();
            aboutForm.ShowDialog();
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            Infocar.PrintAllCarsInSystem();
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            //DELETE BUTTON (function)
        }

        private void SerachButton_Click(object sender, EventArgs e)
        {
            ControlsOperations.SearchInDataGrid(txtSearchText.Text, dataGridView1);
        }
    }
}