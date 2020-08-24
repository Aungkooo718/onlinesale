using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineSalePrj.Data;
using OnlineSalePrj.Models;
using OnlineSalePrj.ViewModel;

namespace OnlineSalePrj.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnviroment;        

        public ProductsController(ApplicationDbContext context, IWebHostEnvironment hostEnviroment)
        {
            _context = context;
            this._hostEnviroment = hostEnviroment;
            
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Products.Include(p => p.ProductCategory);
            return View(await applicationDbContext.ToListAsync());
        }
        public IActionResult AjaxMethod()
        {
            ProductPruchaseItemViewModel item = new ProductPruchaseItemViewModel();
            var products = _context.Products.ToList();
            List<Product> p = new List<Product>();
            products.ForEach(a =>
            {
                p.Add(new Product() { Name = a.Name, Price = a.Price, ImageName = a.ImageName, Qty = a.Qty, ID = a.ID });
            });
            //item.Product = p;

            item.Products = p;
            item.TotalPrice = p.Sum(p => p.Price * p.Qty);
            //item.TotalPrice =  p.Price * p.Qty;
            return View(item);
            //List<Product> products = (from product in _context.Products
            //                          select product).ToList();
            //return View(products);
        }
        public IActionResult ProductSale()
        {
            ProductPruchaseItemViewModel item = new ProductPruchaseItemViewModel();
            var product = _context.Products.ToList();
            List<Product> p = new List<Product>();
            product.ForEach(a =>
            {
                p.Add(new Product { Name = a.Name, Price = a.Price, ImageName = a.ImageName, Qty = a.Qty, ID = a.ID });
            });
            item.Products = p;
            return View(item);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductSale(ProductPruchaseItemViewModel item)
        {

            List<PurchaseItem> pi = new List<PurchaseItem>();
            string user = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var customer = _context.Customers.Where(c=>c.LoginUser==user).FirstOrDefault();
            // var rder = _context.Orders.Where(o => o.CustomerId == pi.Contains()).FirstOrDefault();
          
           
           // double totalamount = pi.Sum(pi => pi.TotalPrice);
            Order order = new Order()
            {
                CustomerId = customer.ID,
               // TotalAmount = totalamount,
            };
            item.ItemList.ToList().ForEach(a =>
            {
               
                var product = _context.Products.Where(c => c.ID == a.ProductId).FirstOrDefault();
                
                pi.Add(new PurchaseItem() { Name = product.Name, Price = a.Price, Qty = a.Qty, TotalPrice = a.TotalPricePerItem,  ProductId = a.ProductId,Order=order});
            });
            _context.AddRange(pi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ProductSale));
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductCategory)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategories, "ID", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Qty,Price,ProductType,ImageFile,ProductCategoryId")] Product product)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnviroment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(product.ImageFile.FileName);
                string extension = Path.GetExtension(product.ImageFile.FileName);
                product.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await product.ImageFile.CopyToAsync(fileStream);
                }
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategories, "ID", "Name", product.ProductCategoryId);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategories, "ID", "Name", product.ProductCategoryId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Qty,Price,ProductType,ImageName,ProductCategoryId")] Product product)
        {
            if (id != product.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategories, "ID", "Name", product.ProductCategoryId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductCategory)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ID == id);
        }
    }
}
