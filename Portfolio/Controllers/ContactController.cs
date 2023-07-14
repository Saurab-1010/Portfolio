using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ContactController (ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //IEnumerable<Contact> objContactList = _db.Contacts;
            //return View(objContactList);
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _db.Contacts.Add(model);
                    _db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return View(model);
        }
    }
}
