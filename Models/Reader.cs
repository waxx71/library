using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace library.Models
{
    [Table("reader")]
    public class Reader
    {
        [Column("id")]
        public long reader_id { get; private set; }
        [Column("name")]
        public string name { get; private set; }
        [Column("gender")]
        public string gender { get; private set; }
        [Column("contact")]
        public string contact { get; private set; }
        [Column("password")]
        public string password { get; private set; }
        [Column("credit")]
        public int credit { get; set; }
    }
}
