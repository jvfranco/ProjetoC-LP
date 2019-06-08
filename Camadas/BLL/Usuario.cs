using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.BLL
{
    public class Usuario
    {
        public List<MODEL.Usuarios> Select()
        {
            DAL.Usuarios dalUser = new DAL.Usuarios();
            return dalUser.Select();
        }
        public List<MODEL.Usuarios> SelectByIdFunc(int id)
        {
            DAL.Usuarios dalUser = new DAL.Usuarios();
            return dalUser.SelectByIdFunc(id);
        }

        public MODEL.Usuarios SelectByLogin(string login)
        {
            DAL.Usuarios dalUser = new DAL.Usuarios();
            return dalUser.SelectByLogin(login);
        }

        public void Insert(MODEL.Usuarios usuario)
        {
            DAL.Usuarios dalUser = new DAL.Usuarios();
            if (usuario.login != string.Empty)
                dalUser.Insert(usuario);
        }

        public void Update(MODEL.Usuarios usuario)
        {
            DAL.Usuarios dalUser = new DAL.Usuarios();
            if (usuario.login != "")
                dalUser.Update(usuario);
        }
/*
        public void Delete(int idFuncionario)
        {
            DAL.Funcionarios dalFunc = new DAL.Funcionarios();
            if (idFuncionario > 0)
                dalFunc.Delete(idFuncionario);

        }*/
    }
}
