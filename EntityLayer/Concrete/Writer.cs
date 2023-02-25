using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Image { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public List<Article> Articles { get; set; }
    }
}
