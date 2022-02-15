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
        [Column(TypeName = "int")]
        public int RankID { get; set; }

        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(50)]
        public string RankName { get; set; }

        [Column(TypeName = "int")]
        public int SalaryId { get; set; }


        public List<Employee> Employees { get; set; }
        public List<ProjectManagers> ProjectManagers { get; set; }
        public List<RecruiteOffice> Recruiters { get; set; }

        [ForeignKey("SalaryId")]
        public Salary Salary { get; set; }
    }
}
