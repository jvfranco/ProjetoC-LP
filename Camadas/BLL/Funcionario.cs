﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.BLL
{
    public class Funcionario
    {
        public List<MODEL.Funcionarios> Select()
        {
            DAL.Funcionarios dalFunc = new DAL.Funcionarios();
            return dalFunc.Select();
        }

        public void Insert(MODEL.Funcionarios funcionario)
        {
            DAL.Funcionarios dalFunc = new DAL.Funcionarios();
            if (funcionario.nome != string.Empty)
                dalFunc.Insert(funcionario);
        }

        public void Update(MODEL.Funcionarios funcionario)
        {
            DAL.Funcionarios dalFunc = new DAL.Funcionarios();
            if (funcionario.nome != "")
                dalFunc.Update(funcionario);
        }

        public void Delete(int idFuncionario)
        {
            DAL.Funcionarios dalFunc = new DAL.Funcionarios();
            if (idFuncionario > 0)
                dalFunc.Delete(idFuncionario);

        }

    }
}