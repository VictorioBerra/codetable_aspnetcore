﻿using System;
using System.ComponentModel.DataAnnotations;
using Toolbox.Codetable.Errors;

namespace Toolbox.Codetable.Models
{
    public class CodetableModelBase
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        [MaxLength(50, ErrorMessage = ErrorMessages.MaxLengthField)]
        public string Code { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        [MaxLength(250, ErrorMessage = ErrorMessages.MaxLengthField)]
        public string Value { get; set; }

        [MaxLength(250, ErrorMessage = ErrorMessages.MaxLengthField)]
        public string Description { get; set; }

        [Required(ErrorMessage = ErrorMessages.RequiredField)]
        public int Serialnumber { get; set; }

        public bool Disabled { get; set; }
    }
}
