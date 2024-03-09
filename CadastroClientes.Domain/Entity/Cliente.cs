using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientes.Domain.Entity
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string RG { get; set; }

        [DisplayName("Data Expedicao")]
        public DateTime? DataExpedicao { get; set; }

        [DisplayName("Orgão Expedicao")]
        public string OrgaoExpedicao { get; set; }

        [DisplayName("UF Expedicao")]
        public string UFExpedicao { get; set; }

        [DisplayName("Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        [DisplayName("Estado Civil")]
        public string EstadoCivil { get; set; }

        [Browsable(false)]
        public EnderecoCliente EnderecoCliente { get; set; }
    }
}
