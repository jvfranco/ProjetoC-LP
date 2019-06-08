using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.MODEL
{
    public class Revisao
    {
        public int idRevisao { get; set; }
        public int idCliente { get; set; }
        public int idFuncionario { get; set; }
        public int idServico { get; set; }
        public int idVeiculo { get; set; }
        public int kmAtual { get; set; }
        public DateTime dataRevisao { get; set; }
        public string observacao { get; set; }
        public float valor_total { get; set; }
        public string forma_pagto { get; set; }
        public float desconto { get; set; }
        public float valor_final { get; set; }

    }
}
