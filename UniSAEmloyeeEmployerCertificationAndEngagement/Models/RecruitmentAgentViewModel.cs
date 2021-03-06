﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniSAEmloyeeEmployerCertificationAndEngagement.Models
{
    public class RecruitmentAgentViewModel 
    {
        public int RecruitmentAgencyId { get; set; }
        [Required]
        public string RecruitmentAgencyName { get; set; }
        [Required]
        public int AddressId { get; set; }
        [Required]
        public string ContactPerson { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string ContactEmailAddress { get; set; }
        public int JobAdvertisedId { get; set; }
        public string Select { get; set; }
        public string Insert { get; set; }
        public string Update { get; set; }
        public string Delete { get; set; }
    }
}