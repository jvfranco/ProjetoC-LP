using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.BLL
{
    public class Veiculo
    {
        DAL.Veiculos dalVei = new DAL.Veiculos();

        public List<MODEL.Veiculos> Select()
        {
            return dalVei.Select();
        }

        public void Insert(MODEL.Veiculos veiculo)
        {
            if (veiculo.modelo != string.Empty)
                dalVei.Insert(veiculo);
        }

        public void Update(MODEL.Veiculos veiculo)
        {
            if (veiculo.modelo != "")
                dalVei.Update(veiculo);
        }

        public void Delete(int idVeiculo)
        {
            if (idVeiculo > 0)
                dalVei.Delete(idVeiculo);

        }
    }
}
