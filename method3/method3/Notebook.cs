using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method3
{
    internal class Notebook : Product
    {
        public string _opSystem;
        public string _processor;
        public bool _hasGraficCard;


        public Notebook(string model, string brandName, decimal price, decimal cost, int count, string opsystem, string processor) : base(model, brandName, price, cost, count)
        {
            _opSystem = opsystem;
            _processor = processor;  
        }
        public Notebook(string model, string brandName, decimal price, decimal cost, int count, string opsystem, string processor, bool hasgraficcard):this(model,brandName,price,cost,count,opsystem,processor)
        {
            _hasGraficCard = hasgraficcard;
        }




        public string Opsystem { get{ return _opSystem; }  set { _opSystem = value; } }
        public string processor { get { return _processor; } set { _processor = value; } }

        public bool hasgraficcard { get { return _hasGraficCard; } set { _hasGraficCard = value; } }



        public void Hasgraficcard(bool _hasgraficcard)
        {
            if (_hasGraficCard == true)
            {
                Console.WriteLine("Your computer has a grafic card!");
            }
            else
            {
                Console.WriteLine("No Grafic card found!");
            }
        }
            public void GetInfo()
        {
            Console.WriteLine($"Id:{Id} Model:{Model} BrandName:{BrandName} Price:{Price} Cost:{Cost} income:{Income} Count:{Count} OpSystem:{_opSystem} Processor:{_processor} Hasgraficcard:{_hasGraficCard}");
        }
    }

} 

