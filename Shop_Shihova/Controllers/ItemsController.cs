using Microsoft.AspNetCore.Mvc;
using Shop_Shihova.Data.Interfaces;
using Shop_Shihova.Data.Models;
using Shop_Shihova.Data.ViewModell;

namespace Shop_Shihova.Controllers
{
    public class ItemsController : Controller
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment;
        private IItems IAllItems;
        private ICategorys IAllCategorys;
        VMItems VMItems = new VMItems();

        public ItemsController(IItems IAllItems, ICategorys IAllCategorys, Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            this.IAllItems = IAllItems;
            this.IAllCategorys = IAllCategorys;
            this.hostingEnvironment = hostingEnvironment;
        }

        public ViewResult List(int id = 0)
        {
            ViewBag.Title = "Страница с предметами";

            VMItems.Items = IAllItems.AllItems;
            VMItems.Categorys = IAllCategorys.AllCategorys;
            VMItems.SelectCategory = id;
            return View(VMItems);
        }
        [HttpGet]
        public ViewResult Add()
        {
            IEnumerable<Categorys> Categorys = IAllCategorys.AllCategorys;

            return View(Categorys);
        }
        [HttpPost]
        public RedirectResult Add(string name, string description, IFormFile files, float price, int idCategory)
        {
            if (files != null)
            {
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "img");
                var filePath = Path.Combine(uploads, files.FileName);
                files.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            Items newItems = new Items();
            newItems.Name = name;
            newItems.Description = description;
            newItems.Img = "/img/" + Path.GetFileName(files.FileName);
            newItems.Price = Convert.ToInt32(price);
            newItems.Category = new Categorys() { Id = idCategory };

            int id = IAllItems.Add(newItems);

            return Redirect("/Items/Update?id=" + id);
        }
        [HttpGet]
        public ViewResult Update(int id)
        {
            ViewBag.Title = "Изменение предмета";
            ViewBag.Categorys = IAllCategorys.AllCategorys;

            Items Item = IAllItems.AllItems.Where(x => x.Id == id).First();

            return View(Item);
        }
        [HttpPost]
        public RedirectResult Update(int id, string name, string description, IFormFile files, float price, int idCategory)
        {
            Items Item = IAllItems.AllItems.Where(x => x.Id == id).First();

            if (files != null)
            {
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "img");
                var filePath = Path.Combine(uploads, files.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    files.CopyTo(stream);
                }
                Item.Img = "/img/" + Path.GetFileName(files.FileName);
            }

            Item.Name = name;
            Item.Description = description;
            Item.Price = Convert.ToInt32(price);
            Item.Category = new Categorys() { Id = idCategory };

            IAllItems.Update(Item);

            return Redirect("/Items/Update?id=" + id);
        }
        [HttpGet]
        public RedirectResult Delete(int id)
        {
            IAllItems.Delete(id);

            return Redirect("/Items/List");
        }
    }
}
