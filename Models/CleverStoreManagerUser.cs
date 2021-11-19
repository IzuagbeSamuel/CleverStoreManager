using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerUser : IdentityUser
   {
      public string FirstName { get; set; }

      public string LastName { get; set; }

      public string FullName {
         get {
            return FirstName + " " + LastName;
         }
      }

      public string Address { get; set; }

      public string AdditionalPhoneNumber { get; set; }

      public byte[] ProfilePicture { get; set; }

      public DateTime DateAdded { get; set; }
   }
}