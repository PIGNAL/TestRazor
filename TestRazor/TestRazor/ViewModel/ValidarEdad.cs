﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestRazor.ViewModel
{
    public class ValidarEdadAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var edad = Convert.ToInt32(value);
                if (edad > 30)
                {
                    return ValidationResult.Success;
                }                
            }
            return new ValidationResult("La edad debe ser mayor que 30");
        }
    }
}