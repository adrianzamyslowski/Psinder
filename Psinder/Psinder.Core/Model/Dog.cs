﻿using Psinder.Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Model
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DogBreeds DogBreeds { get; set; }
        public Gender Gender { get; set; }
        public User User { get; set; }
    }
}
