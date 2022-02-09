using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyADO.NetApp.DataClasses;

namespace MyADO.NetApp
{
    class Employee
    {
        
        public int EmployeeID { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeName { get; set; }
        public Ranks RanksId { get; set; }
        public WorkingMachine WorkingMachine { get; set; }
        public RecruiteOffice HiredBy { get; set; }
        public ProjectManagers ReportingTo { get; set; }
        public DateTime DateofAdmission { get; set; }
    }
}
