using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyADO.NetApp.DataClasses
{
    public class ProjectManagers
    {
        public int PMID { get; set; }
        public string PMSurname { get; set; }
        public string PMName { get; set; }
        public CEOs ReportingToCEO { get; set; }
        public Ranks RankId { get; set; }
    }
}
