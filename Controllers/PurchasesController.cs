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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using CleverStoreManager.ViewModels;
using CleverStoreManager.Models;

namespace CleverStoreManager.Controllers
{
   public class PurchasesController : Controller
   {
       private readonly CleverStoreManagerContext _db;
      private readonly UserManager<CleverStoreManagerUser> _userManager;
      private readonly SignInManager<CleverStoreManagerUser> _signInManager;
      private readonly ILogger<AccountController> _logger;

      // Constructor
      public PurchasesController(UserManager<CleverStoreManagerUser> userManager, SignInManager<CleverStoreManagerUser> signInManager, CleverStoreManagerContext db, ILogger<AccountController> logger)
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
         var agentPurchases = _db.CleverStoreManagerPurchases.Where(entry => entry.Agent.Id == currentAgent.Id).ToList();
         ViewBag.CleverStoreManagerProductId = new SelectList(_db.CleverStoreManagerProducts.Where(entry => entry.Agent.Id == currentAgent.Id), "Id", "Name");
         ViewBag.CleverStoreManagerSellerId = new SelectList(_db.CleverStoreManagerSellers.Where(entry => entry.Agent.Id == currentAgent.Id), "Id" , "BusinessName");
         return View(agentPurchases);
      }

      public async Task<IActionResult> Create(string DateToDeliver, string Quantity, string QuantityBulk, int CleverStoreManagerProductId, int CleverStoreManagerSellerId)
      {
         CleverStoreManagerPurchase purchase = new CleverStoreManagerPurchase();
         purchase.DateOrdered = DateTime.Now;
         purchase.DateToDeliver = DateToDeliver;
         purchase.Quantity = Quantity;
         purchase.QuantityBulk = QuantityBulk;

         // purchase.CleverStoreManagerProductId = CleverStoreManagerProductId;
         // purchase.CleverStoreManagerSellerId = CleverStoreManagerSellerId;

         var agentId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
         var currentAgent = await _userManager.FindByIdAsync(agentId);

         purchase.Agent = currentAgent;
         _db.CleverStoreManagerPurchases.Add(purchase);
         _db.SaveChanges();
         return RedirectToAction("Index");
      }
   }
}