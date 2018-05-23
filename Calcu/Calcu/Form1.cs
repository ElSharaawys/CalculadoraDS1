using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calcu
{
    
    public partial class frmCalcu : Form
    {
        Double numero = 0;
        String operacao = "";
        double valor1 = 0;


        public frmCalcu()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "1";
            lblResult.Text = lblResult.Text + 1;
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "2";
            lblResult.Text = lblResult.Text + 2;
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "3" ;
            lblResult.Text = lblResult.Text + 3;
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "4";
            lblResult.Text = lblResult.Text + 4;
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "5";
            lblResult.Text = lblResult.Text + 5;
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "6";
            lblResult.Text = lblResult.Text + 6;
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "7";
            lblResult.Text = lblResult.Text + 7;
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "8";
            lblResult.Text = lblResult.Text + 8;
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "9";
            lblResult.Text = lblResult.Text + 9;
        }

        private void lbl0_Click(object sender, EventArgs e)
        {
            txbResultado.Text += "0";
            lblResult.Text = lblResult.Text + 0;
        }

        private void lblSoma_Click(object sender, EventArgs e)
        {

            lblIgual.PerformClick(); // ele recebe o que esta na textBox
            operacao = "+";
            txbResultado.Clear();
            lblResult.Text = lblResult.Text + "+";
                
     
        }

     
        private void lblSub_Click(object sender, EventArgs e)
        {

            lblIgual.PerformClick();// 
            operacao = "-";
            txbResultado.Clear();
            lblResult.Text = lblResult.Text + "-";
     
                
                
            
        }

        private void lblMult_Click(object sender, EventArgs e)
        {

            lblIgual.PerformClick();
            operacao = "*";
            txbResultado.Clear();
            lblResult.Text = lblResult.Text + "*";
                 
        }

        private void lblDiv_Click(object sender, EventArgs e)
        {

            lblIgual.PerformClick(); 
            operacao = "/";
            txbResultado.Clear();
            lblResult.Text = lblResult.Text + "/";
                 
        }

        private void lblIgual_Click(object sender, EventArgs e)
        {





            switch(operacao){

                case "+":
                txbResultado.Text = (valor1 + Double.Parse(txbResultado.Text)).ToString(); // Pega o 1° valor e soma com o outro valor que está na TextBox
            break;
               

          
                case "-":
                txbResultado.Text = (valor1 - Double.Parse(txbResultado.Text)).ToString();
             break;


            
                case "*":
                txbResultado.Text = (valor1 * Double.Parse(txbResultado.Text)).ToString();
               break;


           
                case "/":
                txbResultado.Text = (valor1 / Double.Parse(txbResultado.Text)).ToString();
              break;



            }

            valor1 = Double.Parse(txbResultado.Text); //Armazena o resultado no valor1
            operacao = "";
        }

        private void button1_Click(object sender, EventArgs e) {
            numero = 0;
            operacao = "";
            valor1 = 0;
            txbResultado.Text = "";
            lblResult.Text = "";

        }
        }
        


    }

