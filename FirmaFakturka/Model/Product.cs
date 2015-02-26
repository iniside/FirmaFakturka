using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaFakturka.Model
{
    class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }

        public decimal Price { get; set; }
        public int VAT { get; set; }
        public int Disacount { get; set; }

        public decimal NetPrice { get; set; }
        public decimal VatTax { get; set; }
        public decimal GrossPrice { get; set; }
    }
}
