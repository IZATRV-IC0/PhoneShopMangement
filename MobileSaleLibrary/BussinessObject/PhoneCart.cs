using MobileSaleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSaleLibrary.BussinessObject
{
    public class PhoneCart
    {
        public PhoneCart(int phoneID, string phoneName, int price, int quantity, string type, string brand)
        {
            PhoneID = phoneID;
            PhoneName = phoneName;
            Price = price;
            Quantity = quantity;
            Type = type;
            Brand = brand;
        }
        public PhoneCart()
        {

        }

        public int PhoneID { get; set; }
        public string PhoneName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }

        public int total()
        {
            return Price * Quantity;
        }
        public void updateQuantity(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
