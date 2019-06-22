using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.BLL
{
    public class Servico
    {
        public List<MODEL.Servicos> Select()
        {
            DAL.Servicos dalServ = new DAL.Servicos();
            return dalServ.Select();
        }
        public List<MODEL.Servicos> SelectById(int id)
        {
            DAL.Servicos dalServ = new DAL.Servicos();
            return dalServ.SelectById(id);
        }

        public List<MODEL.Servicos> SelectByDescricao(string descricao)
        {
            DAL.Servicos dalServ = new DAL.Servicos();
            return dalServ.SelectByDescricao(descricao);
        }


        public void Insert(MODEL.Servicos servico)
        {
            DAL.Servicos dalServ = new DAL.Servicos();
            if (servico.descricao != string.Empty)
                dalServ.Insert(servico);
        }

        public void Update(MODEL.Servicos servico)
        {
            DAL.Servicos dalServ = new DAL.Servicos();
            if (servico.descricao != "")
                dalServ.Update(servico);
        }

        public void Delete(int idServico)
        {
            DAL.Servicos dalServ = new DAL.Servicos();
            if (idServico > 0)
                dalServ.Delete(idServico);

        }
    }
}
