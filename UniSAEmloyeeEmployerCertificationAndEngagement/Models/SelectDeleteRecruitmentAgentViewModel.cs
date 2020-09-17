﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniSAEmloyeeEmployerCertificationAndEngagement.Models
{
    public class SelectDeleteRecruitmentAgentViewModel
    {
        [Required]
        public int RecruitmentAgencyId { get; set; }
        public string RecruitmentAgencyName { get; set; }
        public int AddressId { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmailAddress { get; set; }
        public int JobAdvertisedId { get; set; }
        public string Select { get; set; }
        public string Insert { get; set; }
        public string Update { get; set; }
        public string Delete { get; set; }
    }
}