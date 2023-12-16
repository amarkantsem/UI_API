using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tblOperational")]
    public class Operational
    {
        [Key]
        public int UID { get; set; }
        public int project_Id { get; set; }
        public string unique_Id { get; set; }
        public string data_by { get; set; }
        public DateTime ? data_date { get; set; }
        public string project_name { get; set; }

    }
}
