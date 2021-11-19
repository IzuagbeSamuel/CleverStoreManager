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
   public class CustomersController : Controller
   {
      private readonly CleverStoreManagerContext _db;
      private readonly UserManager<CleverStoreManagerUser> _userManager;
      private readonly SignInManager<CleverStoreManagerUser> _signInManager;
      private readonly ILogger<AccountController> _logger;

      // Constructor
      public CustomersController(UserManager<CleverStoreManagerUser> userManager, SignInManager<CleverStoreManagerUser> signInManager, CleverStoreManagerContext db, ILogger<AccountController> logger)
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
         var agentCustomers = _db.CleverStoreManagerCustomers.Where(entry => entry.Agent.Id == currentAgent.Id).ToList();
         return View(agentCustomers);
      }

      [HttpPost]
      public async Task<IActionResult> Create(string FirstName, string MiddleName, string LastName, string PhoneNumber, string EmailAddress, string Address) 
      {
         CleverStoreManagerCustomer customer = new CleverStoreManagerCustomer();
         customer.FirstName = FirstName;
         customer.MiddleName = MiddleName;
         customer.LastName = LastName;
         customer.PhoneNumber = PhoneNumber;
         customer.EmailAddress = EmailAddress;
         customer.Address = Address;

         var agentId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
         var currentAgent = await _userManager.FindByIdAsync(agentId);

         customer.Agent = currentAgent;

         _db.CleverStoreManagerCustomers.Add(customer);
         _db.SaveChanges();
         return RedirectToAction("Index");
      }
   }
}