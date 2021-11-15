using System;
using System.Collections.Generic;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerProduct
   {

      public int Id { get; set; }

      public string Barcode { get; set; }

      public string Name { get; set; }

      public string Label { get; set; }

      public string Description { get; set; }

      public string MadeDate { get; set; }

      public string ExpiringDate { get; set; }

      public string Size { get; set; }

      public string Quantity { get; set; }

      public string SalesPrice { get; set; }

      public string CostPrice { get; set; }

      public string DiscountPrice { get; set; }

      public string StockKeepingUnit { get; set; }

      public string Weight { get; set; }

      public virtual CleverStoreManagerUser Agent { get; set; }
      public virtual CleverStoreManagerCategory CleverStoreManagerCategory { get; set; }
      public virtual CleverStoreManagerSeller CleverStoreManagerSeller { get; set; }
   }
}