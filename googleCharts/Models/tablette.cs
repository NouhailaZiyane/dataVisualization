using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace googleCharts.Models
{
    [Table("tablette", Schema = "public")]
    public class tablette
    {
        [Key]
        public string tabid { get; set; }
        public string deviceid { get; set; }
        public string modele { get; set; }
        public string profilid { get; set; }

    }
}