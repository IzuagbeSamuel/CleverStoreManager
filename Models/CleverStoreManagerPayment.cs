using System;
using System.Collections.Generic;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerPayment
   {
      public int Id { get; set; }

      public string PaymentId {
         get {
            return "CSM/P/2021/"+ Id;
         }
      }

      public string AccountName { get; set; }

      public string AccountNumber { get; set; }

      public Bank BankName { get; set; }

      public DateTime DateAdded { get; set; }

      public virtual CleverStoreManagerUser Agent { get; set; }
   }

   public enum Bank
   {
      Zenith,
      GTB,
      First
   }
}