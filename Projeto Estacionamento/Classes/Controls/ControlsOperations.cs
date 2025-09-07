using Projeto_Estacionamento.Factory;

namespace Projeto_Estacionamento.Classes.Controls
{
    /// <summary>
    /// Logic for the main form controls
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
                MessageBox.Show(Properties.Resources.UnExcpectedError,
                    Properties.Resources.MessageBoxError,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(Properties.Resources.UnExcpectedError, 
                    Properties.Resources.MessageBoxError,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static void SearchInDataGrid(string searchText, DataGridView dataGridView1)
        {
            try
            {
                dataGridView1.ClearSelection();
                bool found = false;

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    MessageBox.Show(Properties.Resources.SearchForaPlot, 
                        Properties.Resources.MessageBoxWarning,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

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
                    MessageBox.Show(Properties.Resources.PlotNotFound, 
                        Properties.Resources.MessageBoxInfo, 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.ErrorDuringSearch,
                    Properties.Resources.MessageBoxError, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        public static void NewProject(DataGridView dataGridView1)
        {
            DialogResult resultado = MessageBox.Show(
             Properties.Resources.HaveYouSureNewProject,
             Properties.Resources.Confirmation,
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Yes)
            {
                ClearDataGridView(dataGridView1);
            }
        }

        private static void ClearDataGridView(DataGridView dataGridView1)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();

                MessageBox.Show(Properties.Resources.DataGridClear, 
                                Properties.Resources.MessageBoxInfo,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Properties.Resources.DataGridIsAlreadyClear,
                                Properties.Resources.MessageBoxInfo,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

