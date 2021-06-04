using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeClientes
{
    public partial class FormPr : Form
    {
        public FormPr()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limparTextBox(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = null;
                }
            }

            foreach (Control ctrl in controles)
            {
                if (ctrl is CheckBox)
                {
                    ((CheckBox)(ctrl)).Checked = false;
                }
            }

            foreach (Control ctrl in controles)
            {
                if (ctrl is PictureBox)
                {
                    ((PictureBox)(ctrl)).Image = null;
                }
            }

            foreach (Control ctrl in controles)
            {
                if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)(ctrl)).Text = null;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {   
            limparTextBox(GBox1.Controls);
            limparTextBox(GBox2.Controls);
            limparTextBox(GBox3.Controls);
            limparTextBox(GBs.Controls);
            limparTextBox(picBox.Controls);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro realizado com sucesso, veja as informações:\r\n" +
                "\r\nDados Pessoais" + "\r\nNome: " + tbNome.Text + "\r\nCódigo: " + tbCod.Text + "\r\nData de Nasc.:" + data.Text +
                "\r\nRG: " + tbRg.Text + "\r\nCPF: " + tbCpf.Text + "\r\nTelefone: " + tbFone.Text +
                "\r\nSexo: " + M.Checked + F.Checked + "\r\nEndereço " + "\r\nRua: " + tbRua.Text + 
                "\r\nNúmero: " + tbNum.Text + "\r\nReferência: " + tbRef.Text + "\r\nBairro: " + tbBairro.Text +
                "\r\nCidade: " + tbCidade.Text + "\r\nCEP: " + tbCep.Text + "\r\nEstado: " + tbUF.Text +
                "\r\nDados Extras" + "\r\nEmail: " + tbEmail.Text + "\r\nLinkedin: " + tbLink.Text +
                "\r\nTwitter: " + tbTwitter.Text, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            this.tbNome.Text = "Levi M. S. Lewis";
            this.tbCod.Text = "902";
            this.data.Text = "03/08/2000";
            this.tbRg.Text = "40.975.525-X";
            this.tbCpf.Text = "554.995.458-39";
            this.tbFone.Text = "(11) 9375-6004";

            this.M.Checked = true;

            this.tbRua.Text = "R. Furtuoso da Costa";
            this.tbNum.Text = "879";
            this.tbBairro.Text = "Tatuapé";
            this.tbCidade.Text = "São Paulo";
            this.tbCep.Text = "03311-050";
            this.tbRef.Text = "Ao lado do Banco do Brasil";
            this.tbUF.Text = "SP";

            this.tbEmail.Text = "levmslewiss@gmail.com";
            this.tbLink.Text = "@LeviMS";
            this.tbTwitter.Text = "@Levile";
            this.cBox1.Checked = true;
            this.cBox2.Checked = true;
            this.cBox3.Checked = true;
        }

        private void btnimg1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picBox.ImageLocation = file.FileName;
            }
        }

        private void btnimg2_Click(object sender, EventArgs e)
        {
            picBox.Image = null;
        }

        private void cBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cBox1.Checked == false)
            {
                tbEmail.Enabled = false;
            }
            else 
            {
                tbEmail.Enabled = true;
            }
        }

        private void cBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox2.Checked == false)
            {
                tbLink.Enabled = false;
            }
            else
            {
                tbLink.Enabled = true;
            }
        }

        private void cBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox3.Checked == false)
            {
                tbTwitter.Enabled = false;
            }
            else
            {
                tbTwitter.Enabled = true;
            }
        }

        private void GBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
