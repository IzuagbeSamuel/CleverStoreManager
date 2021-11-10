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
   public class AccountController : Controller
   {
      private readonly CleverStoreManagerContext _db;
      private readonly UserManager<CleverStoreManagerUser> _userManager;
      private readonly SignInManager<CleverStoreManagerUser> _signInManager;
      private readonly ILogger<AccountController> _logger;

      public AccountController(UserManager<CleverStoreManagerUser> userManager, SignInManager<CleverStoreManagerUser> signInManager, CleverStoreManagerContext db, ILogger<AccountController> logger)
      {
         _userManager = userManager;
         _signInManager = signInManager;
         _db = db;
         _logger = logger;
      }

      public IActionResult Register()
      {
         return View();
      }

      [HttpPost]
      public async Task<IActionResult> Register(RegisterViewModel model)
      {
         if(ModelState.IsValid)
         {
            var user = new CleverStoreManagerUser { 
               UserName = model.Email, 
               Email = model.Email,
               FirstName = model.FirstName,
               LastName = model.LastName,
               FullName = model.FullName,
               Address = model.Address,
               AdditionalPhoneNumber = model.AdditionalPhoneNumber,
               DateAdded = DateTime.Now
            };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
         
            if (result.Succeeded)
            {
               return RedirectToAction("Business");
            }
            foreach (var error in result.Errors)
            {
               ModelState.AddModelError(string.Empty, error.Description);
            }
         }
         return View();
      }

      [HttpPost]
      [Authorize]
      public IActionResult Business(CleverStoreManagerBusiness model)
      {
         CleverStoreManagerBusiness business = new CleverStoreManagerBusiness();

         business.CompanyName = model.CompanyName;
         business.Address1 = model.Address1;
         business.Address2 = model.Address2;
         business.City = model.City;
         business.Country = model.Country;
         business.PostalCode = model.PostalCode;
         business.CEOFirstName = model.CEOFirstName;
         business.CEOMiddleName = model.CEOMiddleName;
         business.CEOLastName = model.CEOLastName;
         business.CEODateOfBirth = model.CEODateOfBirth;
         business.CEOGender = model.CEOGender;
         business.IdentityType = model.IdentityType;
         business.NoOfEmployee = model.NoOfEmployee;
         business.CACRegNumber = model.CACRegNumber;
         business.TaxIDNumber = model.TaxIDNumber;
         business.DateAdded = model.DateAdded;
         _db.CleverStoreManagerBusinesses.Add(business);
         _db.SaveChanges();
         ViewBag.Message = "Record added successfully!";
         return RedirectToAction("Payment");
      }

      public IActionResult Login() 
      {
         return View();
      }

      [HttpPost]
      public async Task<ActionResult> Login(LoginViewModel model, string returnUrl = null)
      {
         returnUrl ??= Url.Content("~/");
         Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
         if (result.Succeeded)
         {
            return  LocalRedirect(returnUrl);
         }
         else 
         {
            return View();
         }
      }

      [HttpPost]
      public async Task<ActionResult> LogOff(string returnUrl = null)
      {
         returnUrl ??= Url.Content("~/");
         await _signInManager.SignOutAsync();
         return  LocalRedirect(returnUrl);
      }
   }
}