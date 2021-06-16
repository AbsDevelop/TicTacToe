using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormPr : Form
    {
        int Xplayer = 0, Oplayer = 0, empates = 0, rodadas = 0;
        bool turno = true, jogadaFinal = false;
        string[] letra = new string[9];

        public FormPr()
        {
            InitializeComponent();
        }

        private void limparbtns(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is Button)
                {
                    ((Button)(ctrl)).Text = string.Empty;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparbtns(panelbtns.Controls);

            rodadas = 0;
            jogadaFinal = false;
            for (int i = 0; i < 9; i++)
            {
                letra[i] = "";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;

            if (btn.Text == "" && jogadaFinal == false)
            {
                if (turno)
                {
                    btn.Text = "X";
                    letra[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checagem(1);
                }
                else
                {
                    btn.Text = "O";
                    letra[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checagem(2);
                }
            }
        }

        void Vencedor(int Player)
        {
            jogadaFinal = true;
            if (Player == 1)
            {
                Xplayer++;
                LXptn.Text = Convert.ToString(Xplayer);
                MessageBox.Show("Jogador dos X ganhou!");
                turno = true;
            }
            else
            {
                Oplayer++;
                LOptn.Text = Convert.ToString(Oplayer);
                MessageBox.Show("Jogador dos O ganhou!");
            }
        }

        void Checagem(int ChecagemPlayer)
        {
            string suporte = "";

            if (ChecagemPlayer == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            }

            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if (suporte == letra[horizontal])
                {
                    if (letra[horizontal] == letra[horizontal + 1] && letra[horizontal] == letra[horizontal + 2])
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }
            }

            for (int vertical = 0; vertical < 3; vertical++)
            {
                if (suporte == letra[vertical])
                {
                    if (letra[vertical] == letra[vertical + 3] && letra[vertical] == letra[vertical + 6])
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }
            }

            if (letra[0] == suporte)
            {
                if (letra[0] == letra[4] && letra[0] == letra[8])
                {
                    Vencedor(ChecagemPlayer);
                    return;
                }
            }

            if (letra[2] == suporte)
            {
                if (letra[2] == letra[4] && letra[2] == letra[6])
                {
                    Vencedor(ChecagemPlayer);
                    return;
                }
            }

            if (rodadas == 9 && jogadaFinal == false)
            {
                empates++;
                Lempates.Text = Convert.ToString(empates);
                MessageBox.Show("Empatou meu povo (ツ)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jogadaFinal = true;
                return;
            }
        }


    }
}
