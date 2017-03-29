using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.ENTITY
{
    public class DonDatHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public DateTime ngaydat { get; set; }
        [Required]
        public NhaCungCap NhaCungCap { get; set; }
        [Required]
        public int tongtien { get; set; }
        public List<CT_DonDatHang> CT_DonDatHangs { get; set; }

        public DonDatHang()
        {
            ngaydat = DateTime.Today;
            NhaCungCap = new NhaCungCap();
            tongtien = 0;

        }
        
    }
}
