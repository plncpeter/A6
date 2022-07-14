using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcao1_Click(object sender, EventArgs e)
        {
            // Declaração das variaveis para o funcionamento do .exe:
            string nome;
            string sobrenome;
            int ano;
            int data = DateTime.Now.Year;
            int conta;

            nome = txtNome.Text ;
            sobrenome = txtSobrenome.Text ;
            ano = int.Parse(txtAge.Text) ;
            conta = data - ano ;

            if (conta >= 18 && conta <= 25)
            {

                lblResultado.Text = "Congratulations! You really are a Star Guardian, WOW";
                lblResultado.ForeColor = Color.Goldenrod;
                pic1.Image = Properties.Resources.tobe;
                pic1.BackColor = Color.WhiteSmoke;
            }
            else if (conta >= 26)
            {
                lblResultado.Text = "Sorry, but you have a lot of experience!";
                lblResultado.ForeColor = Color.Goldenrod;
                pic1.Image = Properties.Resources.velho;
            }
            else if (conta <= 17)
            {
                lblResultado.Text = "Oh so sorry! But to be a Star Guardian needs more years";
                lblResultado.ForeColor = Color.Goldenrod;
                pic1.Image = Properties.Resources.menor;
            }
            else
            {
                lblResultado.Text = "Verique suas informações";
                lblResultado.ForeColor = Color.Goldenrod;
                pic1.Image = Properties.Resources.verifique;
            }
        }

        private void btnAcao2_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtAge.Text = "";
            pic1.Image = Properties.Resources.neutro;
            lblResultado.Text = "";
        }

        private void btnAcao3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
