using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.BLL
{
    public class Revisao
    {
        public List<MODEL.Revisao> Select()
        {
            DAL.Revisao dalRev = new DAL.Revisao();
            return dalRev.Select();
        }
        public int SelectUltimoId()
        {
            DAL.Revisao dalRev = new DAL.Revisao();
            return dalRev.SelectUltimoId();
        }
        public List<MODEL.Revisao> SelectById(int id)
        {
            DAL.Revisao dalRev = new DAL.Revisao();
            return dalRev.SelectById(id);
        }
        public void Insert(MODEL.Revisao revisao)
        {
            DAL.Revisao dalRev = new DAL.Revisao();
            dalRev.Insert(revisao);
        }
    }
}
