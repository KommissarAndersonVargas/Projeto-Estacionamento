using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Estacionamento
{
    public partial class Relatar : Form
    {
        public Relatar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string report;
            report= textBox1.Text;
            report = report.ToString();
            StreamWriter sw = new StreamWriter(@"C:\Users\Anderson\Documents\Imagens\relato.txt");
            sw.WriteLine(report);
            sw.Close();
            MessageBox.Show("Relato registrado"); 
        }
    }
}
