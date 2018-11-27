using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BANHANG.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<SANPHAM> Sanphams { get; set; }
        public DbSet<CT_GIOHANG> ChiTiets { get; set; }
        public DbSet<KHACHHANG> KhachHangs { get; set; }
        public DbSet<GIAODICH> Giaodiches { get; set; }
        public DbSet<GIOHANG> Giohangs { get; set; }

    }
}
