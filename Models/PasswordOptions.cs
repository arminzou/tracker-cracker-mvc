using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapTrackerCracker.Models
{
    public class PasswordOptions
    {
        [Display(Name = "Password Length:")]
        public int RequiredLength { get; set; }

        [Display(Name = "Include Numbers:")]
        public bool IncludeDigit { get; set; }

        [Display(Name = "Include Lowercase Characters:")]
        public bool IncludeLowercase { get; set; }

        [Display(Name = "Include Uppercase Characters:")]
        public bool IncludeUppercase { get; set; }

        [Display(Name = "Include Symbols:")]
        public bool IncludeSymbols { get; set; }


        [Display(Name = "No Similar Characters:")]
        public bool NoSimilarCharacters { get; set; }

        [Display(Name = "Quality:")]
        public int Quality { get; set; }
    }
}