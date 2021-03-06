﻿using HackneyAddressesAPI.Interfaces;

namespace HackneyAddressesAPI.Models
{
    public class AddressDetailsSimple : IAddressTypes
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }

        public string City { get; set; }

        public string Postcode { get; set; }

        public string AddressID { get; set; }

    }
}
