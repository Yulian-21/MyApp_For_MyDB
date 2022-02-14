using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyADO.NetApp.DataClasses
{
    public class Ranks
    {
        [Key]
        [Column(TypeName = "int")]
        public int RankID { get; set; }

        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(50)]
        public string RankName { get; set; }

        [ForeignKey("Salary")]
        [Column(TypeName = "int")]
        public Salary SalaryId { get; set; }
    }
}
