﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Models { 
    public partial class Moderators
    {
        public string FullName { get => Role.Name; }
    }
}
