using EntityLayer.Concrete;

namespace PresentationLayer.Models
{
	public class CommentViewModel
	{
		public IEnumerable<Comment> Comments { get; set; }
		public int ArticleID { get; set; }
	}
}
