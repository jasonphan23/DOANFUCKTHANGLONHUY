using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.ENTITY
{
    public class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public DateTime ngayxuat { get; set; }
        [Required]
        public int thanhtien { get; set; }
        public  virtual List<CT_HoaDon> CTHoaDons { get; set; }
         public HoaDon()
        {
            ngayxuat = DateTime.Today;
            thanhtien = 0;            
        }
        
    }
}
