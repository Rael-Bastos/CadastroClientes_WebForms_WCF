using CadastroClientes.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código e configuração ao mesmo tempo.
    public class ClienteService : IClienteService
    {
        public Cliente GetClient(int value)
        {
            return new Cliente() { Nome = "Israel" };
        }

        public List<Cliente> GetClients()
        {
            // Preencher o DataGridView com dados fictícios (substitua com chamadas ao seu serviço WCF)
            return  new List<Cliente>
            {
                new Cliente { CPF = "12345678901", Nome = "João Silva", RG = "1234567", DataNascimento = new DateTime(1990, 5, 15), Sexo = "Masculino", EstadoCivil = "Solteiro" },
                new Cliente { CPF = "98765432109", Nome = "Maria Oliveira", RG = "9876543", DataNascimento = new DateTime(1985, 8, 22), Sexo = "Feminino", EstadoCivil = "Casada" },
                new Cliente { CPF = "22765432109", Nome = "Oliveira", RG = "9876543", DataNascimento = new DateTime(1985, 8, 22), Sexo = "Feminino", EstadoCivil = "Casada" }
            };
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string InsertClient(int value)
        {
            throw new NotImplementedException();
        }

        public string UpdateClient(int value)
        {
            throw new NotImplementedException();
        }
    }
}
