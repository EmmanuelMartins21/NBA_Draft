using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Draft
{
    public class Time
    {
        public string nome;
        public int jogos = 0;
        public int vitorias = 0;
        public int derrotas = 0;
        public Time()
        {

        }
        public Time(int jogos, int vitorias, int derrotas)
        {
            this.jogos = jogos;
            this.vitorias = vitorias;
            this.derrotas = derrotas;
        }
        public Time(string nome,int jogos, int vitorias, int derrotas)
        {
            this.nome = nome;
            this.jogos = jogos;
            this.vitorias = vitorias;
            this.derrotas = derrotas;
        }

        internal bool Any(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }

}
