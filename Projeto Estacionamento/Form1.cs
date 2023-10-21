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


namespace Projeto_Estacionamento
{
    using System.ComponentModel;
    using System.IO;
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
        List<Infocar> list2 = new List<Infocar>();
        List<string> ls = new List<string>();
        // lista de objetos
        //Para salvar infos de um carro num pdf, botar no campo de procura procurar i nome que vai fazer
        //uma varredura numa lista de objteos até achar as infos; 
       
        private void button1_Click(object sender, EventArgs e)
        {
            int i=0;
            
            try
            {
                hora1 = int.Parse(textBox1.Text);
                min1 = int.Parse(textBox2.Text);
                placa = textBox5.Text.ToString();
                string data = DateTimePicker1.Text; // Vem do pequeno calendario datetime picker
               

                d = new DateTime( TimeNow.Year, TimeNow.Month, TimeNow.Day, hora1, min1, TimeNow.Second);
                DateTime HoraEntrada = d;

                car = new Infocar(placa, HoraEntrada, data, "ainda não calculado");

                



                // dtCarros.Rows.Add(new object[] { placa, HoraEntrada, data, null });
                //dtCarros.Rows.Add(placa, HoraEntrada, data, null);
                //placa, hora, tempo permanencia, total pagar, data

                // dataGridView1.DataSource = dtCarros;

                list2.Add(car);
                   
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list2;
                
                

                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox1.Focus();
                textBox2.Focus();
                textBox5.Focus();
            }
            catch(Exception er)
            {
                MessageBox.Show("Erro: \n\n\n\n"+er.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int i;
                for (i = 0; i < list2.Count(); i++)
                {
                    if (textBox6.Text.ToString() == list2[i].Placa)
                    {
                        hora2 = int.Parse(textBox3.Text);
                        min2 = int.Parse(textBox4.Text);
                        c = new DateTime(TimeNow.Year, TimeNow.Month, TimeNow.Day, hora2, min2, TimeNow.Second);
                        //t = c.Subtract(d);
                        t = c.Subtract(list2[i].Time);

                        list2[i].Tempo_Permanenica = t.ToString();

                        if (t.Hours <= 1)
                        {

                            list2[i].TotalPagar = " Total a pagar 3 $";

                        }
                        else if (t.Hours <= 2)
                        {

                            list2[i].TotalPagar = " Total a pagar 5 $";

                        }

                        else if (t.Hours <= 3)
                        {

                            list2[i].TotalPagar = " Total a pagar 7 $";
                        }
                        else if (t.Hours <= 4)
                        {

                            list2[i].TotalPagar = " Total a pagar 10 $";
                        }
                        else if (t.Hours <= 5)
                        {

                            list2[i].TotalPagar = " Total a pagar 13 $";
                        }
                        else
                        {

                            list2[i].TotalPagar = " Total a pagar 20 $";
                        }

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = list2;
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
            catch(Exception ex) {
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
            catch(Exception exce)
            {
                MessageBox.Show("Error: \n\n "+ exce.ToString());
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Registro_de_Veiculos registro_De_Veiculos = new Registro_de_Veiculos();
                registro_De_Veiculos.ShowDialog();
            }
            catch(Exception er)
            {
                MessageBox.Show("Erro: \n\n" + er.ToString());
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            int i;
            
            for (i = 0; i < list2.Count(); i++)
            {
                if(textboxprocurar.Text == list2[i].Placa .ToString())
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog.FileName + i.ToString() + ".pdf";
                      //  string name = @"C:\Users\Anderson\Documents\Imagens\cupom" + i.ToString() + ".pdf";
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
                        paragrafo.Add("Data: " + list2[i].Data + "\n");

                        paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add("Placa: " + list2[i].Placa + "\n");

                        paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add("Horario de entrada: " + list2[i].Time.Hour + ":" + list2[i].Time.Minute + "\n");


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

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos chamando a pol�cia ...");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Relatar relatar = new Relatar ();
            relatar.ShowDialog();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
           /*

            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               string path = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(path);
                for (int w = 0; w < list2.Count(); w++)
                {
                    try
                    {

                        if (w == 0)
                        {
                            sw.WriteLine(list2.Count());
                            sw.WriteLine(list2[w].Placa.ToString());
                            sw.WriteLine(list2[w].Hora_Entrada.ToString());
                            sw.WriteLine(list2[w].min.ToString());
                            sw.WriteLine(list2[w].Tempo_Permanenica.ToString());
                            sw.WriteLine(list2[w].Data.ToString());
                           
                        }
                        else
                        {
                          
                           
                            sw.WriteLine(list2[w].Placa.ToString());
                            sw.WriteLine(list2[w].Hora_Entrada.ToString());
                            sw.WriteLine(list2[w].min.ToString());
                            sw.WriteLine(list2[w].Tempo_Permanenica.ToString());
                            sw.WriteLine(list2[w].Data.ToString());
                          
                        }
                       
                    }

                    catch (Exception ey)
                    {
                        MessageBox.Show("ERROR: " + ey.Message);
                    }

                  
                }
              
                sw.Close();
            }


            */

            

            
           //  Serializa��o basica de json

            string fileName = @"C:\Users\Usuario\Documents\Json\WeatherForecast.json";
        // @"C:\Users\Anderson\Documents\Json\WeatherForecast.json"
        C: //C:\Users\Usuario\Documents\Json
            string jsonString = System.Text.Json.JsonSerializer.Serialize(list2);
            File.WriteAllText(fileName, jsonString);
            //File.WriteAllText(openFileDialog.InitialDirectory, jsonString);
            
            MessageBox.Show("Salvo com sucesso");

        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {/*
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            */
            /*
            OpenFileDialog d1 = new OpenFileDialog();
            d1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            string file = d1.FileName;
            string str;
            if (d1.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = d1.FileName;

                str = File.ReadAllText(d1.FileName);
              
                string[] ler = File.ReadAllLines(d1.FileName);




                int v = 0;
                int w;

                int loop = int.Parse(ler[0]);

                for (w = 0; w < loop; w++)
                {
                    
                    Infocar carro = new Infocar(ler[1 + v].ToString(), int.Parse(ler[2 + v]), int.Parse(ler[3 + v]), ler[4 + v].ToString(), ler[5 + v].ToString());
                    

                    list2.Add(carro);

                    string horas = ler[4+v].Substring(0,2);
                    
                    if (int.Parse(horas) <= 1)
                    {

                        list2[w].TotalPagar = " Total a pagar 3 $";

                    }
                    else if (int.Parse(horas) <= 02)
                    {

                        list2[w].TotalPagar = " Total a pagar 5 $";

                    }

                    else if (int.Parse(horas) <= 03)
                    {

                        list2[w].TotalPagar = " Total a pagar 7 $";
                    }
                    else if (int.Parse(horas) <= 04)
                    {

                        list2[w].TotalPagar = " Total a pagar 10 $";
                    }
                    else if (int.Parse(horas) <= 05)
                    {

                        list2[w].TotalPagar = " Total a pagar 13 $";
                    }
                    else
                    {

                        list2[w].TotalPagar = " Total a pagar 20 $";
                    }

                    
                   
                    
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = list2;
                    v = 5 * (w + 1);


                }
            }
            */


            // ARQUIVO JSON DESSERIALIZAR
            string fileName = @"C:\Users\Usuario\Documents\Json\WeatherForecast.json";

             list2 = infocar();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list2;

            textboxprocurar.Text = list2.Count().ToString();
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
            textBox1.Text = list2.Count().ToString();
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
            catch(Exception ef)
            {
                MessageBox.Show("Erro: " + ef.ToString());
            }
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            //string name = @"C:\Users\Anderson\Documents\Imagens\Registro "  + DateTimePicker1.Text + ".pdf"; // SUBSTIRUIR POR UM OPEM FILE DIALOG
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "All files (*.*)|*.*|Pdf File (*.pdf)|*.pdf";
            //saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(path);

                FileStream arquivoPDF = new FileStream(saveFileDialog.FileName + ".pdf"  , FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);
                string dados = "";
                Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("Registro de Ve�culos do Sistema\n\n");

                int i;
                for (i = 0; i < list2.Count(); i++)
                {




                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Parking Lot Super\n");


                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Data: " + list2[i].Data + "\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Placa: " + list2[i].Placa + "\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Horario de entrada: " + list2[i].Time.Hour + ":" + list2[i].Time.Minute + "\n");


                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Tempo de permanencia: " + list2[i].Tempo_Permanenica + "\n");


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
                MessageBox.Show("Arquivo gerado com sucesso");

            }


        }

        static List<Infocar> infocar()
        {
            string directory = @"C:\Users\Usuario\Documents\Json\WeatherForecast.json";
            

                var car = JsonConvert.DeserializeObject<List<Infocar>>(File.ReadAllText(directory));
                return car;
            
        }

        private DataGridView GetDataGridView1()
        {
            return dataGridView1;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            /*
            var bindingList = new BindingList<Infocar>(list2);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            
            */
            foreach( var n in list2)
            {
                if(delettext.ToString() == n.Placa)
                {
                    n.Placa = null;
                    n.Data = null;
                    n.Tempo_Permanenica = null;
                    n.TotalPagar = null;
                 
                   
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = list2;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int ana1 = int.Parse(analise1.Text);
            var res = list2.Where(x => x.Time.Hour > ana1).Select(x=> x.Placa);
            foreach(var a in res)
            {
                ls.Add("Placa: "+ a.ToString() + "\n");
            }
            Estati estati = new Estati(ls);
            estati.ShowDialog();
        }
    }
    
}