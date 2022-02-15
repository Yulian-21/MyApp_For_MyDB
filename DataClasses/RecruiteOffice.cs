using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyADO.NetApp.DataClasses
{
    public class RecruiteOffice
    {
        [Key]
        [Column(TypeName = "int")]
        public int RecruiterID { get; set; }

        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(100)]
        public string RecruiteSurName { get; set; }

        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(100)]
        public string RecruiterName { get; set; }

        
        [Column(TypeName = "int")]
        public int ReportingToPM { get; set; }

       
        [Column(TypeName = "int")]
        public int RankId { get; set; }




        [ForeignKey("RankId")]
        public Ranks Ranks { get; set; }

        [ForeignKey("ReportingToPM")]
        public ProjectManagers ProjectManagers { get; set; }


        public List<Employee> Employees { get; set; }
    }
}
