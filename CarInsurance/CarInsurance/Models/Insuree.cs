﻿using System.Diagnostics.CodeAnalysis;
using CarInsurance.Controllers;
using CarInsurance.Models;

namespace CarInsurance.Models
{

    public class Insuree
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public System.DateOnly DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public bool DUI { get; set; }
        public byte SpeedingTickets { get; set; }
        public string CoverageType { get; set; }
        public decimal Quote { get; set; } = 50.0m;




    }

}
