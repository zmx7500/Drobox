﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class User
    {
        [Key]
        public string sub { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string given_name { get; set; }
        [Required]
        public string family_name { get; set; }
        [Required]
        public string profile { get; set; }
        [Required]
        public string picture { get; set; }
        
        public string gender { get; set; }
        
        public string locale { get; set; }
    }
}