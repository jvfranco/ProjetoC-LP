using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaMecanica.Camadas.MODEL
{
    public class Clientes
    {
        public int idCliente { get; set; } 
        public string nome { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public DateTime dataCadastro { get; set; }
        public string cpf_cnpj { get; set; }
        public string rg { get; set; }
        public string tipoPessoa { get; set; }
    }
}
