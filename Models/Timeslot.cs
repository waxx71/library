using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    [Table("time_slot")]
    public class Timeslot
    {  
        [Column("time_slot_id")]
        public long time_slot_id { get; private set; }
        [Column("start_time")]
        public DateTime start_time { get; private set; }
        [Column("end_time")]
        public DateTime end_time { get; private set; }
    }
}
