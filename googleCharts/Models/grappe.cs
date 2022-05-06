using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace googleCharts.Models
{
    [Table("grappe", Schema = "public")]
    public class grappe
    {
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int up { get; set; }
        [Key, Column(Order = 1)]
        public int us { get; set; }
        public int dc { get; set; }

        public int se { get; set; }
        public Int32? nbrmen { get; set; }
        public string remq { get; set; }

        public int cgid { get; set; }



    }
}