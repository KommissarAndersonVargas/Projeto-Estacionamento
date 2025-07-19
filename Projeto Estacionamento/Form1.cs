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

        public DateTime d;  // FUTURO: Inserir em uma classe para operações de DateTime
        public DateTime leftHour; // FUTURO: Inserir em uma classe para operações de DateTime
        public TimeSpan difference; // FUTURO: Inserir em uma classe para operações de DateTime
        DateTime TimeNow = DateTime.Now; // FUTURO: Inserir em uma classe para operações de DateTime
        string placa; 
        int hora1; // FUTURO: Inserir em uma classe para operações de DateTime
        int min1; // FUTURO: Inserir em uma classe para operações de DateTime
        int leftTimeHour; // FUTURO: Inserir em uma classe para operações de DateTime
        int leftMin; // FUTURO: Inserir em uma classe para operações de DateTime
        BasicParkingLot car;
        public List<TimeSpan> list = new List<TimeSpan>();
        List<string> ls = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hora1 = int.Parse(textBox1.Text);
                min1 = int.Parse(textBox2.Text);
                placa = textBox5.Text.ToString();
                string data = DateTimePicker1.Text;


                d = new DateTime(TimeNow.Year, TimeNow.Month, TimeNow.Day, hora1, min1, 0);
                DateTime HoraEntrada = d;

                car = InfocarSimpleFactory.CreateCar(placa, HoraEntrada, data, "ainda não calculado");

                Infocar.infocarsList.Add((Infocar)car);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Infocar.infocarsList;



                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox1.Focus();
                textBox2.Focus();
                textBox5.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error:" + er.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var cars in Infocar.infocarsList)
                {
                    if (textBox6.Text.Equals(cars.Placa))
                    {
                        leftTimeHour = int.Parse(textBox3.Text);
                        leftMin = int.Parse(textBox4.Text);
                        leftHour = new DateTime(TimeNow.Year, TimeNow.Month, TimeNow.Day, leftTimeHour, leftMin, 0);
                        difference = leftHour.Subtract(cars.Time);

                        cars.Tempo_Permanenica = difference.ToString();
                        
                        if (difference.Hours > 0 && difference.Hours <= 1)
                        {

                            cars.TotalPagar = " Total a pagar 3 $";

                        }
                        else if (difference.Hours > 1 && difference.Hours <= 2)
                        {

                            cars.TotalPagar = " Total a pagar 5 $";

                        }

                        else if (difference.Hours > 2 && difference.Hours <= 3)
                        {

                            cars.TotalPagar = " Total a pagar 7 $";
                        }
                        else if (difference.Hours > 3 && difference.Hours <= 4)
                        {

                            cars.TotalPagar = " Total a pagar 10 $";
                        }
                        else if (difference.Hours > 4 && difference.Hours <= 5)
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

                textBox3.Clear();
                textBox4.Clear();
                textBox6.Clear();
                textBox3.Focus();
                textBox4.Focus();
                textBox6.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: \n" + ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                difference = leftHour.Subtract(d);
                list.Add(difference);
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
                if (textboxprocurar.Text == Infocar.infocarsList[i].Placa.ToString())
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
                /*
                else
                {
                    MessageBox.Show("Placa nao existente");
                    break;
                }
                */
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }


        private void button6_Click(object sender, EventArgs e)
        {

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

            textboxprocurar.Text = Infocar.infocarsList.Count().ToString();
            textBox1.Focus();
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
            textBox1.Text = Infocar.infocarsList.Count().ToString();
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
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value.ToString().Contains(searchText))
                        {
                            row.Selected = true;

                        }
                    }
                }
            }
            catch (Exception ef)
            {
                MessageBox.Show("Erro: " + ef.ToString());
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

        private DataGridView GetDataGridView1()
        {
            return dataGridView1;
        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            //  "Tempo de Entrada: >\nTemplo de Entrada: <\nTempo de Entrada: ="
            if (comboBox1.Text == "Tempo de Entrada: >")
            {
                if (ls.Count() != 0) { ls.Clear(); }
                int ana1 = int.Parse(analise1.Text);
                var res = Infocar.infocarsList.Where(x => x.Time.Hour > ana1).Select(x => x.Placa);
                foreach (var a in res)
                {
                    ls.Add("Placa: " + a.ToString() + "\n");
                }
                Estati estati = new Estati(ls, Infocar.infocarsList.Count());
                estati.ShowDialog();
            }
            if (comboBox1.Text == "Tempo de Entrada: <")
            {
                if (ls.Count() != 0) { ls.Clear(); }
                int ana1 = int.Parse(analise1.Text);
                var res = Infocar.infocarsList.Where(x => x.Time.Hour < ana1).Select(x => x.Placa);
                foreach (var a in res)
                {
                    ls.Add("Placa: " + a.ToString() + "\n");
                }
                Estati estati = new Estati(ls, Infocar.infocarsList.Count());
                estati.ShowDialog();
            }
            if (comboBox1.Text == "Tempo de Entrada: =")
            {
                if (ls.Count() != 0) { ls.Clear(); }
                int ana1 = int.Parse(analise1.Text);
                var res = Infocar.infocarsList.Where(x => x.Time.Hour == ana1).Select(x => x.Placa);
                foreach (var a in res)
                {
                    ls.Add("Placa: " + a.ToString() + "\n");
                }
                Estati estati = new Estati(ls, Infocar.infocarsList.Count());
                estati.ShowDialog();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            /*
            var bindingList = new BindingBindingList<Infocar>(Infocar.infocarsList);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            // ate aqui ta certo
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            */



            textBox1.Text = Infocar.infocarsList.Count.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }
    }

}