using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.ENTITY
{
    public class CT_DonDatHang
    {

        public DonDatHang DonDatHang { get; set; }
        public SanPham SanPham { get; set; }
        [Required]
        public int sl { get; set; }
        [Required]
        public int tong { get; set; }

        public CT_DonDatHang()
        {
            DonDatHang = new DonDatHang();
            SanPham = new SanPham();
            sl = 1;
            tong = 0;
        }
    }
}
