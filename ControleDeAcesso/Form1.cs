using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            int ano = Convert.ToInt32(txtData.Text);
            int datual = DateTime.Now.Year;
            double resultado = ano - datual;
                 
           
            
            if(resultado >= 18)
            {
               lblResultado.Text = "Bem vindo a mansão maromba" + nome + " " + sobrenome + "aproveite!";
                pbFoto.Image = Properties.Resources.acessoaceito;
            }
            else if(resultado < 18)
            {
                lblResultado.Text = "Não é sua hora de participar!" + nome + " " +sobrenome;
                pbFoto.Image = Properties.Resources.acessonegado;
            }

            

            
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
