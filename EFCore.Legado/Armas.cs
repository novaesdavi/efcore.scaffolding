﻿using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class Armas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? HeroiId { get; set; }

        public virtual Herois Heroi { get; set; }
    }
}
