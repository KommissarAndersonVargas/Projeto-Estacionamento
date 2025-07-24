using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System.Data;
using System.ComponentModel;
using Projeto_Estacionamento.Classes;
using Projeto_Estacionamento.Factory;

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
                GlobalVariables.arriveHour = int.Parse(lblArriveHour.Text);
                GlobalVariables.arriveMin = int.Parse(lblArriveMin.Text);
                GlobalVariables.plot = lblArrivePlot.Text.ToString();
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
            catch (Exception er)
            {
                MessageBox.Show("Error:" + er.ToString());
            }
        }
        private void PrepareArriveInputControls()
        {
            lblArriveHour.Clear();
            lblArriveMin.Clear();
            lblArrivePlot.Clear();
            lblArriveHour.Focus();
            lblArriveMin.Focus();
            lblArrivePlot.Focus();
        }

        private void calculateHours_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var cars in Infocar.infocarsList)
                {
                    if (lblLeftPlot.Text.Equals(cars.Placa))
                    {
                        GlobalVariables.leftTimeHour = int.Parse(lblLeftHour.Text);
                        GlobalVariables.leftMin = int.Parse(lblLeftMin.Text);
                        GlobalVariables.leftHour
                            =
                        new DateTime(GlobalVariables.TimeNow.Year, GlobalVariables.TimeNow.Month, GlobalVariables.TimeNow.Day, GlobalVariables.leftTimeHour, GlobalVariables.leftMin, 0);
                        GlobalVariables.difference = GlobalVariables.leftHour.Subtract(cars.Time);

                        cars.Tempo_Permanenica = GlobalVariables.difference.ToString();

                        if (GlobalVariables.difference.Hours > 0 && GlobalVariables.difference.Hours <= 1)
                        {

                            cars.TotalPagar = " Total a pagar 3 $";

                        }
                        else if (GlobalVariables.difference.Hours > 1 && GlobalVariables.difference.Hours <= 2)
                        {

                            cars.TotalPagar = " Total a pagar 5 $";

                        }

                        else if (GlobalVariables.difference.Hours > 2 && GlobalVariables.difference.Hours <= 3)
                        {

                            cars.TotalPagar = " Total a pagar 7 $";
                        }
                        else if (GlobalVariables.difference.Hours > 3 && GlobalVariables.difference.Hours <= 4)
                        {

                            cars.TotalPagar = " Total a pagar 10 $";
                        }
                        else if (GlobalVariables.difference.Hours > 4 && GlobalVariables.difference.Hours <= 5)
                        {

                            cars.TotalPagar = " Total a pagar 13 $";
                        }
                        else
                        {

                            cars.TotalPagar = " Total a pagar 20 $";
                        }

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Infocar.infocarsList;
                    }
                }

                this.PrepareExitInputControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: \n" + ex.ToString());
            }
        }

        private void PrepareExitInputControls()
        {
            lblLeftHour.Clear();
            lblLeftMin.Clear();
            lblLeftPlot.Clear();
            lblLeftHour.Focus();
            lblLeftMin.Focus();
            lblLeftPlot.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVariables.difference = GlobalVariables.leftHour.Subtract(GlobalVariables.arriveTime);
                GlobalVariables.timeSpanList.Add(GlobalVariables.difference);
            }
            catch (Exception exce)
            {
                MessageBox.Show("Error: \n\n " + exce.ToString());
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
            int i;

            for (i = 0; i < Infocar.infocarsList.Count(); i++)
            {
                if (txtBoxGenerateCupon.Text == Infocar.infocarsList[i].Placa.ToString())
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.Filter = "All files (*.*)|*.*|Pdf File (*.pdf)|*.pdf";
                    saveFileDialog.FilterIndex = 2;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog.FileName;
                        FileStream arquivoPDF = new FileStream(path, FileMode.Create);
                        Document doc = new Document(PageSize.A4);
                        PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

                        string dados = "";
                        Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add("Parking Lot Super\n");

                        paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add("\n");

                        paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add("Data: " + Infocar.infocarsList[i].Data + "\n");

                        paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add("Placa: " + Infocar.infocarsList[i].Placa + "\n");

                        paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add("Horario de entrada: " + Infocar.infocarsList[i].Time.Hour + ":" + Infocar.infocarsList[i].Time.Minute + "\n");


                        paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add("\n");

                        paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic);
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add(" Parking lot Super System �");

                        doc.Open();
                        doc.Add(paragrafo);
                        doc.Close();
                        MessageBox.Show("Arquivo gerado com sucesso");
                        break;
                    }
                }
            }
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

            Infocar.infocarsList = Desserialization();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Infocar.infocarsList;

            txtBoxGenerateCupon.Text = Infocar.infocarsList.Count().ToString();
            lblArriveHour.Focus();
        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcao nao aplicavel");
        }

        private void colarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcao nao aplicavel");
        }

        private void ajudaToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O seguinte programa refere-se a um sistema de estacionamento\n" +
                "com registro de veiculos e geracao de cupons alem de funcoes \n" +
                "exclusivas do operador");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblArriveHour.Text = Infocar.infocarsList.Count().ToString();
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


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All files (*.*)|*.*|Pdf File (*.pdf)|*.pdf";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                FileStream arquivoPDF = new FileStream(saveFileDialog.FileName, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);
                string dados = "";
                Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("Registro de Veiculos do Sistema\n\n");

                int i;
                for (i = 0; i < Infocar.infocarsList.Count(); i++)
                {
                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Parking Lot Super\n");


                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Data: " + Infocar.infocarsList[i].Data + "\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Placa: " + Infocar.infocarsList[i].Placa + "\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Horario de entrada: " + Infocar.infocarsList[i].Time.Hour + ":" + Infocar.infocarsList[i].Time.Minute + "\n");


                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Tempo de permanencia: " + Infocar.infocarsList[i].Tempo_Permanenica + "\n");


                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add(" Parking lot Super System � \n\n");

                }
                doc.Open();
                doc.Add(paragrafo);
                doc.Close();
                MessageBox.Show("Registro gerado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            if (comboBox1.Text == "Tempo de Entrada: >")
            {
                if (GlobalVariables.filterValues.Count() != 0) { GlobalVariables.filterValues.Clear(); }
                int ana1 = int.Parse(analise1.Text);
                var res = Infocar.infocarsList.Where(x => x.Time.Hour > ana1).Select(x => x.Placa);
                foreach (var a in res)
                {
                    GlobalVariables.filterValues.Add("Placa: " + a.ToString() + "\n");
                }
                Estati estati = new Estati(GlobalVariables.filterValues, Infocar.infocarsList.Count());
                estati.ShowDialog();
            }
            if (comboBox1.Text == "Tempo de Entrada: <")
            {
                if (GlobalVariables.filterValues.Count() != 0) { GlobalVariables.filterValues.Clear(); }
                int ana1 = int.Parse(analise1.Text);
                var res = Infocar.infocarsList.Where(x => x.Time.Hour < ana1).Select(x => x.Placa);
                foreach (var a in res)
                {
                    GlobalVariables.filterValues.Add("Placa: " + a.ToString() + "\n");
                }
                Estati estati = new Estati(GlobalVariables.filterValues, Infocar.infocarsList.Count());
                estati.ShowDialog();
            }
            if (comboBox1.Text == "Tempo de Entrada: =")
            {
                if (GlobalVariables.filterValues.Count() != 0) { GlobalVariables.filterValues.Clear(); }
                int ana1 = int.Parse(analise1.Text);
                var res = Infocar.infocarsList.Where(x => x.Time.Hour == ana1).Select(x => x.Placa);
                foreach (var a in res)
                {
                    GlobalVariables.filterValues.Add("Placa: " + a.ToString() + "\n");
                }
                Estati estati = new Estati(GlobalVariables.filterValues, Infocar.infocarsList.Count());
                estati.ShowDialog();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            lblArriveHour.Text = Infocar.infocarsList.Count.ToString();
        }
    }
}