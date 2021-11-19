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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using CleverStoreManager.ViewModels;
using CleverStoreManager.Models;

namespace CleverStoreManager.Controllers
{
   public class SalesController : Controller
   {
      private readonly CleverStoreManagerContext _db;
      private readonly UserManager<CleverStoreManagerUser> _userManager;
      private readonly SignInManager<CleverStoreManagerUser> _signInManager;
      private readonly ILogger<AccountController> _logger;

      // Constructor
      public SalesController(UserManager<CleverStoreManagerUser> userManager, SignInManager<CleverStoreManagerUser> signInManager, CleverStoreManagerContext db, ILogger<AccountController> logger)
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

         ViewBag.CleverStoreManagerProductId = new SelectList(_db.CleverStoreManagerProducts.Where(entry => entry.Agent.Id == currentAgent.Id), "Id" , "Name");

         ViewBag.CleverStoreManagerCustomerId = new SelectList(_db.CleverStoreManagerCustomers.Where(entry => entry.Agent.Id == currentAgent.Id), "Id" , "PhoneNumber");

         var agentSales = _db.CleverStoreManagerSales.Where(entry => entry.Agent.Id == currentAgent.Id).ToList();
         return View(agentSales);
      }

      public IActionResult Create(int CleverStoreManagerCustomer, int CleverStoreManagerProduct, string Quantity)
      {
         CleverStoreManagerSale sale = new CleverStoreManagerSale();

         sale.CleverStoreManagerProductId = CleverStoreManagerProduct;
         sale.CleverStoreManagerCustomerId = CleverStoreManagerCustomer;
         sale.Quantity = Quantity;

         _db.CleverStoreManagerSales.Add(sale);
         _db.SaveChanges();
         return RedirectToAction("Index");
         
      }
   }
}