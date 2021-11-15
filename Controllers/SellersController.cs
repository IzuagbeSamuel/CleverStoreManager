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
   public class SellersController : Controller
   {
      private readonly CleverStoreManagerContext _db;
      private readonly UserManager<CleverStoreManagerUser> _userManager;
      private readonly SignInManager<CleverStoreManagerUser> _signInManager;
      private readonly ILogger<AccountController> _logger;

      // Constructor
      public SellersController(UserManager<CleverStoreManagerUser> userManager, SignInManager<CleverStoreManagerUser> signInManager, CleverStoreManagerContext db, ILogger<AccountController> logger)
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
         var agentSellers = _db.CleverStoreManagerSellers.Where(entry => entry.Agent.Id == currentAgent.Id).ToList();
         return View(agentSellers);
      }

      [HttpPost]
      public async Task<IActionResult> Create(string BusinessName, string Address, string EmailAddress, string PhoneNumber) 
      {
         CleverStoreManagerSeller seller =  new CleverStoreManagerSeller();
         seller.BusinessName = BusinessName;
         seller.Address = Address;
         seller.EmailAddress = EmailAddress;
         seller.PhoneNumber = PhoneNumber;

         var agentId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
         var currentAgent = await _userManager.FindByIdAsync(agentId);

         seller.Agent = currentAgent;

         _db.CleverStoreManagerSellers.Add(seller);
         _db.SaveChanges();
         return RedirectToAction("Index");
      }
   }
}