using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.MODEL
{
    public class Estoque
    {
        public int idProduto { get; set; }
        public string descricao { get; set; }
        public float quantidade { get; set; }
        public float valor { get; set; }
    }
}
