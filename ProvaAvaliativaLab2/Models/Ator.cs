using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaAvaliativaLab2.Models
{
    public class Ator
    {
        public int AtorId { get; set; }
        public string Nome { get; set; }
        public List<Filme> Filme { get; set; }

    }
}