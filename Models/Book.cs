using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    [Table("borrows")]
    public class Book
    {
            [Column("book_id")]
            public long book_id { get; private set; }
            [Column("ISBN")]
            public string ISBN { get; private set; }
            [Column("publisher")]
            public string publisher { get; private set; }
            [Column("author")]
            public string author { get; private set; }
            [Column("name")]
            public string name { get; private set; }
            [Column("type")]
            public string type { get; private set; }
            [Column("publish_date")]
            public DateTime publish_date { get; private set; }
            [Column("introduction")]
            public string introduction { get; private set; }
            [Column("in_use")]
            public int in_use { get; private set; }
            [Column("location_id")]
            public string location_id { get; private set; }
    }
}
