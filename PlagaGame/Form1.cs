using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlagaGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNJ_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void btnHC_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnHH_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void btnCC_Click(object sender, EventArgs e)
        {

        }

        private void btnAtr1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

 
        private void btnSgnte1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void btnAtr2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        // Se cargan los botones de forma dinamica, dependiendo de los valores introducidos por el jugador 

        int count = 1;
        int fila = 1;
        int columna = 1;

        private void btnAGG_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= fila; i++)
            {
                Button b = new Button();
                b.Text = count.ToString();
                b.Name = count.ToString();
                b.Size = new Size(35, 35);
                b.Location = new Point(40 * (i + 1) , 40 * columna);
                Controls.Add(b);

            }
            if ( fila == int.Parse(txtFILA.Text)) 
            {
                fila = 0;
                columna++;
            }

            if (count == int.Parse(txtFILA.Text) * int.Parse(txtCOLUMNA.Text))
            {
                btnAGG.Enabled = false;

            }

            count++;
            fila++;
           
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFILA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCOLUMNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRJ_Click(object sender, EventArgs e)
        {

        }

        private void btnCJ_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }
    }
}
