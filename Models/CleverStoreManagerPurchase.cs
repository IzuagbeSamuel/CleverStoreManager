using System;
using System.Collections.Generic;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerPurchase
   {
      public int Id { get; set; }

      public string ProductName { get; set; }

      public string ProductLabel { get; set; }

      public string ProductDescription { get; set; }

      public DateTime DateOrdered { get; set; }

      public string DateToDeliver { get; set; }

      public string Quantity { get; set; }

      public string QuantityBulk { get; set; }

      public string PurchaseId {
         get {
            return "CSM/" + Id;
         }
      }

      public string PurchaseStatus { get; set; }

      public string SingleAmount { get; set; }

      public string BulkAmount { get; set; }

      public  int CleverStoreManagerProductId { get; set; }
      public int CleverStoreManagerSellerId { get; set; }

      public virtual CleverStoreManagerUser Agent { get; set; }
      public virtual CleverStoreManagerProduct CleverStoreManagerProduct { get; set; }
      public virtual CleverStoreManagerSeller CleverStoreManagerSeller { get; set; }
   }
}