using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Psinder.Core.Model.Enums
{
    public enum Gender
    {
        [Display(Name = "Pies")]
        Male = 1, 
        [Display(Name = "Suczka")]
        Female = 2,
    }
}
