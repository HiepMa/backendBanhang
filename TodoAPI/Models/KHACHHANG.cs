using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BANHANG.Models
{
    [Table("KHACHHANG")]
    public class KHACHHANG
    {
        [Key]
        [Column("IDKH")]
        public long Id { get; set; }

        [Column("TENKH")]
        public string name { get; set; }

        [Column("MATKHAU")]
        public string Pass { get; set; }

        [Column("DIACHIKH")]
        public string DiaChi { get; set; }

        [Column("SDT")]
        public string sdt { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }
    }
}
