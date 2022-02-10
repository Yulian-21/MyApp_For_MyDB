using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyADO.NetApp.DataClasses
{
    public class Salary
    {
        [Key]
        public int SalaryID { get; set; }
        public int DollarsPerHour { get; set; }
    }
}
