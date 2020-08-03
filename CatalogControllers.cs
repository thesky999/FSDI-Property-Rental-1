using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;
namespace PropertyRental.Controllers{

    public class CatalogController : Controller{

        private DataContext dbContext;
        public CatalogController(DataContext db){
            this.dbContext = db;
        }

        public IActionResult Test(){
            return View();
        }

        public IActionResult Index(){
            return View();
        }

        public IActionResult Register(){
            return View();
        }

        [HttpPost]

        public IActionResult RegisterProperty([FromBody] Property p){
            System.Console.WriteLine("user is saving something");
            
            dbContext.Properties.Add(p);
            dbContext.SaveChanges();


            return Json(p);
        }
    }
}