using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.BLL
{
    public class Cliente
    {
        DAL.Clientes dalCli = new DAL.Clientes();

        public List<MODEL.Clientes> Select()
        {
            return dalCli.Select();
        }

        public void Insert(MODEL.Clientes cliente)
        {
            if (cliente.nome != string.Empty)
                dalCli.Insert(cliente);
        }

        public void Update(MODEL.Clientes cliente)
        {
            if (cliente.nome != "")
                dalCli.Update(cliente);
        }

        public void Delete(int idCliente)
        {
            if (idCliente > 0)
                dalCli.Delete(idCliente);

        }
    }
}
