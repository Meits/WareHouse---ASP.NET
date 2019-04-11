using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WareHouse.Abstractions
{
    public interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
