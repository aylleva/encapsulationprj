using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method3
{
    internal class Product
    {
        public string Id;
        public string Model;
        public string BrandName;
        public decimal Price;
        public decimal Cost;
        public decimal Income;
        public decimal Count;

        public Product(string model, string brandName, decimal price, decimal cost, int count)
        {

            Model = model;
            BrandName = brandName;
            Price = price;
            Cost = cost;
            Count = count;
         
        }

      
       public string ModEl { get { return Model; } set { Model = value; } } 
       public string Brandname { get { return Brandname; } set {   Brandname= value; } }

       public decimal PRICE { get { return Price; } set { Price = value; } }    

        public decimal INcome { get { return Income; } set { 
                
                value=Count* (Price - Cost);
                Income += value;
                Income = value; } 
        }   
        public decimal _Cost { get { return Cost; } set { Cost = value; } } 
        
       

        public decimal Sell
        {
            get
            {
                return Count;
            }

            set
            {
                if (value > 0)
                {
                   value-=(Price-Cost)*value;
                    
                    Count = value;
                    Console.WriteLine("Satis ugurlu oldu");

                }
                else
                {
                    Console.WriteLine("Satis mumkun deyil");
                }
            }
        }

        public string ID { get { return ID; } set {
                
                value = BrandName.Substring(0, 2) + Model.Substring(0, 2);
                ID = value;
            }
        
        } 

        public void GetInfo()
        {
            Console.WriteLine($"Id:{Id} Model:{Model} BrandName:{BrandName} Price:{Price} Cost:{Cost} income:{Income} Count:{Count}");
        }
    }

}
