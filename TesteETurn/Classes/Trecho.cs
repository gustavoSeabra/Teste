using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteETurn
{
    public class Trecho
    {
        public Cidade Origem { get; set; }
        public Cidade Destino { get; set; }
        public int Distancia { get; set; }

        /// <summary>
        /// Cria uma instância da classe Trecho vazio
        /// </summary>
        public Trecho()
        { }

        /// <summary>
        /// Cria uma instância da classe Trecho já preenchida
        /// </summary>
        /// <param name="origem">Cidade de origem</param>
        /// <param name="destino">Cidade de Destino</param>
        /// <param name="distancia">Distancia do trecho entre as cidades</param>
        public Trecho(Cidade origem, Cidade destino, int distancia)
        {
            this.Origem = origem;
            this.Destino = destino;
            this.Distancia = distancia;
        }
    }
}
