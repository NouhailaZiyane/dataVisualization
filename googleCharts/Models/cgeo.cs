using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace googleCharts.Models
{
    [Table("cgeo",Schema = "public")]
    public class cgeo
    {
        [Key]
        public int  tid { get; set; }
        public string code { get; set; }
        public string lib { get; set; }
        public string libar { get; set; }
        public int niveau { get; set; }
        public int pid { get; set; }



    }
}