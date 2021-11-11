using System;
using System.Collections.Generic;

namespace CleverStoreManager.Models
{
   public class CleverStoreManagerBusiness
   {
      public int Id { get; set; }

      public string CompanyMadeId { 
         get {
            return "CSM/B/2021"+ Id;
         }
      }

      public string CompanyName { get; set; }

      public string Address1 { get; set; }

      public string Address2 { get; set; }

      public string City { get; set; }

      public string Country { get; set; }

      public string PostalCode { get; set; }

      public string CEOFirstName { get; set; }

      public string CEOMiddleName { get; set; }

      public string CEOLastName { get; set; }

      public string CEOFullName {
         get {
            return CEOFirstName + " " + CEOMiddleName + " " + CEOLastName;
         }
      }

      public string CEODateOfBirth { get; set; }

      public Gender CEOGender { get; set; }

      public IdentityMeans IdentityType { get; set; }

      public byte[] IdentityFile { get; set; }

      public string NoOfEmployee { get; set; }

      public string CACRegNumber { get; set; }

      public byte[] CACCertificateFile { get; set; }

      public byte[] TINCertificateFile { get; set; }

      public string TaxIDNumber { get; set; }

      public DateTime DateAdded { get; set; }

      public virtual CleverStoreManagerUser Agent { get; set; }
   }

   public enum Gender
   {
      Male,
      Female
   }

   public enum IdentityMeans
   {
      Passport,
      NIN,
      VotersCard,
      DriversLicense
   }
}