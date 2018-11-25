using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BANHANG.Models
{
    [Table("GIOHANG")]
    public class GIOHANG
    {
        [Key]
        [Column("IDGIOHANG")]
        public long Id { get; set; }

        [Column("MAKH")]
        public long Ma { get; set;}
       
        [Column("NGAYMUA")]
        public DateTime ngaymua { get; set; }

        [Column("TTTHANHTOAN")]
        public bool TT { get; set; }

        [Column("HINHTHUCTT")]
        public string Hinhthuc { get; set; }

        [Column("TONGTIENGH")]
        public long SumMoney { get; set; }

        [Column("TONGTHANHTOAN")]
        public long SumTT { get; set; }

        [ForeignKey("Ma")]
        public KHACHHANG khachhang { get; set; }
    }
}
