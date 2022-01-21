using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Salesporium.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public string FurnitureItem { get; set; }
        public double Price { get; set; }

        //insurance flat rate of 300 dollars
        public bool Insurance { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //8 percent commission - extra ten percent commission if insurance sold
        double _commision;
        public double Commission
        {
            get
            {
                if(Insurance == true)
                {
                    return Price * .18;
                }
                else
                {
                    return Price * .10;
                }
            }
            set
            {
                if(Insurance == true)
                {
                    _commision = Price * 18;
                }
                else
                {
                    _commision = Price * .10;
                }
            }
        }

        double _total;
        public double Total
        {
            get
            {
                if(Insurance == true)
                {
                    return Price + 300;
                }
                else
                {
                    return Price;
                }
            }
            set
            {
                if(Insurance == true)
                {
                    _total = Price + 300;
                }
                else
                {
                    _total = Price;
                }
            }
        }
    }
}
