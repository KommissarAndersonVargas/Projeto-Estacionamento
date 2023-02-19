using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;



namespace Projeto_Estacionamento
{
    using System.IO;
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
           
        }
      
        DateTime d;
        DateTime c;
        TimeSpan t;
        string placa; 
        int hora1;
        int min1;
        int hora2;
        int min2;
        Infocar car;
        List<TimeSpan> list = new List<TimeSpan>();
        List<Infocar> list2 = new List<Infocar>();
        //Para salvar infos de um carro num pdf, botar no campo de procura procurar i nome que vai fazer
        //uma varredura numa lista de objteos até achar as infos; 
        private void button1_Click(object sender, EventArgs e)
        {
            hora1 = int.Parse(textBox1.Text);
            min1 = int.Parse(textBox2.Text);
            placa = textBox5.Text.ToString();
            string data = DateTimePicker1.Text;
            d = new DateTime(2022, 12, 10, hora1, min1, 0);
            car = new Infocar(placa, hora1, min1,"0", data);
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

        private void button2_Click(object sender, EventArgs e)
        {
            


            int i;
            for (i = 0; i < list2.Count(); i++)
            {
                if (textBox6.Text.ToString() == list2[i].Placa)
                {
                    hora2 = int.Parse(textBox3.Text);
                    min2 = int.Parse(textBox4.Text);
                    c = new DateTime(2022, 12, 10, hora2, min2, 0);
                    t = c.Subtract(d);
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


                }
            }

            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox3.Focus();
            textBox4.Focus();
            textBox6.Focus();

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t = c.Subtract(d);
            list.Add(t);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registro_de_Veiculos registro_De_Veiculos = new Registro_de_Veiculos();
            registro_De_Veiculos.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            int i;
            
            for (i = 0; i < list2.Count(); i++)
            {
                if(textboxprocurar.Text == list2[i].Placa .ToString())
                {
                    string name = @"C:\Users\Anderson\Documents\Imagens\cupom" + i.ToString()+".pdf";
                    FileStream arquivoPDF = new FileStream(name,FileMode.Create);
                    Document doc = new Document(PageSize.A4);
                    PdfWriter escritorPDF  = PdfWriter.GetInstance(doc, arquivoPDF);

                    string dados = "";
                    Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("Parking Lot Super\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Data: " + list2[i].Data+"\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Placa: " + list2[i].Placa + "\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Horario de entrada: " + list2[i].Hora_Entrada + ":" + list2[i].min+"\n" );


                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add(" Parking lot Super System ®");

                    doc.Open();
                    doc.Add(paragrafo);
                    doc.Close();
                    MessageBox.Show("Arquivo gerado com sucesso");
                    break;
                 
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
            //dataGridView1.Columns[car.Placa.ToString()].HeaderText = "Titulo da Coluna";
            // dataGridView1.Columns[0].HeaderText = "Titulo da Coluna";
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estamos chamando a polícia ...");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Relatar relatar = new Relatar ();
            relatar.ShowDialog();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
           



            /*
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"c:\";
            openFileDialog.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
           
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowDialog();

            */

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
                            /*r(string placa, int Hora_Entrada, int min, string Tempo_Permanenica, string Data)
        {*/
                           
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




            //StreamWriter sw = new StreamWriter(sfd.FileName);

            /*
           //  Serialização basica de json
            string fileName = @"C:\Users\Anderson\Documents\Json\WeatherForecast.json";
            string jsonString = System.Text.Json.JsonSerializer.Serialize(list2);
            File.WriteAllText(fileName, jsonString);
            //File.WriteAllText(openFileDialog.InitialDirectory, jsonString);
            */
            MessageBox.Show("Salvo com sucesso");

        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {/*
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            */

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
                    /*
                     (string placa, int Hora_Entrada, int min, string Tempo_Permanenica, string Data)
                     */
                    Infocar carro = new Infocar(ler[1 + v].ToString(), int.Parse(ler[2 + v]), int.Parse(ler[3 + v]), ler[4 + v].ToString(), ler[5 + v].ToString());
                    

                    list2.Add(carro);

                    string horas = ler[4+v].Substring(0,2);
                    //textBox7.Text = ler[4 + v].Substring(0, 2).ToString();
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
            /* ARQUIVO JSON DESSERIALIZAR
            string fileName = @"C:\Users\Anderson\Documents\Json\WeatherForecast.json";

            List<Infocar> list2 = null;
            using (StreamReader stream = new StreamReader(fileName))
            {
                string jsonString = stream.ReadToEnd();
                list2 = JsonConvert.DeserializeObject<List<Infocar>>(jsonString);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list2;
                

            }

            */

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
            string searchText = txtSearchText.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchInDataGrid(searchText);
            }
            txtSearchText.Clear();
            txtSearchText.Focus();

        }

        private void SearchInDataGrid(string searchText)
        {
            dataGridView1.ClearSelection();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Contains(searchText))
                    {
                        row.Selected = true; 

                    }
                }
            }
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            string name = @"C:\Users\Anderson\Documents\Imagens\Registro "  + DateTimePicker1.Text + ".pdf";
            FileStream arquivoPDF = new FileStream(name, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);
            string dados = "";
            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("Registro de Veículos do Sistema\n\n");

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
                    paragrafo.Add("Horário de entrada: " + list2[i].Hora_Entrada + ":" + list2[i].min + "\n");


                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("Tempo de permanência: " + list2[i].Tempo_Permanenica + "\n");


                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add("\n");

                    paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic);
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo.Add(" Parking lot Super System ® \n\n");
                
              




            }

            doc.Open();
            doc.Add(paragrafo);
            doc.Close();
            MessageBox.Show("Arquivo gerado com sucesso");
        }
    }
    
}