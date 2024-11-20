using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBlue.Core.Messages.Integration
{
    public class ResponseMessage : Message
    {
        public ValidationResult ValidateResult { get; set; }

        public ResponseMessage(ValidationResult validateResult)
        {
            ValidateResult = validateResult;
        }
    }
}
