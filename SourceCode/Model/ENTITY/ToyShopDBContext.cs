using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ENTITY
{
    public class ToyShopDBContext : DbContext
    {
        public ToyShopDBContext()
            : base("name=ToyShopDBContext")
        {
        }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<KhachHangTT> KhachHangTTs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<CT_HoaDon> CT_HoaDons { get; set; }
        public DbSet<DonDatHang> DonDatHangs { get; set; }
        public DbSet<CT_DonDatHang> CT_DonDatHangs { get; set; }
        public DbSet<PhieuXK> PhieuXKs { get; set; }
        public DbSet<CT_PhieuXK> CT_PhieuXKs { get; set; }
    }
}
