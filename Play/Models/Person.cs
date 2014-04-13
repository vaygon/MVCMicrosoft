using Play.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Play.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required(ErrorMessage="Please enter name")]
        [NameValidationAttribute("lee")]
        public string Name { get; set; }
        
        [Range(0, 400)]
        public int Height { get; set; }
        
        [Required]
        [RegularExpression(".+\\@.+\\..+")]
        public string EmailAddress { get; set; }

    }
}