using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Power_Ratings
{
    class Resistors
    {
        private double [] voltages = new double [50];
        string[] pass = new string[50];
        private int power;
        private int resistance;
        private int length;
        private string path;
        private double[] dissipation = new double[50];
        
        public Resistors()
        {
            length = 0;
            resistance = 0;
            power = 0; 
            resistance = 0; 
        }
        public string GetPath()
        {
            return path;
        }
        public void SetPath(string p)
        {
            path = p;
        }
        public int GetResistance()
        {
            return resistance;
        }
        public void SetResistance(int r)
        {
            resistance = r;
        }
        public int GetPower()
        {
            return power;
        }
        public void SetPower(int p)
        {
            power = p;
        }
        public int GetLength()
        {
            return length;
        }
        public double GetDissip(int x)
        {
            return dissipation[x];
        }
        public double [] GetDissip()
        {
            return dissipation;
        }
        public string[] GetPass()
        {
            return pass;
        }
        //Purpose:Gets file name under "My documents" section of PC.
        public string GetP()
        {
            string filename;
            string environment = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\";
            Console.WriteLine("What is the name of your file, please inculde extension");
            filename = Console.ReadLine();
            string path = environment + filename;
            return path;
        }
        public double [] GetVoltages()
        {
            return voltages;
        }
        //Purpose: Sets voltages by reading the stream of the file
        public void SetVoltages()
        {
            
            StreamReader data = new StreamReader(GetPath());
            data.DiscardBufferedData();
            data.ReadLine();
            for(int i = 0; i<voltages.Length; i++)
            {
                string buff = data.ReadLine();
                if (buff == null)
                {
                    length = i;
                    break;
                    
                }
                voltages[i] = int.Parse(buff);
            }
        }
        //Purpose: Calculate dissipation from voltages
        public void CalcDissip(double [] voltages)
        {
            
            for(int i = 0; i<GetLength(); i++)
            {
                dissipation[i] = (voltages[i] * voltages[i]) / GetResistance();
            }
        }
        //Purpose: See if dissipation passed the test or not. Dissipation passes if dissipation>power
        public void Pass(double [] dissipation)
        {
            for(int i=0; i<GetLength(); i++)
            {
                if (dissipation[i] < GetPower())
                {
                    pass[i] = "no";
                }
                else
                {
                    pass[i] = "yes";
                }
            }
        }
    }
}
