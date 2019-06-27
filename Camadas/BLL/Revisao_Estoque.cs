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
            DAL.Estoque dalProd = new DAL.Estoque();
            MODEL.Estoque produto = new MODEL.Estoque();

            produto.quantidade -= prodVenda.quantidade;

            dalProd.Update(produto);
            dalRevEst.Insert(prodVenda);
        }

        public List<MODEL.Revisao_Estoque> SelectByIdVenda(int id)
        {
            DAL.Revisao_Estoque dalRevEst = new DAL.Revisao_Estoque();
            return dalRevEst.SelectByIdVenda(id);
        }
    }
}
