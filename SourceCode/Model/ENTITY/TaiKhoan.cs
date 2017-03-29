using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.ENTITY
{
    public class TaiKhoan
    {
        [Key]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        public string tennguoidung { get; set; }
        [Required]
        public int phanquyen { get; set; }
    }
}
