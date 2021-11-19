using System;
using System.Collections.Generic;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerCustomer
   {
      public CleverStoreManagerCustomer() 
      {
         this.CleverStoreManagerSales = new HashSet<CleverStoreManagerSale>();
      }

      public int Id { get; set; }

      public string FirstName { get; set; }

      public string MiddleName { get; set; }

      public string LastName { get; set; }

      public string FullName {
         get {
            return FirstName + " " + MiddleName + " " + LastName;
         }
      }

      public  string PhoneNumber { get; set; } 

      public string EmailAddress { get; set; }

      public string Address { get; set; }

      public virtual CleverStoreManagerUser Agent { get; set; }

      public virtual ICollection<CleverStoreManagerSale> CleverStoreManagerSales { get; set; }
   }
}