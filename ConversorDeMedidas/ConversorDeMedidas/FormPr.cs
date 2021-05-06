using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeMedidas
{
    public partial class FormPr : Form
    {
        public FormPr()
        {
            InitializeComponent();
        }

        private void textMedida_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnCF_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textMedida.Text);
            double tempF;
            tempF = temp / 5;
            MessageBox.Show(temp + "°C corresponde ao valor de " + tempF + "°F");
        }

        private void btnCK_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textMedida.Text);
            double tempK;
            tempK = temp + 273;
            MessageBox.Show(temp + "°C corresponde ao valor de " + tempK + " Kelvin");
        }

        private void btnKC_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textMedida.Text);
            double tempC;
            tempC = temp - 273;
            MessageBox.Show(temp + " Kelvin corresponde ao valor de " + tempC + "°C");
        }

        private void btnKF_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textMedida.Text);
            double tempF;
            tempF = (temp - 273) / 5;
            MessageBox.Show(temp + " Kelvin corresponde ao valor de " + tempF + "°F");
        }
    }
}
