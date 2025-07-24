namespace TheWindCorner.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using TheWindCorner.Data;
    using TheWindCorner.Data.Models.Entities;
    using TheWindCorner.Data.Models.Enums;
    using TheWindCorner.Web.ViewModels.Item;

    public class ItemController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ItemController(ApplicationDbContext _dbContext)
        {
            this.dbContext = _dbContext;          
        }

        [HttpGet]    
        public IActionResult Index()
        {
            IEnumerable<Item> allItems = this.dbContext
                .Items
                .ToList();
            return View(allItems);
        }
    }
}
