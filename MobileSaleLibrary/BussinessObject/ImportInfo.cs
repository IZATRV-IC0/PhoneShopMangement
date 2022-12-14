using MobileSaleLibrary.Repository.IRepository;
using MobileSaleLibrary.Repository;
using System;
using System.Collections.Generic;

namespace MobileSaleLibrary.Models
{
    public partial class ImportInfo
    {
        public int ImportId { get; set; }
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

        public int BuyPricePerUnit { get; set; }

        public int Quantity { get; set; }
        

        public int Total { 
            get
            {
                return Quantity * BuyPricePerUnit;
            } 
        }

        
        public virtual Import Import { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
