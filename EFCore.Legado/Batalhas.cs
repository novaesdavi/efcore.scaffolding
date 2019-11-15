﻿using System;
using System.Collections.Generic;

namespace EFCore.Legado
{
    public partial class Batalhas
    {
        public Batalhas()
        {
            HeroiBatalhas = new HashSet<HeroiBatalhas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime InicioBatalha { get; set; }
        public DateTime FimBatalha { get; set; }

        public virtual ICollection<HeroiBatalhas> HeroiBatalhas { get; set; }
    }
}
