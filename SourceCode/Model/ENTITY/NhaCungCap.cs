using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ENTITY
{
    public class NhaCungCap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get;set;}
        [Required]
        [StringLength(40)]
        public string tenncc { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string diachi { get; set; }
    }
}
