using System.Linq;
using DataContextt.DAL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataContextt.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var studentList = _context.Students.ToList();
            return View(studentList);
        }
    }
}
