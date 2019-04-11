using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WareHouse.Abstractions;

namespace WareHouse.Entities
{
    [Table("products")]
    public class Product : DbEntity
    {
        [Column("name")]
        [StringLength(64)]
        public string Name { get; set; }
        public virtual Stock Stock { get; set; }
        public Guid StockId { get; set; }
    }
}
