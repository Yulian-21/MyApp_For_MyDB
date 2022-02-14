using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyADO.NetApp.DataClasses
{
    public class RecruiteOffice
    {
        [Key]
        [Column(TypeName = "int")]
        public int RecruiterID { get; set; }
        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(100)]
        public string RecruiteSurName { get; set; }
        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(100)]
        public string RecruiterName { get; set; }
        [ForeignKey("ProjectManagers")]
        [Column(TypeName = "int")]
        public ProjectManagers ReportingToPM { get; set; }
        [ForeignKey("Ranks")]
        [Column(TypeName = "int")]
        public Ranks RankId { get; set; }
    }
}
