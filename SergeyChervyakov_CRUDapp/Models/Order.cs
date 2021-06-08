using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SergeyChervyakov_CRUDapp.Models
{
    public enum Status { Created, Paid, Delivered }

    public class Order
    {
        public int ID { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int Quantity { get; set; }
        public Status Status { get; set; }
    }
}
