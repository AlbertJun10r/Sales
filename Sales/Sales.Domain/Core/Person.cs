﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Core
{
    public abstract class Person : BaseEntity
    {
        public DateTime? fechaRegistro { get; set; }
        public String? correo { get; set; }
        public String? clave { get; set; }


    }
}
