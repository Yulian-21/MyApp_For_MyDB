using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyADO.NetApp.DataClasses
{
    public class ProjectManagers
    {
        [Key]
        [Column(TypeName = "int")]
        public int PMID { get; set; }
        [Column(TypeName ="nvarchar")]
        [MinLength(3)]
        [MaxLength(100)]
        public string PMSurname { get; set; }
        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(100)]
        public string PMName { get; set; }
        [Column(TypeName ="int")]
        [ForeignKey("CEOs")]
        public CEOs ReportingToCEO { get; set; }
        [Column(TypeName = "int")]
        [ForeignKey("Ranks")]
        public Ranks RankId { get; set; }
    }
}
