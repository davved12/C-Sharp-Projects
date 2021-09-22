using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class Form1 : Form
    {
        int MAX = 10;        
        int maxLines = 40;
        int track = 0;
        int counter = 0;


        Employee[] employee;

        public Form1()
        {
            employee = new Employee[MAX];
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myfile = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "text files (*.txt)|*txt";           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myfile = openFileDialog1.OpenFile()) != null)
                {
                    
                    StreamReader filename = new StreamReader(myfile);

                    GetLength(ref filename);
                    ResetBuffer(ref filename);
                    CreateEmployee(ref filename);               
                }
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if(counter >= track / 4)
            {
                counter = 0;
            }
           
                TxtBox1.Text = "";
                TxtBox2.Text = "";
                TxtBox3.Text = "";
                TxtBox1.Text = employee[counter].GetName();
                TxtBox2.Text = employee[counter].GetAddress();
                TxtBox3.Text = employee[counter].CalcPay(employee[counter].GetHoursWorked(), employee[counter].GetWage()).ToString();
            counter++;
            
        }
        //Purpose: Counts how many lines are in the actual file
        public void GetLength(ref StreamReader filename)
        {
            for (int i = 0; i < maxLines; i++)
            {

                string read = filename.ReadLine();
                if (read == null)
                {
                    break;
                }
                track++;
            }
        }//Purpose: Resets the StreamReader buffer      
        public void ResetBuffer(ref StreamReader filename)
        {
            filename.DiscardBufferedData();
            filename.BaseStream.Seek(0, SeekOrigin.Begin);
            filename.BaseStream.Position = 0;
        }
        //Purpose: Creates the employee objects
        public void CreateEmployee(ref StreamReader filename)
        {
            string[] initial = new string[40];
            int split = 4;
            int num = 0;
            string name = "";
            string address = "";
            string tmp = "";
            string[] tmp2 = new string[2];
            double wage = 0;
            double hours = 0;

            for (int i = 0; i < track / split; i++)
            {
                for (int j = 0; j < split; j++)
                {
                    string read = filename.ReadLine();
                    initial[j] = read;
                    switch (j)
                    {
                        case 0:
                            num = int.Parse(initial[j]);
                            break;
                        case 1:
                            name = (initial[j]);
                            break;
                        case 2:
                            address = initial[j];
                            break;
                        case 3:
                            tmp = initial[j];
                            tmp2 = tmp.Split();
                            wage = double.Parse(tmp2[0]);
                            hours = double.Parse(tmp2[1]);
                            break;
                    }
                }
                employee[i] = new Employee(num, name, address, wage, hours);
            }
        }
    }
}
