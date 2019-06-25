using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.BLL
{
    public class Revisao_Estoque
    {
        public void Insert(MODEL.Revisao_Estoque prodVenda)
        {
            DAL.Revisao_Estoque dalRevEst = new DAL.Revisao_Estoque();
            dalRevEst.Insert(prodVenda);
        }

        public List<Camadas.MODEL.Revisao_Estoque> SelectByIdRevisao(int id)
        {
            DAL.Revisao_Estoque dalRevEst = new DAL.Revisao_Estoque();
            return dalRevEst.SelectByIdServico(id);
        }
    }
}
