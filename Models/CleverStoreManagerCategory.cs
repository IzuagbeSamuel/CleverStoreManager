using System;
using System.Collections.Generic;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerCategory
   {
      public CleverStoreManagerCategory() 
        {
           this.CleverStoreManagerProducts = new HashSet<CleverStoreManagerProduct>();
        }
              
      public int Id { get; set; }

      public string Name { get; set; }

      public virtual ICollection<CleverStoreManagerProduct> CleverStoreManagerProducts { get; set; }
   }
}