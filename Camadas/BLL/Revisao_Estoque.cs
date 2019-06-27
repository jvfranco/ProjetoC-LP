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
            BLL.Estoque bllProd = new BLL.Estoque();
            MODEL.Estoque produto = new MODEL.Estoque();

            produto = bllProd.SelectById(prodVenda.idProduto)[0];

            produto.quantidade = produto.quantidade - prodVenda.quantidade;

            bllProd.Update(produto);
            dalRevEst.Insert(prodVenda);
        }

        public List<MODEL.Revisao_Estoque> SelectByIdVenda(int id)
        {
            DAL.Revisao_Estoque dalRevEst = new DAL.Revisao_Estoque();
            return dalRevEst.SelectByIdVenda(id);
        }
    }
}
