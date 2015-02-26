using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaFakturka.Model
{
    class Client
    {
        [Key]
        public int Id { get; set; }
        public int NIP { get; set; }
        public string Company { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string StreeAdress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhone { get; set; }
    }
}
