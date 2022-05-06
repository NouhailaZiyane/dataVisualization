using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace googleCharts.Models
{
    [Table("parametrage", Schema = "public")]
    public class parametrage
    {
        [Key]
        public int paramid { get; set; }

        public int param { get; set; }

        public string decsription { get; set; }

        public int valeur { get; set; }

    }
}