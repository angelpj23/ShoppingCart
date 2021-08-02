using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Purchase.Enabled = true;
                groupBox1.Enabled = true;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Purchase.Enabled = true;
                groupBox1.Enabled = true;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                Purchase.Enabled = true;
                groupBox1.Enabled = true;
            }
        }
      
        
        public void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        public void groupBox2_Enter(object sender, EventArgs e)
        {
     
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        
        public void Purchase_Click(object sender, EventArgs e)
        {
            double cantidad = 0;
            string mensaje = "";
            string pay = "";

            cantidad = 0;

            if (checkBox1.Checked == true)
            {
                cantidad = cantidad + 20.00;
                mensaje = mensaje + checkBox1.Text + "\n\r";
            }

            if (checkBox2.Checked == true)
            {
                cantidad = cantidad + 30.00;
                mensaje = mensaje + checkBox2.Text + "\n\r";
            }

            if (checkBox3.Checked == true)
            {
                cantidad = cantidad + 50.00;
                mensaje = mensaje + checkBox3.Text + "\n\r";
            }
            //Metodo de pago
            if(radioButton1.Checked == true)
            {
                pay = pay + radioButton1.Text;
            }

            if (radioButton2.Checked == true)
            {
                pay = pay + radioButton2.Text;
            }

            mensaje = "You Purchased" + "\n\r" + mensaje + "The total payment is:" + cantidad.ToString("c") + "\n\r" + "\n\r" + "Metod pay:" + "\n\r" + pay + "\n\r" + "\n\r" + "Your Comment"+"\n\r" + textBox1.Text;
            MessageBox.Show(mensaje);


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
