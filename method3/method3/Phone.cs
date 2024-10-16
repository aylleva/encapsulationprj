using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace method3
{
    internal class Phone : Product
    {
        public int RAM;
        public string Color = "black";
        public double _balance;
        public Phone(string model, string brandname, decimal price, decimal cost, int count, int ram, string color) : base(model, brandname, price, cost, count)
        {
            RAM = ram;
            Color = color;
            _balance = 0;
        }
         
        public int Ram { get{ return Ram; } set { Ram = value; } }   

        public string COLOR { get { return Color; } set { Color = value; } }


        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value > 0)
                {


                    _balance = value;
                    Console.WriteLine("zeng edildi");
                }
                else
                {
                    Console.WriteLine(("balansinizda kifayet qeder vesait qalmayib"));
                }
            }
        }

        public double Calls(int seconds)
        {
            _balance -= 0.1 * seconds;
            return _balance;
        }
        public double Money(double money)
        {
            if (_balance > 0)
            {
                _balance += money;
                return _balance;
            }
            else
            {
                _balance = 0;
                return _balance;
            }
        }
        public void Getinfo()
        {
            Console.WriteLine($"Id:{Id} Model:{Model} BrandName:{BrandName} Price:{Price} Cost:{Cost} income:{Income} Count:{Count},ram:{RAM} color:{Color} balance:{_balance}");
        }
    }
   

}


