using iTextSharp.text;
using Projeto_Estacionamento.Classes;
using Projeto_Estacionamento.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Estacionamento.Controls
{
    /// <summary>
    /// Logic for the main form controls. WIP
    /// </summary>
    public static class ControlsOperations
    {
        public static void AddsInputInformation(TextBox txtbArriveHour, TextBox txtbArriveMin, TextBox txtbrrivePlot, DateTimePicker DateTimePicker, DataGridView dataGridView1)
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

                PrepareArriveInputControls();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            void PrepareArriveInputControls()
            {
                txtbArriveHour.Clear();
                txtbArriveMin.Clear();
                txtbrrivePlot.Clear();
                txtbArriveHour.Focus();
                txtbArriveMin.Focus();
                txtbrrivePlot.Focus();
            }
        }

        private static void PrepareArriveInputControls(TextBox txtbArriveHour, TextBox txtbArriveMin, TextBox txtbrrivePlot)
        {
            txtbArriveHour.Clear();
            txtbArriveMin.Clear();
            txtbrrivePlot.Clear();
            txtbArriveHour.Focus();
            txtbArriveMin.Focus();
            txtbrrivePlot.Focus();
        }

        public static void CalculateHours(TextBox txtbLeftPlot, TextBox txtbLeftHour, TextBox txtbLeftMin, DataGridView dataGridView1)
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

                PrepareExitInputControls();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            void PrepareExitInputControls()
            {
                txtbLeftHour.Clear();
                txtbLeftMin.Clear();
                txtbLeftPlot.Clear();
                txtbLeftHour.Focus();
                txtbLeftMin.Focus();
                txtbLeftPlot.Focus();
            }
        }
    }
}
