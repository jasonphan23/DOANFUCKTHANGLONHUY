using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.ENTITY
{
    public class CT_PhieuXK
    {
        public PhieuXK PhieuXK { get; set; }
        public SanPham SanPham { get; set; }
        [Required]
        public int sl { get; set; }

        public CT_PhieuXK()
        {
            sl = 0;
        }
    }
}
