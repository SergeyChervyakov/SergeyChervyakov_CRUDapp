using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SergeyChervyakov_CRUDapp.Models
{
    public class OrdersData
    {
        public int ID { get; set; }       
        public string ClientName { get; set; }
        public int ProductCode { get; set; }
        public string ProductTitle { get; set; }

        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal OrderSum { get; set; }
        public Status Status { get; set; }
    }
}
