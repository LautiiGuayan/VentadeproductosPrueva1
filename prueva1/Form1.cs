using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueva1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)

        
        {
            
            int total = 0;
            if (C1.Checked == true)
            total = total + 35000;
            

            if (C2.Checked == true)
                total = total + 2500;
            

            if (C3.Checked == true)
                total = total + 1200;
            

           

            //MessageBox.Show("EL TOTAL DE LA COMPRA ES :"+total);//

            TOTAL1.Text = total.ToString();
            L1.Text = "REMERAS-ZAPATILLAS-GORRAS";


        }

        private void L1_Click(object sender, EventArgs e)
        {
           
        }

        private void B2_Click(object sender, EventArgs e)
        {
            C1.Checked = false;
            C2.Checked = false;
            C3.Checked = false;
            L1.Text = "";
            TOTAL1.Text = "";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void C1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (C1.Checked == true)
                L1.Text = "ZAPATILLAS";
            else
                L1.Text = "";
        }

        private void C2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (C2.Checked == true)
                L1.Text = "REMERA";
            else
                L1.Text = "";

        }

        private void C3_CheckedChanged(object sender, EventArgs e)
        {


            
            if (C3.Checked == true)
                L1.Text = "GORRAS";
            else
                L1.Text = "";
        }
    }
}
