using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Drawing;

namespace Projeto_Estacionamento
{
    using System.ComponentModel;
    using System.IO;
    using System.IO.Ports;
    using System.Windows.Forms;


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }

        DateTime d;
        DateTime c;
        TimeSpan t;
        DateTime TimeNow = DateTime.Now;
        DataTable dtCarros = new DataTable();
        string placa;
        int hora1;
        int min1;
        int hora2;
        int min2;
        Infocar car;
        List<TimeSpan> list = new List<TimeSpan>();
        BindingList<Infocar> carinformations = new BindingList<Infocar>();
        List<string> ls = new List<string>();
        // lista de objetos
        //Para salvar infos de um carro num pdf, botar no campo de procura procurar i nome que vai fazer
        //uma varredura numa lista de objteos até achar as infos; 

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                hora1 = int.Parse(textBox1.Text);
                min1 = int.Parse(textBox2.Text);
                placa = textBox5.Text.ToString();
                string data = DateTimePicker1.Text; // Vem do pequeno calendario datetime picker


                d = new DateTime(TimeNow.Year, TimeNow.Month, TimeNow.Day, hora1, min1, 0);
                DateTime HoraEntrada = d;

                car = new Infocar(placa, HoraEntrada, data, "ainda não calculado");


                carinformations.Add(car);
                Infocar.infocarsList.Add(car);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = carinformations;



                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox1.Focus();
                textBox2.Focus();
                textBox5.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro: \n\n\n\n" + er.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int i;
                for (i = 0; i < carinformations.Count(); i++)
                {
                    if (textBox6.Text.ToString() == carinformations[i].Placa)
                    {
                        hora2 = int.Parse(textBox3.Text);
                        min2 = int.Parse(textBox4.Text);
                        c = new DateTime(TimeNow.Year, TimeNow.Month, TimeNow.Day, hora2, min2, 0);
                        //t = c.Subtract(d);
                        t = c.Subtract(carinformations[i].Time);

                        carinformations[i].Tempo_Permanenica = t.ToString();
                        //REVER CONDIÇÕES DE PAGAMENTO ESTA ERRDADO !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        if (t.Hours <= 1)
                        {

                            carinformations[i].TotalPagar = " Total a pagar 3 $";

                        }
                        else if (t.Hours <= 2)
                        {

                            carinformations[i].TotalPagar = " Total a pagar 5 $";

                        }

                        else if (t.Hours <= 3)
                        {

                            carinformations[i].TotalPagar = " Total a pagar 7 $";
                        }
                        else if (t.Hours <= 4)
                        {

                            carinformations[i].TotalPagar = " Total a pagar 10 $";
                        }
                        else if (t.Hours <= 5)
                        {

                            carinformations[i].TotalPagar = " Total a pagar 13 $";
                        }
                        else
                        {

                            carinformations[i].TotalPagar = " Total a pagar 20 $";
                        }

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = carinformations;
                        //dtCarros.Rows.Add(placa, HoraEntrada, data, null);
                        //placa, hora, tempo permanencia, total pagar, data

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
                t = c.Subtract(d);
                list.Add(t);
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

            for (i = 0; i < carinformations.Count(); i++)
            {
                if (textboxprocurar.Text == carinformations[i].Placa.ToString())
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
                        paragrafo.Add("Data: " + carinformations[i].Data + "\n");

                        paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add("Placa: " + carinformations[i].Placa + "\n");

                        paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add("Horario de entrada: " + carinformations[i].Time.Hour + ":" + carinformations[i].Time.Minute + "\n");


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
                    string jsonString = System.Text.Json.JsonSerializer.Serialize(carinformations);
                    File.WriteAllText(saveFileDialog.FileName, jsonString);

                    MessageBox.Show("Arquivo salvo com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {

            carinformations = Desserialization();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = carinformations;

            textboxprocurar.Text = carinformations.Count().ToString();
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
            textBox1.Text = carinformations.Count().ToString();
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
                for (i = 0; i < carinformations.Count(); i++)
                {




                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Parking Lot Super\n");


                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Data: " + carinformations[i].Data + "\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Placa: " + carinformations[i].Placa + "\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Horario de entrada: " + carinformations[i].Time.Hour + ":" + carinformations[i].Time.Minute + "\n");


                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Tempo de permanencia: " + carinformations[i].Tempo_Permanenica + "\n");


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
                var res = carinformations.Where(x => x.Time.Hour > ana1).Select(x => x.Placa);
                foreach (var a in res)
                {
                    ls.Add("Placa: " + a.ToString() + "\n");
                }
                Estati estati = new Estati(ls, carinformations.Count());
                estati.ShowDialog();
            }
            if (comboBox1.Text == "Tempo de Entrada: <")
            {
                if (ls.Count() != 0) { ls.Clear(); }
                int ana1 = int.Parse(analise1.Text);
                var res = carinformations.Where(x => x.Time.Hour < ana1).Select(x => x.Placa);
                foreach (var a in res)
                {
                    ls.Add("Placa: " + a.ToString() + "\n");
                }
                Estati estati = new Estati(ls, carinformations.Count());
                estati.ShowDialog();
            }
            if (comboBox1.Text == "Tempo de Entrada: =")
            {
                if (ls.Count() != 0) { ls.Clear(); }
                int ana1 = int.Parse(analise1.Text);
                var res = carinformations.Where(x => x.Time.Hour == ana1).Select(x => x.Placa);
                foreach (var a in res)
                {
                    ls.Add("Placa: " + a.ToString() + "\n");
                }
                Estati estati = new Estati(ls, carinformations.Count());
                estati.ShowDialog();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            /*
            var bindingList = new BindingBindingList<Infocar>(carinformations);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            // ate aqui ta certo
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            */



            textBox1.Text = carinformations.Count.ToString();


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