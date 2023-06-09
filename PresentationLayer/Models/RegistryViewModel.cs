using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PresentationLayer.Models
{
	public class RegistryViewModel
	{
		public Writer Writer { get; set; }
		public List<SelectListItem> Country { get; set; }
		public string Terms { get; set; }
		public ModelStateDictionary ModelState { get; set; }
	}
}
