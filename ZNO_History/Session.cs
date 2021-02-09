using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZNO_History
{
    [Table("tblSessions")]
    public class Session
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public decimal Marks { get; set; }
        public virtual User Users { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
