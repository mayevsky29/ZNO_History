using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZNO_History
{
    [Table("tblQuestions")]
    public class Question
    {
        
            [Key]
            public int Id { get; set; }

            [Required, StringLength(400)]
            public string Text { get; set; }

            public virtual ICollection<Answer> Answers { get; set; }
        
    }
}
