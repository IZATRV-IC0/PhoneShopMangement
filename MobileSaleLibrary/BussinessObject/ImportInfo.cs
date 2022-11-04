using System;
using System.Collections.Generic;

namespace MobileSaleLibrary.Models
{
    public partial class ImportInfo
    {
        public int ImportId { get; set; }
        public int PhoneId { get; set; }
        public int Quantity { get; set; }
        public int BuyPricePerUnit { get; set; }

        public int Total { 
            get
            {
                return Quantity * BuyPricePerUnit;
            } 
        }

        public string PhoneName
        {
            get
            {
                return Phone.GetPhoneName();
            }
        }
        public virtual Import Import { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
