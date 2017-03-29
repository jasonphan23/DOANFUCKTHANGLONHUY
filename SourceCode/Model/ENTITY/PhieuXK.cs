using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.ENTITY
{
    public class PhieuXK
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int id { get; set; }
        [Required]
       public DateTime ngayxuat { get; set; }
        [Required]
       public TaiKhoan TaiKhoan { get; set; }
       public virtual List<CT_PhieuXK>  CT_PhieuXKs { get; set; }

       public PhieuXK()
       {
           ngayxuat = DateTime.Today;

       }
    }
}
