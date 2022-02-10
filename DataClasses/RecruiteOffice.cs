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
        public int RecruiterID { get; set; }
        public string RecruiteSurName { get; set; }
        public string RecruiterName { get; set; }
        public ProjectManagers ReportingToPM { get; set; }
        public Ranks RankId { get; set; }
    }
}
