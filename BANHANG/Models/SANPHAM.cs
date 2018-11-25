using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BANHANG.Models
{
    [Table("SANPHAM")]
    public class SANPHAM
    {
        [Key]
        [Column("IDSP")]
        public long Id { get; set; }

        [Column("TenSP")]
        public string Name { get; set; }


        [Column("MoTaSP")]
        public string MoTa { get; set; }

        [Column("DVT")]
        public string DVT { get; set; }

        [Column("SoLuongSP")]
        public int Sl { get; set; }

        [Column("GiaBan")]
        public decimal Giaban { get; set; }


    }
}
