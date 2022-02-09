using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyADO.NetApp.DataClasses
{
    public class Ranks
    {
        public int RankID { get; set; }
        public string RankName { get; set; }
        public Salary SalaryId { get; set; }
    }
}
