using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.MODEL
{
    public class Revisao_Estoque
    {
        public int idRevisao { get; set; }
        public int idProduto { get; set; }
        public float quantidade { get; set; }
    }
}
