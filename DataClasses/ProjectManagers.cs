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
        public int PMID { get; set; }
        public string PMSurname { get; set; }
        public string PMName { get; set; }
        [ForeignKey("CEOs")]
        public CEOs ReportingToCEO { get; set; }
        public Ranks RankId { get; set; }
    }
}
