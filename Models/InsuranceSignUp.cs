﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarInsuranceQuote.Controllers;

namespace CarInsuranceQuote.Models
{
    public class InsuranceSignUp
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string DateOfBirth { get; set; }
        public string CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string DUI { get; set; }
        public string SpeedingTickets { get; set; }
        public string Coverage { get; set; }
        public string QuoteTotal { get; set; }

    }
}