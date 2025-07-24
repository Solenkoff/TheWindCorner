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

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Categories"] = Enum.GetValues(typeof(Category)).Cast<Category>();
            ViewData["ItemTypes"] = Enum.GetValues(typeof(ItemType)).Cast<ItemType>();

            return this.View();
        }

        [HttpPost]
        public IActionResult Create(AddItemInputModel inputModel)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Categories"] = Enum.GetValues(typeof(Category)).Cast<Category>();
                ViewData["ItemTypes"] = Enum.GetValues(typeof(ItemType)).Cast<ItemType>();
                return View(inputModel);
            }

            Item item = new Item()
            {
                Category = inputModel.Category,
                ItemType = inputModel.ItemType,
                Title = inputModel.Title,
                Size = inputModel.Size ?? "-",
                Brand = inputModel.Brand ?? "-",
                Year = inputModel.Year,
                Description = inputModel.Description,
                IsApproved = false,
                IsDeleted = false,
                IsSold = false
            };
          
            this.dbContext.Items.Add(item);
            this.dbContext.SaveChanges();

            return this.RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            bool isValidId = Guid.TryParse(id, out Guid resultId);
            if (!isValidId)
            {
                return RedirectToAction(nameof(Index));
            }

            Item? item = this.dbContext
                .Items
                .FirstOrDefault(i => i.Id == resultId);
            if(item == null)
            {
                return RedirectToAction(nameof(Index)); 
            }

            return this.View(item);
        }
    }
}
