using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6_Shipping_Rates
{
    class Shipping
    {
        private double standardA = 3.00;
        private double standardB = 1.45;
        private double expressA = 4.00;
        private double expressB = 2.50;
        private double sameA = 5.50;
        private double sameB = 3.00;
        private double standardSur = 2.50;
        private double expressSur = 5.00;
        private double sameSur = 8.00;

        public Shipping()
        {
            standardA = 3.00;
            standardB = 1.45;
            expressA = 4.00;
            expressB = 2.50;
            sameA = 5.50;
            sameB = 3.00;
            standardSur = 2.50;
            expressSur = 5.00;
            sameSur = 8.00;
            
        }

        public double GetStandardA()
        {
            return standardA;
        }
        public void SetStandardA(double s)
        {
            standardA = s;
        }
        public double GetStandardB()
        {
            return standardB;
        }
        public void SetStandardB(double s)
        {
            standardB = s;
        }
        public double GetExpressA()
        {
            return expressA;
        }
        public void SetExpressA( double s)
        {
            expressA = s;
        }
        public double GetExpressB()
        {
            return expressB;
        }
        public void SetExpressB(double s)
        {
            expressB = s;
        }
        public double GetSameA()
        {
            return sameA;
        }
        public void SetSameA(double s)
        {
            sameA = s;
        }
        public double GetSameB()
        {
            return sameB;
        }
        public void SetSameB(double s)
        {
            sameB = s;
        }
        public double GetStandardSur()
        {
            return standardSur;
        }
        public double GetExpressSur()
        {
            return expressSur;
        }
        public double GetSameSur()
        {
            return sameSur;
        }
     
        //Checks shipping methods and sets variables returns an int
        //If int >= 3 means shipping is by item
        //if int > 3 means shipping is by weight
        public int CheckShipping(int a, int b)
        {
            int checkShip = a;
            int checkMethod = b;
            int[] possible = { 1, 2, 3, 4, 5, 6 };
            
            switch(checkMethod)
            {
                case 0:
                    switch (checkShip)
                    {
                        case 0:
                            SetStandardA(standardA);
                            return possible[0];
                        case 1:
                            SetExpressA(expressA);
                            return possible[1];
                            
                        case 2:
                            SetSameA(sameA);
                            return possible[2];
                          
                    }
                    break;
                case 1:
                    switch (checkShip)
                    {
                        case 0:
                            SetStandardB(standardB);
                            return possible[3];
                        case 1:
                            SetExpressB(expressB);
                            return possible[4];
                        case 2:
                            SetSameB(sameB);
                            return possible[5];
                    }
                    break;
            }
            return 0;
        }



    }
}
