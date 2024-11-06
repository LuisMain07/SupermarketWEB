﻿using Microsoft.Identity.Client;
using SupermarketWEB.Models;

namespace SupermarketWEB.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
