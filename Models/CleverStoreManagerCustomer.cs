using System;
using System.Collections.Generic;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerCustomer
   {
      public int Id { get; set; }

      public string FirstName { get; set; }

      public string MiddleName { get; set; }

      public string LastName { get; set; }

      public  string PhoneNumber { get; set; } 

      public string EmailAddress { get; set; }

      public string Address { get; set; }
   }
}