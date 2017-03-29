using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Model.ENTITY
{
    public class LoaiSanPham
    {
        [Key]
        [StringLength(10)]
        public string loaisp_id { get; set; }
        [Required]
        public string tenloai { get; set; }
        public virtual List<SanPham> Sanphams { get; set; }

        public LoaiSanPham()
        {
            loaisp_id = "";
            tenloai = "";
        }
    }
}
