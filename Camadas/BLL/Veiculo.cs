using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.BLL
{
    public class Veiculo
    {

        public List<MODEL.Veiculos> Select()
        {
            DAL.Veiculos dalVei = new DAL.Veiculos();
            return dalVei.Select();
        }

        public List<MODEL.Veiculos> SelectByIdCliente(int id)
        {
            DAL.Veiculos dalVei = new DAL.Veiculos();
            return dalVei.Select();
        }
        public List<MODEL.Veiculos> SelectByModelo(string modelo)
        {
            DAL.Veiculos dalVei = new DAL.Veiculos();
            return dalVei.SelectByModelo(modelo);
        }

        public void Insert(MODEL.Veiculos veiculo)
        {
            DAL.Veiculos dalVei = new DAL.Veiculos();
            if (veiculo.modelo != string.Empty)
                dalVei.Insert(veiculo);
        }

        public void Update(MODEL.Veiculos veiculo)
        {
            DAL.Veiculos dalVei = new DAL.Veiculos();
            if (veiculo.modelo != "")
                dalVei.Update(veiculo);
        }

        public void Delete(int idVeiculo)
        {
            DAL.Veiculos dalVei = new DAL.Veiculos();
            if (idVeiculo > 0)
                dalVei.Delete(idVeiculo);

        }
    }
}
