using Microsoft.AspNetCore.Mvc;
using ProductsMarket.Data;

namespace ProductsMarket.Controllers
{
    public class TablesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TablesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            var customers = _context.Customers.ToList();
            var employees = _context.Employees.ToList();
            var orders = _context.Orders.ToList();
            var orderDetails = _context.OrderDetails.ToList();

            ViewData["Products"] = products;
            ViewData["Customers"] = customers;
            ViewData["Employees"] = employees;
            ViewData["Orders"] = orders;
            ViewData["OrderDetails"] = orderDetails;

            return View();
        }

        public IActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.id == id);
            var customer = _context.Customers.FirstOrDefault(c => c.id == id);
            var employee = _context.Employees.FirstOrDefault(e => e.id == id);
            var order = _context.Orders.FirstOrDefault(o => o.id == id);
            var orderDetail = _context.OrderDetails.FirstOrDefault(od => od.order_id == id);

            ViewData["Product"] = product;
            ViewData["Customer"] = customer;
            ViewData["Employee"] = employee;
            ViewData["Order"] = order;
            ViewData["OrderDetail"] = orderDetail;

            return View();
        }
    }
}