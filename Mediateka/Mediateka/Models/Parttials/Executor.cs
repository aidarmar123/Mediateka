﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Models
{
    public partial class Executor
    {
        public string FullName { get => $"{Name} {Surname} {Patronymic}"; }

    }
}
