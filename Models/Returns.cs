using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    [Table("returns")]
    public class Returns
    {
        [Column("borrow_id")]
        public long borrow_id { get; private set; }
        [Column("book_id")]
        public long book_id { get; private set; }
        [Column("reader_id")]
        public long reader_id { get; private set; }
        [Column("time_slot_id")]
        public long time_slot_id { get; private set; }
    }
}
