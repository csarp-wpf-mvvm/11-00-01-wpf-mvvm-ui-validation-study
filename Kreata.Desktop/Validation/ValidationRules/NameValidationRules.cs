using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Desktop.Validation.ValidationRules
{
    public class NameValidationRules
    {
        private readonly string nameToValidate;
        public NameValidationRules(string name)
        {
            this.nameToValidate = name;
        }
    }
}
