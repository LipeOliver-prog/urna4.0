using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urna4._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string numeroCandidato = txtNumero.Text;

            if (numeroCandidato == "13") // Exemplo de número do candidato 1
            {
                pictureBoxCandidato.Image = Properties.Resources.Lula;
                lblNomeCandidato.Text = "Candidato 1 - Partido XYZ";
            }
            else if (numeroCandidato == "22") // Exemplo de número do candidato 2
            {
                pictureBoxCandidato.Image = Properties.Resources.bolsonaro;
                lblNomeCandidato.Text = "Candidato 2 - Partido ABC";
            }
            else
            {
                pictureBoxCandidato.Image = null;
                lblNomeCandidato.Text = "Candidato não encontrado!";
            }
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            pictureBoxCandidato.Image = null;
            lblNomeCandidato.Text = "";
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            pictureBoxCandidato.Image = null;
            lblNomeCandidato.Text = "Voto em Branco";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
