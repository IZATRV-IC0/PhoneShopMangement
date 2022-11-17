using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSaleLibrary.BussinessObject
{
    public class Sales
    {
        public DateTime Date { get; set; }
        public decimal Total { get; set; }

        public Sales()
        {

        }
        public Sales(DateTime date) { Date = date; }
        public override string ToString()
        {
            return "Date=" + Date + ",Total=" + Total;
        }

    }
}
