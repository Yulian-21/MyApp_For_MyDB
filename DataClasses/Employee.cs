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
        public int EmployeeID { get; set; }

        public string EmployeeSurname { get; set; }
        public string EmployeeName { get; set; }

        [ForeignKey("Ranks")]
        public Ranks RanksId { get; set; }

        [ForeignKey("WorkingMachine")]
        public WorkingMachine WM { get; set; }

        [ForeignKey("RecruiteOffice")]
        public RecruiteOffice HiredBy { get; set; }

        [ForeignKey("ProjectManagers")]
        public ProjectManagers ReportingTo { get; set; }
        public DateTime DateofAdmission { get; set; }
    }
}
