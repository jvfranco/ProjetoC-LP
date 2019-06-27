using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.BLL
{
    public class Cliente
    {

        public List<MODEL.Clientes> SelectByID(int idCliente)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.SelectByID(idCliente);
        }

        public List<MODEL.Clientes> SelectByNome(string nomeCliente)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.SelectByNome(nomeCliente);
        }

        public List<MODEL.Clientes> Select()
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.Select();
        }

        public void Insert(MODEL.Clientes cliente)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            if (cliente.nome != string.Empty)
                dalCli.Insert(cliente);
        }

        public void Update(MODEL.Clientes cliente)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            if (cliente.nome != "")
                dalCli.Update(cliente);
        }
    }
}
