using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int ArticleID { get; set; }
        [ForeignKey("ArticleID")]
        public Article Article { get; set; }

        


    }
}
