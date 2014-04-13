using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Play.Attribute
{
    public class NameValidationAttribute : ValidationAttribute
    {
        private string _name;

        public NameValidationAttribute(string allowedName)
        {
            _name = allowedName;
        }

        public override bool IsValid(object value)
        {

            string name = value.ToString();

            return (name.ToUpper() == _name.ToUpper());
                    
        }

    }
}