using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Model
{
    public class DogBreeds
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Dog> Dog { get; set; } = new();
    }
}
