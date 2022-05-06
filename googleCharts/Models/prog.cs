using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace googleCharts.Models
{
    [Table("prog", Schema = "public")]
    public class prog
    {

        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int up { get; set; }
        [Key, Column(Order = 1)]

        public int us { get; set; }
        [Key, Column(Order = 2)]

        public int psg{ get; set; }
        public int annee { get; set; }

        public int mois { get; set; }
        public string tabid { get; set; }
        public int flag { get; set; }


    }
}