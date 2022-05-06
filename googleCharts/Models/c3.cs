using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace googleCharts.Models
{
    [Table("c3", Schema = "public")]
    public class c3
    {
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int up { get; set; }
        [Key, Column(Order = 1)]

        public int us { get; set; }
        [Key, Column(Order = 2)]

        public int men { get; set; }
        [Key, Column(Order = 3)]
        public int equip { get; set; }

        public Int32? nbr { get; set; }
        public Int32? achat { get; set; }
    }
}