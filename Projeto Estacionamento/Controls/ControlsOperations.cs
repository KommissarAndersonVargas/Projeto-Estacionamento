using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estacionamento.Controls
{
    /// <summary>
    /// Logic for the main form controls. WIP
    /// </summary>
    public class ControlsOperations: Form1
    {
        public void Btn3Logic()
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
    }
}
