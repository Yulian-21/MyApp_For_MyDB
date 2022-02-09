using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyADO.NetApp
{
    public class WorkingMachine
    {
        [Key]
        public int MachineID { get; set; }

        public string MachineName { get; set; }
        public string ModelName { get; set; }
    }
}
