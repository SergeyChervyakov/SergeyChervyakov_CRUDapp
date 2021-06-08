using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SergeyChervyakov_CRUDapp.Models
{
    public class ClientData
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        public int OrderCount { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? AvgOrder { get; set; }
    }
}
