using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Diagnostics;
using PresentationLayer.Models;
namespace PresentationLayer.Controllers
{
    public class RegistrationController : Controller
    {
        WriterManager w_manager = new WriterManager(new EfWriterRepository());
        CategoryManager c_manager = new CategoryManager(new EfCategoryRepository());
      
        public RegistryViewModel LoadModel()
        {
			var registryViewModel = new RegistryViewModel
			{
				Writer = new Writer(),
				Country = new()
				{
					new SelectListItem { Text = "EU", Value = "1" },
					new SelectListItem { Text="Non-EU",Value ="2"}
				},
				Terms = "Our terms are very supportive"
			};
            return registryViewModel;
		}
        [HttpGet]
        public IActionResult Index()
        {

			
			
			return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {

			WriterValidator validator = new();
			ValidationResult validationResult = validator.Validate(writer);
			

			if (validationResult.IsValid)
            {
                writer.Status = true;
                writer.About = "Test";
                w_manager.Insert(writer);
                return RedirectToAction("Index", "Home");
            }
			else
            {
                foreach(ValidationFailure failure in validationResult.Errors)
                {
                    validationResult.AddToModelState(ModelState);
                }
                
              
            }
           

            
			return View();
			
        }
    }
}
