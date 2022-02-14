using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyADO.NetApp.DataClasses;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyADO.NetApp
{
    public class Employee
    {
        [Key]
        [Column(TypeName = "int")]
        public int EmployeeID { get; set; }
        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(70)]
        public string EmployeeSurname { get; set; }
        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(70)]
        public string EmployeeName { get; set; }

        [ForeignKey("Ranks")]
        [Column(TypeName ="int")]
        public int RanksId { get; set; }

        [ForeignKey("WorkingMachine")]
        [Column(TypeName = "int")]
        public int WorkingMachineId { get; set; }

        [ForeignKey("RecruiteOffice")]
        [Column(TypeName = "int")]
        public int HiredBy { get; set; }

        [ForeignKey("ProjectManagers")]
        [Column(TypeName = "int")]
        public int ReportingTo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateofAdmission { get; set; }
    }
}
