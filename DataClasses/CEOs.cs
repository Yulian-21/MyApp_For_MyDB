using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyADO.NetApp.DataClasses
{
    public class CEOs : DbContext
    {
        [Key]
        [Column(TypeName = "int")]
        public int CEOID { get; set; }

        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(70)]
        public string CEOSurname { get; set; }

        [Column(TypeName = "nvarchar")]
        [MinLength(3)]
        [MaxLength(80)]
        public string CEOName { get; set; }


        public List<ProjectManagers> ProjectManagers { get; set; }
        public List<RecruiteOffice> Recruiters { get; set; }
    }
}
