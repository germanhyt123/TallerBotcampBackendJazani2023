﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Domain.Cores.Models
{
    public abstract class CoreModel<ID>
    {
        public ID Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }

    }
}
