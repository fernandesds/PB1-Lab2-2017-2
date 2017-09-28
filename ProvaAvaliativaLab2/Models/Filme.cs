using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaAvaliativaLab2.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public string Titulo { get; set; }
        public decimal Duracao { get; set; }
        public List<Ator> Ator { get; set; }
    }
}