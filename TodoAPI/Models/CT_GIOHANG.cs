using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BANHANG.Models
{
    [Table("CT_GIOHANG")]
    public class CT_GIOHANG
    {
        [Key]
        [Column("ID_CTGH")]
        public long Id { get; set; }

        [Column("IDGH")]
        public long IdGh { get; set; }

        [Column("IDSP")]
        public long IdSP { get; set; }

        [Column("SOLUONGBAN")]
        public int Slg { get; set; }

        [ForeignKey("IdGh")]
        public GIOHANG giohang { get; set; }

        [ForeignKey("IdSP")]
        public SANPHAM sp { get; set; }

    }
}
