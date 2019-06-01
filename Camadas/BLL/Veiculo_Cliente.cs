using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.BLL
{
    public class Veiculo_Cliente
    {
        public List<MODEL.Veiculo_Cliente> Select()
        {
            DAL.Veiculo_Cliente dalVeiCli = new DAL.Veiculo_Cliente();
            return dalVeiCli.Select();
        }

        public void Insert(MODEL.Veiculo_Cliente veiCli)
        {
            DAL.Veiculo_Cliente dalVeiCli = new DAL.Veiculo_Cliente();
            if (veiCli.idCliente != null && veiCli.idVeiculo != null)
            {
                dalVeiCli.Insert(veiCli);
            }
                
        }

        public void Update(MODEL.Veiculo_Cliente veiCli)
        {
            DAL.Veiculo_Cliente dalVeiCli = new DAL.Veiculo_Cliente();
            if (veiCli.idCliente != null && veiCli.idVeiculo != null)
                dalVeiCli.Update(veiCli);
        }
/*
        public void Delete(int idCliente)
        {
            DAL.Veiculo_Cliente dalVeiCli = new DAL.Veiculo_Cliente();
            if (dalVeiCli > 0)
                dalVeiCli.Delete(idCliente);

        }*/
    }
}
