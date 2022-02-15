using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyADO.NetApp
{
    public class WorkingMachine
    {
        [Key]
        [Column(TypeName = "int")]
        public int MachineID { get; set; }

        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(200)]
        public string MachineName { get; set; }

        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(200)]
        public string ModelName { get; set; }



        public List<Employee> Employees { get; set; }
    }
}
