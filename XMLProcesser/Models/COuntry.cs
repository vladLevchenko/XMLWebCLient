﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Capital { get; set; }

        public int Population { get; set; }
    }
}