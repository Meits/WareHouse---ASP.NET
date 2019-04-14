using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WareHouse.Abstractions;

namespace WareHouse.Entities
{
    [Table("users")]
    public class User : DbEntity
    {
        [Column("firstname")]
        [StringLength(64)]
        public string Firstname { get; set; }

        [Column("lastname")]
        [StringLength(64)]
        public string Lastname { get; set; }

        [Column("password")]
        [StringLength(64)]
        public string Password { get; set; }

        [Column("email")]
        [StringLength(64)]
        public string Email { get; set; }

        [Column("token")]
        [StringLength(64)]
        public string Token { get; set; }
    }
}
