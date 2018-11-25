using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BANHANG.Models
{
    [Table("GIAODICH")]
    public class GIAODICH
    {
        [Key]
        [Column("IDGIOHANG")]
        public long ID { get; set; }

        [Column("IDGIOHANG")]
        public long IdGh { get; set; }

        [Column("SOTIEN")]
        public long SoTien { get; set; }

        [Column("NGAYTHANHTOAN")]
        public  DateTime NgayTT { get; set; }

        [Column("TRANGTHAITT")]
        public bool trangthai { get; set; }

        [Column("SOTHE")]
        public string Sothe { get; set; }

        [ForeignKey("IdGh")]
        public virtual GIOHANG giohang { get; set; }
    }
}
