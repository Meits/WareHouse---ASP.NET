using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WareHouse.Abstractions;

namespace WareHouse.Entities
{
    [Table("stocks")]
    public class Stock  : DbEntity
    {
        [Column("name")]
        [StringLength(64)]
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
