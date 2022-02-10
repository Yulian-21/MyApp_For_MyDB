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
        public int RankID { get; set; }
        public string RankName { get; set; }
        public Salary SalaryId { get; set; }
    }
}
