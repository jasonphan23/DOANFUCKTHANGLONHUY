using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.ENTITY
{
    public class KhachHangTT
    {
        [Key]
        public string makh { get; set; }
        [Required]
        public string tenkh { get; set; }
        [Required]
        public string cmnd { get; set; }
        public string dienthoai { get; set; }
        public string diachi { get; set; }
        public DateTime ngaysinh { get; set; }
        [Required]
        public int diemtl { get; set; }
        public DateTime ngaydangky { get; set; }
        public DateTime ngayhethan { get; set; }
        public KhachHangTT()
        {
            tenkh = "";
            cmnd = "";
            dienthoai = "";
            diachi = "";
            ngaysinh = new DateTime(1990, 1, 1);
            diemtl = 0;
            ngaydangky = DateTime.Today;
            ngayhethan = ngaydangky.AddDays(365);
        }
    }
}
