using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    [Table("violation")]
    public class Violation
    {
        [Column("violation_id")]
        public long violation_id { get; set; }
        [Column("borrow_id")]
        public long borrow_id { get; set; }
        [Column("type")]
        public string type { get; set; }
        [Column("fine")]
        public int fine { get; set; }
    }
}
