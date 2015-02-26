using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaFakturka.Model
{
    class Invoice
    {
        [Key]
        public int Id { get; set; }
        /*
         * One invoice can only be for one client.
         */
        public Client ClientData { get; set; }

        /*
         * Collection of products on this invoice.
         */
        ICollection<Product> Products;
    }
}
