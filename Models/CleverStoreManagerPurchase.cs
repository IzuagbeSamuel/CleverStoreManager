using System;
using System.Collections.Generic;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerPurchase
   {
      public int Id { get; set; }
      public string PurchaseId {
         get {
            return "CSM/" + DateToDeliver;
         }
      }
      public DateTime DateOrdered { get; set; }
      public string DateToDeliver { get; set; }

      public  int CleverStoreManagerProductId { get; set; }
      public int CleverStoreManagerSeller { get; set; }

      public virtual CleverStoreManagerUser Agent { get; set; }
      public virtual CleverStoreManagerProduct CleverStoreManagerProduct { get; set; }
      public virtual CleverStoreManagerSeller CleverStoreManagerSeller { get; set; }
   }
}