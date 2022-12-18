using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Model
{
    public class Park
    {
        public int Id { get; set; }
        public string NamePark { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
    }
}
