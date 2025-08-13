using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Projeto_Estacionamento.Classes
{
    internal class Infocar : BasicParkingLot
    {
        public Infocar(string placa, DateTime Time, string data, string Tempo_Permanenica)
        {
            Placa = placa;
            this.Time = Time;
            Data = data;
            this.Tempo_Permanenica = Tempo_Permanenica;
        }

        public static BindingList<Infocar> infocarsList = new BindingList<Infocar>();

        public static void PaymentLogic(BasicParkingLot car)
        {
            if (GlobalVariables.difference.Hours > 0 && GlobalVariables.difference.Hours <= 1)
            {

                car.TotalPagar = " Total a pagar 3 $";

            }
            else if (GlobalVariables.difference.Hours > 1 && GlobalVariables.difference.Hours <= 2)
            {

                car.TotalPagar = " Total a pagar 5 $";

            }

            else if (GlobalVariables.difference.Hours > 2 && GlobalVariables.difference.Hours <= 3)
            {

                car.TotalPagar = " Total a pagar 7 $";
            }
            else if (GlobalVariables.difference.Hours > 3 && GlobalVariables.difference.Hours <= 4)
            {

                car.TotalPagar = " Total a pagar 10 $";
            }
            else if (GlobalVariables.difference.Hours > 4 && GlobalVariables.difference.Hours <= 5)
            {

                car.TotalPagar = " Total a pagar 13 $";
            }
            else
            {
                car.TotalPagar = " Total a pagar 20 $";
            }
        }

        public static void PrintOneTicket(string txtBoxGenerateCupon)
        {
            foreach (var car in Infocar.infocarsList)
            {
                if (txtBoxGenerateCupon == car.Placa?.ToString())
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.Filter = "All files (*.*)|*.*|Pdf File (*.pdf)|*.pdf";
                    saveFileDialog.FilterIndex = 2;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog.FileName;
                        PrintTicket(car, path);
                        MessageBox.Show("Arquivo gerado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
            }
        }

        private static void PrintTicket(BasicParkingLot car, string path)
        {
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
            paragrafo.Add("Data: " + car.Data + "\n");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add("Placa: " + car.Placa + "\n");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add("Horario de entrada: " + car.Time.Hour + ":" + car.Time.Minute + "\n");


            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add("\n");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add(" Parking lot Super System �");

            doc.Open();
            doc.Add(paragrafo);
            doc.Close();
        }

        public static void PrintAllCarsInSystem()
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

                foreach (var car in Infocar.infocarsList)
                {
                    PrintAllCars(paragrafo, car);
                }
                doc.Open();
                doc.Add(paragrafo);
                doc.Close();
                MessageBox.Show("Registro gerado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static void PrintAllCars(Paragraph paragrafo, BasicParkingLot car)
        {
            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add("Parking Lot Super\n");


            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add("\n");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add("Data: " + car.Data + "\n");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add("Placa: " + car.Placa + "\n");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add("Horario de entrada: " + car.Time.Hour + ":" + car.Time.Minute + "\n");


            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add("Tempo de permanencia: " + car.Tempo_Permanenica + "\n");


            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add("\n");

            paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10, (int)System.Drawing.FontStyle.Italic);
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Add(" Parking lot Super System � \n\n");
        }
    }
}

