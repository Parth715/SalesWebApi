using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        [StringLength(100), Required]
        public string Description { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public Order() { }
        public virtual IEnumerable<Orderline> Orderlines { get; set; }
    }
}
