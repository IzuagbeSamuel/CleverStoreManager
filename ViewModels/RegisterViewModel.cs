using System.ComponentModel.DataAnnotations;

namespace CleverStoreManager.ViewModels
{
   public class RegisterViewModel
   {  
      [Required]
      [Display(Name = "FirstName")]
      public string FirstName { get; set; }

      [Required]
      [Display(Name = "LastName")]
      public string LastName { get; set; }

      [Required]
      [Display(Name = "FullName")]
      public string FullName { 
         get {
            return FirstName + " " + LastName;
         }
      }

      [Required]
      [Display(Name = "Address")]
      public string Address { get; set; }

      [Required]
      [Phone]
      public string PhoneNumber { get; set; }

      [Required]
      [Display(Name = "Additional PhoneNumber")]
      public string AdditionalPhoneNumber { get; set; }


      [Required]
      [EmailAddress]
      [Display(Name = "Email")]
      public string Email { get; set; }

      [Required]
      [DataType(DataType.Password)]
      [Display(Name = "Password")]
      public string Password { get; set; }

      [DataType(DataType.Password)]
      [Display(Name = "Confirm password")]
      [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
      public string ConfirmPassword { get; set; }
   }
}