using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace googleCharts.Models
{
    [Table("profil", Schema = "public")]
    public class profil
    {
        [Key]
        public int tid { get; set; }
        public string nomprenom { get; set; }
        public string tel { get; set; }
        public string email { get; set; }

        public string pwd { get; set; }
        public int role { get; set; }

        public int cgid { get; set; }



    }
}