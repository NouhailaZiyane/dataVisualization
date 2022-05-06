using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace googleCharts.Models
{
    [Table("dbfiles", Schema = "public")]
    public class dbfiles
    {
        [Key]

        public int tid { get; set; }
        public string tabid { get; set; }

        public Int32? datafile { get; set; }

        public string date_envoi { get; set; }

        public string flg { get; set; }
        public int acteurtid { get; set; }


    }
}