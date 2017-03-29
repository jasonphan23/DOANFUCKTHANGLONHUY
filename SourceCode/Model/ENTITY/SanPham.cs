using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Model.ENTITY
{
    public class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string tensp { get; set; }
        [Required]
        public string dvt { get; set; }
        [Required]
        public string xuatxu { get; set; }
        [Required]
        public int dongia { get; set; }
        [Required]
        public int slbayban{ get; set; }
        [Required]
        public int sltonkho { get; set; }
        public LoaiSanPham LoaiSanPham { get; set; }
        public  SanPham()
        {
            tensp = "";
            dvt = "";
            xuatxu = "";
            dongia = 0;
            slbayban = 1;
            sltonkho = 1;
        }


    }
}
