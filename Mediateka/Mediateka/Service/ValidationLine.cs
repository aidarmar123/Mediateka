using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Service
{
    public static class ValidationLine
    {
        public static StringBuilder ValidationObject<T>(T data)
        {
            var sb = new StringBuilder();
            var validationContext = new ValidationContext(data);
            var validationResult = new List<ValidationResult>();
            if(!Validator.TryValidateObject(data, validationContext, validationResult))
            {
                foreach( var item in validationResult)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb;
        }
    }
}
