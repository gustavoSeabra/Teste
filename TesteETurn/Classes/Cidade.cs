using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteETurn
{
    public class Cidade
    {
        public string Nome { get; set; }
        public bool Visitado { get; set; }

        /// <summary>
        /// Cria uma instância da classe Cidade já preenchida
        /// </summary>
        public Cidade()
        { }

        /// <summary>
        /// Cria uma instância da classe Cidade já preenchida
        /// </summary>
        /// <param name="nome">Nome da Cidade</param>
        public Cidade(string nome)
        {
            this.Nome = nome;
            this.Visitado = false;
        }
    }
}
