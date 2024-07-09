using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        private AppDbContext _context;
        public TestController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return Ok(_context.Products.ToList());
        }
    }
}
