using MobileSaleLibrary.Repository;
using MobileSaleLibrary.Repository.IRepository;
using System;
using System.Collections.Generic;

namespace MobileSaleLibrary.Models
{
    public partial class ReceiptInfo
    {
        public int ReceiptId { get; set; }
        public int PhoneId { get; set; }
        public string PhoneName
        {
            get
            {
                IPhoneRepository pRepos = new PhoneRepository();
                Phone p = pRepos.GetPhoneByID(this.PhoneId);
                return p.GetPhoneName();
            }
            
        }
        public int SellPricePerUnit { get; set; }
        public int Quantity { get; set; }
        

        public int Total
        {
            get
            {
                return Quantity * SellPricePerUnit;
            }
        }

        
        public virtual Phone Phone { get; set; }
        public virtual Receipt Receipt { get; set; }
    }
}
