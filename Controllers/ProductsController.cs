using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Text;
using System.Net.Mail;
using System.Text.Encodings.Web;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using CleverStoreManager.ViewModels;
using CleverStoreManager.Models;

namespace CleverStoreManager.Controllers
{
   public class ProductsController : Controller
   {
      private readonly CleverStoreManagerContext _db;
      private readonly UserManager<CleverStoreManagerUser> _userManager;
      private readonly SignInManager<CleverStoreManagerUser> _signInManager;
      private readonly ILogger<AccountController> _logger;

      // Constructor
      public ProductsController(UserManager<CleverStoreManagerUser> userManager, SignInManager<CleverStoreManagerUser> signInManager, CleverStoreManagerContext db, ILogger<AccountController> logger)
      {
         _userManager = userManager;
         _signInManager = signInManager;
         _db = db;
         _logger = logger;
      }

      
      public async Task<IActionResult> Index() 
      {
         var agentId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
         if(agentId == null)
         {
            return View();
         }
         var currentAgent = await _userManager.FindByIdAsync(agentId);
         var agentProducts = _db.CleverStoreManagerProducts.Where(entry => entry.Agent.Id == currentAgent.Id).ToList();
         return View(agentProducts);
      }

      [HttpPost]
      public async Task<IActionResult> Create(string Barcode, string Name, string Label, string Description, string MadeDate, string ExpiringDate, string Size, string Quantity, string SalesPrice, string CostPrice, string DiscountPrice, string StockKeepingUnit, string Weight)
      {
         CleverStoreManagerProduct product = new CleverStoreManagerProduct();
         product.Barcode = Barcode;
         product.Name = Name;
         product.Label = Label;
         product.Description = Description;
         product.MadeDate = MadeDate;
         product.ExpiringDate = ExpiringDate;
         product.Size = Size;
         product.Quantity = Quantity;
         product.SalesPrice = SalesPrice;
         product.CostPrice = CostPrice;
         product.DiscountPrice = DiscountPrice;
         product.StockKeepingUnit = StockKeepingUnit;
         product.Weight = Weight;

         var agentId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
         var currentAgent = await _userManager.FindByIdAsync(agentId);

         product.Agent = currentAgent;

         _db.CleverStoreManagerProducts.Add(product);
         _db.SaveChanges();
         return RedirectToAction("Index");
      }
   }
}