using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Item
    {
        public int CdItem { get; set; }
        public string CdCod { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public DateTime Ano { get; set; }
        public string Tipo { get; set; }
        public string Preco { get; set; }
        public DateTime DataCompra { get; set; }
        public string ValorCusto { get; set; }
        public string Situacao { get; set; }
        public string Atores { get; set; }
        public string Diretor { get; set; }        
    }
}
