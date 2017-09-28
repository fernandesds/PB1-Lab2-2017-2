using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaAvaliativaLab2.Models
{
    public class Sala
    {
        public int SalaId { get; set; }
        public int Numero { get; set; }
        public int Capacidade { get; set; }
        public string Descricao { get; set; }
        public int  SessaoId { get; set; }
        public Sessao Sessao { get; set; }
    }
}