using System;
using System.Collections.Generic;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerSale
   {
      public int Id { get; set; }

      public string Quantity { get; set; }

      public int CleverStoreManagerProductId { get; set; }

      public int CleverStoreManagerCustomerId { get; set; }

      public virtual CleverStoreManagerProduct CleverStoreManagerProduct { get; set; }
      public virtual CleverStoreManagerCustomer CleverStoreManagerCustomer { get; set; }

      public virtual CleverStoreManagerUser Agent { get; set; }

   }
}