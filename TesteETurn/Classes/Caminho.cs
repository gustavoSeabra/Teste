using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteETurn
{
    public class Caminho
    {
        public string Percurso { get; set; }
        public int Custo { get; set; }

        public Caminho()
        {
            this.Percurso = string.Empty;
            this.Custo = 0;
        }

        public Caminho(string percurso, int custo)
        {
            this.Percurso = percurso;
            this.Custo = custo;
        }
    }
}
