using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Model.ENTITY
{
    public class CT_HoaDon
    {
        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }
        [Required]
        public int sl { get; set; }
        [Required]
        public int tong { get; set; }

        public CT_HoaDon()
        {
            HoaDon = new HoaDon();
            SanPham = new SanPham();
            sl = 0;
            tong = 0;
        }
    }
}
