using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.BLL
{
    public class Estoque
    {
        public List<MODEL.Estoque> Select()
        {
            DAL.Estoque dalEst = new DAL.Estoque();
            return dalEst.Select();
        }

        public MODEL.Estoque SelectById(int id)
        {
            DAL.Estoque dalEst = new DAL.Estoque();
            return dalEst.SelectById(id);
        }

        public MODEL.Estoque SelectByDescricao(string descricao)
        {
            DAL.Estoque dalEst = new DAL.Estoque();
            return dalEst.SelectByDescricao(descricao);
        }

        public void Insert(MODEL.Estoque produto)
        {
            DAL.Estoque dalEst = new DAL.Estoque();
            if (produto.descricao != string.Empty)
                dalEst.Insert(produto);
        }

        public void Update(MODEL.Estoque produto)
        {
            DAL.Estoque dalEst = new DAL.Estoque();
            if (produto.descricao != "")
                dalEst.Update(produto);
        }

        public void Delete(int idProduto)
        {
            DAL.Estoque dalEst = new DAL.Estoque();
            if (idProduto > 0)
                dalEst.Delete(idProduto);
        }
    }
}
