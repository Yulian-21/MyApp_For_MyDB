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
        public int ReportingToCEO { get; set; }

        [Column(TypeName = "int")]
        public int RankId { get; set; }




        public List<Employee> Employees { get; set; }
        public List<RecruiteOffice> Recruiters { get; set; } = new List<RecruiteOffice>();

        [ForeignKey("ReportingToCEO")]
        public CEOs CEOs { get; set; }

        [ForeignKey("RankId")]
        public Ranks Rank { get; set; }
    }
}
