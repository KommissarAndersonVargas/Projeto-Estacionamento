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
    public partial class Estati : Form
    {

        public Estati(List<string> lists, int totalLengh)
        {


            InitializeComponent();
            listBox1.DataSource = null;
            listBox1.DataSource = lists;
            progressBar1.Maximum = 100;
            int barValue = (lists.Count() * 100) / (totalLengh);
            progressBar1.Value = barValue;
            label2.Text = $"Valor do item em relação ao total: {lists.Count()} de {totalLengh} veículos";
            UpdatePercent();
            //fazer arredondamento para evitar erro
        }

        public void UpdatePercent()
        {
            percentLabel.Text = String.Concat(progressBar1.Value.ToString(), "%");
        }
    }
}
