using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Psinder.Core.Model
{
    public class User : IdentityUser
    {
      public DateTime DateOfBirth { get; set; }
        public List<Dog> Dogs { get; set; }


    }
}
