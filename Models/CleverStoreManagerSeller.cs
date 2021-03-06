using System;
using System.Collections.Generic;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerSeller
   {
      public CleverStoreManagerSeller() 
      {
         this.CleverStoreManagerProducts = new HashSet<CleverStoreManagerProduct>();
         this.CleverStoreManagerPurchases = new HashSet<CleverStoreManagerPurchase>();
      }
      public int Id { get; set; }
      public string BusinessName { get; set; }
      public string Address { get; set; }
      public string EmailAddress { get; set; }
      public string PhoneNumber { get; set; }

      public virtual CleverStoreManagerUser Agent { get; set; }

      public virtual ICollection<CleverStoreManagerProduct> CleverStoreManagerProducts { get; set; }
      public virtual ICollection<CleverStoreManagerPurchase> CleverStoreManagerPurchases { get; set;}
     
   }
}