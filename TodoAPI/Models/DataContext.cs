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
        public DbSet<SANPHAM> sp { get; set; }
        public DbSet<CT_GIOHANG> chitiet { get; set; }
        public DbSet<KHACHHANG> khachhang { get; set; }
        public DbSet<GIAODICH> giaodich { get; set; }
        public DbSet<GIOHANG> giohang { get; set; }

    }
}
