using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace googleCharts.Models
{
    [Table("menage", Schema = "public")]
    public class menage
    {
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int up { get; set; }
        [Key, Column(Order = 1)]

        public int us { get; set; }
        [Key, Column(Order = 2)]

        public int men { get; set; }
        public string chefmen { get; set; }
        public string epouse { get; set; }

        public string cadet { get; set; }
        public string adresse1 { get; set; }

        public string adresse2 { get; set; }
        public string flg { get; set; }
        public Int32? sexe { get; set; }
        public Int32? age { get; set; }

        public Int32? netude { get; set; }
        public Int32? activite { get; set; }

        public Int32? nbrind { get; set; }

        public Int32? nbrind15 { get; set; }

        public Int32? nbrindactif { get; set; }

        public Int32? revenu { get; set; }

        public Int32? categrevenu { get; set; }
    }
}