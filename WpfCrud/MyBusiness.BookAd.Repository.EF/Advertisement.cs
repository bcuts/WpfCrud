//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBusiness.BookAd.Repository.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Advertisement
    {
        public int AdvertisementId { get; set; }
        public System.DateTime BookingDateTimeUtc { get; set; }
        public string ClientName { get; set; }
        public int DurationSeconds { get; set; }
    }
}
