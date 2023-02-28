using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Article
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ThumbNailImage { get; set; }
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
        public long ClickAmount { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }

        [ForeignKey("Writer")]
        public int WriterId { get; set; }
        public Writer Writer { get; set; }
        
    }
}
