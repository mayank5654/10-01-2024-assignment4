using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class Product
    {
        public string PName { get; set; }
        public double PPrice { get; set; }
        public string PBrand { get; set; }
        public DateTime MfDate { get; set; }
        public DateTime ExpDate { get; set; }

        public Product(string pName, double pPrice, string pBrand, DateTime mfDate, DateTime expDate)
        {
            PName = pName;
            PPrice = pPrice;
            PBrand = pBrand;
            MfDate = mfDate;
            ExpDate = expDate;
        }
    }
}
