using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_6_Shipping_Rates
{
    public partial class Form1 : Form
    {
        private Shipping s1;

        public Form1()
        {
            InitializeComponent();
            s1 = new Shipping();
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

       

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
           
            double items;
            double total;
            string total2;
            int checkShipping;
            bool flag = false;
            bool flag2 = false;

            flag = double.TryParse(TxtBox1.Text, out items);
            if (flag == false)
            {
                MessageBox.Show("Please input a number for weight or amount of items \nThank you");
            }
            
            checkShipping = s1.CheckShipping(ComboBx1.SelectedIndex, ComboBx2.SelectedIndex);




            if (RadioBtn1.Checked == true)
            {
                switch (checkShipping)
                {
                    case 1:
                        total = (s1.GetStandardA() * items) + s1.GetStandardSur();
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;

                    case 2:
                        total = (s1.GetExpressA() * items) + s1.GetExpressSur();
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;
                    case 3:
                        total = (s1.GetSameA() * items) + s1.GetSameSur();
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;
                    case 4:
                        total = (s1.GetStandardB() * items) + s1.GetStandardSur();
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;
                    case 5:
                        total = (s1.GetExpressB() * items) + s1.GetExpressSur();
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;
                    case 6:
                        total = (s1.GetSameB() * items) + s1.GetSameSur();
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;
                    default:
                        break;
                }
            }
            else if (RadioBtn2.Checked == true)
            {
                switch (checkShipping)
                {
                    case 1:
                        total = (s1.GetStandardA() * items);
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;

                    case 2:
                        total = (s1.GetExpressA() * items);
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;
                    case 3:
                        total = (s1.GetSameA() * items);
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;
                    case 4:
                        total = (s1.GetStandardB() * items);
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;
                    case 5:
                        total = (s1.GetExpressB() * items);
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;
                    case 6:
                        total = (s1.GetSameB() * items);
                        total2 = string.Format("{0:C}", total);
                        TxtBox2.Text = total2;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a radio button, thank you");
            }
        }

        private void ComboBx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string l = "Weight of Shipment";

            if (ComboBx2.SelectedIndex == 1)
            {
                l = label3.Text;
               
            }
        }
    }
}
