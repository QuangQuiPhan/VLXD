using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        private string id_product;
        private string productName;
        private int quantity;
        private double unitPrice;
        private string unit;

        public string Id_product 
        { 
            get => id_product; 
            set => id_product = value; 
        }
        public string ProductName 
        { 
            get => productName; 
            set => productName = value; 
        }
        public double UnitPrice 
        { 
            get => unitPrice; 
            set => unitPrice = value; 
        }
        public int Quantity 
        { 
            get => quantity; 
            set => quantity = value; 
        }
        public string Unit 
        { 
            get => unit; 
            set => unit = value; 
        }
    }
}
